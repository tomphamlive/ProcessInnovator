﻿using MenuBar.ViewModels;
using System.Windows.Controls;

namespace MenuBar.Views
{
    public partial class MenuBarControl : UserControl
    {
        public MenuBarControl()
        {
            InitializeComponent();

            DataContext = new MenuBarViewModel();
        }
    }
}
