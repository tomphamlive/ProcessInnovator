using System.Windows.Input;

namespace ProcessInnovator.Infrastructure.Interfaces
{
    public interface IFileCommands
    {
        ICommand NewCommand { get; set; }

        ICommand OpenCommand { get; set; }

        ICommand SaveCommand { get; set; }

        ICommand SaveAsCommand { get; set; }

        ICommand PrintCommand { get; set; }

        ICommand ExitCommand { get; set; }
    }
}
