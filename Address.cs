namespace SportStudio
{
    public class Address
    {
        public Guid id { get; }
        public string street { get; set; }
        public string city { get; set; }
        public string country { get; set; }
        public string zipCode { get; set; }

        public Address(string street, string city, string country, string zipCode)
        {
            this.id = Guid.NewGuid();
            this.street = street;
            this.city = city;
            this.country = country;
            this.zipCode = zipCode;
        }
    }
}
