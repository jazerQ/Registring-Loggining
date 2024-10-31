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
    
    interface IPage
    {
        void OpenPage();
        void ClosePage();
    }
    class PersonalCabinet : IPage
    {
        TextBlock userTextBlock = new TextBlock();
        TextBlock emailTextBlock = new TextBlock();
        Button exitButton = new Button();
        Button deleteButton = new Button();
        Window window;
        Grid grid;
        Button CabinetButton;
        public PersonalCabinet(string username, string email, Window window, Grid grid, Button CabinetButton)
        {
            this.CabinetButton = CabinetButton;
            this.grid = grid;
            this.window = window;
            SetParams(username, email);
        }
        private void SetParams(string username, string email)
        {
            userTextBlock.Text = "Your Username - " + username;
            emailTextBlock.Text = "Your Email - " + email;
            
            

            SetTextBlock(userTextBlock, new Thickness(0, 0, 0, 400));

            SetTextBlock(emailTextBlock, new Thickness(0, 0, 0, 300));

            SetBtn(exitButton, new Thickness(0, 0, 0, 200), "Exit from account", QuitButton_Click);
            SetBtn(deleteButton, new Thickness(0, 0, 0, 50), "Delete Account", DeleteButton_Click);
            
        }
        private void SetTextBlock(TextBlock txtBlock, Thickness margin)
        {
            Grid.SetColumn(txtBlock, 1);
            txtBlock.HorizontalAlignment = HorizontalAlignment.Center;
            txtBlock.VerticalAlignment = VerticalAlignment.Center;
            txtBlock.Margin = margin;
            txtBlock.FontSize = 24;
            txtBlock.Foreground = Brushes.White;
        }
        private void SetBtn(Button btn, Thickness margin, string content, RoutedEventHandler btn_Click , int width = 100, int height = 75)
        {
            Grid.SetColumn(btn, 1);
            btn.Width = width;
            btn.Height = height;

            btn.Background = Brushes.DarkRed;
            btn.Click += btn_Click;

            btn.HorizontalAlignment = HorizontalAlignment.Center;
            btn.VerticalAlignment = VerticalAlignment.Center;

            btn.Margin = margin;
            btn.Content = content;
        }
        private void QuitButton_Click(object sender, RoutedEventArgs e)
        {
            new Login().Show();
            window.Close();
        }
        private async void DeleteButton_Click(object sender, RoutedEventArgs e)
        {
            await DataAccess.DeleteUser(CabinetUser.user.username);
            QuitButton_Click(sender, e);
        }
        public void OpenPage()
        {
            grid.Children.Add(userTextBlock);
            grid.Children.Add(emailTextBlock);
            grid.Children.Add(exitButton);
            grid.Children.Add(deleteButton);
            CabinetButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#da3f88"));
        }
        public void ClosePage()
        {
            grid.Children.Remove(userTextBlock);
            grid.Children.Remove(emailTextBlock);
            grid.Children.Remove(exitButton);
            grid.Children.Remove(deleteButton);
            CabinetButton.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#8265a8"));

        }

    }
}
