using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    public class Player
    {
        public bool FirstPlayer { get; set; }
        public bool SecondPlayer { get; set; } = false;

       public void TurnFirstPlayer()
        {
            FirstPlayer = false;
            SecondPlayer = true;

        }
        public void TurnSecondPlayer()
        {
            SecondPlayer = false;
            FirstPlayer = true;
        }

        



    }
}
