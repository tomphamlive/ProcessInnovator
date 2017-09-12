using RightPanel.Views;
using Prism.Modularity;
using Prism.Regions;
using ProcessInnovator.Infrastructure;

namespace RightPanel
{
    public class RightPanelModule : IModule
    {
        private readonly IRegionManager _regionManager;

        public RightPanelModule(IRegionManager regionManager)
        {
            _regionManager = regionManager;
        }

        public void Initialize()
        {
            //compose views into shell
            _regionManager.RegisterViewWithRegion(RegionNames.RightPanelRegion, typeof(RightPanelControl));
        }
    }
}