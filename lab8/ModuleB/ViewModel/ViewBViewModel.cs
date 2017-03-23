using Prism.Mvvm;

namespace ModuleB.ViewModel
{
    public class ViewBViewModel : BindableBase
    {
        private string _title = "Hello World Module B";
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }
    }
}