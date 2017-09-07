using Prism.Mvvm;

namespace ProcessInnovator.ViewModels
{
    public class MainWindowViewModel : BindableBase
    {
        private string _title = "Process Innovator ®";
        public string Title
        {
            get => _title;
            set => SetProperty(ref _title, value);
        }

        public MainWindowViewModel()
        {

        }
    }
}
