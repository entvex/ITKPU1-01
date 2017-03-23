using System;
using System.IO;
using System.Timers;
using Newtonsoft.Json;
using Topshelf;

namespace LabWindowsService
{
    public class TownCrier
    {
        readonly Timer _timer;

        private FileSystemWatcher FileSystemWatcher;

        public TownCrier()
        {
            FileSystemWatcher = new FileSystemWatcher();

            try
            {
                File.ReadAllText(@"D:\Config.json");
                Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@"D:\Config.json"));

                FileSystemWatcher.Path = config.PathToWatch;
            }
            catch (Exception e)
            {
                //Write defualt
                Config config = new Config();
                config.PathToWatch = @"D:\KaspersPornMappe";
                string json = JsonConvert.SerializeObject(config, Formatting.Indented);
                File.WriteAllText(@"D:\Config.json", json);

                //Set default value for FileSystemWatcher
                FileSystemWatcher.Path = @"D:\KaspersPornMappe";

            }

            FileSystemWatcher.Created += FileSystemWatcher_Created;
            FileSystemWatcher.Changed += FileSystemWatcher_Changed;
            FileSystemWatcher.Deleted += FileSystemWatcher_Deleted;
            FileSystemWatcher.Renamed += FileSystemWatcher_Renamed;
            FileSystemWatcher.Error += FileSystemWatcher_Error;

            FileSystemWatcher.EnableRaisingEvents = true;

            _timer = new Timer(1000) { AutoReset = true };
            _timer.Elapsed += (sender, eventArgs) => Console.WriteLine("It is {0} and all is well", DateTime.Now);
        }

        public void GetCommand(int command)
        {
            using (var sw = File.AppendText("changeText.txt"))
            {
                sw.WriteLine("Got a custom command:" + command);
            }

            if (command == 128)
            {
                using (var sw = File.AppendText("changeText.txt"))
                {
                    sw.WriteLine("Got a custom command change folder");
                }

                Config config = JsonConvert.DeserializeObject<Config>(File.ReadAllText(@"D:\Config.json"));

                using (var sw = File.AppendText("changeText.txt"))
                {
                    sw.WriteLine("FileWatchPath is now: " + config.PathToWatch);
                }

                FileSystemWatcher.Path = config.PathToWatch;
            }

        }

        private void FileSystemWatcher_Error(object sender, ErrorEventArgs e)
        {
            using (var sw = File.AppendText("changeText.txt"))
            {
                sw.WriteLine("Error: " + e.GetException());
            }
        }

        private void FileSystemWatcher_Renamed(object sender, RenamedEventArgs e)
        {
            using (var sw = File.AppendText("changeText.txt"))
            {
                sw.WriteLine("Renamed: " + e.FullPath);
            }
        }

        private void FileSystemWatcher_Deleted(object sender, FileSystemEventArgs e)
        {
            using (var sw = File.AppendText("changeText.txt"))
            {
                sw.WriteLine("Deleted: " + e.FullPath);
            }
        }

        private void FileSystemWatcher_Changed(object sender, FileSystemEventArgs e)
        {
            using (var sw = File.AppendText("changeText.txt"))
            {
                sw.WriteLine("Changed: " + e.FullPath);
            }
        }

        private void FileSystemWatcher_Created(object sender, FileSystemEventArgs e)
        {
            using (var sw = File.AppendText("changeText.txt"))
            {
                sw.WriteLine("Created: " +e.FullPath);
            }
        }

        public void Start() { _timer.Start(); }
        public void Stop() { _timer.Stop(); }
    }

    class Program
    {
        public static void Main()
        {
            HostFactory.Run(x =>                                 
            {
                x.Service<TownCrier>(s =>                        
                {
                    s.ConstructUsing(name => new TownCrier());     
                    s.WhenStarted(tc => tc.Start());              
                    s.WhenStopped(tc => tc.Stop());  
                    s.WhenCustomCommandReceived((tc,hc,command) => tc.GetCommand(command));             
                });
                x.RunAsLocalSystem();                           

                x.SetDescription("Sample Topshelf Host");        
                x.SetDisplayName("Stuff");                       
                x.SetServiceName("Stuff");                       
            });                                                  
        }
    }
}