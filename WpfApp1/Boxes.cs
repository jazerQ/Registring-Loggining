using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;
using System.Windows;
using System.Windows.Controls;

namespace WpfApp1
{
    static class Boxes
    {
        static public void TBoxUsername_GotFocus(object sender, RoutedEventArgs e)
        {
            TextBox TBox = (TextBox)sender;
            if (TBox.Text == "Username")
            {
                TBox.Text = "";
                TBox.Foreground = Brushes.Black;
            }
        }

        static public void TBoxUsername_LostFocus(object sender, RoutedEventArgs e)
        {
            TextBox TBox = (TextBox)sender;
            if (string.IsNullOrEmpty(TBox.Text))
            {
                TBox.Text = "Username";
                TBox.Foreground = Brushes.DarkGray;
            }

        }
    }
}
