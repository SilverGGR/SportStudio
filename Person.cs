namespace SportStudio
{
    public class Person
    {
        private Guid id { get; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string dateOfBirth { get; set; }
        private Address address { get; set; }

        public Person(string firstName, string lastName, string dateOfBirth, Address address)
        {
            this.id = Guid.NewGuid();
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
        }

    }
}