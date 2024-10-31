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
        private TBoxesFocusCheck TBoxFocus;
        private PBoxesFocusCheck PBoxFocus;
        private bool flagForToggleButton = true;
        public Login()
        {
            InitializeComponent();
            BtnLogIn.IsEnabled = false;
            TBoxFocus = new TBoxesFocusCheck(TBoxUsername, Brushes.Black, Brushes.DarkGray, "Username");
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
            string pass;
            if (flagForToggleButton)
            {
                pass = PBoxPassword.Password;
            }
            else
            {
                pass = TBoxPassword.Text;
            }
            if(await LogIn.HasAccount(TBoxUsername.Text, pass))
            {
                MessageBox.Show("Succesful!");
                CabinetUser.user = new UsersClass(TBoxUsername.Text,await DataAccess.GetEmail(TBoxUsername.Text));
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

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TBtnEye_Click(object sender, RoutedEventArgs e)
        {
            if (flagForToggleButton)
            {
                EyeToggle.Source = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\icons\\eye.png");
                TBoxPassword.Text = PBoxPassword.Password;
                TBoxPassword.Visibility = Visibility.Visible;
                PBoxPassword.Visibility = Visibility.Hidden;
                flagForToggleButton = false;
                return;
            }
            EyeToggle.Source = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\icons\\hideEye.png");
            flagForToggleButton = true;
            PBoxPassword.Password = TBoxPassword.Text;
            PBoxPassword.Visibility = Visibility.Visible;
            TBoxPassword.Visibility = Visibility.Hidden;
        }

        private void PBoxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {
            
        }

        private void TBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TBoxPassword.Text.Length != 0)
            {
                return;
            }
            labelForPass.Visibility = Visibility.Visible;
        }

        private void TBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            labelForPass.Visibility = Visibility.Hidden;
        }
    }
}
