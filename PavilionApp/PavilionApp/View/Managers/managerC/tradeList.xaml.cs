using PavilionApp.Model;
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

namespace PavilionApp.View.Managers.managerC
{
    /// <summary>
    /// Логика взаимодействия для tradeList.xaml
    /// </summary>
    public partial class tradeList : Page
    {
        public tradeList()
        {
            InitializeComponent();
        }

        private void addBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AddTrade());
        }

        private void editBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditTrade());    
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                var curTrade = tradeGrid.SelectedItem as TradeList;
                AppData.db.TradeList.Remove(curTrade);
                AppData.db.SaveChanges();

                tradeGrid.ItemsSource = AppData.db.TradeList.ToList();
                MessageBox.Show("Успешно");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            tradeGrid.ItemsSource = AppData.db.Users.ToList();
            MessageBox.Show("Обновлено");
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tradeGrid.ItemsSource = AppData.db.TradeList.ToList();
        }

        private void cityBT_Click(object sender, RoutedEventArgs e)
        {
            //tradeGrid.ItemsSource = tradeGrid.ItemsSource.OrderBy(tc => tc.City);
        }

        private void statusBT_Click(object sender, RoutedEventArgs e)
        {
          //  tradeGrid.ItemsSource = tradeGrid.ItemsSource.OrderBy(tc => tc.Status);
        }
    }
}
