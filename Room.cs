namespace SportStudio

{
    public class Room
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public byte Floor { get; set; }
        public double RoomSize { get; set; }

        public Room(string name, byte floor, double roomSize)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Floor = floor;
            this.RoomSize = roomSize;
        }

    }
}