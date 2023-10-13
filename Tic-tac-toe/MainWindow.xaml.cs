using System.Collections.Generic;
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
        public bool isNextO = true;
        List<Button> buttonsTop = new List<Button>();
        List<Button> buttonsMid = new List<Button>();
        List<Button> buttonsBot = new List<Button>();
        WindowWin windowWin = new();
        Player player = new();


        public MainWindow()
        {
            InitializeComponent();


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

        private void ButtonClick(object sender, RoutedEventArgs e)
        {
            Button clickedButton = (Button)sender;
            bool isWin = false;
            
            if (isNextO == true)
            {
                clickedButton.Content = "X";
                isNextO = false;
            }
            else
            {
                isNextO = true;
                clickedButton.Content = "O";
            }
            clickedButton.FontSize = 70;
            clickedButton.IsEnabled = false;
            isWin = CheckWin();
            
            if (isWin == true)
            {
                windowWin.Show();
                MakeUnnable();
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
                windowWin.Show();
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
        private void MakeUnnable()
        {
            List<Button> buttons = new List<Button>();
            buttons.AddRange(buttonsTop);
            buttons.AddRange(buttonsMid);
            buttons.AddRange(buttonsBot);
            
            buttons.ForEach(b => b.IsEnabled = false);
        }





    }
}

