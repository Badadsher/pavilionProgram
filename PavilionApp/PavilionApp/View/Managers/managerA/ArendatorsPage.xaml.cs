using PavilionApp.Model;
using PavilionApp.View.Managers.managerC;
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
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PavilionApp.View.Managers.managerA
{
    /// <summary>
    /// Логика взаимодействия для ArendatorsPage.xaml
    /// </summary>
    public partial class ArendatorsPage : Page
    {
        public ArendatorsPage()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            rentGrid.ItemsSource = AppData.db.Arendators.ToList();
           
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            try
            {
                var curRent = rentGrid.SelectedItem as Arendators;
                AppData.db.Arendators.Remove(curRent);
                AppData.db.SaveChanges();

                rentGrid.ItemsSource = AppData.db.Arendators.ToList();
                MessageBox.Show("Успешно");
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void addBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new addRentPage());
        }

        private void editBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditRentPage());
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            rentGrid.ItemsSource = AppData.db.Arendators.ToList();
            MessageBox.Show("Обновлено");
        }

        private void checkRent(object sender, RoutedEventArgs e)
        {
            var curTrade = rentGrid.SelectedItem as Arendators;

            List <Occupancy> filteredData = AppData.db.Occupancy.Where(item => item.ID_occupancy == curTrade.Id).ToList();

            // Установка источника данных для второго DataGrid
            rentArentGrid.ItemsSource = filteredData;
        }
    }
}
