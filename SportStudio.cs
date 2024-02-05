namespace SportStudio
{
    public class SportStudio
    {
        public Guid Id { get; }

        public string Name { get; }

        public SportStudio()
        {
            this.Id = Guid.NewGuid();
            this.Name = "Sport und so";
        }

    }
}