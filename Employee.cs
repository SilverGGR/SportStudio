namespace SportStudio
{
    public class Employee : Person
    {
        private string jobTitle { get; set; }
        private string specialty { get; set; }
        private double cost { get; set; }

        public Employee(string firstName, string lastName, string dateOfBirth, Address address, string jobTitle, string specialty, double cost)
            : base(firstName, lastName, dateOfBirth, address)
        {
            this.jobTitle = jobTitle;
            this.specialty = specialty;
            this.cost = cost;
        }
    }
}