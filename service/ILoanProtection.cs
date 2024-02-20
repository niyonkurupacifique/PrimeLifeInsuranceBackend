using c_.LoanProtectionModels;
namespace c_.service
{
    public interface ILoanProtection
    {
        Task<(Dto.LoanProtectionRateDto, string message)> GetLoanProtectionPremium
            (
            int yearOfBirth, 
            double loanPeriod, 
            string premiumFrequency, 
            double loanAmount, 
            string loanType, 
            bool isJoint,
            bool coverRetrenchment
            );
    }
}
