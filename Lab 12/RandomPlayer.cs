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
            Name = "Randy";
        }
        public override Enum GenerateRoshambo()
        {
            Array values = Enum.GetValues(typeof(roshambo));
            Random random = new Random();
            return (roshambo)values.GetValue(random.Next(values.Length));
        }
    }
}
