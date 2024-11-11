using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Media.Imaging;

namespace WpfApp1
{
    class Game
    {
        public string game;
        public int cost;
        public string path;
        public Game(string game, int cost, string path)
        {
            this.game = game;
            this.cost = cost;
            this.path = path;
        }
    }
    class GameInMainMenu : Game
    {
        public string path_icon;
        public GameInMainMenu(string game, int cost, string path, string path_icon) : base(game, cost, path)
        {
            this.path_icon = path_icon;
        }
    }
    abstract class GameInterface 
    {
        protected List<Game> games { get; set; }
        protected StackPanel Panel_With_Games { get; set; }
        protected abstract void SetParams();
    }
    class GameLibrary : GameInterface
    {
        public GameLibrary(StackPanel Panel_with_games)
        {
            this.Panel_With_Games = Panel_with_games;
            
            SetParams();
        }

        protected async override void SetParams()
        {
            games = await DataAccess.GetGame();
            for (int i = 0; i < games.Count; i++)
            {
                int index = i;
                bool isGameAlreadyPurchased = await DataAccess.IsGameAlreadyPurchased(CabinetUser.user.username, games[index].game);
                Button BuyButton = new Button {
                    Content = $"Buy this for {games[i].cost} rubles",
                    Width = 150,
                    Height = 50,
                    HorizontalAlignment = HorizontalAlignment.Center,
                    IsEnabled = !isGameAlreadyPurchased
                };
                BuyButton.Click += async(sender, e) =>
                {
                    await DataAccess.BuyGame(CabinetUser.user.username, games[index].game);
                    BuyButton.Content = "game purchased";
                    BuyButton.Foreground = Brushes.LightGreen;
                    BuyButton.IsEnabled = false;
                };
                Border border = new Border
                {
                    Margin = new System.Windows.Thickness(10),
                    Padding = new System.Windows.Thickness(10),
                    CornerRadius = new CornerRadius(10),
                    Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#2A1B3D")),
                    Width = 750,
                    Height = 500,
                };
                StackPanel stackPanel = new StackPanel
                {
                    Orientation = Orientation.Vertical,
                    Width = 700,
                    Height = 500
                };
                stackPanel.Children.Add( new Image { Source = ImageConverter.ConvertStringToImageSource(games[i].path), Width = 300, Height = 300 });
                stackPanel.Children.Add(new TextBlock { Text = games[i].game, FontWeight = FontWeights.Bold, FontSize = 20, HorizontalAlignment = HorizontalAlignment.Center});
                stackPanel.Children.Add(BuyButton);
                border.Child = stackPanel;
                Panel_With_Games.Children.Add(border);
            }
        }
    }
    class GameListInLeftMenu
    {
        protected List<GameInMainMenu> games;
        protected StackPanel Panel_With_Games;
        protected ImageBrush imageBrush;
        protected Grid MainGrid;
        protected PersonalCabinet cabinet;
        protected ControlTemplate leftMenuBtn;
        public GameListInLeftMenu(ref StackPanel Panel_With_Games, ref ImageBrush imageBrush,  Grid MainGrid,  ref PersonalCabinet personalCabinet, ControlTemplate controlTemplate)
        {
            this.leftMenuBtn = controlTemplate;
            this.cabinet = personalCabinet;
            this.MainGrid = MainGrid;
            this.imageBrush = imageBrush;
            this.Panel_With_Games = Panel_With_Games;
            SetParams();
        }
        
        protected async void SetParams() 
        {
            games = await DataAccess.GetUserGames(CabinetUser.user.username);
            for(int i = 0; i < games.Count; i++)
            {
                int index = i;
                Button button = new Button
                {
                    Template = leftMenuBtn,
                    Content = games[i].game,
                    
                };
                ImageSource imageSource = new BitmapImage(new Uri(games[i].path_icon, UriKind.Relative));

                button.Resources.Add("Img", imageSource);
                button.Click += (sender, e) =>
                {
                    MainGrid.Children.Clear();
                    imageBrush.ImageSource = ImageConverter.ConvertStringToImageSource(games[index].path);
                    if (cabinet != null && MainGrid.Children.Count != 0)
                    {

                        cabinet.ClosePage();
                    }
                };
                Panel_With_Games.Children.Add(button);
            }
        }
    }
}
