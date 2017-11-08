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
            int opponentAnswer = 0;
            int choice = 0;
            string result;
            string opponentResult;
            while (true)
            {


                Console.Write("Welcome to the Rock Paper Scissos Game!\nPlease enter your name: ");
                ThirdPlayer name = new ThirdPlayer(Validator.NameValidator());
                
                Console.Write($"\nOk {name}. Please select an opponent from the list below.\n1. Shepard\n2. Aloy\nSelect: ");
                int selection = Validator.OpponentSelection();

                if (selection == 1)
                {
                    Console.Write("\nPlease choose R,P,S : ");
                    choice = Validator.InputValidator();
                    result = Validator.Result(choice);
                    Console.WriteLine($"\n{name} you have picked {result} and your opponent {FirstPlayer.Shepard()} has choosen Rock\n");
                    Console.WriteLine(Referee.Score(choice, 0));

                }
                if (selection == 2)
                {
                    Console.Write("\nPlease choose R,P,S : ");
                    choice = Validator.InputValidator();
                    result = Validator.Result(choice);
                    opponentAnswer = SecondPlayer.AloysChoice(opponentAnswer);
                    opponentResult = Validator.Result(opponentAnswer);
                    Console.WriteLine($"\n{name} you have picked {result} and your opponent {SecondPlayer.Aloy()} has choosen {opponentResult}\n");
                    Console.WriteLine(Referee.Score(choice, opponentAnswer));
                }

                Console.WriteLine(Validator.Continue());
            }
            
            
        }
    }
}
