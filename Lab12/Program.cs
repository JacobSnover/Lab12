using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab12
{
    class Program
    {
        static void Main(string[] args)
        {


            int choice = 0;
            string result;
            string opponentResult;

            Console.Write("Welcome to the Rock Paper Scissos Game!\nPlease enter your name: ");
            ThirdPlayer name = new ThirdPlayer(Validator.NameValidator());

            while (true)
            {

                FirstPlayer shepard = new FirstPlayer();

                Console.Write($"\nOk {name}. Please select an opponent from the list below.\n1. Shepard\n2. Aloy\nSelect: ");
                int selection = Validator.OpponentSelection();

                if (selection == 1)
                {
                    Console.Write("\nPlease choose R,P,S : ");
                    choice = name.GenerateRoshambo();
                    Console.WriteLine($"\n{name} you have picked {((EnumRoshambo)choice)} and your opponent {shepard} has choosen {((EnumRoshambo)shepard.GenerateRoshambo())}\n");
                    Console.WriteLine(Referee.Score(choice, 0));

                }
                if (selection == 2)
                {
                    SecondPlayer aloy = new SecondPlayer();
                    Console.Write("\nPlease choose R,P,S : ");
                    choice = name.GenerateRoshambo();
                    result = Validator.Result(choice);
                    int opponentAnswer = aloy.GenerateRoshambo();
                    Console.WriteLine($"\n{name} you have picked {result} and your opponent {aloy} has choosen {((EnumRoshambo)opponentAnswer)}\n");
                    Console.WriteLine(Referee.Score(choice, opponentAnswer));
                }

                Console.WriteLine(Validator.Continue());
            }


        }
    }
}
