using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ProcessInnovator.Infrastructure.Enums;

namespace ProcessInnovator.Infrastructure.Interfaces
{
    public interface ILeftPanelViewModel
    {
        ObservableCollection<string> SimulationModes { get; }

        OperatingMode OperatingMode { get; set; }

        bool IsInDesignMode { get; }

        bool IsInSimulateMode { get; }

        bool IsInAnalyzeMode { get; }

        bool CanDesign { get; }

        bool CanSimulate { get; }

        bool CanAnalyze { get; }

        //ObservableCollection<ToolBoxItem> ToolBoxItems { get; }   //DiagramDesigner

        //ObservableCollection<ToolBoxItem> ExtensionItems { get; } //DiagramDesigner

        //ISpeedDrawObject SpeedDrawObject { get; set; }            //DiagramDesigner

        ICommand UpDrawCommand { get; }
        ICommand DowmDrawCommand { get; }
        ICommand LeftDrawCommand { get; }
        ICommand RightDrawCommand { get; }
        ICommand UpLeftDrawCommand { get; }
        ICommand UpRightDrawCommand { get; }
        ICommand DownLeftDrawCommand { get; }
        ICommand DownRightDrawCommand { get; }
        ICommand SimulateCommand { get; set; }
        ICommand DesignCommand { get; set; }
        ICommand AnalyzeCommand { get; set; }
    }
}
