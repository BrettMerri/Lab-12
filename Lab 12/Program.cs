using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;

            Console.Title = "Rock Paper Scissors Game!";

            Player Human = new HumanPlayer();
            Player Rocky = new RockPlayer();
            Player Randy = new RandomPlayer();

            bool Loop = true;

            Console.WriteLine("Welcome to the Rock Paper Scissors game!\n");

            Console.Write("Enter your name: ");
            Human.Name = Console.ReadLine();

            while (Loop)
            {
                Console.WriteLine("\nWould you like to play against Rocky or Randy?");

                string[] OpponentOptions = { "rocky", "randy" };
                string Opponent = ConsoleValidation.GetValidString(OpponentOptions);

                if (Opponent == "rocky")
                    Play(Human, Rocky);
                else
                    Play(Human, Randy);
                if (!ContinueApp()) //Prompts user if he wants to continue. Set loop to false if use does not want to continue.
                    Loop = false;
            }

        }

        public static void Play(Player Human, Player Opponent)
        {
            string HumanChoice;
            string OpponentChoice;

            while (true)
            {
                HumanChoice = Human.GenerateRoshambo().ToString();
                OpponentChoice = Opponent.GenerateRoshambo().ToString();

                Console.WriteLine($"{Human.Name}: {HumanChoice}");
                Console.WriteLine($"{Opponent.Name}: {OpponentChoice}");

                if ((HumanChoice == "rock" && OpponentChoice == "scissors") ||
                    (HumanChoice == "paper" && OpponentChoice == "rock") ||
                    (HumanChoice == "scissors" && OpponentChoice == "paper"))
                {
                    Console.WriteLine($"{Human.Name} wins!");
                    return;
                }
                else if ((HumanChoice == "rock" && OpponentChoice == "paper") ||
                    (HumanChoice == "paper" && OpponentChoice == "scissors") ||
                    (HumanChoice == "scissors" && OpponentChoice == "rock"))
                {
                    Console.WriteLine($"{Opponent.Name} wins!");
                    return;
                }
                Console.WriteLine("Tie!");
            }
        }
        public static bool ContinueApp()
        {
            string[] Options = new string[] { "y", "n" };
            Console.Write("Do you like to continue? (y/n): "); //Prompt user to type y or n
            string input = ConsoleValidation.GetValidString(Options); //Gets validated string from the user that is either y or n.
            if (input == "y") //If input is y, write new line and return true
            {
                Console.WriteLine();
                return true;
            }
            else //If inpus is n, return false
                return false;
        }
    }
}