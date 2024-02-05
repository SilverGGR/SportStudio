namespace SportStudio
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public bool IsAdmin { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public Membership UserMembership { get; set; }

        public User(
            string firstName,
            string lastName,
            string eMail,
            string password,
            bool isAdmin,
            string street,
            int streetNumber,
            string city,
            int postalCode
            )
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
            this.Password = password;
            this.IsAdmin = isAdmin;
            this.Street = street;
            this.StreetNumber = streetNumber;
            this.City = city;
            this.PostalCode = postalCode;

            this.UserMembership = new Membership(false, false, false, false, 0);
        }

    }
}