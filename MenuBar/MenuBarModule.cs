using System.Windows;
using MenuBar.Views;
using Prism.Modularity;
using Prism.Regions;
using ProcessInnovator.Infrastructure;

namespace MenuBar
{
    public class MenuBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public MenuBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.MenuBarRegion, typeof(MenuBarControl));
        }
    }
}