using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class Fitness : Room
    {

        public Machine[] Machines { get; set; }

        public Fitness(byte floor, double roomSize, Machine[] machines)
            : base("Fitness", floor, roomSize)
        {
            this.Machines = machines;
        }
    }
}
