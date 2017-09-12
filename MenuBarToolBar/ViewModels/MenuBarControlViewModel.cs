using ProcessInnovator.Infrastructure.Interfaces;
using System.Windows.Input;

namespace MenuBarToolBar.ViewModels
{
    public class MenuBarControlViewModel : IFileCommands
    {
        #region Implementation of IFileCommands

        public ICommand NewCommand { get; set; }

        public ICommand OpenCommand { get; set; }

        public ICommand SaveCommand { get; set; }

        public ICommand SaveAsCommand { get; set; }

        public ICommand PrintCommand { get; set; }

        public ICommand ExitCommand { get; set; }

        #endregion
    }

}
