using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class Pool : Room
    {
        private byte capacity { get; }

        public Pool(string name, byte floor, double roomSize)
            : base("Pool", floor, roomSize)
        {
            capacity = 50;
        }
    }
}
