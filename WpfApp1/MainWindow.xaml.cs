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
            if (TBoxUsername.Foreground == Brushes.DarkGray)
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
    }
}