namespace SportStudio
{
    public class Address
    {
        public Guid Id { get; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public Address(string street, int streetNumber, string city, int postalCode)
        {
            this.Id = Guid.NewGuid();
            this.Street = street;
            this.StreetNumber = streetNumber;
            this.City = city;
            this.PostalCode = postalCode;
        }
    }
}
