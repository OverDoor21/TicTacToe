using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    public class Player
    {
        private bool IsNextTurnSecond { get; set; } 
        //Last Player True if First and False - Second
        private bool LastPlayerX { get; set; }
  

       public bool TurnFirstPlayer()
        {
            return IsNextTurnSecond = false;
        }
        public bool TurnSecondPlayer()
        {
           return IsNextTurnSecond = true;
        }

        public bool ReturnLastPlayer()
        {
            return LastPlayerX;
        }


        public bool CheckLastPlayer( bool value)
        {
            LastPlayerX = value;
            return LastPlayerX;
        }



        public bool GetWinner()
        {
            return IsNextTurnSecond;
        }


    }
}
