using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class FirstPlayer : Player
    {
        private static string PlayerName;


        public FirstPlayer() : base(PlayerName)
        {
            PlayerName = "Shepard";
        }

        public override int GenerateRoshambo()
        {
            return 0;
        }

        public override string ToString()
        {
            return $"{PlayerName}";
        }


    }
}
