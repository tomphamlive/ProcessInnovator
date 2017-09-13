using Prism.Mvvm;
using System;
using ProcessInnovator.Infrastructure.Events;

namespace RightPanel.ViewModels
{
    public class RightPanelControlViewModel : BindableBase
    {
        #region Constructor

        public RightPanelControlViewModel()
        {
        }

        #endregion

        #region Constants

        public const int PhysicalPropertiesTabIndex = 0;
        public const int EquipmentItemsTabIndex = 1;
        public const int EngineeringToolBoxTabIndex = 2;

        #endregion

        #region Events

        public event SelectedTabChangedEventHandler SelectedTabChanged;

        #endregion  //Events

        #region Properties

        //Data for 1st tab
        //private PhysProperties _physicalProperties;
        //public PhysProperties PhysicalProperties
        //{
        //    get => _physicalProperties;
        //    set
        //    {
        //        SetProperty(ref _physicalProperties, value);
        //        SelectedTabIndex = PhysicalPropertiesTabIndex;
        //    }
        //}

        //Data for 2nd tab
        //private IInputDataViewModel<DiagramItemData> _modelDataViewModel;
        //public IInputDataViewModel<DiagramItemData> ModelDataViewModel
        //{
        //    get => _modelDataViewModel;
        //    set
        //    {
        //        SetProperty(ref _modelDataViewModel, value);

        //        SelectedTabIndex = _modelDataViewModel == null ? PhysicalPropertiesTabIndex : EquipmentItemsTabIndex;
        //        ShowRightPanel = _modelDataViewModel != null;

        //    }
        //}

        private int _selectedTabIndex;
        public int SelectedTabIndex
        {
            get => _selectedTabIndex;
            set
            {
                if (value < PhysicalPropertiesTabIndex)
                    throw new ArgumentOutOfRangeException(nameof(SelectedTabIndex));
                if (value > EngineeringToolBoxTabIndex)
                    throw new ArgumentOutOfRangeException(nameof(SelectedTabIndex));

                SetProperty(ref _selectedTabIndex, value);

                SelectedTabChanged?.Invoke(this);
            }
        }

        private bool _showRightPanel;
        public bool ShowRightPanel
        {
            get => _showRightPanel;
            set => SetProperty(ref _showRightPanel, value);
        }

        #endregion  //Properties
    }
}
