using Prism.Modularity;
using Prism.Regions;
using ProcessInnovator.Infrastructure;
using StatusBar.Views;

namespace StatusBar
{
    public class StatusBarModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public StatusBarModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            _regionManager.RegisterViewWithRegion(RegionNames.StatusBarRegion, typeof(StatusBarControl));
        }
    }
}