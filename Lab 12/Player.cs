using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_12
{
    abstract class Player
    {
        private string name;
        protected enum roshambo {rock, paper, scissors};
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
        public abstract Enum GenerateRoshambo();


    }
}
