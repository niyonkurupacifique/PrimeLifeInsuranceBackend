using c_.INGENZIModels;
using static c_.service.impl.ProductPaymentStatementService;

namespace c_.service
{
    public interface IProductPaymentStatement
    {
        Task<List<FamilyPaymentStatementDetails>> GetFamilyPaymentStatement(string policyNumber);
        Task<List<EducationPaymentStatementDetails>> GetEducationPaymentStatement(string policyNumber);
        Task<List<EmployeePaymentStatementDetails>> GetEmployeePaymentStatement(string policyNumber);
         Task<List<EmployeeSavingStatementDetails>> GetEmployeeSavingStatement(string policyNumber);
         Task<List<IkiminaSavingStatementDetails>> GetIkiminaSavingStatement(string policyNumber); 

    }
}
