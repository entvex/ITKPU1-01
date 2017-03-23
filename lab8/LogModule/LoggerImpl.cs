using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Prism.Logging;

namespace LogModule
{
    public class LoggerImpl : ILoggerFacade
    {
        public List<string> LogList { get; set; }

        public LoggerImpl()
        {
            LogList = new List<string>();
        }

        public void Log(string message, Category category, Priority priority)
        {
            LogList.Add(message);
        }
    }
}
