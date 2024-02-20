using c_.service;
using Microsoft.AspNetCore.Mvc;

namespace c_.controllers
{
    [Route("api/statement")]
    [ApiController]
    public class StatementController : ControllerBase
    {
            private readonly IProductPaymentStatement _productService;

            public StatementController(IProductPaymentStatement productPaymentStatement)
            {
                this._productService = productPaymentStatement;
            }

            [HttpGet("family/{policyNumber}")]
            public async Task<IActionResult> GetFamilyPaymentStatement(string policyNumber)
            {

                var response = await _productService.GetFamilyPaymentStatement(policyNumber);

                if (response == null)
                {
                    return BadRequest();
                }

                return Ok(response);

            }

             [HttpGet("education/{policyNumber}")]
            public async Task<IActionResult> GetEducationPaymentStatement(string policyNumber)
            {

                var response = await _productService.GetEducationPaymentStatement(policyNumber);

                if (response == null)
                {
                    return BadRequest();
                }

                return Ok(response);

            }

             [HttpGet("employee/{policyNumber}")]
            public async Task<IActionResult> GetEmployeePaymentStatement(string policyNumber)
            {

                var response = await _productService.GetEmployeePaymentStatement(policyNumber);

                if (response == null)
                {
                    return BadRequest();
                }

                return Ok(response);

            }


            [HttpGet("employee/saving/{policyNumber}")]
            public async Task<IActionResult> GetEmployeeSavingStatement(string policyNumber)
            {

                var response = await _productService.GetEmployeeSavingStatement(policyNumber);

                if (response == null)
                {
                    return BadRequest();
                }

                return Ok(response);

            }

           [HttpGet("Ikimina/saving/{policyNumber}")]
            public async Task<IActionResult> GetIkiminaSavingStatement(string policyNumber)
            {

                var response = await _productService.GetIkiminaSavingStatement(policyNumber);

                if (response == null)
                {
                    return BadRequest();
                }

                return Ok(response);

            }

        }
}
