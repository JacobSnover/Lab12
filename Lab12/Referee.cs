using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Referee
    {
        public static int a = 0;
        public static int b = 0;
        public static int c = 0;
        public static string Score(int x, int y)
        {
            if (x == 0 && y == 0)
            {
                c++;
                return $"Draw  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 1 && y == 1)
            {
                c++;
                return $"Draw  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 2 && y == 2)
            {
                c++;
                return $"Draw  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 0 && y == 1)
            {
                b++;
                return $"You lose - Paper beats Rock  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 0 && y == 2)
            {
                a++;
                return $"You win - Rock beats Scissors  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 1 && y == 2)
            {
                b++;
                return $"You lose - Scissors beats Paper  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 1 && y == 0)
            {
                a++;
                return $"You win - Paper beats Rock  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 2 && y == 0)
            {
                b++;
                return $"You lose - Rock beats Scissors  wins: {a}  losses: {b}  draws: {c}";
            }
            else if (x == 2 && y ==1)
            {
                a++;
                return $"You win - Scissors beats Paper  wins: {a}  losses: {b}  draws: {c}";
            }
            else
            {
                return null;
            }
        }
    }
}
