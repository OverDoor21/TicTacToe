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

namespace Tic_tac_toe
{
    /// <summary>
    /// Interaction logic for WindowWin.xaml
    /// </summary>
    public partial class WindowWin : Window
    {
        private MainWindow mainWindow;
        Player Player = new();
        public WindowWin(MainWindow main    )
        {
           InitializeComponent();
           LableWin.Content = GetWinner();
            mainWindow = main;
        }

        public string GetWinner()
        {
            if (Player.GetFirstPlayer())
            {
                return ("X Win the Game");
            }
            else if (Player.GetSecondPlayer())
            {
                return ("O Win the Game");
            }
            return ("");
        }

            private void NewGameEvent(object sender, RoutedEventArgs e)
            {
                mainWindow.MakeUnnable(true);
            }
    }
}
