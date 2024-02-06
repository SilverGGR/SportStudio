namespace SportStudio
{
    public class User : IUser
    {
        public Guid Id { get; }

        public string Email { get; set; }
        public string Password { get; set; }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Street { get; set; }
        public int StreetNumber { get; set; }
        public string City { get; set; }
        public int PostalCode { get; set; }

        public Membership UserMembership { get; set; }

        public User(
            string email,
            string password,
            string firstName,
            string lastName,
            string street,
            int streetNumber,
            string city,
            int postalCode
            )
        {
            this.Id = Guid.NewGuid();
            this.Email = email;
            this.Password = password;
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Street = street;
            this.StreetNumber = streetNumber;
            this.City = city;
            this.PostalCode = postalCode;

            this.UserMembership = new Membership(false, false, false, false, 0);
        }

        public virtual void DisplayMembershipInfo()
        {
            MessageBox.Show("This is a regular Membership");
        }

        public void ShowAttributes()
        {
            MessageBox.Show($"Email: {Email}\nPassword: {Password}\nFirstName: {FirstName}\nLastName: {LastName}\nStreet: {Street}\nStreetNumber: {StreetNumber}\nCity: {City}\nPostalCode: {PostalCode}");
        }
    }
}