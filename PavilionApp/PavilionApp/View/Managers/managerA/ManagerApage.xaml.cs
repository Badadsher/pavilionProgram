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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PavilionApp.View.Managers.managerA
{
    /// <summary>
    /// Логика взаимодействия для ManagerApage.xaml
    /// </summary>
    public partial class ManagerApage : Page
    {
        public ManagerApage()
        {
            InitializeComponent();
        }

        private void procentBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ProcentPage());
        }

      

        private void arendatorsBT(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new ArendatorsPage());
        }
    }
}
