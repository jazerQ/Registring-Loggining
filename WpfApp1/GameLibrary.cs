using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;

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
    class GameLibrary
    {
        private Game[] games;
        private StackPanel Panel_with_games;
        public GameLibrary(StackPanel Panel_with_games)
        {
            this.Panel_with_games = Panel_with_games;
            
            SetParams(2);
        }

        private async void SetParams(int cnt)
        {
            games = await DataAccess.GetGame(cnt);
            for (int i = 0; i < games.Length; i++)
            {
                int index = i;
                Button BuyButton = new Button { 
                    Content = $"Buy this for {games[i].cost} rubles", 
                    Width = 150,
                    Height = 50,
                    HorizontalAlignment = HorizontalAlignment.Center 
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
                    Background = Brushes.LightGray,
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
                Panel_with_games.Children.Add(border);
            }
        }
    }
}
