using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class Cardio : Room
    {
        public Machine[] Machines { get; set; }

        public Cardio(byte floor, double roomSize, Machine[] machines)
            : base("Cardio", floor, roomSize)
        {
            this.Machines = machines;
        }
    }

}
