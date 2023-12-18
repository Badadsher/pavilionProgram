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
using PavilionApp.Model;
using PavilionApp.View;
using PavilionApp.View.Admin;
using PavilionApp.View.Managers.managerA;
using PavilionApp.View.Managers.managerC;

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
            var currentUser = AppData.db.Users.FirstOrDefault(u => u.Login == loginBox.Text.ToLower() && u.Password.ToLower() == PasswordBox.Password.ToLower());

            try
            {
               if(currentUser != null && currentUser.Role == 1)
                {
                    NavigationService.Navigate(new AdminPage());
                }

               else if(currentUser != null && currentUser.Role == 2)
                {
                    NavigationService.Navigate(new ManagerApage());
                }
               else if(currentUser != null && currentUser.Role == 3)
                {
                    NavigationService.Navigate(new ManagerCpage());
                }
                else
                {
                    tryCount++;
                    CheckCapcha();
                }
               
            }
            catch
            {
                MessageBox.Show("Ошибка");
            }
        
        }

    }
}
