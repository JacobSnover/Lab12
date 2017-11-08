using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Referee
    {
       
        public static string Score(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                return "Draw";
            }
            else if (x == 1 && y == 1)
            {
                return "Draw";
            }
            else if (x == 2 && y == 2)
            {
                return "Draw";
            }
            else if (x == 0 && y == 1)
            {
                return "You lose - Paper beats Rock";
            }
            else if (x == 0 && y == 2)
            {
                return "You win - Rock beats Scissors";
            }
            else if (x == 1 && y == 2)
            {
                return "You lose - Scissors beats Paper";
            }
            else if (x == 1 && y == 0)
            {
                return "You win - Paper beats Rock";
            }
            else if (x == 2 && y == 0)
            {
                return "You lose - Rock beats Scissors";
            }
            else if (x == 2 && y ==1)
            {
                return "You win - Scissors beats Paper";
            }
            else
            {
                return null;
            }
        }
    }
}
