using Microsoft.Practices.Unity;
using Prism.Unity;
using ProcessInnovator.Views;
using System.Windows;
using Prism.Modularity;

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

        #region Overrides of Bootstrapper

        protected override IModuleCatalog CreateModuleCatalog()
        {
            return new ConfigurationModuleCatalog();
        }

        #endregion
    }
}
