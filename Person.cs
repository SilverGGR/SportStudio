namespace SportStudio
{
    public class Person
    {
        private int id { get; set; }
        private string firstName { get; set; }
        private string lastName { get; set; }
        private string dateOfBirth { get; set; }
        private Address address { get; set; }

        public Person(int id, string firstName, string lastName, string dateOfBirth, Address address)
        {
            this.id = id;
            this.firstName = firstName;
            this.lastName = lastName;
            this.dateOfBirth = dateOfBirth;
            this.address = address;
        }

    }
}