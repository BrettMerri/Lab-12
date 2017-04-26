using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class HumanPlayer : Player
    {
        public override Enum GenerateRoshambo()
        {
            string[] Options = { "rock", "paper", "scissors" };

            Console.Write("Enter rock, paper, or scissors: ");
            string Choice = ConsoleValidation.GetValidString(Options);
            if (Choice == "rock")
                return roshambo.rock;
            if (Choice == "paper")
                return roshambo.paper;
            else
                return roshambo.scissors;
        }
    }
}
