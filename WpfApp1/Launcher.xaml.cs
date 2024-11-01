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
        private PersonalCabinet personalCabinet ;
        public Launcher()
        {
            InitializeComponent();
            Load_Catalog();
        }

        private void BMinecraft_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\Minecraft.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
               personalCabinet.ClosePage();
            }
        }

        private void DotaButton_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\dota.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
                
                personalCabinet.ClosePage();
            }
        }

        private void BPubg_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\pubg.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
                
                personalCabinet.ClosePage();
            }
        }

        private void BGta_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\gta.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
                
                personalCabinet.ClosePage();
            }
        }

        private void BDarkSouls_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\darkSoul.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
                
                personalCabinet.ClosePage();
            }
        }

        private void BCs_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\cs.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
                
                personalCabinet.ClosePage();
            }
        }

        private void BEldenRing_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\eldenRing.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
                
                personalCabinet.ClosePage();
            }
        }

        private void BDayz_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = ImageConverter.ConvertStringToImageSource("C:\\Users\\user\\source\\repos\\WpfApp1\\WpfApp1\\res\\dayz.jpg");
            if (personalCabinet != null && MainGrid.Children.Count != 0)
            {
                
                personalCabinet.ClosePage();
            }
        }
        private void Load_Catalog()
        {
            UsernameInterface.Text = CabinetUser.user.username;
        }

        private void CabinetBtn_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = null;
            if (personalCabinet == null)
            {
                personalCabinet = new PersonalCabinet(CabinetUser.user.username, CabinetUser.user.email, this, MainGrid, CabinetBtn);
            }
            personalCabinet.OpenPage();
            
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            new GameList().Show();
           
        }
    }
}
