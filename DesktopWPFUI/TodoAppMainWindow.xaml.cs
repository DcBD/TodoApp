﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using DesktopWPFUI.ViewModels;

namespace DesktopWPFUI
{
    /// <summary>
    /// Logika interakcji dla klasy TodoAppMainWindow.xaml
    /// </summary>
    public partial class TodoAppMainWindow : Window
    {
       
        /// <summary>
        /// Creates an instance
        /// </summary>
        public TodoAppMainWindow()
        {
            this.DataContext = new TasksViewModel();

            InitializeComponent();
        }
    }
}
