﻿using ModernWpf;
using ModernWpf.Controls;
using ModernWpf.Controls.Primitives;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SingleControlTest
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ThemeManager.Current.ApplicationTheme = ThemeManager.Current.ApplicationTheme == ApplicationTheme.Light ? ApplicationTheme.Dark : ApplicationTheme.Light;
        }

        private void AppBarButton_Click(object sender, RoutedEventArgs e)
        {
            AppBarButton button = sender as AppBarButton;
        }

        private void UseAcrylicBackdrop_Toggled(object sender, RoutedEventArgs e)
        {
            WindowHelper.SetUseAeroBackdrop(this, UseAcrylicBackdrop.IsOn);
            WindowHelper.SetUseAcrylicBackdrop(this, UseAcrylicBackdrop.IsOn);
            WindowHelper.SetSystemBackdropType(this, UseAcrylicBackdrop.IsOn ? BackdropType.Mica : BackdropType.None);
        }

        private void ToggleButton_Click(object sender, RoutedEventArgs e)
        {
            var toggleButton = (ToggleButton)sender;

            if (toggleButton.IsChecked is true)
            {
                FullScreenHelper.StartFullScreen(this);
            }
            else
            {
                FullScreenHelper.EndFullScreen(this);
            }
        }
    }
}
