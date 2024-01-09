namespace SportStudio

{
    public class Room
    {
        private Guid id { get; }

        private string name { get; set; }

        private byte floor { get; set; }

        private double roomSize { get; set; }

        public Room(string name, byte floor, double roomSize)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.floor = floor;
            this.roomSize = roomSize;
        }

    }
}