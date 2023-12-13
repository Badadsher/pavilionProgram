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


namespace PavilionApp.View
{
    /// <summary>
    /// Логика взаимодействия для SignIn.xaml
    /// </summary>
    public partial class SignIn : Page
    {
        private int tryCount = 0;

        public SignIn()
        {
            InitializeComponent();
        }

     

        private void CheckCapcha()
        {
            if(tryCount > 3) {
                NavigationService.Navigate(new CapchaPage());
                tryCount = 0;
            }
        }

      

        private void SignInBT_Click_1(object sender, RoutedEventArgs e)
        {
            tryCount++;
            CheckCapcha();
        }
    }
}
