namespace SportStudio
{
    public class SportStudio
    {
        public Guid Id { get; }

        public string Name { get; }

        public Address Address { get; set; }

        public SportStudio(Address address)
        {
            this.Id = Guid.NewGuid();
            this.Name = "Sport und so";
            this.Address = address;
        }

    }
}