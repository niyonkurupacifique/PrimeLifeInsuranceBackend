using c_.Dto;
using c_.INGENZIModels;
using c_.utils;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Newtonsoft.Json;
using System.Data;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Text;

namespace c_.service.impl
{
    public class ProductProposalService : IProductProposalService
    {

        private readonly INGENZIDbContext _dbContext;
        private readonly IConfiguration _configuration;
        public ProductProposalService(INGENZIDbContext dbContext, IConfiguration configuration)
        {
            _dbContext = dbContext;
            _configuration = configuration;
        }
        async public Task<string> CreateFamilyProposal(FamilyProductDto proposalInput, string product)
        {

            try
            {
                string proposalNumber = "";
                string schemeId = "";
                string productName = "";
                // Condition on source of the policy
                if(proposalInput.ProductCategory == "Nkunganire -Shoferi Open")
                {
                    int nextProposalNumber = GetNextProposalNumber();
                     proposalNumber =  proposalInput.ProposalNumber = $"PRO-NKG-{nextProposalNumber}";
                    schemeId = "MobileApp";
                    productName = "Nkunganire -Shoferi Open";
                }
                else
                {
                    // other policies from website
                     proposalNumber = proposalInput.ProposalNumber;
                     schemeId = "WEBSITE";
                    productName = "Family Insurance";
                }


                // Retrieve the fields from the input model
                string? productCategory = proposalInput.ProductCategory;
                string? customerCode = proposalInput.CustomerCode;
                string? frequency = proposalInput.Frequency;
                string? paymentMode = proposalInput.PaymentMode;
                bool? isSingle = proposalInput.IsSingle;
                int? numberOfParents = proposalInput.NumberOfParents;
                int? numberOfInLaws = proposalInput.NumberOfInLaws;
                int? numberOfKids = proposalInput.NumberOfKids;
                string? payerNumber = proposalInput.PayerPhone;

                double? calcRiskPremium = 0;


                // Fetch data from FamilyRate model based on CategoryType
                var familyRate = await _dbContext.FamilyRates.FirstOrDefaultAsync(fr => fr.CategoryType == productCategory);
                // Check if the category of product already exists
                //bool isProposalExist = await _dbContext.ProposalRegisters
                    // .AnyAsync(pr => pr.CustomerCode == customerCode && pr.ProductCategory == productCategory);


               // if (isProposalExist)
               // {
                 //   return "You already have the proposal registered";
              //  }


                ProposalRegister proposal = new();
                Helpers helper = new();

                if (familyRate != null)
                {
                    if ((bool)!isSingle)  
                                  
                    {

                        if ((numberOfKids > familyRate.BaseKids))
                        {
                             calcRiskPremium = ((numberOfKids - familyRate.BaseKids) * (frequency == "Monthly" ? familyRate.MonthlyAddPremium : familyRate.AnnualyAddPremium)) +
                                              ((numberOfParents != 0) ? (frequency == "Monthly" ? familyRate.MonthlyAddPmParent : familyRate.MonthlyAddPmParent * 12) : 0) +
                                              ((numberOfInLaws != 0) ? (frequency == "Monthly" ? familyRate.MonthlyAddPmParent : familyRate.MonthlyAddPmParent * 12) : 0) +
                                              (frequency == "Monthly" ? familyRate.MonthlyPremium : familyRate.AnnualyPremium);
                        }
                        else
                        {
                            calcRiskPremium = ((double?)0) +
                                              ((numberOfParents != 0) ? (frequency == "Monthly" ? familyRate.MonthlyAddPmParent : familyRate.MonthlyAddPmParent * 12) : 0) +
                                              ((numberOfInLaws != 0) ? (frequency == "Monthly" ? familyRate.MonthlyAddPmParent : familyRate.MonthlyAddPmParent * 12) : 0) +
                                              (frequency == "Monthly" ? familyRate.MonthlyPremium : familyRate.AnnualyPremium);
                        }


                        proposal.NumberOfKids = numberOfKids;

                        proposal.TotalSumInsured = familyRate.PolicyholderSumInsured + familyRate.SpouseSumInsured +
                                                       (numberOfKids != 0 ? familyRate.KidsSumInsured * numberOfKids : 0) +
                                                       (numberOfParents != 0 ? familyRate.ParentSumInsured : 0) +
                                                       (numberOfInLaws != 0 ? familyRate.ParentSumInsured : 0);

                        proposal.SpouceCover = (decimal)familyRate.SpouseSumInsured;


                    }
                    else
                    {
                        proposalInput.NumberOfKids = 0;
                        proposal.TotalSumInsured = familyRate.PolicyholderSumInsured + ((numberOfParents != 0) ? frequency == "Monthly" ? familyRate.MonthlyAddPmParent : familyRate.MonthlyAddPmParent * 12 : 0) +
                                                  ((numberOfInLaws != 0) ? frequency == "Monthly" ? familyRate.MonthlyAddPmParent : familyRate.MonthlyAddPmParent * 12 : 0);
                        calcRiskPremium = (double)(frequency == "Monthly" ? familyRate.MonthlyPremium : familyRate.AnnualyPremium);
                    }

                    // Get the current year
                    int currentYear = DateTime.Now.Year;

                    string extractedNumbers = customerCode.Substring(2, 4);
                    int policyTermInYears = int.Parse(extractedNumbers);

                    // Calculate the result
                    int policyTerm = 65 - (currentYear - policyTermInYears);

                    

                    // Populate ProposalRegister fields based on FamilyRate data
                    proposal.NumberDirectParent = numberOfParents;
                    proposal.RiskPremium = productCategory == "Nkunganire -Shoferi Open" ? (double)proposalInput.Premium : calcRiskPremium;
                    proposal.ProposalDate = DateTime.Now;
                    proposal.NumberParentLaw = numberOfInLaws;
                    proposal.ProposalNumber = proposalNumber;
                    proposal.CustomerCode = customerCode;
                    proposal.SchemeId = schemeId;
                    proposal.Premium = productCategory == "Nkunganire -Shoferi Open" ? (double) proposalInput.Premium : (double)(frequency == "Monthly" ? (familyRate.MonthlyMinSavings + calcRiskPremium) : (familyRate.AnnualyMinSavings + calcRiskPremium));
                    proposal.PremiumFrequency = frequency;
                    proposal.SavingsPremium =  frequency == "Monthly" ? familyRate.MonthlyMinSavings : familyRate.AnnualyMinSavings;
                    proposal.PolicyTermYears = policyTerm;
                    proposal.ProductCategory = familyRate.CategoryType;
                    proposal.SumInsured = familyRate.PolicyholderSumInsured;
                    proposal.BenefitPaymentFrequency = "Lumpsum";
                    proposal.BusinessChannel = "DIRECT"; // the web is self service so, no agents
                    proposal.DistributionChannelId = "CH100133";
                    proposal.PaymentMode = paymentMode;
                    //proposal.Institutions = payerNumber != null ? helper.GetTelecomOperator(payerNumber) : bankName; // condition based on momo and bank
                    //proposal.AccountNumber = bankAccountNumber;
                    //proposal.ReciptingBankId = bankId;
                    proposal.DueDate = DateTime.Now;
                    proposal.RecordedDate = DateTime.Now;
                    proposal.UserName = "Digital User"; // to add phone number as user
                    proposal.Converted = false;
                    proposal.Product = productName;
                    proposal.Cancelled = false;
                    proposal.ChildCovered = familyRate.BaseKids.ToString();
                    proposal.Funeral = (decimal)familyRate.FuneralAmount;


                    // Add ProposalRegister object to DbContext
                    _dbContext.ProposalRegisters.Add(proposal);

                    // Save changes to the database
                    await _dbContext.SaveChangesAsync();

                    if (!string.IsNullOrEmpty(proposalNumber) && productCategory == "Nkunganire -Shoferi Open")
                    {
                        // Check if the transaction of MOMO is success then
                        // Create proposal

                        // Execute stored procedure using Entity Framework
                        var convertedProposalNumber = await ConvertNkunganireOpenPolicyAsync(proposalNumber);

                        return convertedProposalNumber;
                    }

                    return proposalNumber;

                }
                else
                { 
                    return "Insurance rate data not found for the specified product category.";
                }
            }
            catch (DbUpdateException ex)
            {
                return "Error occurred while inserting data into the database. Please try again."+ex ;
            }
            catch (Exception ex)
            {
                return "An error occurred while processing the request." ;
            }
        }
   


    // add another product proposal interface here
     public async Task<string> CreateEducationProposal(ProposalRegister proposal, string product)
        {
            try
            {
              

                int currentYear = DateTime.Now.Year;
                string birthYearSubstring = proposal.CustomerCode.Substring(1, Math.Min(4, proposal.CustomerCode.Length));
                int age = 0;

                if (int.TryParse(birthYearSubstring, out int birthYear))
                {
                    // Calculate age
                    age = currentYear - birthYear;
                    Console.WriteLine("Age: " + age);
                }
                else
                {
                    Console.WriteLine("Invalid birth year format");
                }

                var requestContent = new
                {
                    age = age,
                    premiumFrequency = proposal.PremiumFrequency,
                    benefitYears = proposal.BenefitsInYears,
                    contributionYears = proposal.PolicyTermYears,
                    premium = proposal.Premium
                };

                var educationApiResponse = await CalculateSumAssured(requestContent.age, requestContent.premiumFrequency, requestContent.benefitYears, requestContent.contributionYears, requestContent.premium);

                if (educationApiResponse != null)
                {
                    proposal.SumInsured = (double?)educationApiResponse;
                }

                int nextProposalNumber = GetNextProposalNumber();
                proposal.ProposalNumber = $"PRO-EDU-{nextProposalNumber}";

                proposal.SchemeId = "WEBSITE";
                proposal.Product = "EDUCATION Insurance";
                proposal.ProductCategory = "Annually";
                proposal.RiskPremium = 50;
                proposal.BusinessChannel = "DIRECT";
                proposal.Converted = false;
                proposal.ConvertedDate = null;
                proposal.PolicyNumber = null;
                proposal.SignedAndReturned = false;
                proposal.ReturnedDate = null;
                proposal.Cancelled = false;
                proposal.CancelledDate = null;
                proposal.CancelledRaison = null;
                proposal.StaffId = null;
                proposal.ReinsuranceNeeded = false;
                proposal.MedicalNeeded = false;
                proposal.NumberOfKids = 0;
                proposal.NumberDirectParent = 0;
                proposal.NumberParentLaw = 0;

                _dbContext.ProposalRegisters.Add(proposal);
                await _dbContext.SaveChangesAsync();

                return proposal.ProposalNumber;
            }
            catch (DbUpdateException ex)
            {
                return "Error occurred while inserting data into the database. Please try again.";
            }
            catch (Exception ex)
            {
                return "An error occurred while processing the request.";
            }
        }


        private async Task<string> ConvertNkunganireOpenPolicyAsync(string proposalNumber)
        {
            var connectionString = _configuration.GetConnectionString("SqlConnectionToIngenzi");

            using (var connection = new SqlConnection(connectionString))
            {
                await connection.OpenAsync();

                using (var command = connection.CreateCommand())
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.CommandText = "ConvertNkunganireOpenPolicy";
                    command.Parameters.AddWithValue("@ProposalNumber", proposalNumber);

                    var result = await command.ExecuteScalarAsync();

                    // Assuming the result is a scalar value, cast appropriately
                    return result?.ToString() ?? string.Empty;
                }
            }
        }

        private async Task<decimal?> CalculateSumAssured(int age, string premiumFrequency, int benefitYears, int contributionYears, double premium)
        {
            using (var client = new HttpClient())
            {
                // Set base URL
                var baseUrl = "http://localhost:5246/api/educationTarrif";
                var queryString = $"?age={age}&premiumFrequency={premiumFrequency}&benefitYears={benefitYears}&contributionYears={contributionYears}&premium={premium}";
                client.BaseAddress = new Uri(baseUrl + queryString);

                // Set request headers
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

                // Send GET request
                var response = await client.GetAsync("");

                // Check for successful response
                if (response.IsSuccessStatusCode)
                {
                    // Get response content
                    var responseContent = await response.Content.ReadAsStringAsync();

                    // Deserialize JSON response
                    var responseData = Newtonsoft.Json.JsonConvert.DeserializeObject<dynamic>(responseContent);

                    // Return sumAssured
                    return (decimal?)((responseData?.endowment_amount_during_differed_period?.Value ?? 0) * (contributionYears - 1) + (benefitYears * (responseData?.endowment_amount_after_differed_period?.Value ?? 0)));
                }
                else
                {
                    // Handle error
                    throw new Exception($"Error calling API: {response.StatusCode}");
                }
            }
        }

        private int GetNextProposalNumber()
        {
            return _dbContext.ProposalRegisters.Count() + 10000002;
        }
    }
     }

   
