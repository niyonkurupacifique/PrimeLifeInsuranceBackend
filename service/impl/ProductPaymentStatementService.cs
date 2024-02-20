using c_.INGENZIModels;
using c_.LoanProtectionTestModels;
using Microsoft.EntityFrameworkCore;

namespace c_.service.impl
{
    public class ProductPaymentStatementService : IProductPaymentStatement
    {

        private readonly INGENZIDbContext _context;
        private readonly LoanProtectionTestDbContext _contextt; 
        public ProductPaymentStatementService(INGENZIDbContext context , LoanProtectionTestDbContext contextt)
        {
            _context = context;
             _contextt=contextt;
        }

        public class FamilyPaymentStatementDetails
        {
            public c_.INGENZIModels.ViewPolicyDetail InsuredDetails { get; set; }
            public List<ViewFamilyPaymentStatement> PaymentStatements { get; set; }
        }

        public async Task<List<FamilyPaymentStatementDetails>> GetFamilyPaymentStatement(string policyNumber)
        {
            try
            {
                if (string.IsNullOrEmpty(policyNumber))
                {
                    throw new ArgumentException("Policy number cannot be empty or null");
                }

                var insuredDetails = await _context.ViewPolicyDetails.FirstOrDefaultAsync(user => user.PolicyNumber == policyNumber);

                if (insuredDetails == null)
                {
                    throw new ApplicationException("No insured found for the given policy number");
                }

                var paymentStatements = await _context.ViewFamilyPaymentStatements
                    .Where(statement => statement.PolicyNumber == policyNumber)
                    .ToListAsync();

                if (paymentStatements == null || !paymentStatements.Any())
                {
                    throw new ApplicationException("No payment statements found for the given policy number");
                }

               var paymentStatementData = new List<FamilyPaymentStatementDetails>();
               paymentStatementData.Add(new FamilyPaymentStatementDetails
                {
                    InsuredDetails = insuredDetails,
                    PaymentStatements = paymentStatements
                });

                return paymentStatementData;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (ApplicationException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the payment statement", ex);
            }

     
      
      
    }

         //////////////////// education///////////////////
 public class EducationPaymentStatementDetails
        {
            public  ViewEducationPolicyDetail educationInsuredDetails { get; set; }
            public List<ViewEdicationPaymentStatement> PaymentStatements { get; set; }
            public double? totalAmountPayed {get;set;}
        }

        public async Task<List<EducationPaymentStatementDetails>> GetEducationPaymentStatement(string policyNumber)
        {
            try
            {
                if (string.IsNullOrEmpty(policyNumber))
                {
                    throw new ArgumentException("Policy number cannot be empty or null");
                }

                var educationInsuredDetails = await _context.ViewEducationPolicyDetails.FirstOrDefaultAsync(user => user.PolicyNumber == policyNumber);

                if (educationInsuredDetails == null)
                {
                    throw new ApplicationException("No insured found for the given policy number");
                }


                var paymentStatements = await _context.ViewEdicationPaymentStatements
                    .Where(statement => statement.PolicyNumber == policyNumber)
                    .ToListAsync();

                if (paymentStatements == null || !paymentStatements.Any())
                {
                    throw new ApplicationException("No payment statements found for the given policy number");
                }


             double? totalAmountPayed = await _context.ViewEdicationPaymentStatements
            .Where(statement => statement.PolicyNumber == policyNumber && statement.AmountPayed != null)
            .SumAsync(statement => statement.AmountPayed);


               var paymentStatementData = new List<EducationPaymentStatementDetails>();
               paymentStatementData.Add(new EducationPaymentStatementDetails
                {
                    educationInsuredDetails = educationInsuredDetails,
                    PaymentStatements = paymentStatements,
                    totalAmountPayed=totalAmountPayed
                });

                return paymentStatementData;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (ApplicationException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the payment statement", ex);
            }

     
      
      
     

    }

 //////////////////// employee///////////////////
 
  
  public class EmployeePaymentStatementDetails
        {
            public  ViewEpiPolicyDetail epiInsuredDetails { get; set; }
            public List<ViewEpiPaymentStatement> PaymentStatements { get; set; }
           
        }

        public async Task<List<EmployeePaymentStatementDetails>> GetEmployeePaymentStatement(string policyNumber)
        {
            try
            {
                if (string.IsNullOrEmpty(policyNumber))
                {
                    throw new ArgumentException("Policy number cannot be empty or null");
                }

                var epiInsuredDetails = await _context.ViewEpiPolicyDetails.FirstOrDefaultAsync(user => user.PolicyNumber == policyNumber);

                if (epiInsuredDetails == null)
                {
                    throw new ApplicationException("No insured found for the given policy number");
                }


                var paymentStatements = await _context.ViewEpiPaymentStatements
                    .Where(statement => statement.PolicyNumber == policyNumber)
                    .ToListAsync();

                if (paymentStatements == null || !paymentStatements.Any())
                {
                    throw new ApplicationException("No payment statements found for the given policy number");
                }


             double? totalAmountPayed = await _context.ViewEdicationPaymentStatements
            .Where(statement => statement.PolicyNumber == policyNumber && statement.AmountPayed != null)
            .SumAsync(statement => statement.AmountPayed);


               var paymentStatementData = new List<EmployeePaymentStatementDetails>();
               paymentStatementData.Add(new EmployeePaymentStatementDetails
                {
                    epiInsuredDetails = epiInsuredDetails,
                    PaymentStatements = paymentStatements,
                   
                });

                return paymentStatementData;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (ApplicationException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the payment statement", ex);
            }

     
      
      
     

    }

//////////////////////////  employee saving /////////////////////////////



  public class EmployeeSavingStatementDetails
        {
            public  c_.INGENZIModels.ViewAllPoliciesStatment epiInsuredDetails { get; set; }
            public List<c_.LoanProtectionTestModels.SavingsPayement> PaymentStatements { get; set; }
             public double? totalAmountPayed {get;set;}
           public  double?  SurrenderAmount{get;set;}
            public  double?  currentFundValue{get;set;}
        }

        public async  Task<List<EmployeeSavingStatementDetails>> GetEmployeeSavingStatement(string policyNumber)
        {
            try
            {
                if (string.IsNullOrEmpty(policyNumber))
                {
                    throw new ArgumentException("Policy number cannot be empty or null");
                }

                var epiInsuredDetails = await _context.ViewAllPoliciesStatments.FirstOrDefaultAsync(user => user.PolicyNumber == policyNumber);

                if (epiInsuredDetails == null)
                {
                    throw new ApplicationException("No insured found for the given policy number");
                }


     var paymentStatements = await _contextt.SavingsPayements
    .Where(statement => statement.PolicyNumber.StartsWith(policyNumber))
    .ToListAsync();

if (paymentStatements == null || !paymentStatements.Any())
{
    throw new ApplicationException("No payment statements found for the given policy number");
}

                 

DateTime currentDate = DateTime.Now.Date;
DateOnly oneMonthAheadDate = DateOnly.FromDateTime(currentDate.AddMonths(1));
DateTime oneMonthAhead = DateTime.Now.AddMonths(1);
    

double? currentFundValue = await _contextt.PensionDetailsTableHistoryStatements
    .Where(statement => 
        statement.PolicyNumber.StartsWith(policyNumber) &&
        statement.DueDate < oneMonthAheadDate &&
        statement.IdRecord == _contextt.PensionDetailsTableHistoryStatements
            .Where(innerStatement => 
                innerStatement.PolicyNumber.StartsWith(policyNumber) &&
                innerStatement.PolicyNumber.StartsWith(policyNumber))
            .Max(innerStatement => innerStatement.IdRecord))
    .MaxAsync(statement => (double?)statement.AcquiredValue);

double fundValue = currentFundValue ?? 0; // Default to 0 if null




          double? totalAmountPayed = await _contextt.SavingsPayements
            .Where(statement =>
              statement.PolicyNumber.StartsWith(policyNumber) &&
            statement.AmountPayed != null &&
            statement.AmountPayed > 0 )
             .SumAsync(statement => statement.AmountPayed);

             double? surrenderAmount = await _contextt.SavingsPayements
            .Where(statement =>
              statement.PolicyNumber.StartsWith(policyNumber) &&
            statement.AmountPayed != null &&
            statement.AmountPayed<0 &&
               statement.PaymentDate < oneMonthAhead)
             .SumAsync(statement => statement.AmountPayed);

            


               var paymentStatementData = new List<EmployeeSavingStatementDetails>();
               paymentStatementData.Add(new EmployeeSavingStatementDetails
                {
                    epiInsuredDetails = epiInsuredDetails,
                    PaymentStatements = paymentStatements,
                    totalAmountPayed=totalAmountPayed,
                    SurrenderAmount=surrenderAmount,
                    currentFundValue=fundValue
                });

                return paymentStatementData;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (ApplicationException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the payment statement", ex);
            }

     
      
      
     

    }

    

////////////////////////////////// IKIMINA ///////////////


public class IkiminaSavingStatementDetails
        {
            public  c_.INGENZIModels.ViewAllPoliciesStatment epiInsuredDetails { get; set; }
            public List<c_.LoanProtectionTestModels.SavingsPayement> PaymentStatements { get; set; }
             public double? totalAmountPayed {get;set;}
           public  double?  SurrenderAmount{get;set;}
            public  double?  currentFundValue{get;set;}
        }

        public async   Task<List<IkiminaSavingStatementDetails>> GetIkiminaSavingStatement(string policyNumber)
        {
            try
            {
                if (string.IsNullOrEmpty(policyNumber))
                {
                    throw new ArgumentException("Policy number cannot be empty or null");
                }

                var epiInsuredDetails = await _context.ViewAllPoliciesStatments.FirstOrDefaultAsync(user => user.PolicyNumber == policyNumber);

                if (epiInsuredDetails == null)
                {
                    throw new ApplicationException("No insured found for the given policy number");
                }


                var paymentStatements = await _contextt.SavingsPayements
                    .Where(statement => statement.PolicyNumber == policyNumber)
                    .ToListAsync();

                if (paymentStatements == null || !paymentStatements.Any())
                {
                    throw new ApplicationException("No payment statements found for the given policy number");
                }

                 

     DateTime oneMonthAhead = DateTime.Now.AddMonths(1);
     DateOnly oneMonthAheadDate = DateOnly.FromDateTime(oneMonthAhead);

    // double? Currentfundvalue= await _contextt.PensionDetailsTableHistoryStatements
    // .Where(statement => 
    //     statement.PolicyNumber == policyNumber &&
    //     statement.DueDate < oneMonthAheadDate)
    // .MaxAsync(statement => statement.AcquiredValue);

    double? currentFundValue = await _contextt.PensionDetailsTableHistoryStatements
    .Where(statement => 
        statement.PolicyNumber.StartsWith(policyNumber) &&
        statement.DueDate < oneMonthAheadDate &&
        statement.IdRecord == _contextt.PensionDetailsTableHistoryStatements
            .Where(innerStatement => 
                innerStatement.PolicyNumber.StartsWith(policyNumber) &&
                innerStatement.PolicyNumber.StartsWith(policyNumber))
            .Max(innerStatement => innerStatement.IdRecord))
    .MaxAsync(statement => (double?)statement.AcquiredValue);

double fundValue = currentFundValue ?? 0; // Default to 0 if null

          double? totalAmountPayed = await _contextt.SavingsPayements
            .Where(statement =>
              statement.PolicyNumber == policyNumber &&
            statement.AmountPayed != null &&
               statement.PaymentDate < oneMonthAhead)
             .SumAsync(statement => statement.AmountPayed);

             double? surrenderAmount = await _contextt.SavingsPayements
            .Where(statement =>
              statement.PolicyNumber == policyNumber &&
            statement.AmountPayed != null &&
            statement.AmountPayed<0 &&
               statement.PaymentDate < oneMonthAhead)
             .SumAsync(statement => statement.AmountPayed);

            


               var paymentStatementData = new List<IkiminaSavingStatementDetails>();
               paymentStatementData.Add(new IkiminaSavingStatementDetails
                {
                    epiInsuredDetails = epiInsuredDetails,
                    PaymentStatements = paymentStatements,
                    totalAmountPayed=totalAmountPayed,
                    SurrenderAmount=surrenderAmount,
                    currentFundValue=   fundValue
                });

                return paymentStatementData;
            }
            catch (ArgumentException ex)
            {
                throw;
            }
            catch (ApplicationException ex)
            {
                throw;
            }
            catch (Exception ex)
            {
                throw new Exception("An error occurred while fetching the payment statement", ex);
            }

     
      
      
     

    }



    }}
