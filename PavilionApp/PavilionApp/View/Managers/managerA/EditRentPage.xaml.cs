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
    /// Логика взаимодействия для EditRentPage.xaml
    /// </summary>
    public partial class EditRentPage : Page
    {
        public EditRentPage()
        {
            InitializeComponent();
        }

        private void editRent(object sender, RoutedEventArgs e)
        {
            var curTrade = rentGrid.SelectedItem as Arendators;
            try
            {
                if (!string.IsNullOrEmpty(namerent.Text) && !string.IsNullOrEmpty(numberrent.Text) && !string.IsNullOrEmpty(adresrent.Text))
                {

                   
                    curTrade.CompanyName = namerent.Text;
                   curTrade.Number = numberrent.Text;
                    curTrade.Adress = adresrent.Text;               
                    AppData.db.SaveChanges();
                    MessageBox.Show("Успешно");
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            rentGrid.ItemsSource = AppData.db.Arendators.ToList();
        }
    }
}
