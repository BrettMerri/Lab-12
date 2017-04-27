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
            Console.BackgroundColor = ConsoleColor.Black; //Set default console colors
            Console.ForegroundColor = ConsoleColor.White;
            Console.Title = "Rock Paper Scissors Game!"; //Set console title

            Player Human = new HumanPlayer(); //Create three Player objects.
            Player Rocky = new RockPlayer();
            Player Randy = new RandomPlayer();

            bool Loop = true; //Set loops to true to loops the application

            Console.WriteLine("Welcome to the Rock Paper Scissors game!\n");

            Console.Write("Enter your name: "); //Prompt user to enter their name
            Human.Name = Console.ReadLine(); //Set the name for the Human player object to the user input

            while (Loop) //Loops application until Loop is set to false
            {
                Console.WriteLine("\nWould you like to play against Rocky or Randy?");

                string Opponent = ConsoleValidation.GetValidString(new string[] { "rocky", "randy" }); //Gets a valid, lowercase string from the user that must be either "rocky" or "randy".

                if (Opponent == "rocky") //If user inputs "rocky"
                    Play(Human, Rocky); //Play Rock Paper Scissors with Rocky

                else //If user inputs "randy"
                    Play(Human, Randy); //Play Rock Paper Scissors with Randy

                if (!ContinueApp()) //Prompts user if he wants to continue.
                    Loop = false; //Set loop to false if user does not want to continue.
            }

        }

        public static void Play(Player Human, Player Opponent) //Play accepts two Player objects
        {
            string HumanChoice; //Declare HumanChoice and OpponentChoice strings
            string OpponentChoice;

            while (true) //Loop in case of a tie
            {
                HumanChoice = Human.GenerateRoshambo().ToString(); //Prompts user to choose between Rock Paper or Scissors.
                OpponentChoice = Opponent.GenerateRoshambo().ToString(); //Generates a Rock Paper Scissors option from the Opponent object.

                Console.WriteLine($"{Human.Name}: {HumanChoice}"); //Displays user's name and his choice of Rock Paper Scissors.
                Console.WriteLine($"{Opponent.Name}: {OpponentChoice}"); //Displays opponent's name and his choice of Rock Paper Scissors.

                if ((HumanChoice == "rock" && OpponentChoice == "scissors") || //These are all of the conditions in which the human player wins
                    (HumanChoice == "paper" && OpponentChoice == "rock") ||
                    (HumanChoice == "scissors" && OpponentChoice == "paper"))
                {
                    Console.WriteLine($"{Human.Name} wins!"); //Display the human player's name and say that he wins
                    return; //Ends this method
                }
                else if ((HumanChoice == "rock" && OpponentChoice == "paper") || //These are all of the conditions in which the opponent player wins
                         (HumanChoice == "paper" && OpponentChoice == "scissors") ||
                         (HumanChoice == "scissors" && OpponentChoice == "rock"))
                {
                    Console.WriteLine($"{Opponent.Name} wins!"); //Display the opponent player's name and say that he wins
                    return; //Ends this method
                }
                Console.WriteLine("Tie!"); //The only conditions left are the ones where both players select the same option. We then write "Tie" and then this method loops and you play Rock Paper Scissors again.
            }
        }
        public static bool ContinueApp()
        {
            Console.Write("Do you like to continue? (y/n): "); //Prompt user to type y or n
            string input = ConsoleValidation.GetValidString(new string[] { "y", "n" }); //Gets a valid, lowercase string from the user that is either y or n.
            if (input == "y") //If input is y, write new line and return true
            {
                Console.WriteLine();
                return true;
            }
            else //If inpus is n, write "Byebye!" to the console and return false
            {
                Console.WriteLine("Byebye!");
                return false;
            }
        }
    }
}