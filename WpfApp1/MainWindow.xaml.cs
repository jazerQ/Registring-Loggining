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
            try
            {
                if (await SignIn.NewAccountAdd(TBoxUsername, TBoxEmail, PBoxPassword))
                {
                    MessageBox.Show("successfully!");
                    new Launcher().Show();
                    this.Close();
                    return;
                }
                MessageBox.Show("such a user already exists!");
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            this.Close();
        }
    }
}