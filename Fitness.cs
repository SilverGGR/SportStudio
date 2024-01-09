using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class Fitness : Room
    {

        private Machine[] machines { get; set; }

        public Fitness(string name, byte floor, double roomSize, Machine[] machines)
            : base("Fitness", floor, roomSize)
        {
            this.machines = machines;
        }
    }
}
