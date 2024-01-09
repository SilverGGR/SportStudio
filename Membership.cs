namespace SportStudio
{
    public class Membership
    {
        private Guid id { get; }
        private string[] modules { get; set; }
        private double monthlyFee { get; set; }
        private string startDate { get; set; }
        private string endDate { get; set; }

        public Membership(string[] modules, double monthlyFee, string startDate, string endDate)
        {
            this.id = Guid.NewGuid();
            this.modules = modules;
            this.monthlyFee = monthlyFee;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        public double calcMonthlyFee()
        {
            if (modules.Contains("water"))

                monthlyFee += 10;
            
            if (modules.Contains("sauna"))
            {
                monthlyFee += 10;
            }

            return monthlyFee;
        }

    }
}