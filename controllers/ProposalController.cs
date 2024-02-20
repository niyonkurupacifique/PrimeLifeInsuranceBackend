using c_.Dto;
using c_.INGENZIModels;
using c_.service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Text;

namespace c_.controllers
{
    [Route("api/proposal")]
    [ApiController]
    public class ProposalController : ControllerBase
    {
        private readonly IProductProposalService _service;

        public ProposalController(IProductProposalService service)
        {
            _service = service;
        }

        [HttpPost("{product}")]
        public async Task<IActionResult> CreateProposal(string product)
        {
            if (string.IsNullOrEmpty(product))
            {
                return BadRequest();
            }

            object requestBody;

            switch (product)
            {
                case "family":
                    requestBody = HttpContext.Items["RequestBody"] as FamilyProductDto;
                    if (requestBody == null)
                    {
                        return BadRequest("No valid body found for family");
                    }

                    // Call the action function 
                    FamilyProductDto familyProposal = (FamilyProductDto)requestBody;

                    // Case for open family policies
                    // Create user if open family policies

                    if (familyProposal.ProductCategory == "Nkunganire -Shoferi Open")
                    {
                        // Create user
                        using var httpClient = new HttpClient();

                        var contentObject = new
                        {
                            userName = familyProposal.PayerPhone,
                            nationalId = familyProposal.NationalId,
                            email = ""
                        };

                        var content = new StringContent(JsonConvert.SerializeObject(contentObject), Encoding.UTF8, "application/json");

                        var res = await httpClient.PostAsync("https://apps.prime.rw/customerbackendtest/User/api/register", content);

                        var resContent = await res.Content.ReadAsStringAsync();
                        var errorObject = JsonConvert.DeserializeObject<dynamic>(resContent);
                        var errorMessage = (string)errorObject.errorMessage;

                        // return error message if the user is not created and pass if alraedy exists
                        if (errorMessage != null && !errorMessage.Equals("National id already in use, contact our support at 1320 for assistance .") 
                            )
                        {
                            // Failed to create user, return error message
                            return StatusCode((int)res.StatusCode, errorMessage);
                        }

                        // Handle params as required on open nkunganire
                        familyProposal.CustomerCode = 'C'+familyProposal.NationalId.Substring(0, familyProposal.NationalId.Length - 3);
                        familyProposal.Frequency = "Open";
                        familyProposal.PaymentMode = "MoMo";
                        familyProposal.IsSingle = true;
                        familyProposal.NumberOfParents = 0;
                        familyProposal.NumberOfInLaws =  0;
                        familyProposal.NumberOfKids = 0;
                       

                    }


                    var response = await _service.CreateFamilyProposal(familyProposal, product);

                    if (response == "Insurance rate data not found for the specified product category.")
                    {
                        return NotFound(response);
                    }

                    else if (response == "Error occurred while inserting data into the database. Please try again.")
                    {
                        return StatusCode(500, response);
                    }
                    else if (response == "You already have the proposal registered")
                    {
                        return StatusCode(409, response);
                    }
                    else if (response.StartsWith('W') || response.StartsWith('F'))
                    {
                        return StatusCode(201, response);

                    }
                    else if(response == "National id already in use, contact our support at 1320 for assistance .")
                    {
                        return StatusCode(200, response);
                    }

                    break;

                case "education":
                    requestBody = HttpContext.Items["RequestBody"] as ProposalRegister;
                    if (requestBody == null)
                    {
                        return BadRequest("No valid body found for education");
                    }
                    break;

                default:
                    return NotFound("Invalid product");
            }

            if (product == "education")
            {
                var educationProposal = (ProposalRegister)requestBody;
                var response = await _service.CreateEducationProposal(educationProposal, product);

                if (response.Contains("PRO-EDU"))
                {
                    return StatusCode(201, response);

                }
            }

            // This point should not be reached, but return BadRequest if it does.
            return BadRequest("Invalid product");
        }



    }
}
