using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class RandomPlayer : Player
    {
        public RandomPlayer()
        {
            Name = "Randy"; //Set RandomPlayer's name to Randy when a new RandomPlayer object is created.
        }
        public override Enum GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(roshambo)); //Creates an array of values based on the roshambo enum (rock, paper, scissors)
            Random random = new Random(); //Generates a new random number instance.
            return (roshambo)values.GetValue(random.Next(values.Length)); //Returns a random enum option. (it will return either Rock, Paper, or Scissors)
        }
    }
}
