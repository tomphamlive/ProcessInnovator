using LeftPanel.Views;
using Prism.Modularity;
using Prism.Regions;
using ProcessInnovator.Infrastructure;

namespace LeftPanel
{
    public class LeftPanelModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public LeftPanelModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            //compose views into shell
            _regionManager.RegisterViewWithRegion(RegionNames.LeftPanelRegion, typeof(LeftPanelControl));

        }
    }
}