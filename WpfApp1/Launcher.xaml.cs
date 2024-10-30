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
    /// Логика взаимодействия для Launcher.xaml
    /// </summary>
    public partial class Launcher : Window
    {
        public Launcher()
        {
            InitializeComponent();
        }

        private void BMinecraft_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\Minecraft.jpg");
        }

        private void DotaButton_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\dota.jpg");

        }

        private void BPubg_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\pubg.jpg");

        }

        private void BGta_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\gta.jpg");

        }

        private void BDarkSouls_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\darkSoul.jpg");

        }

        private void BCs_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\cs.jpg");

        }

        private void BEldenRing_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\eldenRing.jpg");

        }

        private void BDayz_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\dayz.jpg");

        }
    }
}
