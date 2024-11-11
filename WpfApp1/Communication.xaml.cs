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
    /// Логика взаимодействия для Communication.xaml
    /// </summary>
    public partial class Communication : Window
    {
        CloseThisAndOpenMain closeThis;
        public Communication()
        {
            InitializeComponent();
            closeThis = new CloseThisAndOpenMain(this);
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            closeThis.Close();
        }
    }
}
