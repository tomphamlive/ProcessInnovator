using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;
using Prism.Mvvm;
using ProcessInnovator.Infrastructure.Enums;
using ProcessInnovator.Infrastructure.Interfaces;
using System.Collections.Specialized;
using System.ComponentModel;
using Prism.Commands;

namespace LeftPanel.ViewModels
{
    public abstract class LeftPanelViewModel : BindableBase, ILeftPanelViewModel
    {
        #region Constructor

        protected LeftPanelViewModel()
        {
            SimulationModes = new ObservableCollection<string>
            {
                "Process Simulation",
                "Flow Simulation"
            };

            OperatingMode = OperatingMode.Design;

            //ToolBoxItems = new ObservableCollection<ToolBoxItem>();
            //ToolBoxItems.CollectionChanged += ToolBoxItems_CollectionChanged;

            //FeedsItems = new ObservableCollection<ToolBoxItem>();
            //FeedsItems.CollectionChanged += ToolBoxItems_CollectionChanged;

            //ExtensionItems = new ObservableCollection<ToolBoxItem>();
            //ExtensionItems.CollectionChanged += ToolBoxItems_CollectionChanged;

            ShowColumnComboBox = Visibility.Collapsed;
            ShowReactorComboBox = Visibility.Collapsed;
            ShowVesselComboBox = Visibility.Collapsed;

            UpDrawCommand = new DelegateCommand(ExecuteUpDraw);
            DowmDrawCommand = new DelegateCommand(ExecuteDownDraw);
            LeftDrawCommand = new DelegateCommand(ExecuteLeftDraw);
            RightDrawCommand = new DelegateCommand(ExecuteRightDraw);
            UpLeftDrawCommand = new DelegateCommand(ExecuteUpLeftDraw);
            UpRightDrawCommand = new DelegateCommand(ExecuteUpRightDraw);
            DownLeftDrawCommand = new DelegateCommand(ExecutDownLeftDraw);
            DownRightDrawCommand = new DelegateCommand(ExecuteDownRightDraw);
        }

        #endregion  //Constructor

        #region Properties

        public ObservableCollection<string> SimulationModes { get; }

        private string _selectedSimulationMode;
        public string SelectedSimulationMode
        {
            get => _selectedSimulationMode;
            set => SetProperty(ref _selectedSimulationMode, value);
        }

        private OperatingMode _operatingMode;
        public OperatingMode OperatingMode
        {
            get => _operatingMode;
            set
            {
                SetProperty(ref _operatingMode, value);

                RaisePropertyChanged(nameof(IsInDesignMode));
                RaisePropertyChanged(nameof(IsInSimulateMode));
                RaisePropertyChanged(nameof(IsInAnalyzeMode));
                RaisePropertyChanged(nameof(CanDesign));
                RaisePropertyChanged(nameof(CanSimulate));
                RaisePropertyChanged(nameof(CanAnalyze));
            }
        }

        public bool IsInDesignMode => OperatingMode == OperatingMode.Design;

        public bool IsInSimulateMode => OperatingMode == OperatingMode.Simulate;

        public bool IsInAnalyzeMode => OperatingMode == OperatingMode.Analyze;

        public bool CanDesign => true;

        public bool CanSimulate => true;

        public bool CanAnalyze => IsInSimulateMode || IsInAnalyzeMode;

        //public ObservableCollection<ToolBoxItem> ToolBoxItems { get; }

        //public ObservableCollection<ToolBoxItem> FeedsItems { get; }

        //public ObservableCollection<ToolBoxItem> ExtensionItems { get; }

        //private ToolBoxItem _selectedItem;
        //public ToolBoxItem SelectedItem
        //{
        //    get => _selectedItem;
        //    set => SetProperty(ref _selectedItem, value);
        //}

        private bool _showExtensionTypes;
        public bool ShowExtensionTypes
        {
            get => _showExtensionTypes;
            set => SetProperty(ref _showExtensionTypes, value);
        }

        private Visibility _showColumnComboBox;
        public Visibility ShowColumnComboBox
        {
            get => _showColumnComboBox;
            set => SetProperty(ref _showColumnComboBox, value);
        }

        private Visibility _showReactorComboBox;
        public Visibility ShowReactorComboBox
        {
            get => _showReactorComboBox;
            set => SetProperty(ref _showReactorComboBox, value);
        }

        private Visibility _showVesselComboBox;
        public Visibility ShowVesselComboBox
        {
            get => _showVesselComboBox;
            set => SetProperty(ref _showVesselComboBox, value);
        }

        private bool _showExchangerComboBox;
        public bool ShowExchangerComboBox
        {
            get => _showExchangerComboBox;
            set => SetProperty(ref _showExchangerComboBox, value);
        }

        private string _title2;
        public string Title2
        {
            get => _title2;
            set => SetProperty(ref _title2, value);
        }

        private string _title3;
        public string Title3
        {
            get => _title3;
            set => SetProperty(ref _title3, value);
        }

        //private ISpeedDrawObject _speedDrawObject;
        //public ISpeedDrawObject SpeedDrawObject
        //{
        //    get => _speedDrawObject;
        //    set => SetProperty(ref _speedDrawObject, value);
        //}

        private bool _isDiagonal;
        public bool IsDiagonalPath
        {
            get => _isDiagonal;
            set => SetProperty(ref _isDiagonal, value);
        }

        #endregion  //Properties

        #region Commands

        public ICommand UpDrawCommand { get; }

        public ICommand DowmDrawCommand { get; }

        public ICommand LeftDrawCommand { get; }

        public ICommand RightDrawCommand { get; }

        public ICommand UpLeftDrawCommand { get; }

        public ICommand UpRightDrawCommand { get; }

        public ICommand DownLeftDrawCommand { get; }

        public ICommand DownRightDrawCommand { get; }

        public ICommand SimulateCommand { get; set; }

        public ICommand DesignCommand { get; set; }

        public ICommand AnalyzeCommand { get; set; }

        #endregion  //Commands

        #region Abstract Methods

        protected abstract void UpdateExtensionItems();

        protected abstract void CreateSpeedDrawObject(string direction);

        #endregion  //Abstract Methods

        #region Private Methods

        private void ExecuteDownRightDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("DownRight");
        }

        private void ExecutDownLeftDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("DownLeft");
        }

        private void ExecuteUpRightDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("UpRight");
        }

        private void ExecuteUpLeftDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("UpLeft");
        }

        private void ExecuteRightDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("Right");
        }

        private void ExecuteLeftDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("Left");
        }

        private void ExecuteDownDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("Down");
        }

        private void ExecuteUpDraw()
        {
            //if (SelectedItem != null)
                CreateSpeedDrawObject("Up");
        }

        private void ToolBoxItems_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        {
            if (sender != null)
            {
                if (e.OldItems != null)
                {
                    foreach (var item in e.OldItems)
                    {
                        ((INotifyPropertyChanged)item).PropertyChanged -= Item_Changed;
                    }

                }
                if (e.NewItems != null)
                {
                    foreach (var item in e.NewItems)
                    {
                        ((INotifyPropertyChanged)item).PropertyChanged += Item_Changed;
                    }
                }
            }
        }

        private void Item_Changed(object sender, PropertyChangedEventArgs e)
        {
            if (sender != null)
            {
                switch (e.PropertyName)
                {
                    case "IsClicked":
                        //if (((ToolBoxItem)sender).IsClicked)
                        {
                            //SelectedItem = (ToolBoxItem)sender;
                            UpdateExtensionItems();
                        }
                        break;
                }
            }
        }

        #endregion  //Private Methods

    }
}
