using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace c_.LoanProtectionModels;

public partial class LoanProtectionContext : DbContext
{
    public LoanProtectionContext()
    {
    }

    public LoanProtectionContext(DbContextOptions<LoanProtectionContext> options)
        : base(options)
    {
    }

    public virtual DbSet<ACorrection> ACorrections { get; set; }

    public virtual DbSet<AnnualPoliciesRenewal> AnnualPoliciesRenewals { get; set; }

    public virtual DbSet<AuditLoanProtectionPayement> AuditLoanProtectionPayements { get; set; }

    public virtual DbSet<AuditsLoanProtectionJointPartnerDetail> AuditsLoanProtectionJointPartnerDetails { get; set; }

    public virtual DbSet<AuditsLoanProtectionPolicyRegister> AuditsLoanProtectionPolicyRegisters { get; set; }

    public virtual DbSet<AxxisMigrationLoanPContact> AxxisMigrationLoanPContacts { get; set; }

    public virtual DbSet<BankAccessView> BankAccessViews { get; set; }

    public virtual DbSet<ClaimsNotifyListReceiver> ClaimsNotifyListReceivers { get; set; }

    public virtual DbSet<Compassion> Compassions { get; set; }

    public virtual DbSet<DataNonGroup> DataNonGroups { get; set; }

    public virtual DbSet<LoanProtectionAccountNumber> LoanProtectionAccountNumbers { get; set; }

    public virtual DbSet<LoanProtectionAnnualFactor> LoanProtectionAnnualFactors { get; set; }

    public virtual DbSet<LoanProtectionBank> LoanProtectionBanks { get; set; }

    public virtual DbSet<LoanProtectionBankBranch> LoanProtectionBankBranches { get; set; }

    public virtual DbSet<LoanProtectionCell> LoanProtectionCells { get; set; }

    public virtual DbSet<LoanProtectionChannel> LoanProtectionChannels { get; set; }

    public virtual DbSet<LoanProtectionClaimsRegister> LoanProtectionClaimsRegisters { get; set; }

    public virtual DbSet<LoanProtectionCountry> LoanProtectionCountries { get; set; }

    public virtual DbSet<LoanProtectionCrbcustomerDetail> LoanProtectionCrbcustomerDetails { get; set; }

    public virtual DbSet<LoanProtectionCrbpoliciesDetail> LoanProtectionCrbpoliciesDetails { get; set; }

    public virtual DbSet<LoanProtectionCustomer> LoanProtectionCustomers { get; set; }

    public virtual DbSet<LoanProtectionCustomerDetail> LoanProtectionCustomerDetails { get; set; }

    public virtual DbSet<LoanProtectionDistrict> LoanProtectionDistricts { get; set; }

    public virtual DbSet<LoanProtectionEquityRate> LoanProtectionEquityRates { get; set; }

    public virtual DbSet<LoanProtectionFixedLoanFactor> LoanProtectionFixedLoanFactors { get; set; }

    public virtual DbSet<LoanProtectionInsuranceCompany> LoanProtectionInsuranceCompanies { get; set; }

    public virtual DbSet<LoanProtectionInsuranceCompanyBranch> LoanProtectionInsuranceCompanyBranches { get; set; }

    public virtual DbSet<LoanProtectionInvoicePayAcc> LoanProtectionInvoicePayAccs { get; set; }

    public virtual DbSet<LoanProtectionJointPartnerDetail> LoanProtectionJointPartnerDetails { get; set; }

    public virtual DbSet<LoanProtectionOldPolicy> LoanProtectionOldPolicies { get; set; }

    public virtual DbSet<LoanProtectionPayement> LoanProtectionPayements { get; set; }

    public virtual DbSet<LoanProtectionPeriod> LoanProtectionPeriods { get; set; }

    public virtual DbSet<LoanProtectionPolicyRegister> LoanProtectionPolicyRegisters { get; set; }

    public virtual DbSet<LoanProtectionProvince> LoanProtectionProvinces { get; set; }

    public virtual DbSet<LoanProtectionRate> LoanProtectionRates { get; set; }

    public virtual DbSet<LoanProtectionRateAbBank> LoanProtectionRateAbBanks { get; set; }

    public virtual DbSet<LoanProtectionRateVision> LoanProtectionRateVisions { get; set; }

    public virtual DbSet<LoanProtectionRateX> LoanProtectionRateXes { get; set; }

    public virtual DbSet<LoanProtectionRateX2> LoanProtectionRateX2s { get; set; }

    public virtual DbSet<LoanProtectionRatesBk> LoanProtectionRatesBks { get; set; }

    public virtual DbSet<LoanProtectionRatesBkx> LoanProtectionRatesBkxes { get; set; }

    public virtual DbSet<LoanProtectionRatesCopedu> LoanProtectionRatesCopedus { get; set; }

    public virtual DbSet<LoanProtectionRatesEquity> LoanProtectionRatesEquities { get; set; }

    public virtual DbSet<LoanProtectionRatesEquityBcp> LoanProtectionRatesEquityBcps { get; set; }

    public virtual DbSet<LoanProtectionRatesEquityX> LoanProtectionRatesEquityXes { get; set; }

    public virtual DbSet<LoanProtectionRatesU> LoanProtectionRatesUs { get; set; }

    public virtual DbSet<LoanProtectionReceiptingBank> LoanProtectionReceiptingBanks { get; set; }

    public virtual DbSet<LoanProtectionSector> LoanProtectionSectors { get; set; }

    public virtual DbSet<LoanProtectionUser> LoanProtectionUsers { get; set; }

    public virtual DbSet<LoanProtectionUserAccess> LoanProtectionUserAccesses { get; set; }

    public virtual DbSet<LoanProtectionUserBranchAccess> LoanProtectionUserBranchAccesses { get; set; }

    public virtual DbSet<LoanProtectionVillage> LoanProtectionVillages { get; set; }

    public virtual DbSet<LoanprotectionCommission> LoanprotectionCommissions { get; set; }

    public virtual DbSet<ReceiptRegister> ReceiptRegisters { get; set; }

    public virtual DbSet<ReceiptRegisterEducation> ReceiptRegisterEducations { get; set; }

    public virtual DbSet<ReceiptRegisterSavingsEndorsement> ReceiptRegisterSavingsEndorsements { get; set; }

    public virtual DbSet<ReceiptRegisterSavingsPolicy> ReceiptRegisterSavingsPolicies { get; set; }

    public virtual DbSet<ReportReceiptRegister> ReportReceiptRegisters { get; set; }

    public virtual DbSet<SingleInvoiceRegister> SingleInvoiceRegisters { get; set; }

    public virtual DbSet<TestMisMachCustomerCode> TestMisMachCustomerCodes { get; set; }

    public virtual DbSet<UpdatePolicy> UpdatePolicies { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<View3> View3s { get; set; }

    public virtual DbSet<View4> View4s { get; set; }

    public virtual DbSet<ViewAnnualPaymentRenewal> ViewAnnualPaymentRenewals { get; set; }

    public virtual DbSet<ViewAnnualPaymentRenewalsOld> ViewAnnualPaymentRenewalsOlds { get; set; }

    public virtual DbSet<ViewBeneFiciary> ViewBeneFiciaries { get; set; }

    public virtual DbSet<ViewBeneficiariesDetail> ViewBeneficiariesDetails { get; set; }

    public virtual DbSet<ViewBnrLoanprotectionAcct> ViewBnrLoanprotectionAccts { get; set; }

    public virtual DbSet<ViewBnrLoanprotectionCont> ViewBnrLoanprotectionConts { get; set; }

    public virtual DbSet<ViewBnrLoanprotectionCust> ViewBnrLoanprotectionCusts { get; set; }

    public virtual DbSet<ViewCorrectDatum> ViewCorrectData { get; set; }

    public virtual DbSet<ViewDEletepay> ViewDEletepays { get; set; }

    public virtual DbSet<ViewEmailsEducation> ViewEmailsEducations { get; set; }

    public virtual DbSet<ViewEmailsSaving> ViewEmailsSavings { get; set; }

    public virtual DbSet<ViewEp> ViewEps { get; set; }

    public virtual DbSet<ViewExtractPayementRegister> ViewExtractPayementRegisters { get; set; }

    public virtual DbSet<ViewExtractPolicyRegister> ViewExtractPolicyRegisters { get; set; }

    public virtual DbSet<ViewForGetFundValue> ViewForGetFundValues { get; set; }

    public virtual DbSet<ViewInvoicesDisplay> ViewInvoicesDisplays { get; set; }

    public virtual DbSet<ViewLifeDetail> ViewLifeDetails { get; set; }

    public virtual DbSet<ViewListOfClaimsContract> ViewListOfClaimsContracts { get; set; }

    public virtual DbSet<ViewListOfPoliciesContract> ViewListOfPoliciesContracts { get; set; }

    public virtual DbSet<ViewLoanCleanCustomer> ViewLoanCleanCustomers { get; set; }

    public virtual DbSet<ViewLoanProtectionClaimsDetail> ViewLoanProtectionClaimsDetails { get; set; }

    public virtual DbSet<ViewLoanProtectionIntacctIngenziInvoiceRegister> ViewLoanProtectionIntacctIngenziInvoiceRegisters { get; set; }

    public virtual DbSet<ViewLoanProtectionPaymentsDetail> ViewLoanProtectionPaymentsDetails { get; set; }

    public virtual DbSet<ViewLoanProtectionPolicyIdcounter> ViewLoanProtectionPolicyIdcounters { get; set; }

    public virtual DbSet<ViewLoanProtectionPolicyRegister> ViewLoanProtectionPolicyRegisters { get; set; }

    public virtual DbSet<ViewPaymentList> ViewPaymentLists { get; set; }

    public virtual DbSet<ViewPolicyDetail> ViewPolicyDetails { get; set; }

    public virtual DbSet<ViewPolicyRegisterDetail> ViewPolicyRegisterDetails { get; set; }

    public virtual DbSet<ViewPolicyRegisterDetailsExtaction> ViewPolicyRegisterDetailsExtactions { get; set; }

    public virtual DbSet<ViewProductionPensionAndSaving> ViewProductionPensionAndSavings { get; set; }

    public virtual DbSet<ViewResultApiLoanCoverPolicy> ViewResultApiLoanCoverPolicies { get; set; }

    public virtual DbSet<ViewSearchCustomerAndPolDetail> ViewSearchCustomerAndPolDetails { get; set; }

    public virtual DbSet<ViewSingleInvoicePerBank> ViewSingleInvoicePerBanks { get; set; }

    public virtual DbSet<ViewStatementDetail> ViewStatementDetails { get; set; }

    public virtual DbSet<ViewStatementPay> ViewStatementPays { get; set; }

    public virtual DbSet<ViewTableOfPayementPlan> ViewTableOfPayementPlans { get; set; }

    public virtual DbSet<ViewToApprouve> ViewToApprouves { get; set; }

    public virtual DbSet<ViewTopUpRegister> ViewTopUpRegisters { get; set; }

    public virtual DbSet<ViewTransUnionCustomerLoan> ViewTransUnionCustomerLoans { get; set; }

    public virtual DbSet<ViewTransUnionPolicyDetailsLoan> ViewTransUnionPolicyDetailsLoans { get; set; }

    public virtual DbSet<ViewUnpaidPolicyLoanProtection> ViewUnpaidPolicyLoanProtections { get; set; }

    public virtual DbSet<ViewUpdateBeneficiary> ViewUpdateBeneficiaries { get; set; }

    public virtual DbSet<ViewUpdatePay> ViewUpdatePays { get; set; }

    public virtual DbSet<ViewUpdateWrongDate> ViewUpdateWrongDates { get; set; }

    public virtual DbSet<ViewUsersReview> ViewUsersReviews { get; set; }

    public virtual DbSet<ViewZamaraActuarialValuationLoan> ViewZamaraActuarialValuationLoans { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        => optionsBuilder.UseSqlServer("name=SqlConnectionToLoanProtection");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<ACorrection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("A_Corrections");

            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<AnnualPoliciesRenewal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("AnnualPoliciesRenewals");

            entity.Property(e => e.BankName)
                .HasMaxLength(500)
                .HasColumnName("Bank name");
            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.CoverEndDate)
                .HasColumnType("datetime")
                .HasColumnName("cover end date");
            entity.Property(e => e.CoverStartDate)
                .HasColumnType("datetime")
                .HasColumnName("cover start date");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Loan end date");
            entity.Property(e => e.Names).HasMaxLength(1352);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<AuditLoanProtectionPayement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Audit_LoanProtectionPayements");

            entity.Property(e => e.AccountNumberAndBank).HasMaxLength(100);
            entity.Property(e => e.DateOfPayement).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IntegrationDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.Operation).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePayement).HasMaxLength(50);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<AuditsLoanProtectionJointPartnerDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Audits_LoanProtectionJointPartnerDetails");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.Operation).HasMaxLength(50);
            entity.Property(e => e.PartnerId).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SpouseName).HasMaxLength(250);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("Updated_By");
        });

        modelBuilder.Entity<AuditsLoanProtectionPolicyRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Audits_LoanProtectionPolicyRegister");

            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.Operation).HasMaxLength(50);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UpdatedAt)
                .HasColumnType("datetime")
                .HasColumnName("Updated_At");
            entity.Property(e => e.UpdatedBy)
                .HasMaxLength(50)
                .HasColumnName("Updated_By");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<AxxisMigrationLoanPContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Axxis_Migration_LoanP_Contact");

            entity.Property(e => e.Address1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("address2");
            entity.Property(e => e.AddressType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("addressType");
            entity.Property(e => e.Age).HasColumnName("age");
            entity.Property(e => e.AmlRiskId).HasColumnName("amlRiskId");
            entity.Property(e => e.Association).HasColumnName("association");
            entity.Property(e => e.Bank)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("bank");
            entity.Property(e => e.BankAccount).HasColumnName("bankAccount");
            entity.Property(e => e.Birth)
                .HasColumnType("datetime")
                .HasColumnName("birth");
            entity.Property(e => e.Bmi).HasColumnName("bmi");
            entity.Property(e => e.Cif).HasColumnName("cif");
            entity.Property(e => e.Citizenship)
                .HasMaxLength(50)
                .HasColumnName("citizenship");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Cnp).HasColumnName("cnp");
            entity.Property(e => e.CoHqCountry)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("coHqCountry");
            entity.Property(e => e.CoLegalRepName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("coLegalRepName");
            entity.Property(e => e.CoPersonOfContact1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("coPersonOfContact1");
            entity.Property(e => e.CoPersonOfContact2)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("coPersonOfContact2");
            entity.Property(e => e.CoTradeRegister).HasColumnName("coTradeRegister");
            entity.Property(e => e.CoWeb)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("coWeb");
            entity.Property(e => e.Code).HasColumnName("code");
            entity.Property(e => e.ContactId).HasColumnName("contactId");
            entity.Property(e => e.Country)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("country");
            entity.Property(e => e.Created)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("created");
            entity.Property(e => e.Creation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("creation");
            entity.Property(e => e.CustomerDate).HasColumnName("customerDate");
            entity.Property(e => e.Date)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("date");
            entity.Property(e => e.Diagnosis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("diagnosis");
            entity.Property(e => e.Diognasis)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("diognasis");
            entity.Property(e => e.DocsLink)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("docsLink");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("email");
            entity.Property(e => e.Expr19)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr20)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr23)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr25)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr27)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr5)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Expr7).HasMaxLength(50);
            entity.Property(e => e.Expr8)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.FatcaTaxCode).HasColumnName("fatcaTaxCode");
            entity.Property(e => e.FatcaTinGinCode).HasColumnName("fatcaTinGinCode");
            entity.Property(e => e.FileName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("fileName");
            entity.Property(e => e.FiscalNumber).HasColumnName("fiscalNumber");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("gender");
            entity.Property(e => e.GenericField)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("genericField");
            entity.Property(e => e.Height).HasColumnName("height");
            entity.Property(e => e.HoldingId).HasColumnName("holdingId");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.IdType)
                .HasMaxLength(50)
                .HasColumnName("idType");
            entity.Property(e => e.Inactive)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("inactive");
            entity.Property(e => e.Income).HasColumnName("income");
            entity.Property(e => e.IncomeCurrency).HasColumnName("incomeCurrency");
            entity.Property(e => e.InvalidityFlag).HasColumnName("invalidityFlag");
            entity.Property(e => e.IsPerson)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("isPerson");
            entity.Property(e => e.JAfter)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("jAfter");
            entity.Property(e => e.JBefore)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("jBefore");
            entity.Property(e => e.Kinship)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("kinship");
            entity.Property(e => e.Maritalstatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("maritalstatus");
            entity.Property(e => e.MarketingAgreement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("marketingAgreement");
            entity.Property(e => e.MedicalProvider).HasColumnName("medicalProvider");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("middleName");
            entity.Property(e => e.MigrationCode).HasColumnName("migrationCode");
            entity.Property(e => e.Name)
                .HasMaxLength(450)
                .HasColumnName("name");
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .HasColumnName("nationalId");
            entity.Property(e => e.NationalIdExpiration).HasColumnName("nationalIdExpiration");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasColumnName("nationality");
            entity.Property(e => e.Nif).HasColumnName("nif");
            entity.Property(e => e.NotificationChannel)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("notificationChannel");
            entity.Property(e => e.Num).HasColumnName("num");
            entity.Property(e => e.OccupationId).HasColumnName("occupationId");
            entity.Property(e => e.OccupationSectorCode).HasColumnName("occupationSectorCode");
            entity.Property(e => e.Operation)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("operation");
            entity.Property(e => e.Passport)
                .HasMaxLength(50)
                .HasColumnName("passport");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.PreferedCommunicationMethod)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("preferedCommunicationMethod");
            entity.Property(e => e.PrincipalType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("principalType");
            entity.Property(e => e.Procedure)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("procedure");
            entity.Property(e => e.ProcessId).HasColumnName("processId");
            entity.Property(e => e.PublicStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("publicStatus");
            entity.Property(e => e.RelatedId)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("relatedId");
            entity.Property(e => e.Risk)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("risk");
            entity.Property(e => e.State)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("state");
            entity.Property(e => e.Status).HasColumnName("status");
            entity.Property(e => e.Surname1)
                .HasMaxLength(450)
                .HasColumnName("surname1");
            entity.Property(e => e.Surname2)
                .HasMaxLength(450)
                .HasColumnName("surname2");
            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.Type)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("type");
            entity.Property(e => e.Updated)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("updated");
            entity.Property(e => e.User)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("user");
            entity.Property(e => e.Weight)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("weight");
            entity.Property(e => e.Workplace)
                .HasMaxLength(50)
                .HasColumnName("workplace");
            entity.Property(e => e.Zip).HasColumnName("zip");
        });

        modelBuilder.Entity<BankAccessView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BankAccessView");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ClaimsNotifyListReceiver>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClaimsNotifyListReceiver");

            entity.Property(e => e.ClaimOfficerName).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<Compassion>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Compassion");

            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<DataNonGroup>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Data_non_group");

            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionAccountNumber>(entity =>
        {
            entity.HasKey(e => e.ReferenceAcc).HasName("PK_LoanProtectionAccountNumber_1");

            entity.ToTable("LoanProtectionAccountNumber");

            entity.Property(e => e.ReferenceAcc).HasMaxLength(400);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();

            entity.HasOne(d => d.IdInsuranceCompanyNavigation).WithMany(p => p.LoanProtectionAccountNumbers)
                .HasForeignKey(d => d.IdInsuranceCompany)
                .HasConstraintName("FK_LoanProtectionAccountNumber_LoanProtectionInsuranceCompany");
        });

        modelBuilder.Entity<LoanProtectionAnnualFactor>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<LoanProtectionBank>(entity =>
        {
            entity.HasKey(e => e.IdBank);

            entity.ToTable("LoanProtectionBank");

            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.Category).HasMaxLength(100);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LoanProtectionBankBranch>(entity =>
        {
            entity.HasKey(e => e.IdBankBranch);

            entity.ToTable("LoanProtectionBankBranch");

            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.ContactPersonNumber).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);

            entity.HasOne(d => d.IdBankNavigation).WithMany(p => p.LoanProtectionBankBranches)
                .HasForeignKey(d => d.IdBank)
                .HasConstraintName("FK_LoanProtectionBankBranch_LoanProtectionBank");
        });

        modelBuilder.Entity<LoanProtectionCell>(entity =>
        {
            entity.HasKey(e => e.CellId);

            entity.ToTable("LoanProtectionCell");

            entity.Property(e => e.CellId).HasMaxLength(50);
            entity.Property(e => e.CellName).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SectorId).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionChannel>(entity =>
        {
            entity.HasKey(e => e.VendorCode);

            entity.ToTable("LoanProtectionChannel");

            entity.Property(e => e.VendorCode).HasMaxLength(255);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionClaimsRegister>(entity =>
        {
            entity.HasKey(e => e.ClaimNumber);

            entity.ToTable("LoanProtectionClaimsRegister");

            entity.Property(e => e.ClaimNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimType).HasMaxLength(50);
            entity.Property(e => e.DeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.NewPolicyTopUp).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecorDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionCountry>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Country).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionCrbcustomerDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionCRBCustomerDetails");

            entity.Property(e => e.Cell).HasMaxLength(255);
            entity.Property(e => e.Country).HasMaxLength(255);
            entity.Property(e => e.CustomerType)
                .HasMaxLength(255)
                .HasColumnName("Customer type");
            entity.Property(e => e.DateOfBirthOrRegistration)
                .HasColumnType("datetime")
                .HasColumnName("Date of Birth or Registration");
            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(255)
                .HasColumnName("Email Address");
            entity.Property(e => e.EmployerAddressLine1)
                .HasMaxLength(255)
                .HasColumnName("Employer Address Line 1");
            entity.Property(e => e.EmployerCountry)
                .HasMaxLength(255)
                .HasColumnName("Employer Country");
            entity.Property(e => e.EmployerDurationMonths)
                .HasMaxLength(255)
                .HasColumnName("Employer Duration (Months)");
            entity.Property(e => e.EmployerDurationYears)
                .HasMaxLength(255)
                .HasColumnName("Employer Duration (Years)");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(255)
                .HasColumnName("Employer Name");
            entity.Property(e => e.EmployerTown)
                .HasMaxLength(255)
                .HasColumnName("Employer Town");
            entity.Property(e => e.FascimileFax)
                .HasMaxLength(255)
                .HasColumnName("Fascimile / Fax");
            entity.Property(e => e.FirstNameTradingName)
                .HasMaxLength(255)
                .HasColumnName("First Name/Trading Name");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.HomeTelephone)
                .HasMaxLength(255)
                .HasColumnName("Home Telephone");
            entity.Property(e => e.IdentificationDocumentNumber)
                .HasMaxLength(255)
                .HasColumnName("Identification Document Number");
            entity.Property(e => e.IdentificationDocumentType)
                .HasMaxLength(255)
                .HasColumnName("Identification Document Type");
            entity.Property(e => e.IncomeFrequency)
                .HasMaxLength(255)
                .HasColumnName("Income Frequency");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(255)
                .HasColumnName("Marital Status");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("Middle Name");
            entity.Property(e => e.MobileTelephone)
                .HasMaxLength(255)
                .HasColumnName("Mobile Telephone");
            entity.Property(e => e.PhysicalAddress)
                .HasMaxLength(255)
                .HasColumnName("Physical Address");
            entity.Property(e => e.PlaceOfBirthRegistration)
                .HasMaxLength(255)
                .HasColumnName("Place Of Birth/ Registration");
            entity.Property(e => e.Province).HasMaxLength(255);
            entity.Property(e => e.Salutation).HasMaxLength(255);
            entity.Property(e => e.Sector).HasMaxLength(255);
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(255)
                .HasColumnName("Surname/Institution Name");
            entity.Property(e => e.WorkTelephone)
                .HasMaxLength(255)
                .HasColumnName("Work Telephone");
        });

        modelBuilder.Entity<LoanProtectionCrbpoliciesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionCRBPoliciesDetails");

            entity.Property(e => e.BasePolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Base Policy Number");
            entity.Property(e => e.BaseTransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("Base Transaction Date");
            entity.Property(e => e.Classification).HasMaxLength(255);
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.CurrentBalanceOnPolicy).HasColumnName("Current Balance on policy");
            entity.Property(e => e.CustomerIdentificationDocumentNumber)
                .HasMaxLength(255)
                .HasColumnName("Customer Identification Document Number");
            entity.Property(e => e.DaysInArrears).HasColumnName("Days in Arrears");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due date");
            entity.Property(e => e.EndorsementDate)
                .HasMaxLength(255)
                .HasColumnName("Endorsement Date");
            entity.Property(e => e.EndorsementNumber)
                .HasMaxLength(255)
                .HasColumnName("Endorsement Number");
            entity.Property(e => e.FirstNameTradingName)
                .HasMaxLength(250)
                .HasColumnName("First Name/Trading Name");
            entity.Property(e => e.GrossPremiumAmount).HasColumnName("Gross Premium Amount");
            entity.Property(e => e.IdentificationDocumentType)
                .HasMaxLength(255)
                .HasColumnName("Identification Document Type");
            entity.Property(e => e.InsuredAmount).HasColumnName("Insured Amount");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(250)
                .HasColumnName("Middle Name");
            entity.Property(e => e.NumberOfPersonsCovered).HasColumnName("Number of Persons Covered");
            entity.Property(e => e.OtherInformation)
                .HasMaxLength(255)
                .HasColumnName("Other Information");
            entity.Property(e => e.PolicyExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Policy Expiry Date");
            entity.Property(e => e.PolicyStartDate)
                .HasColumnType("datetime")
                .HasColumnName("Policy start date");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(255)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(255)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PremiumPaidToDate).HasColumnName("Premium Paid to Date");
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(250)
                .HasColumnName("Surname/Institution Name");
        });

        modelBuilder.Entity<LoanProtectionCustomer>(entity =>
        {
            entity.HasKey(e => e.IdDocumentNumber);

            entity.ToTable("LoanProtectionCustomer");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployerContactPerson).HasMaxLength(50);
            entity.Property(e => e.EmployerContactPersonNumber).HasMaxLength(50);
            entity.Property(e => e.EmployerFullAdress).HasMaxLength(200);
            entity.Property(e => e.EmployerName).HasMaxLength(50);
            entity.Property(e => e.EmployerPhone).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IssuedCell).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.IssuedVillage).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_2");
            entity.Property(e => e.ReferenceIfJoint).HasMaxLength(50);
            entity.Property(e => e.ResidenceCell).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.ResidenceVillage).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionCustomerDetail>(entity =>
        {
            entity.HasKey(e => e.IdDocumentNumber);

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Hivtest).HasColumnName("HIVTest");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Kidney).HasColumnName("kidney");
        });

        modelBuilder.Entity<LoanProtectionDistrict>(entity =>
        {
            entity.HasKey(e => e.DistrictId);

            entity.ToTable("LoanProtectionDistrict");

            entity.Property(e => e.DistrictId).HasMaxLength(50);
            entity.Property(e => e.DistrictName).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.ProvinceId).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionEquityRate>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BorrowerType).HasMaxLength(50);
            entity.Property(e => e.CoversCategory).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.RateType).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionFixedLoanFactor>(entity =>
        {
            entity.HasNoKey();
        });

        modelBuilder.Entity<LoanProtectionInsuranceCompany>(entity =>
        {
            entity.HasKey(e => e.IdInsuranceCompany);

            entity.ToTable("LoanProtectionInsuranceCompany");

            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.Adress).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.ContactPersonNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionInsuranceCompanyBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionInsuranceCompanyBranch");

            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.Cogearname)
                .HasMaxLength(50)
                .HasColumnName("COGEARName");
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionInvoicePayAcc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionInvoicePayAcc");

            entity.Property(e => e.AccountId)
                .HasMaxLength(255)
                .HasColumnName("AccountID");
            entity.Property(e => e.AccountNumber)
                .HasMaxLength(255)
                .HasColumnName("Account Number");
            entity.Property(e => e.BankName)
                .HasMaxLength(255)
                .HasColumnName("Bank Name");
            entity.Property(e => e.Currency).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionJointPartnerDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(250);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName).HasMaxLength(250);
            entity.Property(e => e.PartnerId).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SpouseName).HasMaxLength(250);
        });

        modelBuilder.Entity<LoanProtectionOldPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountNumber)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Category)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.DateOfBirth)
                .HasPrecision(3)
                .HasColumnName("Date_of_Birth");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.IdBankBranch).HasMaxLength(255);
            entity.Property(e => e.IdDocumentType).HasMaxLength(255);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MartialStatus).HasMaxLength(255);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.NationalIdNumber)
                .HasMaxLength(255)
                .HasColumnName("National_ID_Number");
            entity.Property(e => e.Nationality).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(255)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.ResidenceCell).HasMaxLength(255);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(255);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(255);
            entity.Property(e => e.ResidenceSector).HasMaxLength(255);
            entity.Property(e => e.ResidenceVillage).HasMaxLength(255);
            entity.Property(e => e.Salutation).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionPayement>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountNumberAndBank).HasMaxLength(100);
            entity.Property(e => e.DateOfPayement).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IntegrationDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePayement).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionPeriod>(entity =>
        {
            entity.HasKey(e => e.UnikValue).HasName("PK_SmartBrokerPeriods");

            entity.Property(e => e.UnikValue).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<LoanProtectionPolicyRegister>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("LoanProtectionPolicyRegister");

            entity.HasIndex(e => e.UnikRow, "UnikRow").IsUnique();

            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionProvince>(entity =>
        {
            entity.HasKey(e => e.ProvinceId);

            entity.ToTable("LoanProtectionProvince");

            entity.Property(e => e.ProvinceId).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Province).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionRate");
        });

        modelBuilder.Entity<LoanProtectionRateAbBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rate_Ab_Bank");

            entity.Property(e => e.BorrowerType).HasMaxLength(50);
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LoanType).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionRateVision>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionRateVision");

            entity.Property(e => e.TypeRate).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionRateX>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionRateX");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.TypeRate).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionRateX2>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionRateX2");
        });

        modelBuilder.Entity<LoanProtectionRatesBk>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rates_BK");

            entity.Property(e => e.BorrowerType).HasMaxLength(255);
            entity.Property(e => e.LoanType).HasMaxLength(255);
            entity.Property(e => e.PaymentRateType).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionRatesBkx>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rates_BKX");

            entity.Property(e => e.BorrowerType).HasMaxLength(255);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PaymentRateType).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionRatesCopedu>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rates_Copedu");

            entity.Property(e => e.BorrowerType).HasMaxLength(255);
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PaymentRateType).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionRatesEquity>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rates_Equity");

            entity.Property(e => e.BorrowerType).HasMaxLength(50);
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PaymentRateType).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionRatesEquityBcp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rates_Equity_BCP");

            entity.Property(e => e.BorrowerType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PaymentRateType).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionRatesEquityX>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rates_EquityX");

            entity.Property(e => e.BorrowerType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PaymentRateType).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionRatesU>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtection_Rates_US");

            entity.Property(e => e.BorrowerType).HasMaxLength(255);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.RateType).HasMaxLength(255);
        });

        modelBuilder.Entity<LoanProtectionReceiptingBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionReceiptingBank");

            entity.Property(e => e.AccountCode).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionSector>(entity =>
        {
            entity.HasKey(e => e.SectorId);

            entity.ToTable("LoanProtectionSector");

            entity.Property(e => e.SectorId).HasMaxLength(50);
            entity.Property(e => e.DistrictId).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SectorName).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionUser>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("LoanProtectionUser");

            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IntacctClassId).HasMaxLength(50);
            entity.Property(e => e.IntacctEmployeeId).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(100);
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionUserAccess>(entity =>
        {
            entity.HasKey(e => e.Reference);

            entity.ToTable("LoanProtectionUserAccess");

            entity.Property(e => e.Reference).HasMaxLength(100);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.UserName).HasMaxLength(50);

            entity.HasOne(d => d.UserNameNavigation).WithMany(p => p.LoanProtectionUserAccesses)
                .HasForeignKey(d => d.UserName)
                .HasConstraintName("FK_LoanProtectionUserAccess_LoanProtectionUser");
        });

        modelBuilder.Entity<LoanProtectionUserBranchAccess>(entity =>
        {
            entity.HasKey(e => e.Reference);

            entity.ToTable("LoanProtectionUserBranchAccess");

            entity.Property(e => e.Reference).HasMaxLength(100);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionVillage>(entity =>
        {
            entity.HasKey(e => e.VillageId);

            entity.ToTable("LoanProtectionVillage");

            entity.Property(e => e.VillageId).HasMaxLength(50);
            entity.Property(e => e.CellId).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.VillageName).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanprotectionCommission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LOANPROTECTION_Commissions");

            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.ControllerId).HasColumnName("ControllerID");
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ReceiptRegister>(entity =>
        {
            entity.HasKey(e => e.ReceiptNumber);

            entity.ToTable("ReceiptRegister");

            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceCodeBranch).HasMaxLength(50);
            entity.Property(e => e.IntegratedAcc).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptingBank).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ReceiptRegisterEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReceiptRegisterEducation");

            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(300);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ReceiptRegisterSavingsEndorsement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReceiptRegisterSavingsEndorsements");

            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ReceiptRegisterSavingsPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReceiptRegisterSavingsPolicies");

            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ReportReceiptRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ReportReceiptRegister");

            entity.Property(e => e.BankName)
                .HasMaxLength(255)
                .HasColumnName("Bank Name");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<SingleInvoiceRegister>(entity =>
        {
            entity.HasKey(e => e.InvoiceNumber);

            entity.ToTable("SingleInvoiceRegister");

            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.ReceiptingAccount).HasMaxLength(150);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<TestMisMachCustomerCode>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("TestMisMachCustomerCode");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerCodeCust)
                .HasMaxLength(50)
                .HasColumnName("Customer code Cust");
            entity.Property(e => e.IdDocCustomer)
                .HasMaxLength(50)
                .HasColumnName("Id Doc Customer");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<UpdatePolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("UpdatePolicies");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Pol).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemNumber)
                .HasMaxLength(50)
                .HasColumnName("Schem_Number");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Expr1).HasMaxLength(100);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_2");

            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.SumAssuredType).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<View3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_3");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<View4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_4");

            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewAnnualPaymentRenewal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AnnualPayment_Renewals");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.CoverEndDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cover End Date");
            entity.Property(e => e.CoverStartDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Cover Start Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Loan End Date");
            entity.Property(e => e.LoanEndDate1)
                .HasColumnType("datetime")
                .HasColumnName("LoanEndDate");
            entity.Property(e => e.Names).HasMaxLength(1352);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewAnnualPaymentRenewalsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AnnualPayment_Renewals_Old");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(1352);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewBeneFiciary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ViewBeneFiciaries");

            entity.Property(e => e.BenefitPercentage).HasColumnName("Benefit Percentage");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last name");
            entity.Property(e => e.Policy)
                .HasMaxLength(50)
                .HasColumnName("Policy #");
            entity.Property(e => e.PolicyHolderId)
                .HasMaxLength(50)
                .HasColumnName("Policy holder ID");
            entity.Property(e => e.RecordDate)
                .HasColumnType("datetime")
                .HasColumnName("Record date");
            entity.Property(e => e.RecordedBy)
                .HasMaxLength(100)
                .HasColumnName("Recorded by");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<ViewBeneficiariesDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BeneficiariesDetails");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(101);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e._)
                .ValueGeneratedOnAdd()
                .HasColumnName("#");
        });

        modelBuilder.Entity<ViewBnrLoanprotectionAcct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_LOANPROTECTION_ACCT");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(1352)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(100)
                .HasColumnName("Account_No");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus).HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.DateLastModified)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LeBook).HasColumnName("LE_Book");
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
            entity.Property(e => e.VisionGl)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Vision_GL");
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
        });

        modelBuilder.Entity<ViewBnrLoanprotectionCont>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_LOANPROTECTION_CONT");

            entity.Property(e => e.AccountStatusDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.ContractAdministrativeFee).HasColumnName("Contract_Administrative_Fee");
            entity.Property(e => e.ContractApplicationFee).HasColumnName("Contract_Application_Fee");
            entity.Property(e => e.ContractId)
                .HasMaxLength(100)
                .HasColumnName("Contract_ID");
            entity.Property(e => e.ContractStatus).HasColumnName("Contract_Status");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.DateLastModified)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DealSubType)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Deal_Sub_Type");
            entity.Property(e => e.DealType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Deal_Type");
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook).HasColumnName("LE_Book");
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Maturity_Date");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.PrincipalAmountFcy).HasColumnName("Principal_Amount_FCY");
            entity.Property(e => e.PrincipalAmountLcy).HasColumnName("Principal_Amount_LCY");
            entity.Property(e => e.PrincipalGl)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Principal_GL");
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.StartDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Start_Date");
            entity.Property(e => e.VisionGl)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Vision_GL");
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
        });

        modelBuilder.Entity<ViewBnrLoanprotectionCust>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_LOANPROTECTION_CUST");

            entity.Property(e => e.CommAddress1).HasColumnName("Comm_Address_1");
            entity.Property(e => e.CommAddress2).HasColumnName("Comm_Address_2");
            entity.Property(e => e.CommCountry)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Comm_Country");
            entity.Property(e => e.CommResidenceType).HasColumnName("Comm_Residence_Type");
            entity.Property(e => e.CommVillage)
                .HasMaxLength(50)
                .HasColumnName("Comm_Village");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CustomerAcronym)
                .HasMaxLength(1352)
                .HasColumnName("Customer_Acronym");
            entity.Property(e => e.CustomerGender)
                .HasMaxLength(50)
                .HasColumnName("Customer_Gender");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(1352)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Customer_Open_Date");
            entity.Property(e => e.CustomerStatus).HasColumnName("Customer_Status");
            entity.Property(e => e.CustomerTin).HasColumnName("Customer_TIN");
            entity.Property(e => e.DateLastModified)
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_of_Birth");
            entity.Property(e => e.EconomicSubSectorCodeIsic)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Economic_Sub_Sector_Code_ISIC");
            entity.Property(e => e.EmailId).HasColumnName("Email_ID");
            entity.Property(e => e.EmpAddress1).HasColumnName("Emp_Address_1");
            entity.Property(e => e.EmpAddress2).HasColumnName("Emp_Address_2");
            entity.Property(e => e.EmpCountry).HasColumnName("Emp_Country");
            entity.Property(e => e.EmpVillage).HasColumnName("Emp_Village");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployerName).HasColumnName("Employer_Name");
            entity.Property(e => e.Expr6)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.FaxNumber1).HasColumnName("Fax_Number_1");
            entity.Property(e => e.FaxNumber2).HasColumnName("Fax_Number_2");
            entity.Property(e => e.Forename1)
                .HasMaxLength(450)
                .HasColumnName("Forename_1");
            entity.Property(e => e.Forename2)
                .HasMaxLength(450)
                .HasColumnName("Forename_2");
            entity.Property(e => e.HealthInsuranceNumber).HasColumnName("Health_Insurance_Number");
            entity.Property(e => e.HomeTelephone).HasColumnName("Home_Telephone");
            entity.Property(e => e.IncomeFrequency).HasColumnName("Income_Frequency");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.LegalStatus)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Legal_Status");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("Marital_Status");
            entity.Property(e => e.NaicsCode)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("NAICS_Code");
            entity.Property(e => e.NationalIdNumber)
                .HasMaxLength(50)
                .HasColumnName("National_ID_Number");
            entity.Property(e => e.NationalIdType)
                .HasMaxLength(50)
                .HasColumnName("National_ID_Type");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.NextOfKinIdNumber).HasColumnName("Next_of_kin_ID_Number");
            entity.Property(e => e.NextOfKinIdType).HasColumnName("Next_of_kin_ID_Type");
            entity.Property(e => e.NextOfKinName).HasColumnName("Next_of_kin_Name");
            entity.Property(e => e.NextOfKinTelephone).HasColumnName("Next_of_kin_Telephone");
            entity.Property(e => e.NumberOfDependants).HasColumnName("Number_Of_Dependants");
            entity.Property(e => e.Occupation)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.PermAddress1).HasColumnName("Perm_Address_1");
            entity.Property(e => e.PermAddress2).HasColumnName("Perm_Address_2");
            entity.Property(e => e.PermCountry)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Perm_Country");
            entity.Property(e => e.PermVillage)
                .HasMaxLength(50)
                .HasColumnName("Perm_Village");
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(50)
                .HasColumnName("Place_of_Birth");
            entity.Property(e => e.RelatedParty)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Related_Party");
            entity.Property(e => e.Residence)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SocialEconomicClass)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Social_Economic_Class");
            entity.Property(e => e.SpouseName).HasColumnName("Spouse_Name");
            entity.Property(e => e.Surname).HasMaxLength(450);
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
            entity.Property(e => e.WorkTelephone).HasColumnName("Work_Telephone");
        });

        modelBuilder.Entity<ViewCorrectDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CorrectData");

            entity.Property(e => e.CustCodeCust)
                .HasMaxLength(50)
                .HasColumnName("Cust code cust");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdDoc)
                .HasMaxLength(50)
                .HasColumnName("Id Doc");
            entity.Property(e => e.IdDocPolReg)
                .HasMaxLength(50)
                .HasColumnName("id doc pol reg");
        });

        modelBuilder.Entity<ViewDEletepay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_dELETEPAY");

            entity.Property(e => e.AccountNumberAndBank).HasMaxLength(100);
            entity.Property(e => e.DateOfPayement).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePayement).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewEmailsEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Emails_Education");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(300);
        });

        modelBuilder.Entity<ViewEmailsSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Emails_Savings");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(4000);
        });

        modelBuilder.Entity<ViewEp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EP");

            entity.Property(e => e.AcquisitionCost).HasColumnName("Acquisition cost");
            entity.Property(e => e.AdminFees).HasColumnName("Admin Fees");
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BranchName1)
                .HasMaxLength(50)
                .HasColumnName("Branch name");
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CompanyInterest).HasColumnName("Company Interest");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Ep).HasColumnName("EP");
            entity.Property(e => e.EpDays).HasColumnName("EP days");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.InsurancePeriodInDays).HasColumnName("Insurance period in days");
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("Marital status");
            entity.Property(e => e.Names).HasMaxLength(101);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PremiumPerDay).HasColumnName("Premium Per day");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RiskPremium).HasColumnName("Risk Premium");
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Uep).HasColumnName("UEP");
        });

        modelBuilder.Entity<ViewExtractPayementRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ExtractPayementRegister");

            entity.Property(e => e.AccountNumberAndBank).HasMaxLength(100);
            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BranchCompany)
                .HasMaxLength(50)
                .HasColumnName("Branch company");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DateOfPayement).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(1352);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePayement).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewExtractPolicyRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ExtractPolicyRegister");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BranchName1)
                .HasMaxLength(50)
                .HasColumnName("Branch name");
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("Marital status");
            entity.Property(e => e.Names).HasMaxLength(1352);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewForGetFundValue>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_For_Get_Fund_Value");

            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewInvoicesDisplay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Invoices_Display");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due date");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.InvoiceNumber)
                .HasMaxLength(100)
                .HasColumnName("Invoice Number");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewLifeDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LifeDetails");

            entity.Property(e => e.CustCode).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDoc).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
        });

        modelBuilder.Entity<ViewListOfClaimsContract>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfClaimsContracts");

            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.NewPolicyTopUp).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecorDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewListOfPoliciesContract>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPoliciesContracts");

            entity.Property(e => e.Bank).HasMaxLength(551);
            entity.Property(e => e.ContactType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Contact type");
            entity.Property(e => e.CoverPeriod).HasColumnName("Cover period");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DatePolicy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Date policy");
            entity.Property(e => e.DiscountIn).HasColumnName("Discount in %");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("End date");
            entity.Property(e => e.Id)
                .HasMaxLength(50)
                .HasColumnName("ID #");
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.InsuranceCo)
                .HasMaxLength(50)
                .HasColumnName("Insurance Co.");
            entity.Property(e => e.LoadedRate).HasColumnName("Loaded rate");
            entity.Property(e => e.LoanAmount).HasColumnName("Loan amount");
            entity.Property(e => e.LoanEndDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Loan end date");
            entity.Property(e => e.LoanPeriod).HasColumnName("Loan period");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(901);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PayChannel)
                .HasMaxLength(50)
                .HasColumnName("Pay.channel");
            entity.Property(e => e.PayFrequency)
                .HasMaxLength(50)
                .HasColumnName("Pay Frequency");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.Policy)
                .HasMaxLength(100)
                .HasColumnName("Policy #");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.RetrRate).HasColumnName("Retr. Rate");
            entity.Property(e => e.SalesChannel)
                .HasMaxLength(255)
                .HasColumnName("Sales Channel");
            entity.Property(e => e.SalesChannelType)
                .HasMaxLength(255)
                .HasColumnName("Sales Channel Type");
            entity.Property(e => e.StartDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Start date");
            entity.Property(e => e.TotalPremium).HasColumnName("Total premium");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<ViewLoanCleanCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LoanCleanCustomers");

            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.Gender1).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber1).HasMaxLength(50);
            entity.Property(e => e.IssuedCell).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.IssuedVillage).HasMaxLength(50);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Salutation1).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.Village).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewLoanProtectionClaimsDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LoanProtection_Claims_Details");

            entity.Property(e => e.Bank).HasMaxLength(553);
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimType).HasMaxLength(50);
            entity.Property(e => e.DeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecorDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewLoanProtectionIntacctIngenziInvoiceRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LoanProtection_Intacct_Ingenzi_InvoiceRegister");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.InsuranceCodeBranch).HasMaxLength(50);
            entity.Property(e => e.IntegratedAcc).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.ReceiptingBank).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewLoanProtectionPaymentsDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LoanProtectionPaymentsDetails");

            entity.Property(e => e.AccountNumberAndBank).HasMaxLength(100);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BranchCompany)
                .HasMaxLength(50)
                .HasColumnName("Branch company");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfPayement).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(901);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePayement).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewLoanProtectionPolicyIdcounter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LoanProtectionPolicyIDCounter");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewLoanProtectionPolicyRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LoanProtectionPolicyRegister");

            entity.Property(e => e.Bank).HasMaxLength(551);
            entity.Property(e => e.CoverPeriod).HasColumnName("Cover period");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DatePolicy)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Date policy");
            entity.Property(e => e.DiscountIn).HasColumnName("Discount in %");
            entity.Property(e => e.EndDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("End date");
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.InsuranceCo)
                .HasMaxLength(50)
                .HasColumnName("Insurance Co.");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.LoadedRate).HasColumnName("Loaded rate");
            entity.Property(e => e.LoanAmount).HasColumnName("Loan amount");
            entity.Property(e => e.LoanEndDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Loan end date");
            entity.Property(e => e.LoanPeriod).HasColumnName("Loan period");
            entity.Property(e => e.LoanType).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(901);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PayChannel)
                .HasMaxLength(50)
                .HasColumnName("Pay.channel");
            entity.Property(e => e.PayFrequency)
                .HasMaxLength(50)
                .HasColumnName("Pay Frequency");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.Policy)
                .HasMaxLength(100)
                .HasColumnName("Policy #");
            entity.Property(e => e.Reference).HasMaxLength(250);
            entity.Property(e => e.RetrRate).HasColumnName("Retr. Rate");
            entity.Property(e => e.SalesChannel)
                .HasMaxLength(255)
                .HasColumnName("Sales Channel");
            entity.Property(e => e.SalesChannelType)
                .HasMaxLength(255)
                .HasColumnName("Sales Channel Type");
            entity.Property(e => e.StartDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Start date");
            entity.Property(e => e.TotalPremium).HasColumnName("Total premium");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<ViewPaymentList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Payment_List");

            entity.Property(e => e.Bank).HasMaxLength(500);
            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.CutomerNames)
                .HasMaxLength(1352)
                .HasColumnName("Cutomer names");
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .HasColumnName("Policy number");
            entity.Property(e => e.TransactionDate)
                .HasColumnType("datetime")
                .HasColumnName("Transaction date");
        });

        modelBuilder.Entity<ViewPolicyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PolicyDetails");

            entity.Property(e => e.BenefitsPay)
                .HasMaxLength(50)
                .HasColumnName("Benefits Pay.");
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.ChannelType)
                .HasMaxLength(255)
                .HasColumnName("Channel type");
            entity.Property(e => e.CommRate).HasColumnName("Comm. rate");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.Date)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.InstallmentFees).HasColumnName("Installment Fees");
            entity.Property(e => e.ManagementFees).HasColumnName("Management Fees");
            entity.Property(e => e.PayFrequency)
                .HasMaxLength(50)
                .HasColumnName("Pay. frequency");
            entity.Property(e => e.PensionRate).HasColumnName("Pension rate");
            entity.Property(e => e.RecordDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Record date");
            entity.Property(e => e.RecordedBy)
                .HasMaxLength(100)
                .HasColumnName("Recorded by");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(50)
                .HasColumnName("Scheme Number");
            entity.Property(e => e.SumAssuredType)
                .HasMaxLength(50)
                .HasColumnName("Sum assured type");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<ViewPolicyRegisterDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PolicyRegisterDetails");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewPolicyRegisterDetailsExtaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PolicyRegisterDetailsExtaction");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BranchName1)
                .HasMaxLength(50)
                .HasColumnName("Branch name");
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("Marital status");
            entity.Property(e => e.Names).HasMaxLength(1352);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewProductionPensionAndSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProductionPensionAndSavings");

            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemNumber)
                .HasMaxLength(50)
                .HasColumnName("Schem_Number");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewResultApiLoanCoverPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ResultApiLoanCoverPolicy");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdDoc)
                .HasMaxLength(50)
                .HasColumnName("Id Doc");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSearchCustomerAndPolDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SearchCustomerAndPolDetails");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Policy date");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.Salutation).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSingleInvoicePerBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SingleInvoicePerBank");

            entity.Property(e => e.IdBank).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(450);
            entity.Property(e => e.NetPremium).HasColumnName("Net premium");
            entity.Property(e => e.ReceiptingAccount).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewStatementDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Statement_Details");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due Date");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewStatementPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_StatementPay");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.PaySource)
                .HasMaxLength(50)
                .HasColumnName("Pay. source");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.Proof).HasMaxLength(50);
            entity.Property(e => e.Ref)
                .HasMaxLength(100)
                .HasColumnName("Ref.");
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<ViewTableOfPayementPlan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Table_Of_Payement_Plan");

            entity.Property(e => e.AcquiredValue).HasColumnName("Acquired Value");
            entity.Property(e => e.CommissionAmount).HasColumnName("Commission amount");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.InvestedPremium).HasColumnName("Invested premium");
            entity.Property(e => e.PayementDueDate).HasColumnName("Payement due Date");
            entity.Property(e => e.PensionAmount).HasColumnName("Pension Amount");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(50)
                .HasColumnName("Scheme Number");
        });

        modelBuilder.Entity<ViewToApprouve>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ToApprouve");

            entity.Property(e => e.AgentComm).HasColumnName("Agent Comm.");
            entity.Property(e => e.AgentId)
                .HasMaxLength(50)
                .HasColumnName("Agent Id");
            entity.Property(e => e.AgentName)
                .HasMaxLength(255)
                .HasColumnName("Agent name");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.EndDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("End date");
            entity.Property(e => e.FeesAmount).HasColumnName("Fees amount");
            entity.Property(e => e.IdBranch)
                .HasMaxLength(50)
                .HasColumnName("Id branch");
            entity.Property(e => e.IdDoc)
                .HasMaxLength(50)
                .HasColumnName("Id doc.");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.LoanAmount)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Loan amount");
            entity.Property(e => e.Names).HasMaxLength(152);
            entity.Property(e => e.NetPremium).HasColumnName("Net Premium");
            entity.Property(e => e.PolicyDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Policy date");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .HasColumnName("Policy number");
            entity.Property(e => e.PremiumAmount)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Premium amount");
            entity.Property(e => e.SearchDate)
                .HasColumnType("datetime")
                .HasColumnName("Search date");
            entity.Property(e => e.StartDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Start date");
            entity.Property(e => e.TotalPremium)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Total premium");
            entity.Property(e => e.User).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewTopUpRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TopUpRegister");

            entity.Property(e => e.BankNameNew).HasMaxLength(500);
            entity.Property(e => e.BankNameOld)
                .HasMaxLength(500)
                .HasColumnName("BankName_Old");
            entity.Property(e => e.BranchNameNew).HasMaxLength(50);
            entity.Property(e => e.BranchNameOld)
                .HasMaxLength(50)
                .HasColumnName("BranchName_Old");
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimType).HasMaxLength(50);
            entity.Property(e => e.ClaimsRecorDate)
                .HasColumnType("datetime")
                .HasColumnName("Claims_RecorDate");
            entity.Property(e => e.DeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateNew).HasColumnType("datetime");
            entity.Property(e => e.EndDateOld)
                .HasColumnType("datetime")
                .HasColumnName("EndDate_Old");
            entity.Property(e => e.ErnedPremiumOld).HasColumnName("ErnedPremium_Old");
            entity.Property(e => e.FullNameNew)
                .HasMaxLength(1352)
                .HasColumnName("FullName_New");
            entity.Property(e => e.FullNameOld)
                .HasMaxLength(1352)
                .HasColumnName("FullName_Old");
            entity.Property(e => e.IdDocumentNumberNew).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumberOld)
                .HasMaxLength(50)
                .HasColumnName("IdDocumentNumber_Old");
            entity.Property(e => e.IsCancelledOld).HasColumnName("IsCancelled_Old");
            entity.Property(e => e.IsClaimsCancelled).HasColumnName("IsClaims_Cancelled");
            entity.Property(e => e.LoanAmountOld).HasColumnName("LoanAmount_Old");
            entity.Property(e => e.NewPayableAmount).HasColumnName("New_Payable_Amount");
            entity.Property(e => e.NewPolicyTopUp).HasMaxLength(50);
            entity.Property(e => e.OutstandingAmountOld).HasColumnName("OutstandingAmount_Old");
            entity.Property(e => e.PhoneNumberNew).HasMaxLength(50);
            entity.Property(e => e.PhoneNumberOld)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_Old");
            entity.Property(e => e.PolicyClaimedStatusNew).HasColumnName("PolicyClaimedStatus_New");
            entity.Property(e => e.PolicyClaimedStatusOld).HasColumnName("PolicyClaimedStatus_Old");
            entity.Property(e => e.PolicyNumberOld)
                .HasMaxLength(100)
                .HasColumnName("PolicyNumber_Old");
            entity.Property(e => e.RefundAmountOld).HasColumnName("RefundAmount_Old");
            entity.Property(e => e.ReportingMonthOld).HasColumnName("ReportingMonth_Old");
            entity.Property(e => e.ReportingYearOld).HasColumnName("ReportingYear_Old");
            entity.Property(e => e.RiskPremiumOld).HasColumnName("RiskPremium_Old");
            entity.Property(e => e.StartDateNew).HasColumnType("datetime");
            entity.Property(e => e.StartDateOld)
                .HasColumnType("datetime")
                .HasColumnName("StartDate_Old");
            entity.Property(e => e.TotalPremiumOld).HasColumnName("TotalPremium_Old");
            entity.Property(e => e.UserNameNew).HasMaxLength(50);
            entity.Property(e => e.UsernameOld)
                .HasMaxLength(50)
                .HasColumnName("Username_Old");
        });

        modelBuilder.Entity<ViewTransUnionCustomerLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_Customer_Loan");

            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.Country)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CustomerType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Customer Type");
            entity.Property(e => e.DateOfBirthOrRegistration)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Date of Birth or Registration");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.EmailAddress).HasColumnName("Email Address");
            entity.Property(e => e.EmployerAddressLine1)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Employer Address Line 1");
            entity.Property(e => e.EmployerCountry)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Employer Country");
            entity.Property(e => e.EmployerDurationMonths).HasColumnName("Employer Duration (Months)");
            entity.Property(e => e.EmployerDurationYears).HasColumnName("Employer Duration (Years)");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Employer Name");
            entity.Property(e => e.EmployerTown)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Employer Town");
            entity.Property(e => e.FascimileFax).HasColumnName("Fascimile / Fax");
            entity.Property(e => e.FirstNameTradingName)
                .HasMaxLength(450)
                .HasColumnName("First Name/Trading Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.HomeTelephone).HasColumnName("Home Telephone");
            entity.Property(e => e.IdentificationDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Identification Document Number");
            entity.Property(e => e.IdentificationDocumentType)
                .HasMaxLength(7)
                .IsUnicode(false)
                .HasColumnName("Identification document Type");
            entity.Property(e => e.IncomeFrequency).HasColumnName("Income Frequency");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Marital Status");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle Name");
            entity.Property(e => e.MobileTelephone)
                .HasMaxLength(10)
                .HasColumnName("Mobile Telephone");
            entity.Property(e => e.PhysicalAddress).HasColumnName("Physical Address");
            entity.Property(e => e.PlaceOfBirthRegistration).HasColumnName("Place Of Birth/ Registration");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(450)
                .HasColumnName("Surname/Institution Name");
            entity.Property(e => e.WorkTelephone).HasColumnName("Work Telephone");
        });

        modelBuilder.Entity<ViewTransUnionPolicyDetailsLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_PolicyDetails_Loan");

            entity.Property(e => e.BasePolicyNumber)
                .HasMaxLength(100)
                .HasColumnName("Base Policy Number");
            entity.Property(e => e.BaseTransactionDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Base Transaction Date");
            entity.Property(e => e.Classification)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Currency)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.CurrentBalanceOnPolicy).HasColumnName("Current Balance on policy");
            entity.Property(e => e.CustomerIdentificationDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Customer Identification Document Number");
            entity.Property(e => e.DaysInArrears).HasColumnName("Days in Arrears");
            entity.Property(e => e.DueDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Due date");
            entity.Property(e => e.EndorsementDate).HasColumnName("Endorsement Date");
            entity.Property(e => e.EndorsementNumber).HasColumnName("Endorsement Number");
            entity.Property(e => e.FirstNameTradingName)
                .HasMaxLength(450)
                .HasColumnName("First Name/Trading Name");
            entity.Property(e => e.GrossPremiumAmount).HasColumnName("Gross Premium Amount");
            entity.Property(e => e.IdentificationDocumentType)
                .HasMaxLength(50)
                .HasColumnName("Identification Document Type");
            entity.Property(e => e.InsuredAmount).HasColumnName("Insured Amount");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle Name");
            entity.Property(e => e.NumberOfPersonsCovered).HasColumnName("Number of Persons Covered");
            entity.Property(e => e.OtherInformation).HasColumnName("Other Information");
            entity.Property(e => e.PolicyExpiryDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Policy Expiry Date");
            entity.Property(e => e.PolicyStartDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Policy start date");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PremiumPaidToDate).HasColumnName("Premium Paid to Date");
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(450)
                .HasColumnName("Surname/Institution Name");
        });

        modelBuilder.Entity<ViewUnpaidPolicyLoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UnpaidPolicyLoanProtection");

            entity.Property(e => e.ApprovalDate)
                .HasColumnType("datetime")
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdateBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateBeneficiaries");

            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Expr2).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolUp).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdatePay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePay");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ToUp).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdateWrongDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Update_WrongDates");

            entity.Property(e => e.CorrectEndDate).HasColumnType("datetime");
            entity.Property(e => e.CorrectLoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.CorrectStartDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.WrongEndDate).HasColumnType("datetime");
            entity.Property(e => e.WrongLoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.WrongStartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewUsersReview>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UsersReviews");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewZamaraActuarialValuationLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Actuarial_Valuation_Loan");

            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankName).HasMaxLength(551);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission rate");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Date of Birth");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Effective Date");
            entity.Property(e => e.ExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Expiry Date");
            entity.Property(e => e.ExpiryDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Expiry Date Formated");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(4000)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.LoanAmount).HasColumnName("Loan amount");
            entity.Property(e => e.LoanEndDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.LoanPeriodInMonths).HasColumnName("LoanPeriod in months");
            entity.Property(e => e.LoanType)
                .HasMaxLength(50)
                .HasColumnName("Loan type");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(100)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.TotalPremium).HasColumnName("Total premium");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
