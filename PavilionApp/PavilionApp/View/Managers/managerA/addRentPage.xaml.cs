using PavilionApp.Model;
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

namespace PavilionApp.View.Managers.managerA
{
    /// <summary>
    /// Логика взаимодействия для addRentPage.xaml
    /// </summary>
    public partial class addRentPage : Page
    {
        public addRentPage()
        {
            InitializeComponent();
        }

        private void addTrade(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(namerent.Text) && !string.IsNullOrEmpty(numberrent.Text) && !string.IsNullOrEmpty(adresrent.Text))
                {

                    Arendators arend= new Arendators();
                    arend.CompanyName = namerent.Text;
                    arend.Number = numberrent.Text;
                    arend.Adress = adresrent.Text;
                    AppData.db.Arendators.Add(arend);
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
    }
    }
}
