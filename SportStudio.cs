namespace SportStudio
{
    public class SportStudio
    {
        public Guid id { get; }

        private string name { get; }

        private Address address { get; set; }

        public SportStudio(Address address)
        {
            this.id = Guid.NewGuid();
            this.name = "Sport und so";
            this.address = address;
        }

    }
}