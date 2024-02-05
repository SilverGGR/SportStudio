namespace SportStudio
{
    public class Membership
    {
        public Guid Id { get; }
        public string[] Modules { get; set; }
        public double MonthlyFee { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }

        public Membership(string[] modules, double monthlyFee, string startDate, string endDate)
        {
            this.Id = Guid.NewGuid();
            this.Modules = modules;
            this.MonthlyFee = monthlyFee;
            this.StartDate = startDate;
            this.EndDate = endDate;
        }

        public double calcMonthlyFee()
        {
            if (Modules.Contains("water"))

                MonthlyFee += 10;
            
            if (Modules.Contains("sauna"))
            {
                MonthlyFee += 10;
            }

            return MonthlyFee;
        }

    }
}