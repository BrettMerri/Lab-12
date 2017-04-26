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
            Name = "Rocky";
        }
        public override Enum GenerateRoshambo()
        {
            return roshambo.rock;
        }
    }
}
