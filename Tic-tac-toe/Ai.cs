using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;

namespace Tic_tac_toe
{
    public class Ai : Window
    {
        Random random = new ();
        private List<Button> AvaLiableTurn = new();
        private List<Button> AllButtons = new();
        private MainWindow Main;
        public bool IsEnable = true;
        
        public Ai(MainWindow mainWindow)
        {
            Main = mainWindow;
        }
        
        public void AnalizeAllPlace()
        {
            foreach (var button in AllButtons)
            {
                if(button.Content == null)
                {
                    AvaLiableTurn.Add(button);
                }
            }
        }

        public void LookingForTurn()
        {
            int randomInedex = random.Next(0, AvaLiableTurn.Count);
            Button currentButton = AvaLiableTurn[randomInedex];
            AvaLiableTurn.Remove(currentButton);

        }

        public void MakeTurn(Button buttontoplace)
        {
            
        }


    }
}
