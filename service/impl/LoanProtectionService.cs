using c_.Dto;
using c_.LoanProtectionModels;
using Microsoft.EntityFrameworkCore;
using System;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace c_.service.impl
{
    public class LoanProtectionService : ILoanProtection
    {
        private readonly LoanProtectionContext _context;

        public LoanProtectionService(LoanProtectionContext context)
        {
            _context = context;
        }

      

        public async Task<(LoanProtectionRateDto, string message)> GetLoanProtectionPremium(int yearOfBirth, double loanPeriod, string premiumFrequency, double loanAmount, string loanType, bool isJoint, bool coverRetrenchment)
        {

            try
            {
                string updatedLoanType = (loanType == "CreditLine" ? "Constant" : loanType == "Decreasing" && premiumFrequency == "Annual" ? "Annual" : "Single");
                
                // Get Age of customer from date of birth
                int currentYear = DateTime.Today.Year;
                double age = currentYear - yearOfBirth;

                LoanProtectionRate loanRates = await _context.LoanProtectionRates.FirstOrDefaultAsync(rate => rate.Age == age && rate.LoanPeriod == loanPeriod && rate.TypeRate == updatedLoanType);

                if (loanRates == null)
                {
                    return (null, "Loan rates not found for the given parameters");
                }

                double adminstrationFees = 1000;
                // if cover retrenchment is true
                double retrenchmentPremium = coverRetrenchment ? (premiumFrequency == "Single" ? loanAmount * 0.003 : loanAmount * 0.0013) : 0;

                double netPremium = Math.Round((double)(loanAmount * loanRates.InsuranceRate / 1000)) + retrenchmentPremium;
                
                double totalPremiumSingleBorrower = !isJoint ? netPremium + adminstrationFees : 0;
                double totalPremiumJointBorrowers = isJoint ? (netPremium * 1.5) + adminstrationFees : 0;

                string[] covers = new string[] { "TPD", "Death", "Critical Illness", "Retrenchment" };


                // Get rid of retrenchment cover if customer did not check it
                 if (!coverRetrenchment)
                    {
                        covers = covers.Where(c => c != covers[3]).ToArray();
                    }

                var loanProtectionResponse = new LoanProtectionRateDto
                {
                    NetPremium = netPremium,
                    RetrenchmentPremium = retrenchmentPremium,
                    AdministrationFees = adminstrationFees,
                    TotalPremiumSingleBorrower = totalPremiumSingleBorrower,
                    TotalPremiumJointBorrowers = totalPremiumJointBorrowers,
                    covers = covers
                };

                return (loanProtectionResponse, "Loan protection details retrieved successfully.");

            }

            catch (Exception ex)
            {
                return (null, "An error occurred while calculating the loan protection premium.");
            }
        }

    }
}
