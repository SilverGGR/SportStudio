namespace SportStudio
{
    public class Machine
    {
        public Guid Id { get; }
        public string Name { get; set; }
        public Room Room { get; set; }
        public string Type { get; set; }

        public Machine(string name, Room room, string type)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Room = room;
            this.Type = type;
        }

    }
}