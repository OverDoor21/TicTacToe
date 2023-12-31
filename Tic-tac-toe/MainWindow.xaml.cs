﻿using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;
using Tic_tac_toe.Graphic;

namespace Tic_tac_toe
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private WindowWin windowWin;
        private Player player;
        private bool isWin = false;
        public List<Button> buttonsTop = new List<Button>();
        public List<Button> buttonsMid = new List<Button>();
        public List<Button> buttonsBot = new List<Button>();
       

        public MainWindow()
        {
            InitializeComponent();
            player = new Player();
            player.TurnFirstPlayer();
        }

        private void Window_ContentRendered(object sender, System.EventArgs e)
        {
            AddButtons();
            GamePole.Background = Brushes.Black;


        }

        private void AddButtons()
        {
            for (int i = 0; i <= 8; i++)
            {
                Button button = new Button();
                GamePole.Children.Add(button);

                if (i < 3)
                {
                button.Name = "ButtonTop" + i.ToString();
                buttonsTop.Add(button);
                    Grid.SetColumn(button, i * 2);
                }
                else if (i >= 3 && i < 6)
                {
                    button.Name = "ButtonMid" + (i - 3).ToString();
                    buttonsMid.Add(button);
                    Grid.SetRow(button, 2);
                    Grid.SetColumn(button, (i - 3) * 2);
                }
                else if  (i >= 6 && i < 9)
                    {
                    button.Name = "ButtonBot" + (i - 6).ToString();
                    buttonsBot.Add(button);
                    Grid.SetRow(button, 5);
                    Grid.SetColumn(button, (i - 6) * 2);
                }
            }


        }

        public void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;

            if (player.GetWinner() == false)
            {
                clickedButton.Content = "X";
                player.TurnSecondPlayer();
            }
            else
            {
                clickedButton.Content = "O";
                player.CheckLastPlayer( true);
                player.TurnFirstPlayer();

            }
            clickedButton.FontSize = 70;
            clickedButton.IsEnabled = false;

            isWin = CheckWin();

            if (isWin == true)
            {
                
                OpenSecondWindow();
                MakeUnnable(false);
            }
        }

        private bool CheckWin()
        {

            if (buttonsTop.All(x => x.Content == buttonsTop.First().Content) && buttonsTop.All(x => x.Content != null))
            {

                return true;
            }
             
            if (buttonsMid.All(x => x.Content == buttonsMid.First().Content) && buttonsMid.All(x => x.Content != null))
            {
          
                return true;
            }
            if (buttonsBot.All(x => x.Content == buttonsBot.First().Content) && buttonsBot.All(x => x.Content != null))
            {
                return true;
            }
            if (buttonsTop[0].Content != null && buttonsTop[0].Content == buttonsMid[1].Content && buttonsMid[1].Content == buttonsBot[2].Content)
            {
                
                return true;
            }
            if (buttonsTop[2].Content != null && buttonsTop[2].Content == buttonsMid[1].Content && buttonsMid[1].Content == buttonsBot[0].Content)
            {
                return true;
            }

            if (buttonsTop[0].Content != null && buttonsTop[0].Content == buttonsMid[0].Content && buttonsMid[0].Content == buttonsBot[0].Content)
            {
                
                return true;
            }
            if (buttonsTop[1].Content != null && buttonsTop[1].Content == buttonsMid[1].Content && buttonsMid[1].Content == buttonsBot[1].Content)
            {
            
                return true;
            }
            if (buttonsTop[2].Content != null && buttonsTop[2].Content == buttonsMid[2].Content && buttonsMid[2].Content == buttonsBot[2].Content)
            {
                
                return true;
            }



            return false;
        }
        public void MakeUnnable(bool newgame)
        {
            List<Button> buttons = new List<Button>();
            buttons.AddRange(buttonsTop);
            buttons.AddRange(buttonsMid);
            buttons.AddRange(buttonsBot);
            if (newgame == false)
            {
                buttons.ForEach(b => b.IsEnabled = false);
            }
            else
            {
                player.TurnFirstPlayer();
                buttons.ForEach(b => b.Content = null);
                buttons.ForEach(b => b.IsEnabled = true);
                CloseSecondWindow();
            }

        }

        private void OpenSecondWindow()
        {
            windowWin = new WindowWin(this,player);
            windowWin.Show();
        }

        private void CloseSecondWindow()
        {
            if (windowWin != null)
            {
                windowWin.Close(); // Закрыть второе окно
            }
        }

        private void SoloPlay_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Multiplayer_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

