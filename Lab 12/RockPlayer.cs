using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    class RockPlayer : Player
    {
        public RockPlayer()
        {
            Name = "Rocky"; //Set RockPlayer's name to Rocky when a new RockPlayer object is created
        }
        public override Enum GenerateRoshambo()
        {
            return roshambo.rock; //RockPlayer always returns Rock.
        }
    }
}
