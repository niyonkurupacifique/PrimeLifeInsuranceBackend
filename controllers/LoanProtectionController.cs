using c_.LoanProtectionModels;
using c_.service;
using Microsoft.AspNetCore.Mvc;

namespace c_.controllers
{
    [Route("api/loan-protection")]
    [ApiController]
    public class LoanProtectionController : ControllerBase
    {
        private readonly ILoanProtection _loanProtection;

        public LoanProtectionController(ILoanProtection loanProtection)
        {
            _loanProtection = loanProtection;
        }

        [HttpGet]
        public async Task<IActionResult> GetloanProtection(int yearOfBirth, double loanPeriod, string premiumFrequency, double loanAmount, string loanType, bool isJoint, bool coverRetrenchment)
        {
            var (resultDto, message) = await _loanProtection.GetLoanProtectionPremium(yearOfBirth, loanPeriod, premiumFrequency, loanAmount, loanType, isJoint, coverRetrenchment);

            if (resultDto == null)
            {
                return BadRequest(message);
            }
            else
            {
                return Ok(resultDto);
            }

        }
    }
}
