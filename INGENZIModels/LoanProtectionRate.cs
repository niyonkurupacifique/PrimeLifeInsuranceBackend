namespace c_.INGENZIModels
{
    public class LoanProtectionRate
    {
        public int IdRecord { get; set; }

        public int Age { get; set; }

        public double LoanPeriod { get; set; }

        public double InsuranceRate { get; set; }

        public string TypeRate { get; set; } = null !;
    }
}
