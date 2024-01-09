using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio

{
    internal class Sauna : Room
    {
        private byte[] tempRange { get; set; }

        public Sauna(string name, byte floor, double roomSize, byte[] tempRange)
            : base("Sauna", floor, roomSize)
        {

            this.tempRange = tempRange;
        }
    }
}
