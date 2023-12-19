using Microsoft.Win32;
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
        Users person = new Users();
        public AdderPage()
        {
            InitializeComponent();
        }

        private void addUser_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(nameBox.Text) && !string.IsNullOrEmpty(surnameBox.Text)  && !string.IsNullOrEmpty(patronymicBox.Text) && !string.IsNullOrEmpty(loginBox.Text) && !string.IsNullOrEmpty(passwordBox.Text) && !string.IsNullOrEmpty(roleBox.Text) && !string.IsNullOrEmpty(genderBox.Text) && !string.IsNullOrEmpty(nubmerBox.Text))
                {
                    Users person = new Users();
                    person.Login = loginBox.Text.ToLower();
                        person.Name = nameBox.Text;
                        person.Surname = surnameBox.Text;
                        person.Patronymic = patronymicBox.Text;
                        person.Role = Convert.ToInt32(roleBox.Text);
                        person.Gender = genderBox.Text;
                        person.Number = nubmerBox.Text;
                        person.Image = null;
                    person.Password = passwordBox.Text; 
                    person.Id = AppData.db.Users.Any() ? AppData.db.Users.Max(u => u.Id) + 1 : 1;
                        AppData.db.Users.Add(person);
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
