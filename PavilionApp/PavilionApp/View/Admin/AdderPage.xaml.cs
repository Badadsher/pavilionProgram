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
    /// Логика взаимодействия для AdderPage.xaml
    /// </summary>
    public partial class AdderPage : Page
    {

        public int result;
        public AdderPage()
        {
            InitializeComponent();
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (nameBox.Text != null && surnameBox.Text != null && patronymicBox.Text != null && loginBox.Text != null && passwordBox.Text != null && roleBox.Text != null && genderBox.Text != null && nubmerBox.Text != null)
                {
                    string input = roleBox.Text;
                    bool isInt = int.TryParse(input, out result);
                    if ( isInt )
                    {
                        Users person = new Users();
                        person.Login = loginBox.Text.ToLower();
                        person.Name = nameBox.Text;
                        person.Surname = surnameBox.Text;
                        person.Patronymic = patronymicBox.Text;
                        person.Role = Convert.ToInt32(roleBox.Text);
                        person.Gender = genderBox.Text;
                        person.Number = nubmerBox.Text;
                        AppData.db.Users.Add(person);
                        AppData.db.SaveChanges();
                        MessageBox.Show("Успешно");
                    }
                    else
                    {
                        MessageBox.Show("Введите в окно ввода роли цифру роли!");
                    }
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
    }
}
