using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio

{
    internal class Sauna : Room
    {
        public byte[] TempRange { get; set; }

        public Sauna(byte floor, double roomSize, byte[] tempRange)
            : base("Sauna", floor, roomSize)
        {

            this.TempRange = tempRange;
        }
    }
}
