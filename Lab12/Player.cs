using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    abstract class Player
    {

        private String playerName;
        int value = 0;



        public Player(string playerName)
        {
            PlayerName = playerName;
        }



        public string PlayerName { get => playerName; set => playerName = value; }

        abstract public int GenerateRoshambo();


        public override string ToString()
        {
            return $"{value}";
        }

    }
}
