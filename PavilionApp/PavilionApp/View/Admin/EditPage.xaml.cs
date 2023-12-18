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
    /// Логика взаимодействия для EditPage.xaml
    /// </summary>
    public partial class EditPage : Page
    {
        int result;
        public EditPage()
        {
            InitializeComponent();
        }

        private void editUser(object sender, RoutedEventArgs e)
        {
            var curUser = usersGrid.SelectedItem as Users;
            try
            {
                if (nameBox.Text != null && surnameBox.Text != null && patronymicBox.Text != null && loginBox.Text != null && passwordBox.Text != null && roleBox.Text != null && genderBox.Text != null && nubmerBox.Text != null)
                {
                    string input = roleBox.Text;
                    bool isInt = int.TryParse(input, out result);
                    if (isInt)
                    {
                        
                        curUser.Login = loginBox.Text.ToLower();
                        curUser.Name = nameBox.Text;
                        curUser.Surname = surnameBox.Text;
                        curUser.Patronymic = patronymicBox.Text;
                        curUser.Role = Convert.ToInt32(roleBox.Text);
                        curUser.Gender = genderBox.Text;
                        curUser.Number = nubmerBox.Text;
                        AppData.db.Users.Add(curUser);
                        AppData.db.SaveChanges();
                        MessageBox.Show("Изменения внесены!");
                    }
                    else
                    {
                        MessageBox.Show("Введите в окно ввода роли цифру роли!");
                    }
              
                }
                else
                {
                    MessageBox.Show("Пусто!");
                }
            }
            catch
            {
                MessageBox.Show("Ошибка!");
            }
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {
            usersGrid.ItemsSource = AppData.db.Users.ToList();
        }
    }
}
