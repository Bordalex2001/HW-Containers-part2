﻿using System;
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

namespace HW_Containers__part_2_
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

        private void ButtonWithPopup_Click(object sender, RoutedEventArgs e)
        {
            //Button button = (Button)sender;
            //Popup popup = (Popup)button.DataContext;
        }

        private void ClosePopup_Click(object sender, RoutedEventArgs e)
        {
            //popup.IsOpen = false;
        }
    }
}