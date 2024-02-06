namespace SportStudio
{
    public class Membership
    {
        public Guid Id { get; }
        public int MonthlyFee { get; set; }
        public bool MukiAbo {  get; set; }
        public bool CardioAbo { get; set; }
        public bool WasserAbo { get; set; }
        public bool WellnessAbo { get; set; }

        public Membership(bool mukiAbo, bool cardioAbo, bool wasserAbo, bool wellnessAbo, int monthlyFee)
        {
            this.Id = Guid.NewGuid();
            this.MukiAbo = mukiAbo;
            this.CardioAbo = cardioAbo;
            this.WasserAbo = wasserAbo;
            this.WellnessAbo = wellnessAbo;
            this.MonthlyFee = monthlyFee;
        }
    }
}