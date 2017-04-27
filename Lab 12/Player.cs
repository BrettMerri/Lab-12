using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    abstract class Player
    {
        private string name; //All players will have a name.
        protected enum roshambo {rock, paper, scissors}; //Declares an enum with the options "rock", "paper", or "scissors".

        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                name = value;
            }
        }

        public abstract Enum GenerateRoshambo(); //Creates an abstract method so that other classes can use a different GenerateRoshambo method.


    }
}
