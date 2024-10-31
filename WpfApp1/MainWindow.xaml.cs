using Microsoft.Data.Sqlite;
using System.Security.Authentication;
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
        private bool flagForToggleButton = true;
        private PBoxesFocusCheck PassBox;
        private TBoxesFocusCheck TxtBox;
        private TBoxesFocusCheck EmailBox;
        public MainWindow()
        {
            InitializeComponent();
            BtnSignIn.IsEnabled = false;
            PassBox = new PBoxesFocusCheck(PBoxPassword, Brushes.Black, Brushes.DarkGray, labelForPass);
            TxtBox = new TBoxesFocusCheck(TBoxUsername, Brushes.Black, Brushes.DarkGray, "Username");
            EmailBox = new TBoxesFocusCheck(TBoxEmail, Brushes.Black, Brushes.DarkGray, "Email");
        }

        private void PBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            PassBox.PBox_GotFocus();
        }

        private void PBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            PassBox.PBox_LostFocus();
            
            
        }

        private void TBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            TxtBox.TBox_GotFocus();
        }

        private void TBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            TxtBox.TBox_LostFocus();
           
        }

        private void Window_MouseDown(object sender, MouseButtonEventArgs e)
        {
            
            WindowMouse.Down(PassBox, TxtBox, EmailBox);
            BtnIsEnabling();
        }

        private void TextBox_GotFocus(object sender, RoutedEventArgs e)
        {
            EmailBox.TBox_GotFocus();
        }

        private void TextBox_LostFocus(object sender, RoutedEventArgs e)
        {
            EmailBox.TBox_LostFocus();
            
        }
        private void BtnIsEnabling()
        {
            if((!string.IsNullOrEmpty(TBoxEmail.Text) && TBoxEmail.Text != "Email") 
                && (!string.IsNullOrEmpty(TBoxUsername.Text) && (TBoxUsername.Text != "Username")) 
                && (!string.IsNullOrEmpty(PBoxPassword.Password) && PBoxPassword.Password != "Password"))
            {
                BtnSignIn.IsEnabled = true;
                return;
            }
            BtnSignIn.IsEnabled = false;
            
        }

        private async void BtnSignIn_Click(object sender, RoutedEventArgs e)
        {
            BtnIsEnabling();

            string pass;
                
                
            
            try
            {

                //проверка Емайла и пароля
                if (!Validator.IsValidEmail(TBoxEmail.Text))
                {
                    throw new InvalidCredentialsException($"некорректный email {TBoxEmail.Text}");
                }
                if (!Validator.IsValidPassword(PBoxPassword.Password))
                {
                    throw new InvalidCredentialsException($"некорректный password  В пароле должна быть минимум одна цифра, одна буква(английская), большая буква и любой знак, который не цифра и не буква, максимальная длина пароля 16 символов.");
                }

                if (flagForToggleButton)
                {
                    pass = PBoxPassword.Password;
                }
                else
                {
                    pass = TBoxPassword.Text;
                }
                // добавление в базу данных
                if (await SignIn.NewAccountAdd(TBoxUsername.Text, TBoxEmail.Text, pass))
                {
                    MessageBox.Show("successfully!");
                    CabinetUser.user = new UsersClass(TBoxUsername.Text, await DataAccess.GetEmail(TBoxUsername.Text));

                    new Launcher().Show();
                    this.Close();
                    return;
                }
                MessageBox.Show("such a user already exists!");
            } catch (InvalidCredentialsException ex) 
            {
                MessageBox.Show(ex.Message);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            this.Close();
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void TBoxPassword_LostFocus(object sender, RoutedEventArgs e)
        {
            if(TBoxPassword.Text.Length != 0)
            {
                return;
            }
            labelForPass.Visibility = Visibility.Visible;
        }

        private void TBoxPassword_GotFocus(object sender, RoutedEventArgs e)
        {
            labelForPass.Visibility = Visibility.Hidden;
        }

        private void PBoxPassword_PasswordChanged(object sender, RoutedEventArgs e)
        {

        }

        private void ToggleButton_Checked(object sender, RoutedEventArgs e)
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
    }
}