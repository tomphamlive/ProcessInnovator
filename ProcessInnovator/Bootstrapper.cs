using Microsoft.Practices.Unity;
using Prism.Unity;
using ProcessInnovator.Views;
using System.Windows;

namespace ProcessInnovator
{
    class Bootstrapper : UnityBootstrapper
    {
        protected override DependencyObject CreateShell()
        {
            return Container.Resolve<MainWindow>();
        }

        protected override void InitializeShell()
        {
            Application.Current.MainWindow.Show();
        }
    }
}
