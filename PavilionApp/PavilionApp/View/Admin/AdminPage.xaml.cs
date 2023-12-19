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

namespace PavilionApp.View.Admin
{
    /// <summary>
    /// Логика взаимодействия для AdminPage.xaml
    /// </summary>
    public partial class AdminPage : Page
    {
        public AdminPage()
        {
            InitializeComponent();

        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            usersGrid.ItemsSource = AppData.db.Users.ToList();
        }

        private void Search(object sender, TextChangedEventArgs e)
        {
            
                if (searchBox.Text != null)
                {
                    try
                    {
                        usersGrid.ItemsSource = AppData.db.Users.Where(item => item.Surname == searchBox.Text).ToList();
                    }
                    catch
                    {
                        MessageBox.Show("Ошибка");
                    }
                }
            
        }

        private void addBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new AdderPage());
        }

        private void editBT_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.Navigate(new EditPage());
        }

        private void Update(object sender, RoutedEventArgs e)
        {
            usersGrid.ItemsSource = AppData.db.Users.ToList();
            MessageBox.Show("Обновлено");
        }

        private void Delete(object sender, RoutedEventArgs e)
        {
            var curUser = usersGrid.SelectedItem as Users;

            curUser.Role = 4;
        }
    }
}
