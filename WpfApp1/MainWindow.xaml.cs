using Microsoft.Data.Sqlite;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            BtnSignIn.IsEnabled = false;
        }

        private void PBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            labelForPass.Visibility = Visibility.Hidden;
            PBoxPassword.Foreground = Brushes.Black;
        }

        private void PBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(PBoxPassword.Password))
            {
                labelForPass.Visibility = Visibility.Visible;
                PBoxPassword.Foreground = Brushes.DarkGray;
                

            }
            
            
        }

        private void TBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TBoxUsername.Text == "Username")
            {
                TBoxUsername.Text = "";
                TBoxUsername.Foreground = Brushes.Black;
            }
        }

        private void TBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBoxUsername.Text))
            {
                TBoxUsername.Text = "Username";
                TBoxUsername.Foreground = Brushes.DarkGray;
            }
           
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            Keyboard.ClearFocus();
            TBoxUsername_LostFocus(sender, e);
            PBoxPassword_LostFocus(sender, e);
            TextBox_LostFocus(sender, e);
            BtnIsEnabling();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            if (TBoxEmail.Foreground == Brushes.DarkGray)
            {
                TBoxEmail.Text = "";
                TBoxEmail.Foreground = Brushes.Black;
            }
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrEmpty(TBoxEmail.Text))
            {
                TBoxEmail.Text = "Email";
                TBoxEmail.Foreground = Brushes.DarkGray;
            }
            
        }
        private void BtnIsEnabling()
        {
            if((!string.IsNullOrEmpty(TBoxEmail.Text) && TBoxEmail.Text != "Email") && (!string.IsNullOrEmpty(TBoxUsername.Text) && (TBoxUsername.Text != "Username")) && (!string.IsNullOrEmpty(PBoxPassword.Password) && PBoxPassword.Password != "Password"))
            {
                BtnSignIn.IsEnabled = true;
                return;
            }
            BtnSignIn.IsEnabled = false;
            
        }

        private async void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            BtnIsEnabling();
            bool flagUsername = false;
            bool flagEmail = false;
            try
            {
                flagUsername = await (DataAccess.CheckValueExists("Username", TBoxUsername.Text));
                flagEmail = await (DataAccess.CheckValueExists("Email", TBoxEmail.Text));

                if (flagUsername && flagEmail)
                {
                    DataAccess.InputParams(TBoxUsername.Text, PBoxPassword.Password, TBoxEmail.Text);
                    MessageBox.Show("successfully!");
                    Launcher launcher = new Launcher();
                    launcher.Show();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("such a user already exists!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }  
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            /*Login login = new Login();
            login.Show();
            this.Close();*/
        }
    }
}