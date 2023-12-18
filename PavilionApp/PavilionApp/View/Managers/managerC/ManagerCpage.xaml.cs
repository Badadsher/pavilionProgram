using System;
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
using PavilionApp.View;
using PavilionApp.View.Managers.managerA;

namespace PavilionApp.View.Managers.managerC
{
    /// <summary>
    /// Логика взаимодействия для ManagerCpage.xaml
    /// </summary>
    public partial class ManagerCpage : Page
    {
        public ManagerCpage()
        {
            InitializeComponent();
        }

        private void pavilionBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new tradeList());
        }
    }
}
