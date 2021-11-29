using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Reg_And_Log
{
    /// <summary>
    /// Interaction logic for RegisterWindow.xaml
    /// </summary>
    public partial class RegisterWindow : Window
    {
        public RegisterWindow()
        {
            InitializeComponent();
            nameTextBox_TextChanged(null, null);
        }

        private void canselBtm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registerBtm_Click(object sender, RoutedEventArgs e)
        {
            if (nameTextBox.Background != Brushes.IndianRed &&
                surnameTextBox.Background != Brushes.IndianRed &&
                loginTextBox.Background != Brushes.IndianRed &&
                passwdTextBox.Background != Brushes.IndianRed &&
                repitPasTextBox.Background != Brushes.IndianRed)
            {
                User user = new User() { Login = loginTextBox.Text, Name = nameTextBox.Text, Surname = surnameTextBox.Text, Passwd = passwdTextBox.Text };
                DbServise.Add(user);
                this.Close();
            }
        }

        private void nameTextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            string patrn = @"^(?=.*\d)(?=.*[a-z])(?=.*[A-Z])(?=.*[a-zA-Z]).{8,}$";
            Regex regex = new Regex(patrn);
            if (nameTextBox.Text.Length < 3)
            {
                nameTextBox.Background = Brushes.IndianRed;
            }
            else
            {
                nameTextBox.Background = Brushes.White;
            }
            if (surnameTextBox.Text.Length < 3)
            {
                surnameTextBox.Background = Brushes.IndianRed;
            }
            else
            {
                surnameTextBox.Background = Brushes.White;
            }
            if (loginTextBox.Text.Length < 5)
            {
                loginTextBox.Background = Brushes.IndianRed;
            }
            else
            {
                loginTextBox.Background = Brushes.White;
            }
            if (regex.IsMatch(passwdTextBox.Text) && passwdTextBox.Text == repitPasTextBox.Text)
            {
                passwdTextBox.Background = Brushes.White;
                repitPasTextBox.Background = Brushes.White;
            }
            else
            {
                passwdTextBox.Background = Brushes.IndianRed;
                repitPasTextBox.Background = Brushes.IndianRed;
            }
        }
    }
}
