namespace SportStudio
{
    public class User
    {
        public Guid Id { get; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
        public Boolean IsAdmin { get; set; }
        public Address Address { get; set; }

        public User(string firstName, string lastName, string eMail, string password, bool isAdmin, Address address)
        {
            this.Id = Guid.NewGuid();
            this.FirstName = firstName;
            this.LastName = lastName;
            this.EMail = eMail;
            this.Password = password;
            this.IsAdmin = isAdmin;
            this.Address = address;
        }

    }
}