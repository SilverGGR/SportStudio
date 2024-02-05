using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class Pool : Room
    {
        public byte Capacity { get; }

        public Pool(byte floor, double roomSize)
            : base("Pool", floor, roomSize)
        {
            Capacity = 50;
        }
    }
}
