﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;
using library;

namespace WpfUI
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public ApplicationService ApplicationService { get; set; }
        public ServiceService Service { get; set; }
        

        public MainWindow()
        {
            
            InitializeComponent();
            Initialise();
            
        }

        private void Initialise()
        {
            ApplicationService = new ApplicationService();
            Service = new ServiceService("node-app-windows-launcher");

            var appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
            ApplicationService.Read(appDataPath + "\\Node-App-Windows-Launcher\\applications.json");
            GridDataOutput.DataContext = ApplicationService.Applications.Application;
        }

        private void ButtonBase_OnClick(object sender, RoutedEventArgs e)
        {
           Service.RestartService(50);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
