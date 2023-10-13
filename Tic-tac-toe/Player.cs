using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tic_tac_toe
{
    public class Player
    {
        private bool FirstPlayer { get; set; } = true;
        private bool SecondPlayer { get; set; } = false;
        //Last Player True if First and False - Second
        private bool LastPlayer { get; set; }
  

       public bool TurnFirstPlayer()
        {
            SecondPlayer = false;
            return FirstPlayer = true;
        }
        public bool TurnSecondPlayer()
        {
           FirstPlayer = false;
           return SecondPlayer = true;
        }

        public bool GetFirstPlayer()
        {
            return this.FirstPlayer;
        }

        public bool GetSecondPlayer()
        {
            return this.SecondPlayer;
        }
        
        public bool GetWinner()
        {
            return LastPlayer;
        }

        public void SetWinner(bool value)
        {
            this.LastPlayer = value;
        }

    }
}
