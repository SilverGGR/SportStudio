using System;

namespace SportStudio
{
    public class SportStudio
    {
        private int id { get; set; }
        private string name { get; set; }
        private Address address { get; set; }

        public SportStudio(int id, string name, Address address)
        {
            this.id = id;
            this.name = name;
            this.address = address;
        }

    }
}