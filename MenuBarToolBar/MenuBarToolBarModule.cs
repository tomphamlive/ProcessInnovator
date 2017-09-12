using MenuBarToolBar.Views;
using Prism.Modularity;
using Prism.Regions;
using ProcessInnovator.Infrastructure;

namespace MenuBarToolBar
{
    public class MenuBarToolBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MenuBarToolBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            //compose views into shell
            _regionManager.RegisterViewWithRegion(RegionNames.MenuBarRegion, typeof(MenuBarControl));
            _regionManager.RegisterViewWithRegion(RegionNames.ToolBarRegion, typeof(ToolBarControl));

            //ways that modules can communicate in a loosely coupled way
            //subscribe to application level events or services

            //register shared services with the application's dependency injection container
            //A shared service is a class that can be accessed through a common interface.
            //Typically, shared services are found in a shared assembly and provide system-wide services,
            //such as authentication, logging, or configuration
        }
    }
}