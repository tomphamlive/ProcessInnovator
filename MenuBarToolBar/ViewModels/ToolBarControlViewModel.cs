using ProcessInnovator.Infrastructure.Interfaces;
using System.Windows.Input;

namespace MenuBarToolBar.ViewModels
{
    public class ToolBarControlViewModel : IFileCommands
    {
        #region Implementation of IFileCommands

        public ICommand NewCommand { get; set; }

        public ICommand OpenCommand { get; set; }

        public ICommand SaveCommand { get; set; }

        public ICommand SaveAsCommand { get; set; }

        public ICommand PrintCommand { get; set; }

        public ICommand ExitCommand { get; set; }

        #endregion

        public ICommand UndoCommand { get; set; }

        public ICommand RedoCommand { get; set; }

        public ICommand DuplicateItemCommand { get; set; }
    }

}
