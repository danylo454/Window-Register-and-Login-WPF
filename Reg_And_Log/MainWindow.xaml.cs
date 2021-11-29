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

namespace Reg_And_Log
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void loginBtm_Click(object sender, RoutedEventArgs e)
        {
            var isUser = DbServise.SearchUser(loginTexBox.Text, paswTexBox.Text);
            if (isUser!= null)
            {
                MessageBox.Show("Your Login is valid!!!");
            }
            else
            {
                MessageBox.Show("Your Login is not valid!!!");
            }
        }

        private void caselBtm_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void registerBtm_Click(object sender, RoutedEventArgs e)
        {
            RegisterWindow window = new RegisterWindow();
            Visibility = Visibility.Hidden;
            window.ShowDialog();
            Visibility = Visibility.Visible;
        }
    }
}
