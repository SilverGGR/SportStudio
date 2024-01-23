﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SportStudio
{
    internal class Cardio : Room
    {
        private Machine[] machines { get; set; }

        public Cardio(string name, byte floor, double roomSize, Machine[] machines)
            : base("Cardio", floor, roomSize)
        {
            this.machines = machines;
        }
    }

}