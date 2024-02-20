namespace c_.Dto
{
    public class LoanProtectionRateDto
    {
            public double NetPremium { get; set; }
            public double AdministrationFees { get; set; }
            public double TotalPremiumSingleBorrower { get; set; }
            public double TotalPremiumJointBorrowers { get; set; }
            public double RetrenchmentPremium { get; set; }
            public string[] covers { get; set; }

    }
}
