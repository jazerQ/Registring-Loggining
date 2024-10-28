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
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Логика взаимодействия для Login.xaml
    /// </summary>
    public partial class Login : Window
    {
        TBoxesFocusCheck TBoxFocus;
        PBoxesFocusCheck PBoxFocus;
        public Login()
        {
            InitializeComponent();
            BtnLogIn.IsEnabled = false;
            TBoxFocus = new TBoxesFocusCheck(TBoxUsername, Brushes.Black, Brushes.DarkGray, "Username or Email");
            PBoxFocus = new PBoxesFocusCheck(PBoxPassword, Brushes.Black, Brushes.DarkGray, labelForPass);
        }

        private void TBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            TBoxFocus.TBox_GotFocus();
        }

        private void TBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            TBoxFocus.TBox_LostFocus();
        }

        private void PBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            PBoxFocus.PBox_GotFocus();
        }

        private void PBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            PBoxFocus.PBox_LostFocus();
        }

        private async void BtnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if(await LogIn.HasAccount(TBoxUsername, PBoxPassword))
            {
                MessageBox.Show("Succesful!");
                new Launcher().Show();
                this.Close();
                return;
            }
            MessageBox.Show("wrong password");
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            WindowMouse.Down(PBoxFocus, TBoxFocus);
            BtnIsEnabling();
        }
        private void BtnIsEnabling()
        {
            if ((!string.IsNullOrEmpty(TBoxUsername.Text) && (TBoxUsername.Text != "Username"))
                && (!string.IsNullOrEmpty(PBoxPassword.Password) && PBoxPassword.Password != "Password"))
            {
                BtnLogIn.IsEnabled = true;
                return;
            }
            BtnLogIn.IsEnabled = false;

        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new MainWindow().Show();
            this.Close();
        }
    }
}
