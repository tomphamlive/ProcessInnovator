using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftPanel.ViewModels
{
    public class LeftPanelControlViewModel : LeftPanelViewModel
    {
        public LeftPanelControlViewModel()
        {
            SelectedSimulationMode = SimulationModes.First();
            Title2 = "Streams";
            Title3 = "Unit Ops";
        }

        #region Overrides of LeftPanelViewModel

        protected override void UpdateExtensionItems()
        {
        }

        protected override void CreateSpeedDrawObject(string direction)
        {
        }

        #endregion  //Overrides of LeftPanelViewModel
    }
}
