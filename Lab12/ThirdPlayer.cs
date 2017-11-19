using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class ThirdPlayer : Player
    {

        private static string PlayerName;


        public ThirdPlayer(string thirdPlayer) : base(PlayerName)
        {
            PlayerName = thirdPlayer;

        }


        public override int GenerateRoshambo()
        {
            return Validator.InputValidator();
        }

        public override string ToString()
        {
            return $"{PlayerName}";
        }

    }
}
