using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class SecondPlayer : Player
    {

        private static string PlayerName;



        public SecondPlayer() : base(PlayerName)
        {
            PlayerName = "Aloy";
        }

      

        //public static int AloysChoice(int x)
        //{
        //    Random r = new Random();
        //    return r.Next(0, 2);
        //}

        public override int GenerateRoshambo()
        {
            Random r = new Random();
            int x = r.Next(0, 2);
            return x;
       
        }

        public override string ToString()
        {
            return $"{PlayerName}";
        }
    }
}
