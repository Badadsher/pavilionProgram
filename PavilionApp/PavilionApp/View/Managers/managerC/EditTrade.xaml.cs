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
    /// Логика взаимодействия для EditTrade.xaml
    /// </summary>
    public partial class EditTrade : Page
    {
        public EditTrade()
        {
            InitializeComponent();
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            tradeGrid.ItemsSource = AppData.db.TradeList.ToList();
        }


        private void addTradeFunction(object sender, RoutedEventArgs e)
        {
            var curTrade = tradeGrid.SelectedItem as TradeList;

            try
            {
                if (!string.IsNullOrEmpty(tradenameBox.Text)  && !string.IsNullOrEmpty(statusBox.Text) && !string.IsNullOrEmpty(countBox.Text) && !string.IsNullOrEmpty(cityBox.Text) && !string.IsNullOrEmpty(coofBox.Text) && !string.IsNullOrEmpty(priceBox.Text) && !string.IsNullOrEmpty(floorBox.Text))
                {
                    curTrade.NameTrade = tradenameBox.Text;
                    curTrade.Status = statusBox.Text;
                    curTrade.PavilionsCount = Convert.ToInt32(countBox.Text);
                    curTrade.City = cityBox.Text;
                    curTrade.AddedValueTrade = Convert.ToInt32(coofBox.Text);
                    curTrade.PriceBuilding = priceBox.Text;
                    curTrade.floor = Convert.ToInt32(floorBox.Text);

                    AppData.db.SaveChanges();
                    MessageBox.Show("Данные изменены");
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        }

        private void Page_Loaded_1(object sender, RoutedEventArgs e)
        {

        }
    }
}
