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
    /// Логика взаимодействия для AddTrade.xaml
    /// </summary>
    public partial class AddTrade : Page
    {
        public AddTrade()
        {
            InitializeComponent();
        }

        private void addTrade(object sender, RoutedEventArgs e)
        {
            try
            {
                if (tradenameBox.Text != null && statusBox.Text != null && countBox.Text != null && cityBox.Text != null && coofBox.Text != null && priceBox.Text != null && floorBox.Text != null)
                {
                   
                        TradeList trade = new TradeList();
                        trade.NameTrade = tradenameBox.Text;
                        trade.Status = statusBox.Text;
                        trade.PavilionsCount = Convert.ToInt32(countBox.Text);
                        trade.City = cityBox.Text;
                        trade.AddedValueTrade = Convert.ToInt32(coofBox.Text);
                        trade.PriceBuilding = priceBox.Text;
                        trade.floor = Convert.ToInt32(floorBox.Text);
                    trade.imageTrade = null;
                        AppData.db.TradeList.Add(trade);
                        AppData.db.SaveChanges();
                        MessageBox.Show("Успешно");
                }
                else
                {
                    MessageBox.Show("Заполните все поля!");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
