// using c_.Models;
using c_.INGENZIModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Reflection;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.Extensions.Options;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
namespace controll.Controllers;
using Microsoft.Data.SqlClient;
using System.Net.Http;
using System.Xml.Linq;
using System.Net;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.Globalization;
using System.Data;
using System.Data.SqlClient;
[ApiController]
[Route("[controller]")]
public class UserController : ControllerBase
{
    private readonly INGENZIDbContext _dbContext;
    private readonly jwtSettings jwtSettings;
    private readonly IConfiguration _configuration;
    
    
    public UserController(INGENZIDbContext dbContext, IOptions<jwtSettings> options, IConfiguration configuration)
    {
        this._dbContext = dbContext;
        this.jwtSettings = options.Value;
        this._configuration = configuration;
    }

     
    [HttpPost("api/Authenticate")]
public async Task<IActionResult> Authenticate([FromBody] UserCreds userCred)
{
    if (userCred.UserName == "")
    {
        var responsee = new { errorMessage = "Email required" };
        return Unauthorized(responsee);
    }

    if (userCred.Password == "")
    {
        var responsee = new { errorMessage = "Password required" };
        return Unauthorized(responsee);
    }

    var user = await this._dbContext.CustomersUsers.FirstOrDefaultAsync(item => item.UserName ==userCred.UserName);
   

    if (user == null)
    {
        var responsee = new { errorMessage = "User not found or invalid credentials. Please register first." };
        return Unauthorized(responsee);
    }
     string decryptedPassword = DecryptPassword(user.Password);
    if(userCred.Password!=decryptedPassword){
       var responsee = new { errorMessage = "User not found or invalid credentials. Please register first." };
        return Unauthorized(responsee);  
    }

    if (user.Otpcode == "1")
    {
        var responsee = new { errorMessage = "Mobile number not verified. Please verify your phone and try again.",user.Otpcode };
        return Unauthorized(responsee);
    }

    // Check if the password consists only of numbers
    if (userCred.Password.All(char.IsDigit))
    {
        var responsee = new { errorMessage = "Invalid password format. Password cannot consist only of numbers." };
        return Unauthorized(responsee);
    }

    var tokenHandler = new JwtSecurityTokenHandler();
    var tokenKey = Encoding.UTF8.GetBytes(this.jwtSettings.securityKey);
   var tokenDesc = new SecurityTokenDescriptor
{
    Subject = new ClaimsIdentity(
        new Claim[] { new Claim(ClaimTypes.Name, user.Email) }
    ),
    Expires = DateTime.UtcNow.AddMinutes(10),
    SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(tokenKey), SecurityAlgorithms.HmacSha256)
};

    var token = tokenHandler.CreateToken(tokenDesc);
    string finalToken = tokenHandler.WriteToken(token);

    var response = new { token = finalToken, successMessage = "Login successful", email = user.Email,userName=user.UserName, names = user.Names, NationalId= user.NationalId, id = user.IdRecord };

    return Ok(response);
}

    

    // [Route("api/paymentsDetails")]
    //  [HttpPost]
    // public async Task<IActionResult> PostPaymentsDetails([FromBody] PaymentsDetailsRequestModel request)
    // {
    //     try
    //     {
    //         if (string.IsNullOrEmpty(request.CustomerName))
    //     {
    //         return BadRequest(new { errorMessage = "CustomerName is required." });
    //     }
    //     if (string.IsNullOrEmpty(request.CustomerEmail))
    //     {
    //         return BadRequest(new { errorMessage = "Customer Email is required." });
    //     }
    //     if (string.IsNullOrEmpty(request.CustomerPhoneNumber))
    //     {
    //         return BadRequest(new { errorMessage = "Customer phoneNumber is required." });
    //     }
    //     if (string.IsNullOrEmpty(request.CustomerNationalId))
    //     {
    //         return BadRequest(new { errorMessage = "Customer nationalId is required." });
    //     }
    //     if (string.IsNullOrEmpty(request.CustomerMartalStatus))
    //     {
    //         return BadRequest(new { errorMessage = "Customer martal status is required." });
    //     }
    //     if (string.IsNullOrEmpty(request.SelectedCategoryType))
    //     {
    //         return BadRequest(new { errorMessage = "Category is required." });
    //     }
    //         var user = await _dbContext.CustomersUsers.FirstOrDefaultAsync(u => u.Email == request.CustomerEmail);

    //         if (user == null)
    //         {
    //             return Unauthorized(new { errorMessage = "User not found. Please register first." });
    //         }
          
    //         var paymentDetails = new PaymentDetailsTable
    //         {
    //             CustomerName = request.CustomerName,
    //             CustomerEmail = request.CustomerEmail,
    //             CustomerPhoneNumber = request.CustomerPhoneNumber,
    //             CustomerNationalId = request.CustomerNationalId,
    //             CustomerMartalStatus = request.CustomerMartalStatus,
    //             SelectedCategoryType = request.SelectedCategoryType,
    //             NumberDirectParent = request.NumberDirectParent,
    //             PrimiumFrequency = request.PrimiumFrequency,
    //             NumberofChildren = request.NumberofChildren,
    //             RiskPremium = request.RiskPremium,
    //             AnnualRiskPremium = request.AnnualRiskPremium,
    //             MonthlyMinSaving = request.MonthlyMinSaving,
    //             AnnualMinSaving = request.AnnualMinSaving,
    //             RiskPremiumMonthlyMinSavings = request.RiskPremiumMonthlyMinSavings,
    //             AnnualRiskPremiumAnnualyMinSavings = request.AnnualRiskPremiumAnnualyMinSavings,
    //             RecordedDate = DateTime.Now,
    //             PaymentMode = request.PaymentMode,
    //             IdRecord = user.IdRecord
    //         };
              
             
         


    //         _dbContext.PaymentDetailsTables.Add(paymentDetails);
    //         await _dbContext.SaveChangesAsync();

    //         return CreatedAtAction(nameof(PostPaymentsDetails), new { successMessage = "Paid successfully." });
    //     }
    //     catch (Exception ex)
    //     {
    //         Console.Error.WriteLine(ex.Message);
    //         return StatusCode(500, new { errorMessage = "Error occurred while recording data into the database." });
    //     }
    // }



CultureInfo culture = CultureInfo.InvariantCulture;

  [Route("api/register")]
  [HttpPost]
  
 public async Task<IActionResult> Register([FromBody] SignupDetailsRequestModels request)
{
    try
    {
        // Validate input
        if (string.IsNullOrEmpty(request.UserName))
        {
            return BadRequest(new { errorMessage = "Phone number is required." });
        }

        if (string.IsNullOrEmpty(request.NationalId))
        {
            return BadRequest(new { errorMessage = "NationalId is required." });
        }

       
        // Check if the national ID is valid using the NIDA API
        var nationalId = request.NationalId;
        var nationalIdResponse = await SendNationalIdVerificationRequest(nationalId);

        if (!nationalIdResponse.StatusCode.Equals(HttpStatusCode.OK))
        {
            return BadRequest(new { errorMessage = "Invalid national ID." });
        }

        // Check if the DocumentNumber element exists and has a value
       XDocument xmlDocument = XDocument.Parse(await nationalIdResponse.Content.ReadAsStringAsync());
        if (xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DocumentNumber").FirstOrDefault() == null ||
            string.IsNullOrEmpty(xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DocumentNumber").First().Value))
        {
            return BadRequest(new { errorMessage = "Invalid national ID." });
            
        }
           

              string otpMessage = GenerateOTP(); 
          string EncryptPassword;
        using (SqlConnection connection = new SqlConnection( _configuration.GetConnectionString("SqlConnectionToIngenzi")))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("SELECT dbo.Encryption(@EncryptedPassword)", connection))
            {
                command.Parameters.AddWithValue("@EncryptedPassword", otpMessage);

                // Execute the function
                EncryptPassword = (string)command.ExecuteScalar();
            }
        }

             
        
          string applicationNumberString = await nationalIdResponse.Content.ReadAsStringAsync();
          string applicationNumber = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("ApplicationNumber").First().Value;

          string cell = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Cell").First().Value;
        string civilStatus = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("CivilStatus").First().Value;
       
        string countryOfBirth = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("CountryOfBirth").First().Value;
            //DateTime dateOfBirth = DateTime.Parse(xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DateOfBirth").First().Value);
            DateTime dateOfBirth = DateTime.ParseExact(xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DateOfBirth").FirstOrDefault()?.Value, "dd/MM/yyyy", CultureInfo.InvariantCulture);

            //string dateOfExpiry = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DateOfExpiry").FirstOrDefault()?.Value ?? "";
            //    DateTime dateOfIssue = DateTime.ParseExact(xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DateOfIssue").First().Value, "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);
            string district = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("District").First().Value;
        string documentNumber = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DocumentNumber").First().Value;
        int documentType = int.Parse(xmlDocument.Descendants("AuthenticateDocumentResult").Elements("DocumentType").First().Value);
        string fatherNames = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("FatherNames").First().Value;
        string foreName = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("ForeName").First().Value;
        string id = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Id").FirstOrDefault()?.Value ?? "";
        int issueNumber = int.Parse(xmlDocument.Descendants("AuthenticateDocumentResult").Elements("IssueNumber").First().Value);
        string motherNames = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("MotherNames").First().Value;
        string nationality = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Nationality").FirstOrDefault()?.Value ?? "";
        string photo = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Photo").FirstOrDefault()?.Value ?? "";
        string placeOfBirth = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("PlaceOfBirth").First().Value;
        string placeOfIssue = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("PlaceOfIssue").First().Value;
        string province = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Province").First().Value;
        string sector = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Sector").First().Value;
        string sex = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Sex").First().Value;
        
        string signature = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Signature").FirstOrDefault()?.Value ?? "";
        string spouse = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Spouse").FirstOrDefault()?.Value ?? "";
        int status = int.Parse(xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Status").First().Value);
        string surnames = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Surnames").First().Value;
        string timeSubmitted = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("TimeSubmitted").FirstOrDefault()?.Value ?? "";
        string village = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("Village").First().Value;
        string villageID = xmlDocument.Descendants("AuthenticateDocumentResult").Elements("VillageID").First().Value;

          
           
           string phoneNumber = request.UserName;
           var otpRequest = new {
            PhoneNumber = phoneNumber,
            Text = $"Murakoze Gufata ubwishingizi muri Prime Life Insurance, " +
                    $"Ijambo banga mwakoresha mureba imisanzu yanyu kuri Website ni : {otpMessage}"
        };



            DateTime formattedDate = DateTime.Now;

DateTime parsedDate = DateTime.ParseExact(formattedDate.ToString("yyyy-MM-dd HH:mm:ss"), "yyyy-MM-dd HH:mm:ss", CultureInfo.InvariantCulture);

var newUser = new CustomersUser
{
    Names = foreName+" "+surnames,
    UserName = request.UserName,
    Password =EncryptPassword,
    Email = request.Email,
    NationalId = request.NationalId,
    RecordedDate = DateTime.Now,
};
 var newCustomer = new Customer();
newCustomer.FirstName=foreName;
newCustomer.LastName=surnames;
newCustomer.FullName = foreName + " " + surnames;
if(sex=="M")
{
newCustomer.Salutation ="mr";
} 
else{
    newCustomer.Salutation ="miss";
}
 string Replace=documentNumber.Replace(" ", "");
  string customerCode = "C" + Replace.Substring(0, Math.Min(13, Replace.Length));
 
newCustomer.Gender = sex; 
newCustomer.DateOfBirth =dateOfBirth;
newCustomer.MartialStatus = civilStatus;
newCustomer.Nationality = nationality;
newCustomer.IdDocumentType = "National ID";
newCustomer.IdDocumentNumber = documentNumber.Replace(" ", "");
newCustomer.IssuedProvince = province;
newCustomer.IssuedDistrict = district;
newCustomer.IssuedSector = sector;
newCustomer.IssuedCell = cell;
newCustomer.IssuedVillage = village;
newCustomer.ResidenceProvince = province;
newCustomer.ResidenceDistrict = district;
newCustomer.ResidenceSector = sector;
newCustomer.ResidenceCell = cell;
newCustomer.ResidenceVillage = village;
newCustomer.Email = request.Email;
newCustomer.PhoneNumber1 = request.UserName;
newCustomer.PlaceOfBirth = placeOfBirth;
newCustomer.CustomerCode =customerCode;

newCustomer.CreationDate = DateTime.Now;
    var phoneNumberBasedOnNationalId = await _dbContext.Customers
    .Where(u => u.IdDocumentNumber == documentNumber.Replace(" ", ""))
    .Select(u => u.PhoneNumber1)
    .FirstOrDefaultAsync();

          var NationalIdExistsInCustomers= await _dbContext.Customers.AnyAsync(u =>u.IdDocumentNumber==documentNumber.Replace(" ", ""));
           var phoneNumberExistInCustomers= await _dbContext.Customers.AnyAsync(u =>u.PhoneNumber1==phoneNumber);
           var NationalIdExists= await _dbContext.CustomersUsers.AnyAsync(u =>u.NationalId== request.NationalId.Replace(" ", "")); 
          if(NationalIdExistsInCustomers && NationalIdExists) {
             return StatusCode(409, new { errorMessage = "National id already in use, contact our support at 1320 for assistance ." });
          }
          if(NationalIdExistsInCustomers && !NationalIdExists)
          {
         
         if(phoneNumberBasedOnNationalId!=phoneNumber){
           return StatusCode(409, new { errorMessage = "Please enter the phone number associated with your account or contact our support at 1320 for assistance." });
            
         }
         else{
           _dbContext.CustomersUsers.Add(newUser);
            var otpResponse = await SendOtpRequest(otpRequest);

            if (!otpResponse.StatusCode.Equals(HttpStatusCode.OK))
              {
                 return StatusCode(500, new { errorMessage = "Error occurred while sending OTP." });
               }

                }
          }
          if(!NationalIdExistsInCustomers && !NationalIdExists){
            _dbContext.CustomersUsers.Add(newUser);
            _dbContext.Customers.Add(newCustomer);
                // Send OTP as password to use
                
                await SendOtpRequest(otpRequest);
          }

       
        await _dbContext.SaveChangesAsync();
         StoreOTPInDatabase(request.UserName, otpMessage);
        // Return success response with user details and token
         DateTime now = DateTime.Now;
        return CreatedAtAction(nameof(Register), new
        {
            successMessage = "User registered successfully.",
            id = newUser.IdRecord,
            names = newUser.Names,
            email = newUser.Email,
            username = newUser.UserName,
            phoneNumber = newUser.UserName,
            recordedDate = newUser.RecordedDate,
            applicationNumber = applicationNumber,
            cell = cell,
            civilStatus = civilStatus,
            countryOfBirth = countryOfBirth,
            dateOfBirth = dateOfBirth,
           dateOfExpiry = dateOfBirth,
          dateOfIssue = dateOfBirth,
        district = district,
        documentNumber = documentNumber,
       documentType = documentType,
        fatherNames = fatherNames,
        foreName = foreName,
       issueNumber = issueNumber,
        motherNames = motherNames,
        nationality=nationality,
        photo=photo,
        placeOfBirth=placeOfBirth,
        placeOfIssue=placeOfIssue,
        province=province,
        sector=sector,
        sex=sex,
        signature=signature,
        spouse=spouse,
        status=status,
        surnames=surnames,
        timeSubmitted=timeSubmitted,
        village=village,
        villageID=villageID

        });
        
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return StatusCode(500, new { errorMessage = "Error occurred while registering the user."+ex.Message+DateTime.Now });
    }
}

  private async Task<HttpResponseMessage> SendOtpRequest(object otpRequest)
{
    using var httpClient = new HttpClient();

    var content = new StringContent(JsonConvert.SerializeObject(otpRequest), Encoding.UTF8, "application/json");

    return await httpClient.PostAsync("https://apps.prime.rw/onlineservicesapi/digitalservices/sendsmslife", content);
}
 private string GenerateOTP()
{
    
    Random random = new Random();
    int otp = random.Next(100000, 999999);
    return otp.ToString();
}
private void StoreOTPInDatabase(string userName, string otp)
{
   
    DateTime expirationTimestamp = DateTime.Now.AddMinutes(3);
     Debug.WriteLine("expiration is"+expirationTimestamp);
    var user = _dbContext.CustomersUsers.SingleOrDefault(u => u.UserName == userName);

    if (user != null)
    {
        user.Otpcode ="1";
       
        _dbContext.SaveChanges();
    }
}


private async Task<HttpResponseMessage> SendNationalIdVerificationRequest(string nationalId)
{
    using var httpClient = new HttpClient();

    var request = new HttpRequestMessage(HttpMethod.Get, "https://apps.prime.rw/nidaresources/resources/getdetails?DocumentNumber=" +
        nationalId + "&EntityCode=106");

    return await httpClient.SendAsync(request);
}

 private string DecryptPassword(string encryptedPassword)
{
    string decryptedPassword;

    using (SqlConnection connection = new SqlConnection( _configuration.GetConnectionString("SqlConnectionToIngenzi")
    
    ))
    {
        connection.Open();

        using (SqlCommand command = new SqlCommand("SELECT dbo.Decrypt(@EncryptedPassword)", connection))
        {
            command.Parameters.AddWithValue("@EncryptedPassword", encryptedPassword);

            // Execute the function
            decryptedPassword = (string)command.ExecuteScalar();
        }
    }

    return decryptedPassword;
}




 [Route("api/verify-otp")]
[HttpPost]
public async Task<IActionResult> VerifyOTP([FromBody] OTPVerificationRequestModels request)
{

    try
    {
        // Retrieve user by username
        var user =   _dbContext.CustomersUsers.SingleOrDefault(u => u.UserName == request.UserName);

        // Check if the user exists
        if (user == null)
        {
            return NotFound(new { errorMessage = "User not found." });
        }

        // Update OtpVerification field
     user.Otpcode = "0";
      _dbContext.SaveChanges();

          // Decrypt the password
     string decryptedPassword = DecryptPassword(user.Password);

      // Check if OTP is correct and not expired
     if (decryptedPassword != request.OTP || (user.RecordedDate.HasValue && user.RecordedDate.Value.AddMinutes(10) < DateTime.Now))
                  {
                  return BadRequest(new { errorMessage = "Invalid OTP or OTP has expired." });
                 }


        // Update OtpVerification field
        user.Otpcode ="0";
       
        _dbContext.SaveChanges();

        return Ok(new { successMessage = "OTP verified successfully." });
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return StatusCode(500, new { errorMessage = "Error occurred while verifying OTP." });
    }
}


   
 [HttpPost("resendOtp")]
 public async Task<IActionResult> ResendOtp(int id)
{
  var user = await _dbContext.CustomersUsers.FirstOrDefaultAsync(u =>u.IdRecord ==id);
   DateTime expirationTimestamp = DateTime.Now.AddMinutes(3);
  if(user==null) 
    return NotFound();
    
  // Generate new OTP
  string otp = ReGenerateOTP();
   string EncryptPassword;
        using (SqlConnection connection = new SqlConnection( _configuration.GetConnectionString("SqlConnectionToIngenzi")))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("SELECT dbo.Encryption(@EncryptedPassword)", connection))
            {
                command.Parameters.AddWithValue("@EncryptedPassword", otp);

                // Execute the function
                EncryptPassword = (string)command.ExecuteScalar();
            }
        }
  
  // Update OTP and expiration in database
    user.Otpcode ="1"; 
    user.RecordedDate = DateTime.Now;
    user.Password=EncryptPassword;
  _dbContext.SaveChanges();

  // Send OTP 
  await ReSendOtpRequest(new {
    PhoneNumber = user.UserName,
    Text = $"Your new OTP is {otp}"
  });

  return Ok("New OTP generated and sent");
}


private string ReGenerateOTP()
{
   Random random = new Random();
   int otp = random.Next(100000, 999999);
   return otp.ToString(); 
}

 


 private async Task<HttpResponseMessage> ReSendOtpRequest(object otpRequest)
{
   using var httpClient = new HttpClient();

    var content = new StringContent(JsonConvert.SerializeObject(otpRequest), Encoding.UTF8, "application/json");

    return await httpClient.PostAsync("https://apps.prime.rw/onlineservicesapi/digitalservices/sendsmslife", content);
}



   [HttpPost("send-new-password")]
public async Task<IActionResult> sendNewPassword(string username)
{
    var user = await _dbContext.CustomersUsers.FirstOrDefaultAsync(u => u.UserName == username);
    if (user == null)
       return NotFound(new { errorMessage = "User not found." });

    // Generate new password
    string password = GenerateRandomPassword(7);
    string encryptedPassword;
    using (SqlConnection connection = new SqlConnection( _configuration.GetConnectionString("SqlConnectionToIngenzi")))
    {
        connection.Open();

        using (SqlCommand command = new SqlCommand("SELECT dbo.Encryption(@EncryptedPassword)", connection))
        {
            command.Parameters.AddWithValue("@EncryptedPassword", password);

            // Execute the function
            encryptedPassword = (string)command.ExecuteScalar();
        }
    }

    // Update password in the database
    user.Password = encryptedPassword;
    _dbContext.SaveChanges();

    // Send new password
    var passwordRequest = new PasswordRequest
    {
        PhoneNumber = user.UserName,
        Text = $" Your new password is  " + password + " Change it before continue!, PRIME LIFE"
    };

    await SendNewPassword(passwordRequest);

    return Ok("New password generated and sent");
}

private string GenerateRandomPassword(int length)
{
    const string allowedChars = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789!@#$%^&*()-_";

    StringBuilder password = new StringBuilder();
    Random random = new Random();

    for (int i = 0; i < length; i++)
    {
        int index = random.Next(0, allowedChars.Length);
        password.Append(allowedChars[index]);
    }

    return password.ToString();
}

private async Task<HttpResponseMessage> SendNewPassword(object passwordRequest)
{
    using var httpClient = new HttpClient();

    var content = new StringContent(JsonConvert.SerializeObject(passwordRequest), Encoding.UTF8, "application/json");

    return await httpClient.PostAsync("https://apps.prime.rw/onlineservicesapi/digitalservices/sendsmslife", content);
}

//verify new password generated randomly


[Route("api/verify-password")]
[HttpPost]
public async Task<IActionResult> VerifyPassword([FromBody] passwordVerificationModel request)
{

    
    
    try
    {
        // Retrieve user by username
        var user =   _dbContext.CustomersUsers.SingleOrDefault(u => u.UserName == request.UserName);

        // Check if the user exists
        if (user == null)
        {
            return NotFound(new { errorMessage = "User not found." });
        }

          // Decrypt the password
     string decryptedPassword = DecryptPassword(user.Password);

      // Check if OTP is correct and not expired
     if (decryptedPassword != request.password )
                  {
                  return BadRequest(new { errorMessage = "Invalid password ." });
                 }
        user.Otpcode="0";
        return Ok(new { successMessage = "Change your  password to continue." });
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return StatusCode(500, new { errorMessage = "Error occurred while verifying password." });
    }
}











[Route("api/create-password")]
[HttpPost]

public async Task<IActionResult> UpdatePassword([FromBody] UpdatePasswordRequestModel request)
{
    try
    {
        // Retrieve user by username
        var username =  request.UserName;
        var user = await _dbContext.CustomersUsers.SingleOrDefaultAsync(u => u.UserName == username);

        // Check if the user exists
        if (user == null)
        {
            return NotFound(new { errorMessage = "User not found." });
        }

        // // Check if the current password is correct
        // string decryptedPassword = DecryptPassword(user.Password);
        // if (request.CurrentPassword != decryptedPassword)
        // {
        //     return BadRequest(new { errorMessage = "Invalid current password." });
        // }

        // Validate and update the new password
        if (string.IsNullOrEmpty(request.Password))
        {
            return BadRequest(new { errorMessage = " password is required." });
        }
        if(request.Password.Length<8){
            return BadRequest(new { errorMessage = " password must have at least 8 characters." });
        }

        // Encrypt the new password before saving it
        string encryptedNewPassword;
        using (SqlConnection connection = new SqlConnection( _configuration.GetConnectionString("SqlConnectionToIngenzi")))
        {
            connection.Open();

            using (SqlCommand command = new SqlCommand("SELECT dbo.Encryption(@EncryptedPassword)", connection))
            {
                command.Parameters.AddWithValue("@EncryptedPassword", request.Password);

                // Execute the function
                encryptedNewPassword = (string)command.ExecuteScalar();
            }
        }

        // Update the user's password in the database
        user.Password = encryptedNewPassword;
        await _dbContext.SaveChangesAsync();

        return Ok(new { successMessage = "Password Created successfully." });
    }
    catch (Exception ex)
    {
        Console.Error.WriteLine(ex.Message);
        return StatusCode(500, new { errorMessage = "Error occurred while updating the password." });
    }
}




//  [HttpGet("api/getPaymentDetails")]
// public async Task<IActionResult> GetPaymentDetails()
// {
//     var sqlQuery = @"
//         SELECT * FROM PaymentDetailsTable
//     ";

//     try
//     {
//         var paymentDetailsList = await _dbContext.PaymentDetailsTables.FromSqlRaw(sqlQuery).ToListAsync();
//         return Ok(paymentDetailsList);
//     }
//     catch (Exception ex)
//     {
//         Console.Error.WriteLine(ex.Message);
//         return StatusCode(500, new { errorMessage = "Error occurred while fetching data from the database." });
//     }
// }

// [HttpGet("api/getPaymentDetailsById")]
// public async Task<IActionResult> GetPaymentDetailsById([FromQuery] int id)
// {
//     var sqlQuery = @"
//         SELECT *
//         FROM PaymentDetailsTable
//         WHERE IdRecord = @id
//     ";

//     try
//     {
//         var paymentDetails = await _dbContext.PaymentDetailsTables.FromSqlRaw(sqlQuery, new SqlParameter("id", id)).ToListAsync();

//         if (paymentDetails != null && paymentDetails.Count > 0)
//         {
//             return Ok(new { paymentsDetails = paymentDetails });
//         }
//         else
//         {
//             return NotFound("No data found.");
//         }
//     }
//     catch (Exception ex)
//     {
//         Console.Error.WriteLine(ex.Message);
//         return StatusCode(500, new { errorMessage = "Error occurred while fetching data from the database." });
//     }
// }

    
}

