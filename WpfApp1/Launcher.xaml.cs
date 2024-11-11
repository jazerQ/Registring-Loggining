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
        private void Load_Catalog()
        {
            UsernameInterface.Text = CabinetUser.user.username;
            ControlTemplate leftMenuTemplate = (ControlTemplate)FindResource("LeftMenuBtn");
            GameListInLeftMenu gameListInLeftMenu = new GameListInLeftMenu(ref LeftMenuGame, ref GridBackGround, MainGrid, ref personalCabinet, leftMenuTemplate);
        }

        private void CabinetBtn_Click(object sender, RoutedEventArgs e)
        {
            GridBackGround.ImageSource = null;
            if (personalCabinet == null)
            {
                personalCabinet = new PersonalCabinet(CabinetUser.user.username, CabinetUser.user.email, this, MainGrid, CabinetBtn);
            }
            if (personalCabinet.isOpen)
            {
                personalCabinet.ClosePage();
                return;
            }
            personalCabinet.OpenPage();
            
        }

        private void ShopButton_Click(object sender, RoutedEventArgs e)
        {
            new GameList().Show();
            this.Close();
           
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            new Communication().Show();
            this.Close();
        }
    }
}
