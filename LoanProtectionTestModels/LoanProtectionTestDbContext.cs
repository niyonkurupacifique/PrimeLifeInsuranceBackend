using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace c_.LoanProtectionTestModels;

public partial class LoanProtectionTestDbContext : DbContext
{
    public LoanProtectionTestDbContext()
    {
    }

    public LoanProtectionTestDbContext(DbContextOptions<LoanProtectionTestDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AirtelCallBackLog> AirtelCallBackLogs { get; set; }

    public virtual DbSet<AxxisMigrationSavingsContact> AxxisMigrationSavingsContacts { get; set; }

    public virtual DbSet<BankAccessView> BankAccessViews { get; set; }

    public virtual DbSet<CallBackResponse> CallBackResponses { get; set; }

    public virtual DbSet<ClaimsNotifyListReceiver> ClaimsNotifyListReceivers { get; set; }

    public virtual DbSet<Compassion> Compassions { get; set; }

    public virtual DbSet<CustomerIdentification> CustomerIdentifications { get; set; }

    public virtual DbSet<DataNonGroup> DataNonGroups { get; set; }

    public virtual DbSet<IkiminaTechnicalBasic> IkiminaTechnicalBasics { get; set; }

    public virtual DbSet<ListOfPoliciesWithoutPayment> ListOfPoliciesWithoutPayments { get; set; }

    public virtual DbSet<ListOfPolicy> ListOfPolicies { get; set; }

    public virtual DbSet<ListPaymentsPolicy> ListPaymentsPolicies { get; set; }

    public virtual DbSet<LoanProtectionInsuranceCompany> LoanProtectionInsuranceCompanies { get; set; }

    public virtual DbSet<LoanProtectionInsuranceCompanyBranch> LoanProtectionInsuranceCompanyBranches { get; set; }

    public virtual DbSet<LoanProtectionUser> LoanProtectionUsers { get; set; }

    public virtual DbSet<LoanProtectionUserAccess> LoanProtectionUserAccesses { get; set; }

    public virtual DbSet<LoanProtectionUserBranchAccess> LoanProtectionUserBranchAccesses { get; set; }

    public virtual DbSet<NewViewDetailsEndorsement> NewViewDetailsEndorsements { get; set; }

    public virtual DbSet<NewViewListPayEndorsement> NewViewListPayEndorsements { get; set; }

    public virtual DbSet<NewViewListToPay> NewViewListToPays { get; set; }

    public virtual DbSet<NewViewPolicyDetail> NewViewPolicyDetails { get; set; }

    public virtual DbSet<NewViewPolicyRegister> NewViewPolicyRegisters { get; set; }

    public virtual DbSet<NewViewStatement> NewViewStatements { get; set; }

    public virtual DbSet<OnlineMoMoPortal> OnlineMoMoPortals { get; set; }

    public virtual DbSet<OnlinePaymentTransaction> OnlinePaymentTransactions { get; set; }

    public virtual DbSet<OnlinePaymentTransactionGen> OnlinePaymentTransactionGens { get; set; }

    public virtual DbSet<OtherPaymentsTransactionsRegister> OtherPaymentsTransactionsRegisters { get; set; }

    public virtual DbSet<PensionDetailsTable> PensionDetailsTables { get; set; }

    public virtual DbSet<PensionDetailsTableHistory> PensionDetailsTableHistories { get; set; }

    public virtual DbSet<PensionDetailsTableHistoryProvision> PensionDetailsTableHistoryProvisions { get; set; }

    public virtual DbSet<PensionDetailsTableHistoryStatement> PensionDetailsTableHistoryStatements { get; set; }

    public virtual DbSet<PolicyListDetail> PolicyListDetails { get; set; }

    public virtual DbSet<PsPolicyRegisterSigned> PsPolicyRegisterSigneds { get; set; }

    public virtual DbSet<REmovenUll> REmovenUlls { get; set; }

    public virtual DbSet<ReceivedSm> ReceivedSms { get; set; }

    public virtual DbSet<SavingsChannel> SavingsChannels { get; set; }

    public virtual DbSet<SavingsClaimsRegister> SavingsClaimsRegisters { get; set; }

    public virtual DbSet<SavingsClaimsRegisterHistorical> SavingsClaimsRegisterHistoricals { get; set; }

    public virtual DbSet<SavingsCommission> SavingsCommissions { get; set; }

    public virtual DbSet<SavingsCountry> SavingsCountries { get; set; }

    public virtual DbSet<SavingsDistrict> SavingsDistricts { get; set; }

    public virtual DbSet<SavingsEndorsementRegister> SavingsEndorsementRegisters { get; set; }

    public virtual DbSet<SavingsEndorsementRegisterDetail> SavingsEndorsementRegisterDetails { get; set; }

    public virtual DbSet<SavingsExportListInvoicing> SavingsExportListInvoicings { get; set; }

    public virtual DbSet<SavingsIntegrationTable> SavingsIntegrationTables { get; set; }

    public virtual DbSet<SavingsPayement> SavingsPayements { get; set; }

    public virtual DbSet<SavingsPayementsTemp> SavingsPayementsTemps { get; set; }

    public virtual DbSet<SavingsPaymentsTable> SavingsPaymentsTables { get; set; }

    public virtual DbSet<SavingsPensionRate> SavingsPensionRates { get; set; }

    public virtual DbSet<SavingsPolicyBeneficiary> SavingsPolicyBeneficiaries { get; set; }

    public virtual DbSet<SavingsPolicyRegister> SavingsPolicyRegisters { get; set; }

    public virtual DbSet<SavingsPolicyRegisterDetail> SavingsPolicyRegisterDetails { get; set; }

    public virtual DbSet<SavingsProvince> SavingsProvinces { get; set; }

    public virtual DbSet<SavingsQuotation> SavingsQuotations { get; set; }

    public virtual DbSet<SavingsRate> SavingsRates { get; set; }

    public virtual DbSet<SavingsSector> SavingsSectors { get; set; }

    public virtual DbSet<SchemesList> SchemesLists { get; set; }

    public virtual DbSet<SingleInvoicesRegister> SingleInvoicesRegisters { get; set; }

    public virtual DbSet<SmsToSend> SmsToSends { get; set; }

    public virtual DbSet<TempSavingsProvision> TempSavingsProvisions { get; set; }

    public virtual DbSet<TestMisMachCustomerCode> TestMisMachCustomerCodes { get; set; }

    public virtual DbSet<TransferRegister> TransferRegisters { get; set; }

    public virtual DbSet<UpdatePolicy> UpdatePolicies { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<View10> View10s { get; set; }

    public virtual DbSet<View11> View11s { get; set; }

    public virtual DbSet<View12> View12s { get; set; }

    public virtual DbSet<View13> View13s { get; set; }

    public virtual DbSet<View14> View14s { get; set; }

    public virtual DbSet<View15> View15s { get; set; }

    public virtual DbSet<View16> View16s { get; set; }

    public virtual DbSet<View17> View17s { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<View3> View3s { get; set; }

    public virtual DbSet<View4> View4s { get; set; }

    public virtual DbSet<View5> View5s { get; set; }

    public virtual DbSet<View6> View6s { get; set; }

    public virtual DbSet<View7> View7s { get; set; }

    public virtual DbSet<View8> View8s { get; set; }

    public virtual DbSet<View9> View9s { get; set; }

    public virtual DbSet<ViewAllInvoicesPsMainEndoDetail> ViewAllInvoicesPsMainEndoDetails { get; set; }

    public virtual DbSet<ViewAllInvoicesPsMainEndoDetailsNew> ViewAllInvoicesPsMainEndoDetailsNews { get; set; }

    public virtual DbSet<ViewAllPaymentsPsMainEndoSummary> ViewAllPaymentsPsMainEndoSummaries { get; set; }

    public virtual DbSet<ViewAllPoliciesPsMainEndoDetail> ViewAllPoliciesPsMainEndoDetails { get; set; }

    public virtual DbSet<ViewAllPoliciesPsMainEndoDetailsNew> ViewAllPoliciesPsMainEndoDetailsNews { get; set; }

    public virtual DbSet<ViewAllPoliciesPsMainEndoSummary> ViewAllPoliciesPsMainEndoSummaries { get; set; }

    public virtual DbSet<ViewBeneFiciary> ViewBeneFiciaries { get; set; }

    public virtual DbSet<ViewBindListOfPolicy> ViewBindListOfPolicies { get; set; }

    public virtual DbSet<ViewCheckIncompleteConvertedInvoice> ViewCheckIncompleteConvertedInvoices { get; set; }

    public virtual DbSet<ViewCheckIncompleteConvertedPoliciesSaving> ViewCheckIncompleteConvertedPoliciesSavings { get; set; }

    public virtual DbSet<ViewCheckValidPaymentCustomer> ViewCheckValidPaymentCustomers { get; set; }

    public virtual DbSet<ViewCheckValidPaymentCustomersInvalid> ViewCheckValidPaymentCustomersInvalids { get; set; }

    public virtual DbSet<ViewClaimsRegisterSavingsHistoAll> ViewClaimsRegisterSavingsHistoAlls { get; set; }

    public virtual DbSet<ViewClaimsRegisterSavingsHistoEndo> ViewClaimsRegisterSavingsHistoEndos { get; set; }

    public virtual DbSet<ViewClaimsRegisterSavingsHistoMain> ViewClaimsRegisterSavingsHistoMains { get; set; }

    public virtual DbSet<ViewConvertUpdateConvertSavingPolicy> ViewConvertUpdateConvertSavingPolicies { get; set; }

    public virtual DbSet<ViewFirstPaymentSaving> ViewFirstPaymentSavings { get; set; }

    public virtual DbSet<ViewForDigitalAllPayment> ViewForDigitalAllPayments { get; set; }

    public virtual DbSet<ViewForDigitalEducationPayment> ViewForDigitalEducationPayments { get; set; }

    public virtual DbSet<ViewForDigitalEpiPayment> ViewForDigitalEpiPayments { get; set; }

    public virtual DbSet<ViewForDigitalFamilyPayment> ViewForDigitalFamilyPayments { get; set; }

    public virtual DbSet<ViewForDigitalFreeEducationPayment> ViewForDigitalFreeEducationPayments { get; set; }

    public virtual DbSet<ViewForDigitalSavingsPayment> ViewForDigitalSavingsPayments { get; set; }

    public virtual DbSet<ViewForGetFundValue> ViewForGetFundValues { get; set; }

    public virtual DbSet<ViewIkiminaAllPayment> ViewIkiminaAllPayments { get; set; }

    public virtual DbSet<ViewIkiminaAllPolicy> ViewIkiminaAllPolicies { get; set; }

    public virtual DbSet<ViewIkiminaFailedTransfer> ViewIkiminaFailedTransfers { get; set; }

    public virtual DbSet<ViewIkiminaWithdraw> ViewIkiminaWithdraws { get; set; }

    public virtual DbSet<ViewInvalidSchemeIdSaving> ViewInvalidSchemeIdSavings { get; set; }

    public virtual DbSet<ViewInvoicesDisplay> ViewInvoicesDisplays { get; set; }

    public virtual DbSet<ViewLifeDetail> ViewLifeDetails { get; set; }

    public virtual DbSet<ViewListOfPoliceEndosmentSavingPension> ViewListOfPoliceEndosmentSavingPensions { get; set; }

    public virtual DbSet<ViewListOfPoliceSavingPensionAll> ViewListOfPoliceSavingPensionAlls { get; set; }

    public virtual DbSet<ViewListOfPolicyBaseMaxPaymentDateSavingsPension> ViewListOfPolicyBaseMaxPaymentDateSavingsPensions { get; set; }

    public virtual DbSet<ViewListOfPolicyBaseProvisionMaxDate> ViewListOfPolicyBaseProvisionMaxDates { get; set; }

    public virtual DbSet<ViewListOfPolicyEndorsementMaxPaymentDateSavingsPension> ViewListOfPolicyEndorsementMaxPaymentDateSavingsPensions { get; set; }

    public virtual DbSet<ViewListOfPolicyEndorsmentProvisionMaxDate> ViewListOfPolicyEndorsmentProvisionMaxDates { get; set; }

    public virtual DbSet<ViewListOfPolicySavingPolicyBase> ViewListOfPolicySavingPolicyBases { get; set; }

    public virtual DbSet<ViewLoanRenewalAnnual> ViewLoanRenewalAnnuals { get; set; }

    public virtual DbSet<ViewNewBusinessSaving> ViewNewBusinessSavings { get; set; }

    public virtual DbSet<ViewOutStandingBasePolicy> ViewOutStandingBasePolicies { get; set; }

    public virtual DbSet<ViewPaymentsValidationsAllInvoice> ViewPaymentsValidationsAllInvoices { get; set; }

    public virtual DbSet<ViewPaymentsValidationsAllPayment> ViewPaymentsValidationsAllPayments { get; set; }

    public virtual DbSet<ViewPaymentsValidationsCheck> ViewPaymentsValidationsChecks { get; set; }

    public virtual DbSet<ViewPensionSaving> ViewPensionSavings { get; set; }

    public virtual DbSet<ViewPensionSavingsCleanCustomer> ViewPensionSavingsCleanCustomers { get; set; }

    public virtual DbSet<ViewPolicyDetail> ViewPolicyDetails { get; set; }

    public virtual DbSet<ViewPolicyRegisterDetail> ViewPolicyRegisterDetails { get; set; }

    public virtual DbSet<ViewPolicyRegisterSurrenderNotRestricted> ViewPolicyRegisterSurrenderNotRestricteds { get; set; }

    public virtual DbSet<ViewProductionPensionAndSaving> ViewProductionPensionAndSavings { get; set; }

    public virtual DbSet<ViewProvision> ViewProvisions { get; set; }

    public virtual DbSet<ViewProvisionBasePolicySavingPension> ViewProvisionBasePolicySavingPensions { get; set; }

    public virtual DbSet<ViewProvisionEndorsmentSavingPension> ViewProvisionEndorsmentSavingPensions { get; set; }

    public virtual DbSet<ViewPsEndorsementNext> ViewPsEndorsementNexts { get; set; }

    public virtual DbSet<ViewPsPolicyWithoutBeneficiary> ViewPsPolicyWithoutBeneficiaries { get; set; }

    public virtual DbSet<ViewPsSignedReturned> ViewPsSignedReturneds { get; set; }

    public virtual DbSet<ViewResultApiLoanCoverPolicy> ViewResultApiLoanCoverPolicies { get; set; }

    public virtual DbSet<ViewSavingPensionInvoiceSp> ViewSavingPensionInvoiceSps { get; set; }

    public virtual DbSet<ViewSavingsActuarialsDataEndo> ViewSavingsActuarialsDataEndos { get; set; }

    public virtual DbSet<ViewSavingsActuarialsDataMain> ViewSavingsActuarialsDataMains { get; set; }

    public virtual DbSet<ViewSavingsClaimsProcess> ViewSavingsClaimsProcesses { get; set; }

    public virtual DbSet<ViewSavingsCommissionAll> ViewSavingsCommissionAlls { get; set; }

    public virtual DbSet<ViewSavingsCommissionEndo> ViewSavingsCommissionEndos { get; set; }

    public virtual DbSet<ViewSavingsCommissionMain> ViewSavingsCommissionMains { get; set; }

    public virtual DbSet<ViewSavingsIntacctIngenziCombinedInvoice> ViewSavingsIntacctIngenziCombinedInvoices { get; set; }

    public virtual DbSet<ViewSavingsIntacctIngenziInvoiceRegisterBasePolicy> ViewSavingsIntacctIngenziInvoiceRegisterBasePolicies { get; set; }

    public virtual DbSet<ViewSavingsIntacctIngenziInvoiceRegisterEndorsement> ViewSavingsIntacctIngenziInvoiceRegisterEndorsements { get; set; }

    public virtual DbSet<ViewSavingsPytStatement> ViewSavingsPytStatements { get; set; }

    public virtual DbSet<ViewSchemeInvalid> ViewSchemeInvalids { get; set; }

    public virtual DbSet<ViewSchemeUpdateName> ViewSchemeUpdateNames { get; set; }

    public virtual DbSet<ViewSearchCustomerAndPolDetail> ViewSearchCustomerAndPolDetails { get; set; }

    public virtual DbSet<ViewSmsToSendMaxDate> ViewSmsToSendMaxDates { get; set; }

    public virtual DbSet<ViewSmsToSendMaxDateEndo> ViewSmsToSendMaxDateEndos { get; set; }

    public virtual DbSet<ViewStatementDetail> ViewStatementDetails { get; set; }

    public virtual DbSet<ViewStatementPay> ViewStatementPays { get; set; }

    public virtual DbSet<ViewTableOfPayementPlan> ViewTableOfPayementPlans { get; set; }

    public virtual DbSet<ViewTechnicalProvision> ViewTechnicalProvisions { get; set; }

    public virtual DbSet<ViewTechnicalProvisionAll> ViewTechnicalProvisionAlls { get; set; }

    public virtual DbSet<ViewTechnicalProvisionEndo> ViewTechnicalProvisionEndos { get; set; }

    public virtual DbSet<ViewTechnicalProvisionMain> ViewTechnicalProvisionMains { get; set; }

    public virtual DbSet<ViewToApprouve> ViewToApprouves { get; set; }

    public virtual DbSet<ViewTransUnionCustomer> ViewTransUnionCustomers { get; set; }

    public virtual DbSet<ViewUpdateBeneficiary> ViewUpdateBeneficiaries { get; set; }

    public virtual DbSet<ViewUpdatePatmentChannel> ViewUpdatePatmentChannels { get; set; }

    public virtual DbSet<ViewUpdatePay> ViewUpdatePays { get; set; }

    public virtual DbSet<ViewUpdatePensionSavingsInvoice> ViewUpdatePensionSavingsInvoices { get; set; }

    public virtual DbSet<ViewUpdatePensionSavingsMissingDetail> ViewUpdatePensionSavingsMissingDetails { get; set; }

    public virtual DbSet<ViewUpdateProposalRegisterSaving> ViewUpdateProposalRegisterSavings { get; set; }

    public virtual DbSet<ViewUpdateSavingsPolicyRegisterClaim> ViewUpdateSavingsPolicyRegisterClaims { get; set; }

    public virtual DbSet<ViewUpdateScheme> ViewUpdateSchemes { get; set; }

    public virtual DbSet<ViewUpdateSchemeMain> ViewUpdateSchemeMains { get; set; }

    public virtual DbSet<ViewUpdateSchemeSprdetail> ViewUpdateSchemeSprdetails { get; set; }

    public virtual DbSet<ViewUploadExcel> ViewUploadExcels { get; set; }

    public virtual DbSet<ViewViewSavingsPytStatementsEndorsement> ViewViewSavingsPytStatementsEndorsements { get; set; }

    public virtual DbSet<ViewZamaraIkimina> ViewZamaraIkiminas { get; set; }

    public virtual DbSet<ViewZamaraPensionSavingsEndorsment> ViewZamaraPensionSavingsEndorsments { get; set; }

    public virtual DbSet<ViewZamaraPensionSavingsPolicy> ViewZamaraPensionSavingsPolicies { get; set; }

    public virtual DbSet<ViewZamaraPensionsavingsAll> ViewZamaraPensionsavingsAlls { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("Server=10.10.1.44;Database=LoanProtectionTest;User Id=sa;Password=inrichTECH789;Integrated Security=False;TrustServerCertificate=True;");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AirtelCallBackLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AirtelCallBackLog");

            entity.Property(e => e.ExternalTransactionId).HasMaxLength(250);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Message).HasMaxLength(500);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(150);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionId).HasMaxLength(250);
            entity.Property(e => e.TransactionStatus).HasMaxLength(250);
        });

        modelBuilder.Entity<AxxisMigrationSavingsContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Axxis_Migration_Savings_Contact");

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
            entity.Property(e => e.Birth).HasColumnName("birth");
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
                .HasMaxLength(10)
                .IsFixedLength()
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
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("maritalstatus");
            entity.Property(e => e.MarketingAgreement)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("marketingAgreement");
            entity.Property(e => e.MedicalProvider).HasColumnName("medicalProvider");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("middleName");
            entity.Property(e => e.MigrationCode).HasColumnName("migrationCode");
            entity.Property(e => e.Name)
                .HasMaxLength(50)
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
                .HasMaxLength(50)
                .HasColumnName("surname1");
            entity.Property(e => e.Surname2)
                .HasMaxLength(50)
                .HasColumnName("surname2");
            entity.Property(e => e.Tag).HasColumnName("tag");
            entity.Property(e => e.Title)
                .HasMaxLength(18)
                .IsUnicode(false)
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
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("workplace");
            entity.Property(e => e.Zip).HasColumnName("zip");
        });

        modelBuilder.Entity<BankAccessView>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("BankAccessView");

            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<CallBackResponse>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
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

        modelBuilder.Entity<CustomerIdentification>(entity =>
        {
            entity.HasKey(e => e.CustomerCode);

            entity.ToTable("CustomerIdentification");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerType).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
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

        modelBuilder.Entity<IkiminaTechnicalBasic>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.RecordedDate).HasColumnType("smalldatetime");
        });

        modelBuilder.Entity<ListOfPoliciesWithoutPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListOfPoliciesWithoutPayments");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Fullname)
                .HasMaxLength(101)
                .HasColumnName("fullname");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyComponentType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.Product)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ListOfPolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.Property(e => e.PolicyNumber).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ListPaymentsPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("ListPaymentsPolicies");

            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<LoanProtectionInsuranceCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionInsuranceCompany");

            entity.Property(e => e.Adress).HasMaxLength(50);
            entity.Property(e => e.CompanyName).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.ContactPersonNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionInsuranceCompanyBranch>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LoanProtectionInsuranceCompanyBranch");

            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanProtectionUser>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("LoanProtectionUser");

            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
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

        modelBuilder.Entity<NewViewDetailsEndorsement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("New_View_Details_Endorsements");

            entity.Property(e => e.ChildPolicy)
                .HasMaxLength(50)
                .HasColumnName("Child Policy #");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.Effective)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDoc)
                .HasMaxLength(50)
                .HasColumnName("Id doc");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Maturity)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.ParentPolicy)
                .HasMaxLength(50)
                .HasColumnName("Parent Policy #");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("Scheme id");
            entity.Property(e => e.SchemeId1)
                .HasMaxLength(50)
                .HasColumnName("SchemeId");
            entity.Property(e => e.SumAssuredAmount).HasColumnName("Sum assured amount");
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<NewViewListPayEndorsement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NewView_ListPay_Endorsements");

            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .HasColumnName("Customer #");
            entity.Property(e => e.DueDate).HasColumnName("Due date");
            entity.Property(e => e.Invoice)
                .HasMaxLength(100)
                .HasColumnName("Invoice #");
            entity.Property(e => e.Names).HasMaxLength(152);
            entity.Property(e => e.Policy)
                .HasMaxLength(50)
                .HasColumnName("Policy #");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("Scheme id");
        });

        modelBuilder.Entity<NewViewListToPay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NewView_ListToPay");

            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .HasColumnName("Customer #");
            entity.Property(e => e.DueDate).HasColumnName("Due date");
            entity.Property(e => e.Invoice)
                .HasMaxLength(100)
                .HasColumnName("Invoice #");
            entity.Property(e => e.Names).HasMaxLength(152);
            entity.Property(e => e.Policy)
                .HasMaxLength(50)
                .HasColumnName("Policy #");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("Scheme id");
        });

        modelBuilder.Entity<NewViewPolicyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("New_View_Policy_Details");

            entity.Property(e => e.ChildPolicy)
                .HasMaxLength(50)
                .HasColumnName("Child Policy #");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Effective)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDoc)
                .HasMaxLength(50)
                .HasColumnName("Id doc");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Maturity)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.ParentPolicy)
                .HasMaxLength(50)
                .HasColumnName("Parent Policy #");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("Scheme id");
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.SumAssuredAmount).HasColumnName("Sum assured amount");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<NewViewPolicyRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("New_View_Policy_Register");

            entity.Property(e => e.BenefitPayMode)
                .HasMaxLength(50)
                .HasColumnName("Benefit pay mode");
            entity.Property(e => e.CommissionsRate).HasColumnName("Commissions rate");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IdNumber)
                .HasMaxLength(50)
                .HasColumnName("Id number");
            entity.Property(e => e.InstallmentFees).HasColumnName("Installment fees");
            entity.Property(e => e.InterestRate).HasColumnName("Interest rate");
            entity.Property(e => e.ManagementFees).HasColumnName("Management fees");
            entity.Property(e => e.Names).HasMaxLength(152);
            entity.Property(e => e.Policy)
                .HasMaxLength(50)
                .HasColumnName("Policy #");
            entity.Property(e => e.PolicyDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Policy date");
            entity.Property(e => e.PremiumFrequencyPay)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency pay");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("Scheme id");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(50)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SumAssured)
                .HasMaxLength(50)
                .HasColumnName("Sum assured");
            entity.Property(e => e.Type).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorName)
                .HasMaxLength(255)
                .HasColumnName("Vendor name");
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<NewViewStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("NewView_Statement");

            entity.Property(e => e.Customer)
                .HasMaxLength(50)
                .HasColumnName("Customer #");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(152);
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(50)
                .HasColumnName("Payment mode");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Policy)
                .HasMaxLength(50)
                .HasColumnName("Policy #");
            entity.Property(e => e.PolicyEffectDate)
                .HasColumnType("datetime")
                .HasColumnName("Policy Effect date");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Scheme).HasMaxLength(150);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
        });

        modelBuilder.Entity<OnlineMoMoPortal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OnlineMoMoPortal");

            entity.Property(e => e.Amount).HasMaxLength(255);
            entity.Property(e => e.Currency).HasMaxLength(255);
            entity.Property(e => e.Date).HasMaxLength(255);
            entity.Property(e => e.Externalid).HasMaxLength(255);
            entity.Property(e => e.From).HasMaxLength(255);
            entity.Property(e => e.Fromhandlername).HasMaxLength(255);
            entity.Property(e => e.Fromname).HasMaxLength(255);
            entity.Property(e => e.IdConfirmation).HasMaxLength(255);
            entity.Property(e => e.Initiatedby).HasMaxLength(255);
            entity.Property(e => e.Initiatedby1).HasMaxLength(255);
            entity.Property(e => e.Onbehalfof).HasMaxLength(255);
            entity.Property(e => e.Onbehalfof1).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.To).HasMaxLength(255);
            entity.Property(e => e.Tohandlername).HasMaxLength(255);
            entity.Property(e => e.Tomessage).HasMaxLength(255);
            entity.Property(e => e.Toname).HasMaxLength(255);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<OnlinePaymentTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OnlinePaymentTransaction");

            entity.Property(e => e.ExternalReference).HasMaxLength(250);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(150);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(250);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransactionId).HasMaxLength(450);
        });

        modelBuilder.Entity<OnlinePaymentTransactionGen>(entity =>
        {
            entity.HasKey(e => e.TransactionId);

            entity.ToTable("OnlinePaymentTransactionGen");

            entity.Property(e => e.ExternalReference).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
        });

        modelBuilder.Entity<OtherPaymentsTransactionsRegister>(entity =>
        {
            entity.HasKey(e => e.InternalTransactionId);

            entity.ToTable("OtherPaymentsTransactionsRegister");

            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(150);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(450);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<PensionDetailsTable>(entity =>
        {
            entity.HasKey(e => e.IdentityRecord);

            entity.ToTable("PensionDetailsTable");

            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<PensionDetailsTableHistory>(entity =>
        {
            entity.HasKey(e => e.IdentityRecord);

            entity.ToTable("PensionDetailsTable_History");

            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<PensionDetailsTableHistoryProvision>(entity =>
        {
            entity.HasKey(e => new { e.IdentityRecord, e.Username });

            entity.ToTable("PensionDetailsTable_History_Provision");

            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<PensionDetailsTableHistoryStatement>(entity =>
        {
            entity.HasKey(e => new { e.IdentityRecord, e.Username });

            entity.ToTable("PensionDetailsTable_History_Statement");

            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.Username).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<PolicyListDetail>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.EndorsementType)
                .HasMaxLength(255)
                .HasColumnName("Endorsement_Type");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemNumber)
                .HasMaxLength(255)
                .HasColumnName("Schem_Number");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(255);
        });

        modelBuilder.Entity<PsPolicyRegisterSigned>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("PS_PolicyRegister_Signed");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<REmovenUll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("rEMOVEnULL");

            entity.Property(e => e.PolicenUmber)
                .HasMaxLength(50)
                .HasColumnName("POLICEnUMBER");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ReceivedSm>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(150);
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedTime).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsChannel>(entity =>
        {
            entity.HasKey(e => e.VendorCode);

            entity.ToTable("SavingsChannel");

            entity.Property(e => e.VendorCode).HasMaxLength(255);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<SavingsClaimsRegister>(entity =>
        {
            entity.HasKey(e => e.ClaimNumber);

            entity.ToTable("Savings_ClaimsRegister");

            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(50)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.BeneficiaryAccounts).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryId)
                .HasMaxLength(50)
                .HasColumnName("BeneficiaryID");
            entity.Property(e => e.BeneficiaryInstitution).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryPhone).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryRelationshipType).HasMaxLength(50);
            entity.Property(e => e.BenefitsPayment).HasMaxLength(50);
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(80)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(80)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.ClaimentId)
                .HasMaxLength(50)
                .HasColumnName("ClaimentID");
            entity.Property(e => e.ClaimentRelationship).HasMaxLength(50);
            entity.Property(e => e.Cmaction)
                .HasMaxLength(50)
                .HasColumnName("CMAction");
            entity.Property(e => e.CmapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CMApprovedDate");
            entity.Property(e => e.CmapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CMApprovedUserName");
            entity.Property(e => e.CoinsuranceRecoverable).HasColumnName("Coinsurance_Recoverable");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateLastDocument).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IdlifeInsured).HasColumnName("IDLifeInsured");
            entity.Property(e => e.IdofBeneficiary).HasColumnName("IDOfBeneficiary");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(250);
            entity.Property(e => e.OperationStatus).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(100)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordUserName).HasMaxLength(100);
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
        });

        modelBuilder.Entity<SavingsClaimsRegisterHistorical>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Savings_ClaimsRegister_Historical");

            entity.Property(e => e.Assured).HasMaxLength(255);
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyNumberValid).HasMaxLength(255);
            entity.Property(e => e.Product).HasMaxLength(255);
            entity.Property(e => e.TypeOfClaims).HasMaxLength(255);
        });

        modelBuilder.Entity<SavingsCommission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SAVINGS_Commissions");

            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.ControllerId).HasColumnName("ControllerID");
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsCountry>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Country).HasMaxLength(255);
        });

        modelBuilder.Entity<SavingsDistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SavingsDistrict");

            entity.Property(e => e.DistrictName).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsEndorsementRegister>(entity =>
        {
            entity.HasKey(e => new { e.PolicyNumber, e.EndorsementNumber, e.EndorsementDate, e.IsCancelled });

            entity.ToTable("SavingsEndorsementRegister");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.EndorsementNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.EndorsementType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SumAssuredType).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsEndorsementRegisterDetail>(entity =>
        {
            entity.HasKey(e => new { e.PolicyNumber, e.PolicyNumberChild, e.CustomerCode }).HasName("PK_SavingsEndorsementRegisterDetails_1");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsExportListInvoicing>(entity =>
        {
            entity.HasKey(e => e.InvoiceNumber);

            entity.ToTable("Savings_Export_List_Invoicing");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Names).HasMaxLength(500);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(500);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(500);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsIntegrationTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Savings_Integration_Table");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerNames).HasMaxLength(50);
            entity.Property(e => e.Idrecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsPayement>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsPayementsTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SavingsPayements_Temp");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsPaymentsTable>(entity =>
        {
            entity.HasKey(e => e.ReferencePay).HasName("PK_PLPaymentsTable");

            entity.ToTable("SavingsPaymentsTable");

            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsPensionRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SavingsPensionRate");

            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<SavingsPolicyBeneficiary>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BeneficiaryFirstname).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryLastName).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsPolicyRegister>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("SavingsPolicyRegister");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SumAssuredType).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<SavingsPolicyRegisterDetail>(entity =>
        {
            entity.HasKey(e => new { e.PolicyNumber, e.PolicyNumberChild, e.CustomerCode }).HasName("PK_SavingsPolicyRegisterDetails_1");

            entity.ToTable(tb => tb.HasTrigger("Proposal_converted_PensionAndSaving_trigger"));

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SendContract)
                .HasDefaultValue(0)
                .HasColumnName("Send_Contract");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.SubPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SubProductType).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsProvince>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SavingsProvince");

            entity.Property(e => e.Province).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsQuotation>(entity =>
        {
            entity.HasKey(e => e.QuotationId);

            entity.Property(e => e.QuotationId).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Names).HasMaxLength(150);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<SavingsRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SavingsRate");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
        });

        modelBuilder.Entity<SavingsSector>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SavingsSector");

            entity.Property(e => e.DistrictName).HasMaxLength(50);
            entity.Property(e => e.SectorName).HasMaxLength(50);
        });

        modelBuilder.Entity<SchemesList>(entity =>
        {
            entity.HasKey(e => e.SchemeId);

            entity.ToTable("SchemesList");

            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.ContactPersonPhone).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SchemeType).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<SingleInvoicesRegister>(entity =>
        {
            entity.HasKey(e => e.InvoiceNumber);

            entity.ToTable("SingleInvoicesRegister");

            entity.Property(e => e.InvoiceNumber).HasMaxLength(150);
            entity.Property(e => e.Account).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(500);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<SmsToSend>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("SmsToSend");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(150);
            entity.Property(e => e.LastName).HasMaxLength(150);
            entity.Property(e => e.MiddleName).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(500);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<TempSavingsProvision>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Temp_SavingsProvisions");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductTypes).HasMaxLength(50);
            entity.Property(e => e.ReportingDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
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

        modelBuilder.Entity<TransferRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TransferRegister");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InternalTransactionId).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ServiceProvider).HasMaxLength(50);
            entity.Property(e => e.ServiceProviderTransactionId).HasMaxLength(150);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
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

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<View10>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_10");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.PayChan)
                .HasMaxLength(50)
                .HasColumnName("Pay Chan");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
        });

        modelBuilder.Entity<View11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_11");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.Mode).HasMaxLength(255);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<View12>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_12");

            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
        });

        modelBuilder.Entity<View13>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_13");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<View14>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_14");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.Cust).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<View15>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_15");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
        });

        modelBuilder.Entity<View16>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_16");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<View17>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_17");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Expr2).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_2");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<View3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_3");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<View4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_4");

            entity.Property(e => e.Pol).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
        });

        modelBuilder.Entity<View5>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_5");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<View6>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_6");

            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
        });

        modelBuilder.Entity<View7>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_7");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<View8>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_8");

            entity.Property(e => e.PolicenUmber)
                .HasMaxLength(50)
                .HasColumnName("POLICEnUMBER");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
        });

        modelBuilder.Entity<View9>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_9");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewAllInvoicesPsMainEndoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllInvoices_PS_Main_Endo_Details");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDateEndo).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.NexEndorsement).HasMaxLength(56);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewAllInvoicesPsMainEndoDetailsNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllInvoices_PS_Main_Endo_Details_New");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDateEndo).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullNames).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.NexEndorsement).HasMaxLength(56);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewAllPaymentsPsMainEndoSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllPayments_PS_Main_Endo_Summary");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.Bonus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of Birth");
            entity.Property(e => e.DistributionPerson)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(152)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.MaxDateFormated)
                .HasColumnType("datetime")
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPayingTerm).HasColumnName("Premium Paying Term");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Profit Sharing");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
        });

        modelBuilder.Entity<ViewAllPoliciesPsMainEndoDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllPolicies_PS_Main_Endo_Details");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDateEndo).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.NexEndorsement).HasMaxLength(56);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewAllPoliciesPsMainEndoDetailsNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllPolicies_PS_Main_Endo_Details_New");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDateEndo).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullNames).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.NexEndorsement).HasMaxLength(56);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewAllPoliciesPsMainEndoSummary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllPolicies_PS_Main_Endo_Summary");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.Bonus)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of Birth");
            entity.Property(e => e.DistributionPerson)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(152)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.MaxDateFormated)
                .HasColumnType("datetime")
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPayingTerm).HasColumnName("Premium Paying Term");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Profit Sharing");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
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

        modelBuilder.Entity<ViewBindListOfPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BindListOfPolicies");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.EndorsmentNumber)
                .HasMaxLength(50)
                .HasColumnName("Endorsment Number");
            entity.Property(e => e.IdDocument)
                .HasMaxLength(50)
                .HasColumnName("ID document");
            entity.Property(e => e.Names).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewCheckIncompleteConvertedInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Incomplete_Converted_Invoices");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullNames).HasMaxLength(152);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewCheckIncompleteConvertedPoliciesSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Incomplete_Converted_Policies_Savings");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewCheckValidPaymentCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Valid_PaymentCustomers");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
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
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.UniqueKey)
                .HasMaxLength(100)
                .HasColumnName("UNiqueKey");
        });

        modelBuilder.Entity<ViewCheckValidPaymentCustomersInvalid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Valid_PaymentCustomers_Invalid");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewClaimsRegisterSavingsHistoAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegisterSavings_Histo_All");

            entity.Property(e => e.Assured).HasMaxLength(255);
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberValid).HasMaxLength(255);
            entity.Property(e => e.Product).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TypeOfClaims).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewClaimsRegisterSavingsHistoEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegisterSavings_Histo_Endo");

            entity.Property(e => e.Assured).HasMaxLength(255);
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberValid).HasMaxLength(255);
            entity.Property(e => e.Product).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TypeOfClaims).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewClaimsRegisterSavingsHistoMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegisterSavings_Histo_Main");

            entity.Property(e => e.Assured).HasMaxLength(255);
            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberValid).HasMaxLength(255);
            entity.Property(e => e.Product).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TypeOfClaims).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewConvertUpdateConvertSavingPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Convert_UpdateConvert_SavingPolicy");

            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFirstPaymentSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FirstPayment_Savings");

            entity.Property(e => e.MainPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewForDigitalAllPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ForDigital_All_Payment");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewForDigitalEducationPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ForDigital_EducationPayment");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewForDigitalEpiPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ForDigital_EPI_Payment");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewForDigitalFamilyPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ForDigital_Family_Payment");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewForDigitalFreeEducationPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ForDigital_FreeEducationPayment");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewForDigitalSavingsPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ForDigital_SavingsPayment");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
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

        modelBuilder.Entity<ViewIkiminaAllPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Ikimina_All_Payments");

            entity.Property(e => e.Channel).HasMaxLength(50);
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
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.YearMonth)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("YEAR_MONTH");
        });

        modelBuilder.Entity<ViewIkiminaAllPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Ikimina_All_Policies");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CreationYearMonths)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("Creation_YearMonths");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
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
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewIkiminaFailedTransfer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Ikimina_Failed_Transfers");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.ServiceProviderTransactionId).HasMaxLength(150);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewIkiminaWithdraw>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Ikimina_Withdraws");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PolicyholderName).HasMaxLength(152);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.ServiceProviderTransactionId).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewInvalidSchemeIdSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Invalid_SchemeID_Savings");

            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
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
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeIdSavings).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
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

        modelBuilder.Entity<ViewListOfPoliceEndosmentSavingPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPoliceEndosmentSavingPension");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerType).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewListOfPoliceSavingPensionAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPoliceSavingPension_All");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerType).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewListOfPolicyBaseMaxPaymentDateSavingsPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPolicyBaseMaxPaymentDateSavingsPension");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerType).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MaxPayDate).HasColumnType("datetime");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewListOfPolicyBaseProvisionMaxDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPolicyBaseProvisionMaxDate");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MaxPayDate).HasColumnType("datetime");
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewListOfPolicyEndorsementMaxPaymentDateSavingsPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPolicyEndorsementMaxPaymentDateSavingsPension");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerType).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.Expr2).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MaxPayDate).HasColumnType("datetime");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewListOfPolicyEndorsmentProvisionMaxDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPolicyEndorsmentProvisionMaxDate");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MaxPayDate).HasColumnType("datetime");
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewListOfPolicySavingPolicyBase>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfPolicySavingPolicyBase");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerType).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewLoanRenewalAnnual>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LoanRenewal_Annual");

            entity.Property(e => e.BankName).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(901);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewNewBusinessSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_NewBusiness_Savings");

            entity.Property(e => e.Branch)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewOutStandingBasePolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_OutStandingBasePolicies");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductName)
                .HasMaxLength(15)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewPaymentsValidationsAllInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Payments_Validations_AllInvoices");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDateEndo).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullNames).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.NexEndorsement).HasMaxLength(56);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Uniquekey)
                .HasMaxLength(163)
                .HasColumnName("UNIQUEKEY");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewPaymentsValidationsAllPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Payments_Validations_AllPayments");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyNumberPayment).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.Uniquekey)
                .HasMaxLength(163)
                .HasColumnName("UNIQUEKEY");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewPaymentsValidationsCheck>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Payments_Validations_Checks");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDateEndo).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullNames).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberPayment).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Uniquekey)
                .HasMaxLength(163)
                .HasColumnName("UNIQUEKEY");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewPensionSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PensionSavings");

            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(255);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(255);
            entity.Property(e => e.MiddleName).HasMaxLength(255);
            entity.Property(e => e.PhoneNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.SchemeName).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewPensionSavingsCleanCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PensionSavingsCleanCustomers");

            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Gender1).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber1).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Salutation1).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.Village).HasMaxLength(50);
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

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.Effective)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.EndorsementType)
                .HasMaxLength(50)
                .HasColumnName("Endorsement_Type");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First Name");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last Name");
            entity.Property(e => e.Maturity)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.RecordDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Record date");
            entity.Property(e => e.RecordedBy)
                .HasMaxLength(100)
                .HasColumnName("Recorded by");
            entity.Property(e => e.SchemNumber)
                .HasMaxLength(50)
                .HasColumnName("Schem Number");
            entity.Property(e => e.SumAssured).HasColumnName("Sum assured");
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<ViewPolicyRegisterSurrenderNotRestricted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PolicyRegisterSurrenderNotRestricted");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
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

        modelBuilder.Entity<ViewProvision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Provisions");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewProvisionBasePolicySavingPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProvisionBasePolicySavingPension");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewProvisionEndorsmentSavingPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProvisionEndorsmentSavingPension");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewPsEndorsementNext>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PS_Endorsement_Next");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.NexEndorsement).HasMaxLength(56);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewPsPolicyWithoutBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PS_PolicyWithoutBeneficiaries");

            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewPsSignedReturned>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PS_SignedReturned");

            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
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

        modelBuilder.Entity<ViewSavingPensionInvoiceSp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SavingPension_Invoice_SP");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSavingsActuarialsDataEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Actuarials_Data_Endo");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSavingsActuarialsDataMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Actuarials_Data_Main");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSavingsClaimsProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Claims_Process");

            entity.Property(e => e.BeneficiaryAccounts).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryId)
                .HasMaxLength(50)
                .HasColumnName("BeneficiaryID");
            entity.Property(e => e.BeneficiaryInstitution).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryPhone).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryRelationshipType).HasMaxLength(50);
            entity.Property(e => e.BenefitsPayment).HasMaxLength(50);
            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(50)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(80)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(80)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.ClaimentId)
                .HasMaxLength(50)
                .HasColumnName("ClaimentID");
            entity.Property(e => e.ClaimentRelationship).HasMaxLength(50);
            entity.Property(e => e.Cmaction)
                .HasMaxLength(50)
                .HasColumnName("CMAction");
            entity.Property(e => e.CmapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CMApprovedDate");
            entity.Property(e => e.CmapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CMApprovedUserName");
            entity.Property(e => e.CoinsuranceRecoverable).HasColumnName("Coinsurance_Recoverable");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateLastDocument).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdlifeInsured).HasColumnName("IDLifeInsured");
            entity.Property(e => e.IdofBeneficiary).HasColumnName("IDOfBeneficiary");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.OperationStatus).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(100)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordUserName).HasMaxLength(100);
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewSavingsCommissionAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SAVINGS_COMMISSION_ALL");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CommissionRate)
                .HasColumnType("numeric(13, 1)")
                .HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSavingsCommissionEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SAVINGS_COMMISSION_ENDO");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSavingsCommissionMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SAVINGS_COMMISSION_MAIN");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CommissionRate)
                .HasColumnType("numeric(13, 1)")
                .HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSavingsIntacctIngenziCombinedInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Intacct_Ingenzi_CombinedInvoices");

            entity.Property(e => e.InsuranceCodeBranch).HasMaxLength(50);
            entity.Property(e => e.IntegratedAcc).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.ReceiptingBank).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSavingsIntacctIngenziInvoiceRegisterBasePolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Intacct_Ingenzi_InvoiceRegister_BasePolicies");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.InsuranceCodeBranch).HasMaxLength(50);
            entity.Property(e => e.IntegratedAcc).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.ReceiptingBank).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSavingsIntacctIngenziInvoiceRegisterEndorsement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Intacct_Ingenzi_InvoiceRegister_Endorsement");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.InsuranceCodeBranch).HasMaxLength(50);
            entity.Property(e => e.IntegratedAcc).HasMaxLength(50);
            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReceiptDescription).HasMaxLength(500);
            entity.Property(e => e.ReceiptNumber).HasMaxLength(50);
            entity.Property(e => e.ReceiptingBank).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSavingsPytStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Pyt_Statements");

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
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSchemeInvalid>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Scheme_Invalid");

            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<ViewSchemeUpdateName>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Scheme_Update_Names");

            entity.Property(e => e.ChannelDetails).HasMaxLength(150);
            entity.Property(e => e.ChannelMain).HasMaxLength(50);
            entity.Property(e => e.PaymentChannelDetails).HasMaxLength(50);
            entity.Property(e => e.PaymentChannelMain).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
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

        modelBuilder.Entity<ViewSmsToSendMaxDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SmsToSend_MAX_Date");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.SchemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSmsToSendMaxDateEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SmsToSend_MAX_Date_Endo");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.SchemeName).HasMaxLength(50);
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
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.DateOfPay)
                .HasColumnType("datetime")
                .HasColumnName("Date of Pay");
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

        modelBuilder.Entity<ViewTechnicalProvision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Technical_Provision");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasMaxLength(50);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastName).HasMaxLength(50);
            entity.Property(e => e.MiddleName).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewTechnicalProvisionAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Technical_Provision_All");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaxDateFormated)
                .HasColumnType("datetime")
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.SchemeName).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewTechnicalProvisionEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Technical_Provision_Endo");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaxDateFormated)
                .HasColumnType("datetime")
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.SchemeName).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewTechnicalProvisionMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Technical_Provision_Main");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.MaxDateFormated)
                .HasColumnType("datetime")
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.SchemeName).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
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

        modelBuilder.Entity<ViewTransUnionCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_Customer");

            entity.Property(e => e.Country)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.CustomerType)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("Customer Type");
            entity.Property(e => e.DateOfBirthOrRegistration)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Date of Birth or Registration");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(50)
                .HasColumnName("Email Address");
            entity.Property(e => e.EmployerAddressLine1).HasColumnName("Employer Address Line 1");
            entity.Property(e => e.EmployerCountry).HasColumnName("Employer Country");
            entity.Property(e => e.EmployerDurationMonths).HasColumnName("Employer Duration (Months)");
            entity.Property(e => e.EmployerDurationYears).HasColumnName("Employer Duration (Years)");
            entity.Property(e => e.EmployerName).HasColumnName("Employer Name");
            entity.Property(e => e.EmployerTown).HasColumnName("Employer Town");
            entity.Property(e => e.FascimileFax).HasColumnName("Fascimile / Fax");
            entity.Property(e => e.FirstNameTradingName)
                .HasMaxLength(50)
                .HasColumnName("First Name/Trading Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(14)
                .IsUnicode(false);
            entity.Property(e => e.HomeTelephone).HasColumnName("Home Telephone");
            entity.Property(e => e.IdentificationDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Identification Document Number");
            entity.Property(e => e.IdentificationDocumentType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Identification document Type");
            entity.Property(e => e.IncomeFrequency).HasColumnName("Income Frequency");
            entity.Property(e => e.MaritalStatus).HasColumnName("Marital Status");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle Name");
            entity.Property(e => e.MobileTelephone)
                .HasMaxLength(50)
                .HasColumnName("Mobile Telephone");
            entity.Property(e => e.PhysicalAddress).HasColumnName("Physical Address");
            entity.Property(e => e.PlaceOfBirthRegistration).HasColumnName("Place Of Birth/ Registration");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation)
                .HasMaxLength(18)
                .IsUnicode(false)
                .HasColumnName("salutation");
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(50)
                .HasColumnName("Surname/Institution Name");
            entity.Property(e => e.WorkTelephone).HasColumnName("Work Telephone");
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

        modelBuilder.Entity<ViewUpdatePatmentChannel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Update_PatmentChannel");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewUpdatePay>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePay");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ToUp).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdatePensionSavingsInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePensionSavings_Invoice");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewUpdatePensionSavingsMissingDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePensionSavings_MissingDetails");

            entity.Property(e => e.Cancelled)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Channel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SendContract).HasColumnName("Send_Contract");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Surrendered)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Suspended)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdateProposalRegisterSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateProposalRegister_Savings");

            entity.Property(e => e.ChildPolicy)
                .HasMaxLength(50)
                .HasColumnName("Child Policy #");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Effective)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDoc)
                .HasMaxLength(50)
                .HasColumnName("Id doc");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.Maturity)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.ParentPolicy)
                .HasMaxLength(50)
                .HasColumnName("Parent Policy #");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("Scheme id");
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.SumAssuredAmount).HasColumnName("Sum assured amount");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e._).HasColumnName("#");
        });

        modelBuilder.Entity<ViewUpdateSavingsPolicyRegisterClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateSavingsPolicyRegisterClaims");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(4000)
                .HasColumnName("Effective Date");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(4000)
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStaus)
                .HasMaxLength(8)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewUpdateScheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateScheme");

            entity.Property(e => e.ChannelDetails).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannelDetails).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeIdupd).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewUpdateSchemeMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateSchemeMain");

            entity.Property(e => e.ChannelInDetails).HasMaxLength(150);
            entity.Property(e => e.ChannelMain).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentChannelMain).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeIdUpd).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewUpdateSchemeSprdetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateSchemeSPRDetails");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.SchemeIdInRegister).HasMaxLength(50);
            entity.Property(e => e.SchemeIdOfChannel).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewUploadExcel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UploadExcel");

            entity.Property(e => e.Comments)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.IntegratedAcc)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PaymentChannel).HasMaxLength(255);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(255);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonth)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ReportingYear)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(22)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewViewSavingsPytStatementsEndorsement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_View_Savings_Pyt_Statements_Endorsements");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewZamaraIkimina>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Ikimina");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Last withdrawal date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.NextWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Next withdrawal date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("Phone Number");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(7)
                .IsUnicode(false);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(500);
            entity.Property(e => e.StartDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewZamaraPensionSavingsEndorsment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_PensionSavings_Endorsment");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Last withdrawal date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.NextWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Next withdrawal date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("Phone Number");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(500);
            entity.Property(e => e.StartDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewZamaraPensionSavingsPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_PensionSavings_Policy");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Last withdrawal date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.NextWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Next withdrawal date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("Phone Number");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(500);
            entity.Property(e => e.StartDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewZamaraPensionsavingsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_PENSIONSAVINGS_ALL");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.LastWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Last withdrawal date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max payment date");
            entity.Property(e => e.NextWithdrawalDate)
                .HasColumnType("datetime")
                .HasColumnName("Next withdrawal date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("Phone Number");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(500);
            entity.Property(e => e.StartDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
