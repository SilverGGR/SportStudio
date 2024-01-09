namespace SportStudio
{
    public class Machine
    {
        private Guid id { get; }

        private string name { get; set; }

        private Room room { get; set; }

        private string type { get; set; }

        public Machine(string name, Room room, string type)
        {
            this.id = Guid.NewGuid();
            this.name = name;
            this.room = room;
            this.type = type;
        }

    }
}