using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class SecondPlayer
    {

        

        public static string Aloy()
        {
            return "Aloy";
        }

        public static int AloysChoice(int x)
        {
            Random r = new Random();
            return r.Next(0, 2);

        }

    }
}
