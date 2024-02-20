using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;

namespace c_.INGENZIModels;

public partial class INGENZIDbContext : DbContext
{
    public INGENZIDbContext()
    {
    }

    public INGENZIDbContext(DbContextOptions<INGENZIDbContext> options)
        : base(options)
    {
    }

    public virtual DbSet<AdministrativeLocation> AdministrativeLocations { get; set; }

    public virtual DbSet<AllPoliciesValidated> AllPoliciesValidateds { get; set; }

    public virtual DbSet<AssetCategory> AssetCategories { get; set; }

    public virtual DbSet<AssetDepartment> AssetDepartments { get; set; }

    public virtual DbSet<AssetEmployee> AssetEmployees { get; set; }

    public virtual DbSet<AssetItem> AssetItems { get; set; }

    public virtual DbSet<AssetMovement> AssetMovements { get; set; }

    public virtual DbSet<AtDeletedPayement> AtDeletedPayements { get; set; }

    public virtual DbSet<AuditCustomersInfo> AuditCustomersInfos { get; set; }

    public virtual DbSet<AxxisMigrationIngenziContact> AxxisMigrationIngenziContacts { get; set; }

    public virtual DbSet<BnrErrorLog> BnrErrorLogs { get; set; }

    public virtual DbSet<BnrOccupation> BnrOccupations { get; set; }

    public virtual DbSet<Bnrdatacollected> Bnrdatacollecteds { get; set; }

    public virtual DbSet<ClaimsNotifyListReceiver> ClaimsNotifyListReceivers { get; set; }

    public virtual DbSet<ClaimsRegisterManagement> ClaimsRegisterManagements { get; set; }

    public virtual DbSet<CorporateRegistrationType> CorporateRegistrationTypes { get; set; }

    public virtual DbSet<CountryList> CountryLists { get; set; }

    public virtual DbSet<Customer> Customers { get; set; }

    public virtual DbSet<CustomerDetailsCleaningLife> CustomerDetailsCleaningLives { get; set; }

    public virtual DbSet<CustomerValidation> CustomerValidations { get; set; }

    public virtual DbSet<CustomersUser> CustomersUsers { get; set; }

    public virtual DbSet<DataOtherPayement> DataOtherPayements { get; set; }

    public virtual DbSet<DeliveryConvertedPolicy> DeliveryConvertedPolicies { get; set; }

    public virtual DbSet<DistributionChannel> DistributionChannels { get; set; }

    public virtual DbSet<DistributionChannelLogin> DistributionChannelLogins { get; set; }

    public virtual DbSet<EducationAnnuitiesBill> EducationAnnuitiesBills { get; set; }

    public virtual DbSet<EducationBaseMprovision> EducationBaseMprovisions { get; set; }

    public virtual DbSet<EducationBaseMprovisionMigration> EducationBaseMprovisionMigrations { get; set; }

    public virtual DbSet<EducationClaim> EducationClaims { get; set; }

    public virtual DbSet<EducationClaimsBeneficiary> EducationClaimsBeneficiaries { get; set; }

    public virtual DbSet<EducationClaimsBill> EducationClaimsBills { get; set; }

    public virtual DbSet<EducationClaimsBillsPayment> EducationClaimsBillsPayments { get; set; }

    public virtual DbSet<EducationCommission> EducationCommissions { get; set; }

    public virtual DbSet<EducationFreePayment> EducationFreePayments { get; set; }

    public virtual DbSet<EducationFreeTarifNewRate> EducationFreeTarifNewRates { get; set; }

    public virtual DbSet<EducationIntegrationTable> EducationIntegrationTables { get; set; }

    public virtual DbSet<EducationInvoice> EducationInvoices { get; set; }

    public virtual DbSet<EducationPayement> EducationPayements { get; set; }

    public virtual DbSet<EducationPayement1> EducationPayements1 { get; set; }

    public virtual DbSet<EducationPolicyMember> EducationPolicyMembers { get; set; }

    public virtual DbSet<EducationPolicyMembersMigration> EducationPolicyMembersMigrations { get; set; }

    public virtual DbSet<EducationPolicyRegisterDetail> EducationPolicyRegisterDetails { get; set; }

    public virtual DbSet<EducationPolicyRegisterMain> EducationPolicyRegisterMains { get; set; }

    public virtual DbSet<EducationPolicyRegisterSigned> EducationPolicyRegisterSigneds { get; set; }

    public virtual DbSet<EducationTempBeneficiary> EducationTempBeneficiaries { get; set; }

    public virtual DbSet<EducationTempCalculation> EducationTempCalculations { get; set; }

    public virtual DbSet<Employee> Employees { get; set; }

    public virtual DbSet<EmployeeDatum> EmployeeData { get; set; }

    public virtual DbSet<EmployeeProductionIntegrationTable> EmployeeProductionIntegrationTables { get; set; }

    public virtual DbSet<EmployeeProtectionSetting> EmployeeProtectionSettings { get; set; }

    public virtual DbSet<EmployeesTest> EmployeesTests { get; set; }

    public virtual DbSet<EmployeesTestInvalid> EmployeesTestInvalids { get; set; }

    public virtual DbSet<EpReportInnocentProvision> EpReportInnocentProvisions { get; set; }

    public virtual DbSet<Epbeneficiary> Epbeneficiaries { get; set; }

    public virtual DbSet<EpbeneficiaryNextOfKin> EpbeneficiaryNextOfKins { get; set; }

    public virtual DbSet<EpiPolicyRegisterSigned> EpiPolicyRegisterSigneds { get; set; }

    public virtual DbSet<Eppolicy> Eppolicies { get; set; }

    public virtual DbSet<EppolicyRegister> EppolicyRegisters { get; set; }

    public virtual DbSet<EpsavingsRegisterDetail> EpsavingsRegisterDetails { get; set; }

    public virtual DbSet<Epscheme> Epschemes { get; set; }

    public virtual DbSet<ExistingCustomer> ExistingCustomers { get; set; }

    public virtual DbSet<FamilyAndEmployeeIntegrationTable> FamilyAndEmployeeIntegrationTables { get; set; }

    public virtual DbSet<FamilyClaim> FamilyClaims { get; set; }

    public virtual DbSet<FamilyClaimsRegister> FamilyClaimsRegisters { get; set; }

    public virtual DbSet<FamilyCommission> FamilyCommissions { get; set; }

    public virtual DbSet<FamilyDatum> FamilyData { get; set; }

    public virtual DbSet<FamilyEpiClaim> FamilyEpiClaims { get; set; }

    public virtual DbSet<FamilyEpiClaimsRegister> FamilyEpiClaimsRegisters { get; set; }

    public virtual DbSet<FamilyEpiCommission> FamilyEpiCommissions { get; set; }

    public virtual DbSet<FamilyEpiInvoice> FamilyEpiInvoices { get; set; }

    public virtual DbSet<FamilyEpiPayement> FamilyEpiPayements { get; set; }

    public virtual DbSet<FamilyEpiPolicyMember> FamilyEpiPolicyMembers { get; set; }

    public virtual DbSet<FamilyEpiPolicyRegister> FamilyEpiPolicyRegisters { get; set; }

    public virtual DbSet<FamilyInvoice> FamilyInvoices { get; set; }

    public virtual DbSet<FamilyNextOfKin> FamilyNextOfKins { get; set; }

    public virtual DbSet<FamilyPayement> FamilyPayements { get; set; }

    public virtual DbSet<FamilyPolicyMember> FamilyPolicyMembers { get; set; }

    public virtual DbSet<FamilyPolicyRegister> FamilyPolicyRegisters { get; set; }

    public virtual DbSet<FamilyPolicyRegisterSigned> FamilyPolicyRegisterSigneds { get; set; }

    public virtual DbSet<FamilyProposalMember> FamilyProposalMembers { get; set; }

    public virtual DbSet<FamilyRate> FamilyRates { get; set; }

    public virtual DbSet<FamilyReportingMonth> FamilyReportingMonths { get; set; }

    public virtual DbSet<FamilySavingRate> FamilySavingRates { get; set; }

    public virtual DbSet<FamilySavingsDatum> FamilySavingsData { get; set; }

    public virtual DbSet<FamilySavingsPayement> FamilySavingsPayements { get; set; }

    public virtual DbSet<FamilySavingsRegister> FamilySavingsRegisters { get; set; }

    public virtual DbSet<FamilySavingsRegisterDetail> FamilySavingsRegisterDetails { get; set; }

    public virtual DbSet<FamilyScheme> FamilySchemes { get; set; }

    public virtual DbSet<GplClaim> GplClaims { get; set; }

    public virtual DbSet<GplClaimRegister> GplClaimRegisters { get; set; }

    public virtual DbSet<GplMortalityTable> GplMortalityTables { get; set; }

    public virtual DbSet<GplPolicyBeneficiary> GplPolicyBeneficiaries { get; set; }

    public virtual DbSet<GplPolicyRegisterBase> GplPolicyRegisterBases { get; set; }

    public virtual DbSet<GplPolicyRegisterDetail> GplPolicyRegisterDetails { get; set; }

    public virtual DbSet<GplQuoteTempDetail> GplQuoteTempDetails { get; set; }

    public virtual DbSet<GplRate> GplRates { get; set; }

    public virtual DbSet<IdToCorrect> IdToCorrects { get; set; }

    public virtual DbSet<IngenziDbcustomer> IngenziDbcustomers { get; set; }

    public virtual DbSet<IntegrationTableFreeEducation> IntegrationTableFreeEducations { get; set; }

    public virtual DbSet<InvBank> InvBanks { get; set; }

    public virtual DbSet<InvInvestment> InvInvestments { get; set; }

    public virtual DbSet<Invoicing> Invoicings { get; set; }

    public virtual DbSet<IsicClass> IsicClasses { get; set; }

    public virtual DbSet<LifeClaimsRegister> LifeClaimsRegisters { get; set; }

    public virtual DbSet<ListOfPolicy> ListOfPolicies { get; set; }

    public virtual DbSet<ListOfSendingList> ListOfSendingLists { get; set; }

    public virtual DbSet<LoanCustomer> LoanCustomers { get; set; }

    public virtual DbSet<MaturedPolicy> MaturedPolicies { get; set; }

    public virtual DbSet<MedicalReport> MedicalReports { get; set; }

    public virtual DbSet<MifotraCommitment> MifotraCommitments { get; set; }

    public virtual DbSet<MissingPremium> MissingPremiums { get; set; }

    public virtual DbSet<MomoStatment> MomoStatments { get; set; }

    public virtual DbSet<MomoTelephone> MomoTelephones { get; set; }

    public virtual DbSet<MortalityTableCima> MortalityTableCimas { get; set; }

    public virtual DbSet<MortalityTableKenya> MortalityTableKenyas { get; set; }

    public virtual DbSet<NipdataManagement> NipdataManagements { get; set; }

    public virtual DbSet<NovaBeneficiaire> NovaBeneficiaires { get; set; }

    public virtual DbSet<NovaClient> NovaClients { get; set; }

    public virtual DbSet<NovaPolice> NovaPolices { get; set; }

    public virtual DbSet<OccupationsClass> OccupationsClasses { get; set; }

    public virtual DbSet<OldPoliciesDatum> OldPoliciesData { get; set; }

    public virtual DbSet<PartnersDocumentRequired> PartnersDocumentRequireds { get; set; }

    public virtual DbSet<PartnersDocumentRequiredDatum> PartnersDocumentRequiredData { get; set; }

    public virtual DbSet<PartnersDocumentRequiredHistorical> PartnersDocumentRequiredHistoricals { get; set; }

    public virtual DbSet<PlCell> PlCells { get; set; }

    public virtual DbSet<PlCountry> PlCountries { get; set; }

    public virtual DbSet<PlDistrict> PlDistricts { get; set; }

    public virtual DbSet<PlProvince> PlProvinces { get; set; }

    public virtual DbSet<PlSector> PlSectors { get; set; }

    public virtual DbSet<PlUser> PlUsers { get; set; }

    public virtual DbSet<PlVillage> PlVillages { get; set; }

    public virtual DbSet<ProposalClaim> ProposalClaims { get; set; }

    public virtual DbSet<ProposalConvertTemp> ProposalConvertTemps { get; set; }

    public virtual DbSet<ProposalRegister> ProposalRegisters { get; set; }

    public virtual DbSet<Query> Queries { get; set; }

    public virtual DbSet<QueryCustomer> QueryCustomers { get; set; }

    public virtual DbSet<QueryEducationProposal> QueryEducationProposals { get; set; }

    public virtual DbSet<QuerySavingsProposal> QuerySavingsProposals { get; set; }

    public virtual DbSet<Receipting> Receiptings { get; set; }

    public virtual DbSet<ReceiptingBank> ReceiptingBanks { get; set; }

    public virtual DbSet<ReceivedSm> ReceivedSms { get; set; }

    public virtual DbSet<ReinsuranceCompany> ReinsuranceCompanies { get; set; }

    public virtual DbSet<ReinsuranceRate> ReinsuranceRates { get; set; }

    public virtual DbSet<ReinsuranceRegister> ReinsuranceRegisters { get; set; }

    public virtual DbSet<ReinsuranceTreaty> ReinsuranceTreaties { get; set; }

    public virtual DbSet<ReinsuranceTreaty1> ReinsuranceTreaties1 { get; set; }

    public virtual DbSet<RelationshipType> RelationshipTypes { get; set; }

    public virtual DbSet<RightProductsCommand> RightProductsCommands { get; set; }

    public virtual DbSet<SalesTarget> SalesTargets { get; set; }

    public virtual DbSet<TempCustomer> TempCustomers { get; set; }

    public virtual DbSet<TempCustomers1> TempCustomers1s { get; set; }

    public virtual DbSet<TempInvoicing> TempInvoicings { get; set; }

    public virtual DbSet<TermDeposit> TermDeposits { get; set; }

    public virtual DbSet<View1> View1s { get; set; }

    public virtual DbSet<View11> View11s { get; set; }

    public virtual DbSet<View2> View2s { get; set; }

    public virtual DbSet<View3> View3s { get; set; }

    public virtual DbSet<View4> View4s { get; set; }

    public virtual DbSet<View5> View5s { get; set; }

    public virtual DbSet<View6> View6s { get; set; }

    public virtual DbSet<View7> View7s { get; set; }

    public virtual DbSet<View8> View8s { get; set; }

    public virtual DbSet<View9> View9s { get; set; }

    public virtual DbSet<ViewAkabandoAllPayment> ViewAkabandoAllPayments { get; set; }

    public virtual DbSet<ViewAkabandoAllPaymentsOld> ViewAkabandoAllPaymentsOlds { get; set; }

    public virtual DbSet<ViewAkabandoAllPoliciesNew> ViewAkabandoAllPoliciesNews { get; set; }

    public virtual DbSet<ViewAkabandoAllPoliciesOld> ViewAkabandoAllPoliciesOlds { get; set; }

    public virtual DbSet<ViewAkabandoAllPolicy> ViewAkabandoAllPolicies { get; set; }

    public virtual DbSet<ViewAllChannel> ViewAllChannels { get; set; }

    public virtual DbSet<ViewAllChannelsLoan> ViewAllChannelsLoans { get; set; }

    public virtual DbSet<ViewAllClaimsIkimina> ViewAllClaimsIkiminas { get; set; }

    public virtual DbSet<ViewAllCustomersNotInUse> ViewAllCustomersNotInUses { get; set; }

    public virtual DbSet<ViewAllCustomersTable> ViewAllCustomersTables { get; set; }

    public virtual DbSet<ViewAllInvoicesEducation> ViewAllInvoicesEducations { get; set; }

    public virtual DbSet<ViewAllInvoicesEpi> ViewAllInvoicesEpis { get; set; }

    public virtual DbSet<ViewAllInvoicesFamily> ViewAllInvoicesFamilies { get; set; }

    public virtual DbSet<ViewAllInvoicesLoan> ViewAllInvoicesLoans { get; set; }

    public virtual DbSet<ViewAllInvoicesProduct> ViewAllInvoicesProducts { get; set; }

    public virtual DbSet<ViewAllInvoicesPsEndo> ViewAllInvoicesPsEndos { get; set; }

    public virtual DbSet<ViewAllInvoicesPsMain> ViewAllInvoicesPsMains { get; set; }

    public virtual DbSet<ViewAllOutStandingAllPolicy> ViewAllOutStandingAllPolicies { get; set; }

    public virtual DbSet<ViewAllOutStandingEdu> ViewAllOutStandingEdus { get; set; }

    public virtual DbSet<ViewAllOutStandingEpi> ViewAllOutStandingEpis { get; set; }
    public virtual DbSet<educationTariffs> educationTariffs { get; set; }

    public virtual DbSet<ViewAllOutStandingFamily> ViewAllOutStandingFamilies { get; set; }

    public virtual DbSet<ViewAllOutStandingP> ViewAllOutStandingPs { get; set; }

    public virtual DbSet<ViewAllOutStandingPremium> ViewAllOutStandingPremia { get; set; }

    public virtual DbSet<ViewAllPaymentEducation> ViewAllPaymentEducations { get; set; }

    public virtual DbSet<ViewAllPaymentEpi> ViewAllPaymentEpis { get; set; }

    public virtual DbSet<ViewAllPaymentFamily> ViewAllPaymentFamilies { get; set; }

    public virtual DbSet<ViewAllPaymentLoan> ViewAllPaymentLoans { get; set; }

    public virtual DbSet<ViewAllPaymentPsEndo> ViewAllPaymentPsEndos { get; set; }

    public virtual DbSet<ViewAllPaymentPsEndox> ViewAllPaymentPsEndoxes { get; set; }

    public virtual DbSet<ViewAllPaymentPsMain> ViewAllPaymentPsMains { get; set; }

    public virtual DbSet<ViewAllPoliciesEducation> ViewAllPoliciesEducations { get; set; }

    public virtual DbSet<ViewAllPoliciesEpi> ViewAllPoliciesEpis { get; set; }

    public virtual DbSet<ViewAllPoliciesFamily> ViewAllPoliciesFamilies { get; set; }

    public virtual DbSet<ViewAllPoliciesLoanProtection> ViewAllPoliciesLoanProtections { get; set; }

    public virtual DbSet<ViewAllPoliciesPaymentProduct> ViewAllPoliciesPaymentProducts { get; set; }

    public virtual DbSet<ViewAllPoliciesPaymentProductsNew> ViewAllPoliciesPaymentProductsNews { get; set; }

    public virtual DbSet<ViewAllPoliciesPsAll> ViewAllPoliciesPsAlls { get; set; }

    public virtual DbSet<ViewAllPoliciesPsEndorsement> ViewAllPoliciesPsEndorsements { get; set; }

    public virtual DbSet<ViewAllPoliciesPsMain> ViewAllPoliciesPsMains { get; set; }

    public virtual DbSet<ViewAllPoliciesPsMainStattment> ViewAllPoliciesPsMainStattments { get; set; }

    public virtual DbSet<ViewAllPoliciesRecoveryReport> ViewAllPoliciesRecoveryReports { get; set; }

    public virtual DbSet<ViewAllPoliciesStatment> ViewAllPoliciesStatments { get; set; }

    public virtual DbSet<ViewAllPoliciesWithoutPayment> ViewAllPoliciesWithoutPayments { get; set; }

    public virtual DbSet<ViewAllPolicy> ViewAllPolicies { get; set; }

    public virtual DbSet<ViewAllPolicySignedReturned> ViewAllPolicySignedReturneds { get; set; }

    public virtual DbSet<ViewAllPolicyWithoutBeneficiariesAndProposal> ViewAllPolicyWithoutBeneficiariesAndProposals { get; set; }

    public virtual DbSet<ViewAllPolicyWithoutBeneficiariesAndProposalP> ViewAllPolicyWithoutBeneficiariesAndProposalPs { get; set; }

    public virtual DbSet<ViewAllPolicyWithoutBeneficiary> ViewAllPolicyWithoutBeneficiaries { get; set; }

    public virtual DbSet<ViewAllUsedChannel> ViewAllUsedChannels { get; set; }

    public virtual DbSet<ViewAssetEmployeeDetail> ViewAssetEmployeeDetails { get; set; }

    public virtual DbSet<ViewAssetRegister> ViewAssetRegisters { get; set; }

    public virtual DbSet<ViewAudit> ViewAudits { get; set; }

    public virtual DbSet<ViewAxxisCustomersIngenzi> ViewAxxisCustomersIngenzis { get; set; }

    public virtual DbSet<ViewAxxisCustomersLoanProtection> ViewAxxisCustomersLoanProtections { get; set; }

    public virtual DbSet<ViewAxxisCustomersSaving> ViewAxxisCustomersSavings { get; set; }

    public virtual DbSet<ViewBnrAllAcct> ViewBnrAllAccts { get; set; }

    public virtual DbSet<ViewBnrAllCont> ViewBnrAllConts { get; set; }

    public virtual DbSet<ViewBnrAllCust> ViewBnrAllCusts { get; set; }

    public virtual DbSet<ViewBnrAllCustomersFamily> ViewBnrAllCustomersFamilies { get; set; }

    public virtual DbSet<ViewBnrAllCustomersLoan> ViewBnrAllCustomersLoans { get; set; }

    public virtual DbSet<ViewBnrAllCustomersPensionSaving> ViewBnrAllCustomersPensionSavings { get; set; }

    public virtual DbSet<ViewBnrAllLifeClaim> ViewBnrAllLifeClaims { get; set; }

    public virtual DbSet<ViewBnrValidCastomer> ViewBnrValidCastomers { get; set; }

    public virtual DbSet<ViewCardsPoliciesFamily> ViewCardsPoliciesFamilies { get; set; }

    public virtual DbSet<ViewCardsPoliciesFamilySina> ViewCardsPoliciesFamilySinas { get; set; }

    public virtual DbSet<ViewCheckDuplicationAll> ViewCheckDuplicationAlls { get; set; }

    public virtual DbSet<ViewCheckDuplicationEducation> ViewCheckDuplicationEducations { get; set; }

    public virtual DbSet<ViewCheckDuplicationEpi> ViewCheckDuplicationEpis { get; set; }

    public virtual DbSet<ViewCheckDuplicationFamily> ViewCheckDuplicationFamilies { get; set; }

    public virtual DbSet<ViewCheckDuplicationSaving> ViewCheckDuplicationSavings { get; set; }

    public virtual DbSet<ViewClaimsAmountDueUpdate> ViewClaimsAmountDueUpdates { get; set; }

    public virtual DbSet<ViewClaimsRegisterAll> ViewClaimsRegisterAlls { get; set; }

    public virtual DbSet<ViewClaimsRegisterEducation> ViewClaimsRegisterEducations { get; set; }

    public virtual DbSet<ViewClaimsRegisterIkimina> ViewClaimsRegisterIkiminas { get; set; }

    public virtual DbSet<ViewClaimsRegisterLoanProtection> ViewClaimsRegisterLoanProtections { get; set; }

    public virtual DbSet<ViewClaimsRegisterSaving> ViewClaimsRegisterSavings { get; set; }

    public virtual DbSet<ViewClaimsSavingsValidation> ViewClaimsSavingsValidations { get; set; }

    public virtual DbSet<ViewCommissionsAll> ViewCommissionsAlls { get; set; }

    public virtual DbSet<ViewCommissionsAllReport> ViewCommissionsAllReports { get; set; }

    public virtual DbSet<ViewCommissionsEducation> ViewCommissionsEducations { get; set; }

    public virtual DbSet<ViewCommissionsEducationOld> ViewCommissionsEducationOlds { get; set; }

    public virtual DbSet<ViewCommissionsEpi> ViewCommissionsEpis { get; set; }

    public virtual DbSet<ViewCommissionsFamily> ViewCommissionsFamilies { get; set; }

    public virtual DbSet<ViewCommissionsLoanProtection> ViewCommissionsLoanProtections { get; set; }

    public virtual DbSet<ViewCommissionsPensionSavingsEndorsement> ViewCommissionsPensionSavingsEndorsements { get; set; }

    public virtual DbSet<ViewCommissionsPensionSavingsMain> ViewCommissionsPensionSavingsMains { get; set; }

    public virtual DbSet<ViewConvertedProposalPerAgent> ViewConvertedProposalPerAgents { get; set; }

    public virtual DbSet<ViewCustomerDetailsCleaningLife> ViewCustomerDetailsCleaningLives { get; set; }

    public virtual DbSet<ViewCustomerLoan> ViewCustomerLoans { get; set; }

    public virtual DbSet<ViewCustomerUpdateNidum> ViewCustomerUpdateNida { get; set; }

    public virtual DbSet<ViewCustomerValidation> ViewCustomerValidations { get; set; }

    public virtual DbSet<ViewCustomersValidList> ViewCustomersValidLists { get; set; }

    public virtual DbSet<ViewDigitalAllPayment> ViewDigitalAllPayments { get; set; }

    public virtual DbSet<ViewDigitalCalimsUmurage> ViewDigitalCalimsUmurages { get; set; }

    public virtual DbSet<ViewDigitalCorrectFamillyPayment> ViewDigitalCorrectFamillyPayments { get; set; }

    public virtual DbSet<ViewDigitalNotConvertedReminder> ViewDigitalNotConvertedReminders { get; set; }

    public virtual DbSet<ViewEdicationPaymentStatement> ViewEdicationPaymentStatements { get; set; }

    public virtual DbSet<ViewEducationClaimsProcess> ViewEducationClaimsProcesses { get; set; }

    public virtual DbSet<ViewEducationClaimsUpdate> ViewEducationClaimsUpdates { get; set; }

    public virtual DbSet<ViewEducationMainDdg> ViewEducationMainDdgs { get; set; }

    public virtual DbSet<ViewEducationMember> ViewEducationMembers { get; set; }

    public virtual DbSet<ViewEducationMigrationCustomer> ViewEducationMigrationCustomers { get; set; }

    public virtual DbSet<ViewEducationNewPayment> ViewEducationNewPayments { get; set; }

    public virtual DbSet<ViewEducationPaymentTemp> ViewEducationPaymentTemps { get; set; }

    public virtual DbSet<ViewEducationPolicyDetail> ViewEducationPolicyDetails { get; set; }

    public virtual DbSet<ViewEducationPolicyDetail1> ViewEducationPolicyDetails1 { get; set; }

    public virtual DbSet<ViewEducationPolicyMember> ViewEducationPolicyMembers { get; set; }

    public virtual DbSet<ViewEducationPolicyWithoutBeneficiary> ViewEducationPolicyWithoutBeneficiaries { get; set; }

    public virtual DbSet<ViewEducationPolicyWithoutPayment> ViewEducationPolicyWithoutPayments { get; set; }

    public virtual DbSet<ViewEducationSignedReturned> ViewEducationSignedReturneds { get; set; }

    public virtual DbSet<ViewEducationUpdatePremium> ViewEducationUpdatePremia { get; set; }

    public virtual DbSet<ViewEducationUpdateScheme> ViewEducationUpdateSchemes { get; set; }

    public virtual DbSet<ViewEligiblePoliciesAll> ViewEligiblePoliciesAlls { get; set; }

    public virtual DbSet<ViewEligiblePoliciesAllY> ViewEligiblePoliciesAllies { get; set; }

    public virtual DbSet<ViewEligiblePoliciesEducation> ViewEligiblePoliciesEducations { get; set; }

    public virtual DbSet<ViewEligiblePoliciesEducationY> ViewEligiblePoliciesEducationies { get; set; }

    public virtual DbSet<ViewEligiblePoliciesEpi> ViewEligiblePoliciesEpis { get; set; }

    public virtual DbSet<ViewEligiblePoliciesEpiY> ViewEligiblePoliciesEpiYs { get; set; }

    public virtual DbSet<ViewEligiblePoliciesFamily> ViewEligiblePoliciesFamilies { get; set; }

    public virtual DbSet<ViewEligiblePoliciesFamilyY> ViewEligiblePoliciesFamilyYs { get; set; }

    public virtual DbSet<ViewEligiblePoliciesSavingsEndo> ViewEligiblePoliciesSavingsEndos { get; set; }

    public virtual DbSet<ViewEligiblePoliciesSavingsEndoY> ViewEligiblePoliciesSavingsEndoYs { get; set; }

    public virtual DbSet<ViewEligiblePoliciesSavingsMain> ViewEligiblePoliciesSavingsMains { get; set; }

    public virtual DbSet<ViewEligiblePoliciesSavingsMainY> ViewEligiblePoliciesSavingsMainies { get; set; }

    public virtual DbSet<ViewEmailsAll> ViewEmailsAlls { get; set; }

    public virtual DbSet<ViewEmailsEducation> ViewEmailsEducations { get; set; }

    public virtual DbSet<ViewEmailsFamily> ViewEmailsFamilies { get; set; }

    public virtual DbSet<ViewEmailsLoanProtection> ViewEmailsLoanProtections { get; set; }

    public virtual DbSet<ViewEmailsSaving> ViewEmailsSavings { get; set; }

    public virtual DbSet<ViewEmployeProtection> ViewEmployeProtections { get; set; }

    public virtual DbSet<ViewEpiClaimsProcess> ViewEpiClaimsProcesses { get; set; }

    public virtual DbSet<ViewEpiCombained> ViewEpiCombaineds { get; set; }

    public virtual DbSet<ViewEpiPaymentStatement> ViewEpiPaymentStatements { get; set; }

    public virtual DbSet<ViewEpiPaymentsDetail> ViewEpiPaymentsDetails { get; set; }

    public virtual DbSet<ViewEpiPc> ViewEpiPcs { get; set; }

    public virtual DbSet<ViewEpiPolicyDetail> ViewEpiPolicyDetails { get; set; }

    public virtual DbSet<ViewEpiPolicyWithoutBeneficiary> ViewEpiPolicyWithoutBeneficiaries { get; set; }

    public virtual DbSet<ViewEpiPolicyWithoutPayment> ViewEpiPolicyWithoutPayments { get; set; }

    public virtual DbSet<ViewEpiReportRegisterPayment> ViewEpiReportRegisterPayments { get; set; }

    public virtual DbSet<ViewEpiSignedReturned> ViewEpiSignedReturneds { get; set; }

    public virtual DbSet<ViewExpoCustomerIdentification> ViewExpoCustomerIdentifications { get; set; }

    public virtual DbSet<ViewExpoPensionDetailsTable> ViewExpoPensionDetailsTables { get; set; }

    public virtual DbSet<ViewExpoSavingsPayement> ViewExpoSavingsPayements { get; set; }

    public virtual DbSet<ViewExpoSavingsPolicyRegister> ViewExpoSavingsPolicyRegisters { get; set; }

    public virtual DbSet<ViewExpoSavingsPolicyRegisterDetail> ViewExpoSavingsPolicyRegisterDetails { get; set; }

    public virtual DbSet<ViewFamilyClaimsProcess> ViewFamilyClaimsProcesses { get; set; }

    public virtual DbSet<ViewFamilyCleanCustomer> ViewFamilyCleanCustomers { get; set; }

    public virtual DbSet<ViewFamilyInvoice> ViewFamilyInvoices { get; set; }

    public virtual DbSet<ViewFamilyMemberCreationDate> ViewFamilyMemberCreationDates { get; set; }

    public virtual DbSet<ViewFamilyPayment> ViewFamilyPayments { get; set; }

    public virtual DbSet<ViewFamilyPaymentStatement> ViewFamilyPaymentStatements { get; set; }

    public virtual DbSet<ViewFamilyPaymentStatementMax> ViewFamilyPaymentStatementMaxes { get; set; }

    public virtual DbSet<ViewFamilyPolicyWithoutBeneficiary> ViewFamilyPolicyWithoutBeneficiaries { get; set; }

    public virtual DbSet<ViewFamilyPolicyWithoutPayment> ViewFamilyPolicyWithoutPayments { get; set; }

    public virtual DbSet<ViewFamilyProvision> ViewFamilyProvisions { get; set; }

    public virtual DbSet<ViewFamilyRegister> ViewFamilyRegisters { get; set; }

    public virtual DbSet<ViewFamilySaving> ViewFamilySavings { get; set; }

    public virtual DbSet<ViewFamilySignedReturned> ViewFamilySignedReturneds { get; set; }

    public virtual DbSet<ViewFirstPaymentEducation> ViewFirstPaymentEducations { get; set; }

    public virtual DbSet<ViewFirstPaymentEpi> ViewFirstPaymentEpis { get; set; }

    public virtual DbSet<ViewFirstPaymentFamily> ViewFirstPaymentFamilies { get; set; }

    public virtual DbSet<ViewGroupBusinessDataCollection> ViewGroupBusinessDataCollections { get; set; }

    public virtual DbSet<ViewIkiminaOnLinePayment> ViewIkiminaOnLinePayments { get; set; }

    public virtual DbSet<ViewIkiminaPayment> ViewIkiminaPayments { get; set; }

    public virtual DbSet<ViewInvoiceDuplication> ViewInvoiceDuplications { get; set; }

    public virtual DbSet<ViewInvoicingEpi> ViewInvoicingEpis { get; set; }

    public virtual DbSet<ViewListAllVendor> ViewListAllVendors { get; set; }

    public virtual DbSet<ViewListOfAllProposal> ViewListOfAllProposals { get; set; }

    public virtual DbSet<ViewListPolicyEducation> ViewListPolicyEducations { get; set; }

    public virtual DbSet<ViewListSalesAgent> ViewListSalesAgents { get; set; }

    public virtual DbSet<ViewMigrationEpiInvoice> ViewMigrationEpiInvoices { get; set; }

    public virtual DbSet<ViewMigrationEpiMember> ViewMigrationEpiMembers { get; set; }

    public virtual DbSet<ViewMigrationEpiPolicy> ViewMigrationEpiPolicies { get; set; }

    public virtual DbSet<ViewMigrationEpiReceipting> ViewMigrationEpiReceiptings { get; set; }

    public virtual DbSet<ViewMomoAll> ViewMomoAlls { get; set; }

    public virtual DbSet<ViewMomoEducation> ViewMomoEducations { get; set; }

    public virtual DbSet<ViewMomoEpi> ViewMomoEpis { get; set; }

    public virtual DbSet<ViewMomoFamily> ViewMomoFamilies { get; set; }

    public virtual DbSet<ViewMomoNotAllocatedEducation> ViewMomoNotAllocatedEducations { get; set; }

    public virtual DbSet<ViewMomoNotAllocatedIkimina> ViewMomoNotAllocatedIkiminas { get; set; }

    public virtual DbSet<ViewMomoNotAllocatedP> ViewMomoNotAllocatedPs { get; set; }

    public virtual DbSet<ViewMomoPensionSaving> ViewMomoPensionSavings { get; set; }

    public virtual DbSet<ViewMomoStatmentOnlineTransaction> ViewMomoStatmentOnlineTransactions { get; set; }

    public virtual DbSet<ViewNewBusinessAll> ViewNewBusinessAlls { get; set; }

    public virtual DbSet<ViewNewBusinessEducation> ViewNewBusinessEducations { get; set; }

    public virtual DbSet<ViewNewBusinessEpi> ViewNewBusinessEpis { get; set; }

    public virtual DbSet<ViewNewBusinessFamily> ViewNewBusinessFamilies { get; set; }

    public virtual DbSet<ViewNkunganireAllPayment> ViewNkunganireAllPayments { get; set; }

    public virtual DbSet<ViewNkunganireAllPaymentsPartner> ViewNkunganireAllPaymentsPartners { get; set; }

    public virtual DbSet<ViewNkunganireAllPoliciesPartner> ViewNkunganireAllPoliciesPartners { get; set; }

    public virtual DbSet<ViewNkunganireAllPolicy> ViewNkunganireAllPolicies { get; set; }

    public virtual DbSet<ViewNovanet> ViewNovanets { get; set; }

    public virtual DbSet<ViewOk> ViewOks { get; set; }

    public virtual DbSet<ViewOldPymt> ViewOldPymts { get; set; }

    public virtual DbSet<ViewPoliciesAll> ViewPoliciesAlls { get; set; }

    public virtual DbSet<ViewPoliciesAllEducation> ViewPoliciesAllEducations { get; set; }

    public virtual DbSet<ViewPoliciesAllEpi> ViewPoliciesAllEpis { get; set; }

    public virtual DbSet<ViewPoliciesAllFamily> ViewPoliciesAllFamilies { get; set; }

    public virtual DbSet<ViewPoliciesAllGroupLife> ViewPoliciesAllGroupLives { get; set; }

    public virtual DbSet<ViewPoliciesAllSavingsEndorsment> ViewPoliciesAllSavingsEndorsments { get; set; }

    public virtual DbSet<ViewPoliciesAllSavingsMain> ViewPoliciesAllSavingsMains { get; set; }

    public virtual DbSet<ViewPolicyDetail> ViewPolicyDetails { get; set; }

    public virtual DbSet<ViewPolicyFamilly> ViewPolicyFamillies { get; set; }

    public virtual DbSet<ViewPolicyPerUser> ViewPolicyPerUsers { get; set; }

    public virtual DbSet<ViewProposalConvertedStatus> ViewProposalConvertedStatuses { get; set; }

    public virtual DbSet<ViewProposalCoverter> ViewProposalCoverters { get; set; }

    public virtual DbSet<ViewProposalDetail> ViewProposalDetails { get; set; }

    public virtual DbSet<ViewProposalDetailsPrinting> ViewProposalDetailsPrintings { get; set; }

    public virtual DbSet<ViewProposalDueDate> ViewProposalDueDates { get; set; }

    public virtual DbSet<ViewProposalEducation> ViewProposalEducations { get; set; }

    public virtual DbSet<ViewProposalEducationCombo> ViewProposalEducationCombos { get; set; }

    public virtual DbSet<ViewProposalEmployeeProtection> ViewProposalEmployeeProtections { get; set; }

    public virtual DbSet<ViewProposalRegister> ViewProposalRegisters { get; set; }

    public virtual DbSet<ViewProposalRegisterNoMember> ViewProposalRegisterNoMembers { get; set; }

    public virtual DbSet<ViewProposalRegistersTemp> ViewProposalRegistersTemps { get; set; }

    public virtual DbSet<ViewProposalSaving> ViewProposalSavings { get; set; }

    public virtual DbSet<ViewProposalWithoutBeneficiary> ViewProposalWithoutBeneficiaries { get; set; }

    public virtual DbSet<ViewReceiptingEpi> ViewReceiptingEpis { get; set; }

    public virtual DbSet<ViewReinsuranceDataAll> ViewReinsuranceDataAlls { get; set; }

    public virtual DbSet<ViewReinsuranceDataEpi> ViewReinsuranceDataEpis { get; set; }

    public virtual DbSet<ViewReinsuranceDataFamilly> ViewReinsuranceDataFamillies { get; set; }

    public virtual DbSet<ViewReinsuranceDataGpl> ViewReinsuranceDataGpls { get; set; }

    public virtual DbSet<ViewReinsuranceDataLoanProtection> ViewReinsuranceDataLoanProtections { get; set; }

    public virtual DbSet<ViewReinsuranceDataPensionEndo> ViewReinsuranceDataPensionEndos { get; set; }

    public virtual DbSet<ViewReinsuranceDataPensionMain> ViewReinsuranceDataPensionMains { get; set; }

    public virtual DbSet<ViewRiskSavingsFamEpi> ViewRiskSavingsFamEpis { get; set; }

    public virtual DbSet<ViewSalesAgentEligibleStatus> ViewSalesAgentEligibleStatuses { get; set; }

    public virtual DbSet<ViewSavingsPaymentEndoDdg> ViewSavingsPaymentEndoDdgs { get; set; }

    public virtual DbSet<ViewSavingsPaymentMainDdg> ViewSavingsPaymentMainDdgs { get; set; }

    public virtual DbSet<ViewSavingsTelephoneValidation> ViewSavingsTelephoneValidations { get; set; }

    public virtual DbSet<ViewSingleInvoiceAll> ViewSingleInvoiceAlls { get; set; }

    public virtual DbSet<ViewSingleInvoiceEducation> ViewSingleInvoiceEducations { get; set; }

    public virtual DbSet<ViewSingleInvoiceEpi> ViewSingleInvoiceEpis { get; set; }

    public virtual DbSet<ViewSingleInvoiceFamily> ViewSingleInvoiceFamilies { get; set; }

    public virtual DbSet<ViewSms15LoanProtection> ViewSms15LoanProtections { get; set; }

    public virtual DbSet<ViewSms5Education> ViewSms5Educations { get; set; }

    public virtual DbSet<ViewSms5Epi> ViewSms5Epis { get; set; }

    public virtual DbSet<ViewSms5Family> ViewSms5Families { get; set; }

    public virtual DbSet<ViewSms5PsEndoPension> ViewSms5PsEndoPensions { get; set; }

    public virtual DbSet<ViewSms5PsEndoSaving> ViewSms5PsEndoSavings { get; set; }

    public virtual DbSet<ViewSms5PsMainPension> ViewSms5PsMainPensions { get; set; }

    public virtual DbSet<ViewSms5PsMainSaving> ViewSms5PsMainSavings { get; set; }

    public virtual DbSet<ViewSms5PsPension> ViewSms5PsPensions { get; set; }

    public virtual DbSet<ViewSms5PsSaving> ViewSms5PsSavings { get; set; }

    public virtual DbSet<ViewSmsAnniversary> ViewSmsAnniversaries { get; set; }

    public virtual DbSet<ViewSmsAnniversarySend> ViewSmsAnniversarySends { get; set; }

    public virtual DbSet<ViewSmsDigitalFamilyNotConverted> ViewSmsDigitalFamilyNotConverteds { get; set; }

    public virtual DbSet<ViewSmsDigitalIkiminaNotConverted> ViewSmsDigitalIkiminaNotConverteds { get; set; }

    public virtual DbSet<ViewSmsDigitalPendingPayment> ViewSmsDigitalPendingPayments { get; set; }

    public virtual DbSet<ViewSmsLapsedEpi> ViewSmsLapsedEpis { get; set; }

    public virtual DbSet<ViewSmsLapsedFamily> ViewSmsLapsedFamilies { get; set; }

    public virtual DbSet<ViewTransUnionCustomersAll> ViewTransUnionCustomersAlls { get; set; }

    public virtual DbSet<ViewTransUnionCustomersIngenzi> ViewTransUnionCustomersIngenzis { get; set; }

    public virtual DbSet<ViewTransUnionPolicyDetailsEducation> ViewTransUnionPolicyDetailsEducations { get; set; }

    public virtual DbSet<ViewTransUnionPolicyDetailsEpi> ViewTransUnionPolicyDetailsEpis { get; set; }

    public virtual DbSet<ViewTransUnionPolicyDetailsFamily> ViewTransUnionPolicyDetailsFamilies { get; set; }

    public virtual DbSet<ViewUmurageActuarialValuation> ViewUmurageActuarialValuations { get; set; }

    public virtual DbSet<ViewUmurageAllPayment> ViewUmurageAllPayments { get; set; }

    public virtual DbSet<ViewUmurageAllPolicy> ViewUmurageAllPolicies { get; set; }

    public virtual DbSet<ViewUpdateCustomerEducation> ViewUpdateCustomerEducations { get; set; }

    public virtual DbSet<ViewUpdateCustomerIngenzi> ViewUpdateCustomerIngenzis { get; set; }

    public virtual DbSet<ViewUpdateCustomersInPayementFamily> ViewUpdateCustomersInPayementFamilies { get; set; }

    public virtual DbSet<ViewUpdateEdicationRegisterClaim> ViewUpdateEdicationRegisterClaims { get; set; }

    public virtual DbSet<ViewUpdateEpiSaving> ViewUpdateEpiSavings { get; set; }

    public virtual DbSet<ViewUpdateEpiregisterClaim> ViewUpdateEpiregisterClaims { get; set; }

    public virtual DbSet<ViewUpdateFamilyInvPayment> ViewUpdateFamilyInvPayments { get; set; }

    public virtual DbSet<ViewUpdateFamilyRegisterClaim> ViewUpdateFamilyRegisterClaims { get; set; }

    public virtual DbSet<ViewUpdateFamilySaving> ViewUpdateFamilySavings { get; set; }

    public virtual DbSet<ViewUpdatePolicyEducation> ViewUpdatePolicyEducations { get; set; }

    public virtual DbSet<ViewUpdatePolicyEpi> ViewUpdatePolicyEpis { get; set; }

    public virtual DbSet<ViewUpdatePolicyFamily> ViewUpdatePolicyFamilies { get; set; }

    public virtual DbSet<ViewUpdatePolicyPension> ViewUpdatePolicyPensions { get; set; }

    public virtual DbSet<ViewUpdateProposalRegister> ViewUpdateProposalRegisters { get; set; }

    public virtual DbSet<ViewUpdateRegisterEpi> ViewUpdateRegisterEpis { get; set; }

    public virtual DbSet<ViewUpdateRegisterFamilly> ViewUpdateRegisterFamillies { get; set; }

    public virtual DbSet<ViewUpdateSchemeEpi> ViewUpdateSchemeEpis { get; set; }

    public virtual DbSet<ViewUpdateSchemeEpiRegister> ViewUpdateSchemeEpiRegisters { get; set; }

    public virtual DbSet<ViewUpdateSchemeFamily> ViewUpdateSchemeFamilies { get; set; }

    public virtual DbSet<ViewUsersInactiveAgent> ViewUsersInactiveAgents { get; set; }

    public virtual DbSet<ViewZamaraActuarialValuationEducation> ViewZamaraActuarialValuationEducations { get; set; }

    public virtual DbSet<ViewZamaraActuarialValuationEpi> ViewZamaraActuarialValuationEpis { get; set; }

    public virtual DbSet<ViewZamaraActuarialValuationEpiMember> ViewZamaraActuarialValuationEpiMembers { get; set; }

    public virtual DbSet<ViewZamaraActuarialValuationFamily> ViewZamaraActuarialValuationFamilies { get; set; }

    public virtual DbSet<ViewZamaraActuarialValuationFamilyMember> ViewZamaraActuarialValuationFamilyMembers { get; set; }

    public virtual DbSet<ViewZamaraActuarialValuationUmurage> ViewZamaraActuarialValuationUmurages { get; set; }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see https://go.microsoft.com/fwlink/?LinkId=723263.
        => optionsBuilder.UseSqlServer("name=SqlConnectionToIngenzi");

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<AdministrativeLocation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AdministrativeLocation");

            entity.Property(e => e.Cellule).HasMaxLength(255);
            entity.Property(e => e.CodeCell)
                .HasMaxLength(255)
                .HasColumnName("Code_cell");
            entity.Property(e => e.CodeDistrict)
                .HasMaxLength(255)
                .HasColumnName("code_District");
            entity.Property(e => e.CodeProvince)
                .HasMaxLength(255)
                .HasColumnName("Code_Province");
            entity.Property(e => e.CodeSector)
                .HasMaxLength(255)
                .HasColumnName("Code_Sector");
            entity.Property(e => e.CodeVillage)
                .HasMaxLength(50)
                .HasColumnName("Code_village");
            entity.Property(e => e.District).HasMaxLength(255);
            entity.Property(e => e.MapLocation).HasMaxLength(255);
            entity.Property(e => e.Province).HasMaxLength(255);
            entity.Property(e => e.Sector).HasMaxLength(255);
            entity.Property(e => e.SlNo)
                .ValueGeneratedOnAdd()
                .HasColumnName("Sl_No");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.Village).HasMaxLength(255);
        });

        modelBuilder.Entity<AllPoliciesValidated>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("All policies_Validated");

            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.Names).HasMaxLength(255);
            entity.Property(e => e.Paymentdate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyStatus).HasMaxLength(255);
            entity.Property(e => e.Product).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });
         modelBuilder.Entity<educationTariffs>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("educationTariffs");

            entity.Property(e => e.BenefitYears).HasColumnName("Benefit_years");
            entity.Property(e => e.ContributionYears).HasColumnName("Contribution_years");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Premium_frequency");
            entity.Property(e => e.RatePerMille).HasColumnName("rate_per_mille");
        });

        modelBuilder.Entity<AssetCategory>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("ASSET_CATEGORY");

            entity.Property(e => e.CategoryId)
                .HasMaxLength(20)
                .HasColumnName("CATEGORY_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .HasColumnName("CATEGORY_NAME");
        });

        modelBuilder.Entity<AssetDepartment>(entity =>
        {
            entity.HasKey(e => e.DepartmentId);

            entity.ToTable("ASSET_DEPARTMENTS");

            entity.Property(e => e.DepartmentId)
                .HasMaxLength(20)
                .HasColumnName("Department_ID");
            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("Department_Name");
            entity.Property(e => e.PDepartmentId)
                .HasMaxLength(20)
                .HasColumnName("P_Department_ID");
        });

        modelBuilder.Entity<AssetEmployee>(entity =>
        {
            entity.HasKey(e => e.EmployeeId);

            entity.ToTable("ASSET_EMPLOYEES");

            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.DepartmentId)
                .HasMaxLength(50)
                .HasColumnName("DepartmentID");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IdJobTitle).HasMaxLength(200);
            entity.Property(e => e.NationalId)
                .HasMaxLength(20)
                .HasColumnName("NationalID");
            entity.Property(e => e.StartDate).HasPrecision(3);
        });

        modelBuilder.Entity<AssetItem>(entity =>
        {
            entity.HasKey(e => e.CodeItem);

            entity.ToTable("ASSET_ITEMS");

            entity.Property(e => e.CodeItem).HasMaxLength(20);
            entity.Property(e => e.AquisitionDate).HasColumnType("datetime");
            entity.Property(e => e.Barcode).HasMaxLength(20);
            entity.Property(e => e.CategoryId)
                .HasMaxLength(20)
                .HasColumnName("Category_ID");
            entity.Property(e => e.Comments).HasMaxLength(255);
            entity.Property(e => e.ItemDescription).HasMaxLength(100);
            entity.Property(e => e.Nbv).HasColumnName("NBV");
            entity.Property(e => e.SerialNumber).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<AssetMovement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ASSET_MOVEMENTS");

            entity.Property(e => e.AssignedDate).HasColumnType("datetime");
            entity.Property(e => e.CodeItem).HasMaxLength(20);
            entity.Property(e => e.Comments).HasMaxLength(255);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(20)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.InRecords).ValueGeneratedOnAdd();
            entity.Property(e => e.ItemLocation).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(10);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<AtDeletedPayement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("AT_Deleted_Payements");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DeletedByUserId).HasMaxLength(50);
            entity.Property(e => e.DeletedDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<AuditCustomersInfo>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Audit_CustomersInfo");

            entity.Property(e => e.Comments).HasMaxLength(300);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("Last_Name");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.RecoredDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<AxxisMigrationIngenziContact>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("Axxis_Migration_Ingenzi_Contact");

            entity.Property(e => e.Address1)
                .HasMaxLength(50)
                .HasColumnName("address1");
            entity.Property(e => e.Address2)
                .HasMaxLength(50)
                .HasColumnName("address2");
            entity.Property(e => e.BankAccount).HasColumnName("bankAccount");
            entity.Property(e => e.Birth)
                .HasColumnType("datetime")
                .HasColumnName("birth");
            entity.Property(e => e.BranchId).HasColumnName("BRANCH ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasColumnName("BRANCH NAME");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CategoryType)
                .HasMaxLength(50)
                .HasColumnName("CATEGORY TYPE");
            entity.Property(e => e.City)
                .HasMaxLength(50)
                .HasColumnName("city");
            entity.Property(e => e.Created).HasColumnName("created");
            entity.Property(e => e.Education).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployerContactPerson)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER CONTACT PERSON");
            entity.Property(e => e.EmployerContactPersonNumber)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER CONTACT PERSON NUMBER");
            entity.Property(e => e.EmployerFullAddress)
                .HasMaxLength(200)
                .HasColumnName("EMPLOYER FULL ADDRESS");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER NAME");
            entity.Property(e => e.EmployerPhone)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER PHONE");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(50)
                .HasColumnName("HOUSE NUMBER");
            entity.Property(e => e.IdType)
                .HasMaxLength(50)
                .HasColumnName("idType");
            entity.Property(e => e.Inactive).HasColumnName("inactive");
            entity.Property(e => e.IsPerson)
                .HasMaxLength(21)
                .IsUnicode(false)
                .HasColumnName("isPerson");
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("middleName");
            entity.Property(e => e.MigrationCode)
                .HasMaxLength(14)
                .HasColumnName("Migration_Code");
            entity.Property(e => e.Name)
                .HasMaxLength(450)
                .HasColumnName("name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.Nif)
                .HasMaxLength(50)
                .HasColumnName("nif");
            entity.Property(e => e.NumberOfDependents).HasColumnName("NUMBER OF DEPENDENTS");
            entity.Property(e => e.OccupationId)
                .HasMaxLength(50)
                .HasColumnName("occupationId");
            entity.Property(e => e.Phone)
                .HasMaxLength(50)
                .HasColumnName("phone");
            entity.Property(e => e.Phone1)
                .HasMaxLength(50)
                .HasColumnName("phone1");
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(50)
                .HasColumnName("PLACE OF BIRTH");
            entity.Property(e => e.ReferenceIfJoint).HasColumnName("REFERENCE IF JOINT");
            entity.Property(e => e.RelatedParty)
                .HasMaxLength(100)
                .HasColumnName("RELATED PARTY");
            entity.Property(e => e.ResidenceCell)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE CELL");
            entity.Property(e => e.ResidenceDistrict)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE DISTRICT");
            entity.Property(e => e.ResidenceProvince)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE PROVINCE");
            entity.Property(e => e.ResidenceSector)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE SECTOR");
            entity.Property(e => e.ResidenceVillage)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE VILLAGE");
            entity.Property(e => e.Sector)
                .HasMaxLength(50)
                .HasColumnName("sector");
            entity.Property(e => e.SocialEconomicClass).HasColumnName("SOCIAL ECONOMIC CLASS");
            entity.Property(e => e.State)
                .HasMaxLength(50)
                .HasColumnName("state");
            entity.Property(e => e.StreetNumber)
                .HasMaxLength(50)
                .HasColumnName("STREET NUMBER");
            entity.Property(e => e.Surname1)
                .HasMaxLength(450)
                .HasColumnName("surname1");
            entity.Property(e => e.Title)
                .HasMaxLength(50)
                .HasColumnName("title");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("USER ID");
            entity.Property(e => e.Zip).HasColumnName("zip");
        });

        modelBuilder.Entity<BnrErrorLog>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BNR_ErrorLog");

            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.ErrorDescription).HasMaxLength(500);
            entity.Property(e => e.TransactionDate).HasColumnType("datetime");
            entity.Property(e => e.TransactionId)
                .HasMaxLength(50)
                .HasColumnName("TransactionID");
            entity.Property(e => e.TransactionType).HasMaxLength(50);
        });

        modelBuilder.Entity<BnrOccupation>(entity =>
        {
            entity.HasKey(e => e.Occupation);

            entity.ToTable("BNR_Occupation");

            entity.Property(e => e.Occupation).HasMaxLength(4);
            entity.Property(e => e.OccupationDescription)
                .HasMaxLength(150)
                .HasColumnName("Occupation_Description");
        });

        modelBuilder.Entity<Bnrdatacollected>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("BNRDATACOLLECTED");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(255);
            entity.Property(e => e.Idn).HasColumnName("IDN");
            entity.Property(e => e.Products).HasMaxLength(255);
        });

        modelBuilder.Entity<ClaimsNotifyListReceiver>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ClaimsNotifyListReceiver");

            entity.Property(e => e.ClaimOfficerName).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ClaimsRegisterManagement>(entity =>
        {
            entity.HasKey(e => e.ClaimNumberUpdate);

            entity.ToTable("ClaimsRegisterManagement");

            entity.Property(e => e.ClaimNumberUpdate).HasMaxLength(50);
            entity.Property(e => e.AmountOfClaimReserveCfv).HasColumnName("AmountOfClaimReserve_CFV");
            entity.Property(e => e.ApprovedModByUser).HasMaxLength(100);
            entity.Property(e => e.ApprovedModDate).HasColumnType("datetime");
            entity.Property(e => e.BeneficiaryNames).HasMaxLength(100);
            entity.Property(e => e.ClaimDeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(50);
            entity.Property(e => e.ClaimSettlementDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimStatus).HasMaxLength(50);
            entity.Property(e => e.Comment).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(255);
            entity.Property(e => e.CreatedByUser).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IdentificationNumber).HasMaxLength(50);
            entity.Property(e => e.IncidentDate).HasColumnType("datetime");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.NameOfProduct).HasMaxLength(50);
            entity.Property(e => e.NumOfPreviousClaims).HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.PenaltiesAdvanceSurrender).HasColumnName("PenaltiesAdvance_Surrender");
            entity.Property(e => e.PlaceOfIncident).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus).HasMaxLength(50);
            entity.Property(e => e.PolicyholderName).HasMaxLength(100);
            entity.Property(e => e.RecoredDate).HasColumnType("datetime");
            entity.Property(e => e.RelationshipPolicyholder).HasMaxLength(100);
            entity.Property(e => e.SalesAgent).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SubmissionDateOfLastDocument).HasColumnType("datetime");
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.TypeofClaim).HasMaxLength(50);
        });

        modelBuilder.Entity<CorporateRegistrationType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CorporateRegistrationType");

            entity.Property(e => e.CompanyType).HasMaxLength(50);
            entity.Property(e => e.IntAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<CountryList>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CountryList");

            entity.Property(e => e.Country).HasMaxLength(100);
        });

        modelBuilder.Entity<Customer>(entity =>
        {
            entity.HasKey(e => e.CustomerCode);

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CategoryType).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Education).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployerContactPerson).HasMaxLength(50);
            entity.Property(e => e.EmployerContactPersonNumber).HasMaxLength(50);
            entity.Property(e => e.EmployerFullAdress).HasMaxLength(200);
            entity.Property(e => e.EmployerName).HasMaxLength(50);
            entity.Property(e => e.EmployerPhone).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.HouseNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
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
            entity.Property(e => e.NumberOfDependants).HasColumnName("Number_Of_Dependants");
            entity.Property(e => e.Occupation).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_2");
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(50);
            entity.Property(e => e.RelatedParty)
                .HasMaxLength(100)
                .HasColumnName("Related_Party");
            entity.Property(e => e.ResidenceCell).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.ResidenceVillage).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SocialEconomicClass).HasColumnName("Social_Economic_Class");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.StreetNumber).HasMaxLength(50);
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("UserID");
        });

        modelBuilder.Entity<CustomerDetailsCleaningLife>(entity =>
        {
            entity.HasKey(e => e.IdDocumentNumber);

            entity.ToTable("CustomerDetailsCleaningLife");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Forename).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(150);
            entity.Property(e => e.Village).HasMaxLength(50);
            entity.Property(e => e.VillageId).HasMaxLength(50);
        });

        modelBuilder.Entity<CustomerValidation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("CustomerValidation");

            entity.Property(e => e.FullNames).HasMaxLength(255);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(20);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<CustomersUser>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("Customers_User");

            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Names).HasMaxLength(100);
            entity.Property(e => e.NationalId)
                .HasMaxLength(50)
                .HasColumnName("NationalID");
            entity.Property(e => e.Otpcode)
                .HasMaxLength(50)
                .HasColumnName("OTPCode");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<DataOtherPayement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DataOtherPayements$");

            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.FinanceUserId).HasMaxLength(255);
            entity.Property(e => e.FullName).HasMaxLength(255);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(255)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(255)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(255)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Premium Recorded Date");
            entity.Property(e => e.ProductType).HasMaxLength(255);
            entity.Property(e => e.ReferencePay).HasMaxLength(255);
            entity.Property(e => e.ReportingMonths).HasMaxLength(255);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(255)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SubProductType).HasMaxLength(255);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(255);
        });

        modelBuilder.Entity<DeliveryConvertedPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Delivery_Converted_Policy");

            entity.Property(e => e.AcceptedTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("Accepted_timestamp");
            entity.Property(e => e.ConvertedTime)
                .HasColumnType("datetime")
                .HasColumnName("Converted_time");
            entity.Property(e => e.CustEmail)
                .HasMaxLength(200)
                .IsUnicode(false)
                .HasColumnName("Cust_email");
            entity.Property(e => e.CustPhone)
                .HasMaxLength(50)
                .HasColumnName("Cust_Phone");
            entity.Property(e => e.DeliveryTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("delivery_timestamp");
            entity.Property(e => e.Feedback)
                .HasMaxLength(800)
                .HasComment("This may contain the feedback/reason for rejecting contract");
            entity.Property(e => e.FullName).HasColumnType("text");
            entity.Property(e => e.Id)
                .ValueGeneratedOnAdd()
                .HasColumnName("ID");
            entity.Property(e => e.MessageDesc)
                .HasMaxLength(1000)
                .IsUnicode(false)
                .HasColumnName("Message_desc");
            entity.Property(e => e.MessageSent)
                .HasDefaultValue(0)
                .HasComment("0 is False and 1 is True ")
                .HasColumnName("Message_sent");
            entity.Property(e => e.OtpNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Otp_number");
            entity.Property(e => e.OtpVerified)
                .HasDefaultValue(0)
                .HasComment("0 stand for not yet verified and 1 is when verified")
                .HasColumnName("Otp_verified");
            entity.Property(e => e.OtpVerifiedTimestamp)
                .HasColumnType("datetime")
                .HasColumnName("Otp_verified_timestamp");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasColumnName("Policy_number");
            entity.Property(e => e.Product)
                .HasMaxLength(50)
                .IsUnicode(false);
            entity.Property(e => e.Status)
                .HasMaxLength(50)
                .IsUnicode(false)
                .HasDefaultValue("Pending")
                .HasComment("This will have 3 status such as Pending, Rejected, Accepted ");
        });

        modelBuilder.Entity<DistributionChannel>(entity =>
        {
            entity.ToTable("DistributionChannel");

            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.ChannelAdress).HasMaxLength(250);
            entity.Property(e => e.ChannelContactEmail).HasMaxLength(50);
            entity.Property(e => e.ChannelContactTelephone).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.InRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("inRecord");
            entity.Property(e => e.LicenceId)
                .HasMaxLength(50)
                .HasColumnName("LicenceID");
            entity.Property(e => e.Status).HasDefaultValue(true);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<DistributionChannelLogin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("DistributionChannelLogin");

            entity.Property(e => e.ChannelName).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
        });

        modelBuilder.Entity<EducationAnnuitiesBill>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_AnnuitiesBills");

            entity.Property(e => e.BillNumber)
                .HasMaxLength(30)
                .HasColumnName("Bill_Number");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.CustomerCode).HasMaxLength(30);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PayUserName).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentStatus).HasColumnName("Payment_Status");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.RecordUserName).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.TypeOfPayment).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationBaseMprovision>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_BaseMProvision");

            entity.Property(e => e.BusinessType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MathematicalProvisionTmp).HasColumnName("MathematicalProvisionTMP");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecorededDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationBaseMprovisionMigration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_BaseMProvisionMigration");

            entity.Property(e => e.BusinessType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.MathematicalProvisionTmp).HasColumnName("MathematicalProvisionTMP");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecorededDate).HasColumnType("smalldatetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Claims");

            entity.Property(e => e.BenefitsPayment).HasMaxLength(50);
            entity.Property(e => e.Ceoaction)
                .HasMaxLength(50)
                .HasColumnName("CEOAction");
            entity.Property(e => e.CeoapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CEOApprovedDate");
            entity.Property(e => e.CeoapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CEOApprovedUserName");
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(50)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.ClaimentId)
                .HasMaxLength(50)
                .HasColumnName("ClaimentID");
            entity.Property(e => e.Cmaction)
                .HasMaxLength(50)
                .HasColumnName("CMAction");
            entity.Property(e => e.CmapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CMApprovedDate");
            entity.Property(e => e.CmapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CMApprovedUserName");
            entity.Property(e => e.CustomerCode).HasMaxLength(30);
            entity.Property(e => e.DateLastDocument).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IdlifeInsured).HasColumnName("IDLifeInsured");
            entity.Property(e => e.IdofBeneficiary).HasColumnName("IDOfBeneficiary");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(250);
            entity.Property(e => e.OperationStatus).HasMaxLength(50);
            entity.Property(e => e.PhysicalLossIncurred).HasColumnName("Physical_Loss_Incurred");
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(150)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordUserName).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(10)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SurrenderType)
                .HasMaxLength(50)
                .HasColumnName("Surrender_Type");
            entity.Property(e => e.SurrenderValue).HasColumnName("Surrender_Value");
            entity.Property(e => e.Tdaction)
                .HasMaxLength(50)
                .HasColumnName("TDAction");
            entity.Property(e => e.TdapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("TDApprovedDate");
            entity.Property(e => e.TdapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("TDApprovedUserName");
            entity.Property(e => e.TotalLoan).HasColumnName("Total_Loan");
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
        });

        modelBuilder.Entity<EducationClaimsBeneficiary>(entity =>
        {
            entity.HasKey(e => new { e.ClaimNumber, e.MemberCode });

            entity.ToTable("Education_ClaimsBeneficiaries");

            entity.Property(e => e.ClaimNumber).HasMaxLength(50);
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.BankAccount).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationClaimsBill>(entity =>
        {
            entity.HasKey(e => new { e.ClaimNumber, e.PolicyNumber });

            entity.ToTable("Education_Claims_Bills");

            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.BillDueDate)
                .HasColumnType("datetime")
                .HasColumnName("Bill_Due_Date");
            entity.Property(e => e.ClaimAmountDue).HasColumnName("Claim_Amount_Due");
            entity.Property(e => e.ClaimBillNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Bill_Number");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.CustomerCode).HasMaxLength(30);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordUserName).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EducationClaimsBillsPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Claims_Bills_Payments");

            entity.Property(e => e.BankAccount).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(150);
            entity.Property(e => e.BillPaiementDate)
                .HasColumnType("datetime")
                .HasColumnName("Bill_Paiement_Date");
            entity.Property(e => e.ClaimAmountPaid).HasColumnName("Claim_Amount_Paid");
            entity.Property(e => e.ClaimBillNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Bill_Number");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.CustomerCode).HasMaxLength(30);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordUserName).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EducationCommission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EDUCATION_Commissions");

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

        modelBuilder.Entity<EducationFreePayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Free_Payments");

            entity.Property(e => e.CustomerCode).HasMaxLength(30);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IntegrationDate).HasColumnType("datetime");
            entity.Property(e => e.NDuration).HasColumnName("nDuration");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.ValueDate).HasColumnType("datetime");
            entity.Property(e => e.XAge).HasColumnName("xAge");
        });

        modelBuilder.Entity<EducationFreeTarifNewRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Free_Tarif_NewRate");
        });

        modelBuilder.Entity<EducationIntegrationTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Integration_Table");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerNames).HasMaxLength(50);
            entity.Property(e => e.Idrecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(500);
            entity.Property(e => e.PaymentReference).HasMaxLength(500);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(500);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationInvoice>(entity =>
        {
            entity.HasKey(e => e.ReferencePay);

            entity.ToTable("Education_Invoices");

            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationPayement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Payements");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationPayement1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Payements$");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.Oldpayments)
                .HasMaxLength(120)
                .HasColumnName("oldpayments");
            entity.Property(e => e.PaymentDate).HasPrecision(3);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationPolicyMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_PolicyMember");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationPolicyMembersMigration>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_PolicyMembersMigration$");

            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.DateOfBirth).HasMaxLength(255);
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(255);
            entity.Property(e => e.IdDocumentType).HasMaxLength(255);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(255);
            entity.Property(e => e.MemberFullName).HasMaxLength(255);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(255);
            entity.Property(e => e.NextOfKin).HasMaxLength(255);
            entity.Property(e => e.Percentages).HasColumnName("percentages");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.Relationship).HasMaxLength(255);
        });

        modelBuilder.Entity<EducationPolicyRegisterDetail>(entity =>
        {
            entity.HasKey(e => e.PolicyNumberEndo).HasName("PK_Education_PolicyRegister_Details_1");

            entity.ToTable("Education_PolicyRegister_Details", tb => tb.HasTrigger("Proposal_converted_Education"));

            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndwomentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SendContract)
                .HasDefaultValue(0)
                .HasColumnName("Send_Contract");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationPolicyRegisterMain>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber).HasName("PK_Education_PolicyRegister_Main_1");

            entity.ToTable("Education_PolicyRegister_Main");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PrimeBranch).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.SubscriberId)
                .HasMaxLength(50)
                .HasColumnName("SubscriberID");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationPolicyRegisterSigned>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("Education_PolicyRegister_Signed");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<EducationTempBeneficiary>(entity =>
        {
            entity.HasKey(e => new { e.MemberCode, e.UserName });

            entity.ToTable("Education_Temp_Beneficiaries");

            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.BankAccount).HasMaxLength(50);
            entity.Property(e => e.BankName).HasMaxLength(100);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<EducationTempCalculation>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Education_Temp_Calculation");

            entity.Property(e => e.AgeXplusK).HasColumnName("Age_XplusK");
            entity.Property(e => e.AgeXplusK1).HasColumnName("Age_XplusK1");
            entity.Property(e => e.Am).HasColumnName("AM");
            entity.Property(e => e.AnmsKms1).HasColumnName("ANmsKms1");
            entity.Property(e => e.AxplusKnmsK).HasColumnName("AXplusKNmsK");
            entity.Property(e => e.DeferralYearsK).HasColumnName("Deferral_Years_k");
            entity.Property(e => e.Lx).HasColumnName("LX");
            entity.Property(e => e.LxplusK).HasColumnName("LXplusK");
            entity.Property(e => e.LxplusK1).HasColumnName("LXplusK1");
            entity.Property(e => e.MathematicalProvisionTmp).HasColumnName("MathematicalProvisionTMP");
            entity.Property(e => e.MpevaluationValue).HasColumnName("MPEvaluationValue");
            entity.Property(e => e.Pac).HasColumnName("PAC");
            entity.Property(e => e.Pac1).HasColumnName("PAC1");
            entity.Property(e => e.Pai).HasColumnName("PAI");
            entity.Property(e => e.Pai1).HasColumnName("PAI1");
            entity.Property(e => e.Pap).HasColumnName("PAP");
            entity.Property(e => e.Pap1).HasColumnName("PAP1");
            entity.Property(e => e.Pmk).HasColumnName("PMk");
            entity.Property(e => e.Pmk1).HasColumnName("PMk1");
            entity.Property(e => e.Pmk2).HasColumnName("PMk2");
            entity.Property(e => e.Puc).HasColumnName("PUC");
            entity.Property(e => e.Puc1).HasColumnName("PUC1");
            entity.Property(e => e.Pui).HasColumnName("PUI");
            entity.Property(e => e.Pui1).HasColumnName("PUI1");
            entity.Property(e => e.Pup).HasColumnName("PUP");
            entity.Property(e => e.Pup1).HasColumnName("PUP1");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e._6tz1ms2per3tz4).HasColumnName("6tz1ms2per3tz4");
            entity.Property(e => e._6tz1per3tz5).HasColumnName("6tz1per3tz5");
        });

        modelBuilder.Entity<Employee>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Branches).HasMaxLength(255);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(255)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.Entities).HasMaxLength(255);
            entity.Property(e => e.PrimaryContact).HasMaxLength(255);
            entity.Property(e => e.PrimaryContactName).HasMaxLength(255);
            entity.Property(e => e.Status).HasDefaultValue(true);
        });

        modelBuilder.Entity<EmployeeDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("policyNumber");
            entity.Property(e => e.Product).HasMaxLength(255);
        });

        modelBuilder.Entity<EmployeeProductionIntegrationTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EmployeeProduction_Integration_Table");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerNames).HasMaxLength(50);
            entity.Property(e => e.Idrecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(500);
            entity.Property(e => e.PaymentReference).HasMaxLength(500);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(500);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<EmployeeProtectionSetting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("employeeProtectionSettings");

            entity.Property(e => e.ComissionRate).HasColumnName("comissionRate");
            entity.Property(e => e.Fees).HasColumnName("fees");
            entity.Property(e => e.ManagementRate).HasColumnName("managementRate");
            entity.Property(e => e.PremiumRiskRate).HasColumnName("premiumRiskRate");
            entity.Property(e => e.TechnicalRate).HasColumnName("technicalRate");
        });

        modelBuilder.Entity<EmployeesTest>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Employees_Test");

            entity.Property(e => e.BasicSalary).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.Branches).HasMaxLength(50);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(20)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.Entities).HasMaxLength(100);
            entity.Property(e => e.PrimaryContact).HasMaxLength(20);
            entity.Property(e => e.PrimaryContactName).HasMaxLength(255);
        });

        modelBuilder.Entity<EmployeesTestInvalid>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Employees_Test_Invalid");

            entity.Property(e => e.BasicSalary).HasMaxLength(255);
            entity.Property(e => e.Branches).HasMaxLength(255);
            entity.Property(e => e.Dob)
                .HasMaxLength(255)
                .HasColumnName("DOB");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(255)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.Entities).HasMaxLength(255);
            entity.Property(e => e.ErrorNames).IsUnicode(false);
            entity.Property(e => e.PrimaryContact).HasMaxLength(255);
            entity.Property(e => e.PrimaryContactName).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
        });

        modelBuilder.Entity<EpReportInnocentProvision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EP_Report_Innocent_Provision");

            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .HasColumnName("customerName");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdsi).HasColumnName("deathTPDSI");
            entity.Property(e => e.DeathTpdsis).HasColumnName("deathTPDSIS");
            entity.Property(e => e.DreadDeseaseSi).HasColumnName("dreadDeseaseSI");
            entity.Property(e => e.DreadDeseaseSis).HasColumnName("dreadDeseaseSIS");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.FuneralSi).HasColumnName("funeralSI");
            entity.Property(e => e.FuneralSis).HasColumnName("funeralSIS");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastPaidDate).HasColumnType("datetime");
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("lossOfRevenueSI");
            entity.Property(e => e.LossOfRevenueSis).HasColumnName("lossOfRevenueSIS");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.Ppdsi).HasColumnName("PPDSI");
            entity.Property(e => e.Ppdsis).HasColumnName("PPDSIS");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(50)
                .HasColumnName("schemeNumber");
            entity.Property(e => e.TotalPremium).HasColumnName("totalPremium");
        });

        modelBuilder.Entity<Epbeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EPBeneficiary$");

            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AutoID");
            entity.Property(e => e.BeneficiaryCode).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(500);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.InsuredCode).HasMaxLength(100);
            entity.Property(e => e.InsuredName).HasMaxLength(500);
            entity.Property(e => e.Relationship).HasMaxLength(500);
            entity.Property(e => e.SchemeNumber).HasMaxLength(500);
        });

        modelBuilder.Entity<EpbeneficiaryNextOfKin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EPBeneficiaryNextOfKin$");

            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AutoID");
            entity.Property(e => e.BeneficiaryCode).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(500);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.InsuredCode).HasMaxLength(100);
            entity.Property(e => e.InsuredName).HasMaxLength(500);
            entity.Property(e => e.Relationship).HasMaxLength(500);
            entity.Property(e => e.SchemeNumber).HasMaxLength(500);
        });

        modelBuilder.Entity<EpiPolicyRegisterSigned>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("EPI_PolicyRegister_Signed");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<Eppolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EPPolicies$");

            entity.Property(e => e.ActiveStatus).HasDefaultValue(true);
            entity.Property(e => e.BranchName)
                .HasMaxLength(50)
                .HasColumnName("branchName");
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .HasColumnName("customerName");
            entity.Property(e => e.CustomerNumber).HasMaxLength(50);
            entity.Property(e => e.DeathTpdpremium).HasColumnName("deathTPDPremium");
            entity.Property(e => e.DeathTpdsi).HasColumnName("deathTPDSI");
            entity.Property(e => e.DeathTpdsis).HasColumnName("deathTPDSIS");
            entity.Property(e => e.DreadDeseasePremium).HasColumnName("dreadDeseasePremium");
            entity.Property(e => e.DreadDeseaseSi).HasColumnName("dreadDeseaseSI");
            entity.Property(e => e.DreadDeseaseSis).HasColumnName("dreadDeseaseSIS");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Fees).HasColumnName("fees");
            entity.Property(e => e.FuneralPremium).HasColumnName("funeralPremium");
            entity.Property(e => e.FuneralSi).HasColumnName("funeralSI");
            entity.Property(e => e.FuneralSis).HasColumnName("funeralSIS");
            entity.Property(e => e.IntId)
                .ValueGeneratedOnAdd()
                .HasColumnName("intID");
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("lossOfRevenueSI");
            entity.Property(e => e.LossOfRevenueSis).HasColumnName("lossOfRevenueSIS");
            entity.Property(e => e.LossOfrevenuePremium).HasColumnName("lossOfrevenuePremium");
            entity.Property(e => e.Numberofpyt).HasColumnName("numberofpyt");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.Ppdpremium).HasColumnName("PPDPremium");
            entity.Property(e => e.Ppdsi).HasColumnName("PPDSI");
            entity.Property(e => e.Ppdsis).HasColumnName("PPDSIS");
            entity.Property(e => e.RiskPremium).HasColumnName("riskPremium");
            entity.Property(e => e.Salary).HasDefaultValue(0.0);
            entity.Property(e => e.SalaryOrFixedAmount).HasColumnName("salaryOrFixedAmount");
            entity.Property(e => e.SalaryOrFixedAmountType)
                .HasMaxLength(50)
                .HasColumnName("salaryOrFixedAmountType");
            entity.Property(e => e.Savings).HasColumnName("savings");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(50)
                .HasColumnName("schemeNumber");
            entity.Property(e => e.TotalPremium).HasColumnName("totalPremium");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<EppolicyRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("EPPolicyRegister");

            entity.Property(e => e.Advisor).HasMaxLength(100);
            entity.Property(e => e.Channel).HasMaxLength(100);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .HasColumnName("customerName");
            entity.Property(e => e.CustomerNumber).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdpremium).HasColumnName("deathTPDPremium");
            entity.Property(e => e.DeathTpdsi).HasColumnName("deathTPDSI");
            entity.Property(e => e.DeathTpdsis).HasColumnName("deathTPDSIS");
            entity.Property(e => e.DreadDeseasePremium).HasColumnName("dreadDeseasePremium");
            entity.Property(e => e.DreadDeseaseSi).HasColumnName("dreadDeseaseSI");
            entity.Property(e => e.DreadDeseaseSis).HasColumnName("dreadDeseaseSIS");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Fees).HasColumnName("fees");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.FuneralPremium).HasColumnName("funeralPremium");
            entity.Property(e => e.FuneralSi).HasColumnName("funeralSI");
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("lossOfRevenueSI");
            entity.Property(e => e.LossOfRevenueSis).HasColumnName("lossOfRevenueSIS");
            entity.Property(e => e.LossOfrevenuePremium).HasColumnName("lossOfrevenuePremium");
            entity.Property(e => e.Numberofpyt).HasColumnName("numberofpyt");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.Ppdpremium).HasColumnName("PPDPremium");
            entity.Property(e => e.Ppdsi).HasColumnName("PPDSI");
            entity.Property(e => e.Ppdsis).HasColumnName("PPDSIS");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.RiskPremium).HasColumnName("riskPremium");
            entity.Property(e => e.SalaryOrFixedAmount).HasColumnName("salaryOrFixedAmount");
            entity.Property(e => e.TotalPremium).HasColumnName("totalPremium");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<EpsavingsRegisterDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EPSavingsRegisterDetails$");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumbers).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberBase)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Base");
            entity.Property(e => e.PolicyNumberEndorsement)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Endorsement");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<Epscheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("EPScheme$");

            entity.Property(e => e.Advisor).HasMaxLength(100);
            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AutoID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasColumnName("branchName");
            entity.Property(e => e.Channel).HasMaxLength(100);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.CustomerCode).HasMaxLength(100);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(100)
                .HasColumnName("customerName");
            entity.Property(e => e.DeathTpd).HasColumnName("deathTPD");
            entity.Property(e => e.DreadDesease).HasColumnName("dreadDesease");
            entity.Property(e => e.FuneralFees).HasColumnName("funeralFees");
            entity.Property(e => e.LossOfRevenue).HasColumnName("lossOfRevenue");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDetails).HasMaxLength(100);
            entity.Property(e => e.PercentageSavingSalary).HasColumnName("percentageSavingSalary");
            entity.Property(e => e.PolicyPytPlan).HasMaxLength(100);
            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.SalaryTimes).HasDefaultValue(1);
            entity.Property(e => e.Saving).HasColumnName("saving");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(100)
                .HasColumnName("schemeNumber");
            entity.Property(e => e.UserName)
                .HasMaxLength(100)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<ExistingCustomer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.IdNumber).HasMaxLength(150);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
        });

        modelBuilder.Entity<FamilyAndEmployeeIntegrationTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FamilyAndEmployee_Integration_Table");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerNames).HasMaxLength(50);
            entity.Property(e => e.Idrecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InvoiceNumber).HasMaxLength(500);
            entity.Property(e => e.PaymentReference).HasMaxLength(500);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(500);
            entity.Property(e => e.Product).HasMaxLength(150);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_Claims");

            entity.Property(e => e.AdvanceAndInterest).HasColumnName("Advance_And_ Interest");
            entity.Property(e => e.BeneficiaryNames)
                .HasMaxLength(255)
                .HasColumnName("Beneficiary Names");
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDateLastDocument)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Last_Document");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(255)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimReserveAmount).HasColumnName("Claim_Reserve_Amount");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(255)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(255)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective date");
            entity.Property(e => e.InterestOnAdvance).HasColumnName("Interest_On_Advance");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity date");
            entity.Property(e => e.NameOfProduct)
                .HasMaxLength(255)
                .HasColumnName("Name of Product");
            entity.Property(e => e.PhysicalLossIncurred).HasColumnName("Physical_Loss_Incurred");
            entity.Property(e => e.PlaceOfIncident)
                .HasColumnType("datetime")
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyholderName)
                .HasMaxLength(255)
                .HasColumnName("Policyholder name");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(255)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(255)
                .HasColumnName("Scheme Name");
            entity.Property(e => e.SumInsured).HasColumnName("Sum insured");
            entity.Property(e => e.SurrenderType)
                .HasColumnType("datetime")
                .HasColumnName("Surrender_Type");
            entity.Property(e => e.SurrenderValue).HasColumnName("Surrender_Value");
            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .HasColumnName("TELEPHONE");
            entity.Property(e => e.TotalLoan).HasColumnName("Total_Loan");
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<FamilyClaimsRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_ClaimsRegister");

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

        modelBuilder.Entity<FamilyCommission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_Commissions");

            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.ControllerId).HasColumnName("ControllerID");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyDatum>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_Data");

            entity.Property(e => e.CreationDate).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(255);
            entity.Property(e => e.PaymentSource).HasMaxLength(255);
            entity.Property(e => e.PolicyComponentType).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(255);
            entity.Property(e => e.ProductCategory).HasMaxLength(255);
            entity.Property(e => e.RecordedDate).HasMaxLength(255);
            entity.Property(e => e.SavingPolicyNumber).HasMaxLength(255);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(255)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserName).HasMaxLength(255);
            entity.Property(e => e.VendorId)
                .HasMaxLength(255)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<FamilyEpiClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_EPI_Claims");

            entity.Property(e => e.AdvanceAndInterest).HasColumnName("Advance_And_ Interest");
            entity.Property(e => e.BeneficiaryNames)
                .HasMaxLength(255)
                .HasColumnName("Beneficiary Names");
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDateLastDocument)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Last_Document");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(255)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimReserveAmount).HasColumnName("Claim_Reserve_Amount");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(255)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(255)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective date");
            entity.Property(e => e.InterestOnAdvance).HasColumnName("Interest_On_Advance");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity date");
            entity.Property(e => e.NameOfProduct)
                .HasMaxLength(255)
                .HasColumnName("Name of Product");
            entity.Property(e => e.PhysicalLossIncurred).HasColumnName("Physical_Loss_Incurred");
            entity.Property(e => e.PlaceOfIncident)
                .HasColumnType("datetime")
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyholderName)
                .HasMaxLength(255)
                .HasColumnName("Policyholder name");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(255)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(255)
                .HasColumnName("Scheme Name");
            entity.Property(e => e.SumInsured).HasColumnName("Sum insured");
            entity.Property(e => e.SurrenderType)
                .HasColumnType("datetime")
                .HasColumnName("Surrender_Type");
            entity.Property(e => e.SurrenderValue).HasColumnName("Surrender_Value");
            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .HasColumnName("TELEPHONE");
            entity.Property(e => e.TotalLoan).HasColumnName("Total_Loan");
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<FamilyEpiClaimsRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_EPI_ClaimsRegister");

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

        modelBuilder.Entity<FamilyEpiCommission>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_EPI_Commissions");

            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.ControllerId).HasColumnName("ControllerID");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyEpiInvoice>(entity =>
        {
            entity.HasKey(e => e.ReferencePay);

            entity.ToTable("FAMILY_EPI_Invoices");

            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyEpiPayement>(entity =>
        {
            entity.HasKey(e => new { e.IdRecord, e.ReferencePay });

            entity.ToTable("FAMILY_EPI_Payements");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyEpiPolicyMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_EPI_PolicyMember");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(100)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyEpiPolicyRegister>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("FAMILY_EPI_PolicyRegister", tb => tb.HasTrigger("Proposal_converted_EmployeeProtection"));

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DeathTpdsi).HasColumnName("DeathTPDSI");
            entity.Property(e => e.DreadDeseaseSi).HasColumnName("DreadDeseaseSI");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FuneralSi).HasColumnName("FuneralSI");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("LossOfRevenueSI");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus).HasMaxLength(50);
            entity.Property(e => e.Ppdsi).HasColumnName("PPDSI");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SavingPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SendContract)
                .HasDefaultValue(0)
                .HasColumnName("Send_Contract");
            entity.Property(e => e.SpouseCoverSi).HasColumnName("SpouseCoverSI");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<FamilyInvoice>(entity =>
        {
            entity.HasKey(e => e.ReferencePay);

            entity.ToTable("FAMILY_Invoices");

            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyNextOfKin>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_NextOfKin");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKinCode).HasMaxLength(50);
            entity.Property(e => e.NextOfKinFullName).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyPayement>(entity =>
        {
            entity.HasKey(e => new { e.IdRecord, e.ReferencePay });

            entity.ToTable("FAMILY_Payements");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyPolicyMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_PolicyMember");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyPolicyRegister>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("FAMILY_PolicyRegister", tb => tb.HasTrigger("Proposal_converted_Family"));

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SavingPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SendContract)
                .HasDefaultValue(0)
                .HasColumnName("Send_Contract");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<FamilyPolicyRegisterSigned>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.ToTable("FAMILY_PolicyRegister_Signed");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FamilyProposalMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_ProposalMember");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyRate>(entity =>
        {
            entity.HasKey(e => e.CategoryId);

            entity.ToTable("FAMILY_Rate");

            entity.Property(e => e.CategoryId)
                .HasMaxLength(50)
                .HasColumnName("CategoryID");
            entity.Property(e => e.CategoryType).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<FamilyReportingMonth>(entity =>
        {
            entity.HasKey(e => e.RecordId);

            entity.ToTable("FAMILY_ReportingMonth");

            entity.Property(e => e.RecordId).HasColumnName("RecordID");
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
        });

        modelBuilder.Entity<FamilySavingRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_SavingRate$");

            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<FamilySavingsDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(255);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(255)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(255);
            entity.Property(e => e.PaymentSource).HasMaxLength(255);
            entity.Property(e => e.PolicyNumberBase)
                .HasMaxLength(255)
                .HasColumnName("PolicyNumber_Base");
            entity.Property(e => e.PolicyNumberEndorsement)
                .HasMaxLength(255)
                .HasColumnName("PolicyNumber_Endorsement");
            entity.Property(e => e.SchemeName).HasMaxLength(255);
            entity.Property(e => e.Source).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<FamilySavingsPayement>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_Savings_Payements$");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilySavingsRegister>(entity =>
        {
            entity.HasKey(e => e.PolicyNumberBase).HasName("PK_FAMILY_SavingsRegister");

            entity.ToTable("FAMILY_SavingsRegister$");

            entity.Property(e => e.PolicyNumberBase)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Base");
            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade)
                .HasMaxLength(50)
                .HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndorsement)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Endorsement");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.SumAssuredType).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilySavingsRegisterDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_SavingsRegister_Details$");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.InvoiceDate).HasColumnType("datetime");
            entity.Property(e => e.InvoiceNumbers).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberBase)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Base");
            entity.Property(e => e.PolicyNumberEndorsement)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Endorsement");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<FamilyScheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("FAMILY_Scheme");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(200);
            entity.Property(e => e.SchemeType).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<GplClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GPL_Claims$");

            entity.Property(e => e.AutoId)
                .ValueGeneratedOnAdd()
                .HasColumnName("AutoID");
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimPercentage).HasDefaultValue(100);
            entity.Property(e => e.ClaimReason).HasMaxLength(100);
            entity.Property(e => e.ClaimType).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(100);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.PolicyEffectDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyMaturityDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeName).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<GplClaimRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GPL_ClaimRegister");

            entity.Property(e => e.AutoId).HasColumnName("AutoID");
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimReason).HasMaxLength(100);
            entity.Property(e => e.ClaimType).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(100);
            entity.Property(e => e.CustomerName).HasMaxLength(100);
            entity.Property(e => e.PolicyEffectDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyMaturityDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeName).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<GplMortalityTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GPL_MortalityTable");

            entity.Property(e => e.IntAut).ValueGeneratedOnAdd();
            entity.Property(e => e.KalF).HasColumnName("KAL_F");
            entity.Property(e => e.KalM).HasColumnName("KAL_M");
            entity.Property(e => e.KglF).HasColumnName("KGL_F");
            entity.Property(e => e.KglM).HasColumnName("KGL_M");
            entity.Property(e => e.KolF).HasColumnName("KOL_F");
            entity.Property(e => e.KolM).HasColumnName("KOL_M");
            entity.Property(e => e.Safrica).HasColumnName("SAfrica");
            entity.Property(e => e.Uk).HasColumnName("UK");
        });

        modelBuilder.Entity<GplPolicyBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GPL_PolicyBeneficiary");

            entity.Property(e => e.BeneficiaryCode).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryFullName).HasMaxLength(500);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PolicyNumberDetails).HasMaxLength(100);
            entity.Property(e => e.Relationship).HasMaxLength(500);
        });

        modelBuilder.Entity<GplPolicyRegisterBase>(entity =>
        {
            entity.HasKey(e => new { e.PolicyNumberBase, e.CustomerCode }).HasName("PK_GPL_PolicyRegisterBase_1");

            entity.ToTable("GPL_PolicyRegisterBase");

            entity.Property(e => e.PolicyNumberBase).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdrate).HasColumnName("DeathTPDRate");
            entity.Property(e => e.DeathTpdrateSpouse).HasColumnName("DeathTPDRateSpouse");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MainInsurer).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.Ppdrate).HasColumnName("PPDRate");
            entity.Property(e => e.PpdrateSpouse).HasColumnName("PPDRateSpouse");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.PricingMethod).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeName).HasMaxLength(200);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<GplPolicyRegisterDetail>(entity =>
        {
            entity.HasKey(e => new { e.PolicyNumberBase, e.PolicyNumberChild, e.CustomerCodeMember });

            entity.ToTable("GPL_PolicyRegisterDetails");

            entity.Property(e => e.PolicyNumberBase).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.CustomerCodeMember).HasMaxLength(100);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdamount).HasColumnName("DeathTPDAmount");
            entity.Property(e => e.DeathTpdpremium).HasColumnName("DeathTPDPremium");
            entity.Property(e => e.DeathTpdspouseAmount).HasColumnName("DeathTPDSpouseAmount");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.Ppdamount).HasColumnName("PPDAmount");
            entity.Property(e => e.Ppdpremium).HasColumnName("PPDPremium");
            entity.Property(e => e.PpdspouseAmount).HasColumnName("PPDSpouseAmount");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<GplQuoteTempDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GPL_Quote_Temp_Details");

            entity.Property(e => e.CustomerCode).HasMaxLength(100);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyNumberBase).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<GplRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("GPL_Rate");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<IdToCorrect>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IdToCorrect");

            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.IdDocument).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
        });

        modelBuilder.Entity<IngenziDbcustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("IngenziDBCustomer");

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
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
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

        modelBuilder.Entity<IntegrationTableFreeEducation>(entity =>
        {
            entity.HasKey(e => new { e.ExternalTransaction, e.PolicyNumber });

            entity.ToTable("IntegrationTableFreeEducation");

            entity.Property(e => e.ExternalTransaction).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<InvBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("INV_BANKS");

            entity.Property(e => e.AccountType)
                .HasMaxLength(10)
                .HasColumnName("Account_Type");
            entity.Property(e => e.AccruedInterest)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Accrued_Interest");
            entity.Property(e => e.BankAccountNo)
                .HasMaxLength(30)
                .HasColumnName("Bank_Account_No");
            entity.Property(e => e.BankLeBook)
                .HasMaxLength(3)
                .HasColumnName("Bank_Le_Book");
            entity.Property(e => e.BankName)
                .HasMaxLength(80)
                .HasColumnName("Bank_Name");
            entity.Property(e => e.ChargesIncurred)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Charges_Incurred");
            entity.Property(e => e.CreditRating)
                .HasMaxLength(10)
                .HasColumnName("Credit_Rating");
            entity.Property(e => e.CreditRatingAgency)
                .HasMaxLength(10)
                .HasColumnName("Credit_Rating_Agency");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.InterestRate)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("Interest_Rate");
            entity.Property(e => e.MaturityDate).HasColumnName("Maturity_Date");
            entity.Property(e => e.Names).HasMaxLength(250);
            entity.Property(e => e.OpeningDate).HasColumnName("Opening_Date");
            entity.Property(e => e.PensionSchemeType)
                .HasMaxLength(10)
                .HasColumnName("Pension_Scheme_Type");
            entity.Property(e => e.PrincipalAmount)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Principal_Amount");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.RelatedPartyFlag)
                .HasMaxLength(1)
                .HasColumnName("Related_Party_Flag");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<InvInvestment>(entity =>
        {
            entity.HasKey(e => e.InvestmentId);

            entity.ToTable("INV_INVESTMENTS");

            entity.Property(e => e.InvestmentId)
                .HasMaxLength(30)
                .HasColumnName("Investment_ID");
            entity.Property(e => e.AccruedReceivables)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Accrued_Receivables");
            entity.Property(e => e.AdditionalInvestment)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Additional_Investment");
            entity.Property(e => e.AssetAcquisitionDate).HasColumnName("Asset_Acquisition_Date");
            entity.Property(e => e.AssetAllocationMandate)
                .HasMaxLength(100)
                .HasColumnName("Asset_Allocation_Mandate");
            entity.Property(e => e.BasisOfValuation)
                .HasMaxLength(30)
                .HasColumnName("Basis_Of_Valuation");
            entity.Property(e => e.CapitalGain)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Capital_Gain");
            entity.Property(e => e.CashFromInvIncome)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Cash_From_Inv_Income");
            entity.Property(e => e.Charges).HasColumnType("numeric(23, 5)");
            entity.Property(e => e.CompanyCountry)
                .HasMaxLength(2)
                .HasColumnName("Company_Country");
            entity.Property(e => e.CompanySubSectorIsic)
                .HasMaxLength(10)
                .HasColumnName("Company_Sub_Sector_ISIC");
            entity.Property(e => e.CreditRating)
                .HasMaxLength(10)
                .HasColumnName("Credit_Rating");
            entity.Property(e => e.CreditRatingAgency)
                .HasMaxLength(10)
                .HasColumnName("Credit_Rating_Agency");
            entity.Property(e => e.CurrentValue)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Current_Value");
            entity.Property(e => e.DateOfValuation).HasColumnName("Date_Of_Valuation");
            entity.Property(e => e.EmailAddress)
                .HasMaxLength(20)
                .HasColumnName("Email_Address");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IdentificationOfProperty)
                .HasMaxLength(50)
                .HasColumnName("Identification_Of_Property");
            entity.Property(e => e.InitialInvestment)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Initial_Investment");
            entity.Property(e => e.InvestmentClass)
                .HasMaxLength(100)
                .HasColumnName("Investment_Class");
            entity.Property(e => e.ListedFlag)
                .HasMaxLength(1)
                .HasColumnName("Listed_Flag");
            entity.Property(e => e.MaturityDate).HasColumnName("Maturity_Date");
            entity.Property(e => e.NameOfCompany)
                .HasMaxLength(80)
                .HasColumnName("Name_Of_Company");
            entity.Property(e => e.NameOfGuarantor)
                .HasMaxLength(80)
                .HasColumnName("Name_Of_Guarantor");
            entity.Property(e => e.Names).HasMaxLength(250);
            entity.Property(e => e.NumberOfUnits)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("Number_of_Units");
            entity.Property(e => e.PercentageOfOwnership)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("Percentage_Of_Ownership");
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(20)
                .HasColumnName("Phone_Number");
            entity.Property(e => e.RecFromInvIncome)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Rec_From_Inv_Income");
            entity.Property(e => e.ReceivableDate).HasColumnName("Receivable_date");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.RegFinInstitution)
                .HasMaxLength(1)
                .HasColumnName("Reg_Fin_Institution");
            entity.Property(e => e.RelatedPartyFlag)
                .HasMaxLength(1)
                .HasColumnName("Related_Party_Flag");
            entity.Property(e => e.RevaluationGain)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Revaluation_Gain");
            entity.Property(e => e.RoiRate)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("ROI_Rate");
            entity.Property(e => e.StockExchangeName)
                .HasMaxLength(80)
                .HasColumnName("Stock_Exchange_Name");
            entity.Property(e => e.TypeOfInvestment)
                .HasMaxLength(100)
                .HasColumnName("Type_Of_Investment");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.ValuerContact)
                .HasMaxLength(50)
                .HasColumnName("Valuer_Contact");
            entity.Property(e => e.ValuerName)
                .HasMaxLength(80)
                .HasColumnName("Valuer_Name");
        });

        modelBuilder.Entity<Invoicing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Invoicing");

            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InsuredCode).HasMaxLength(50);
            entity.Property(e => e.InsuredName).HasMaxLength(100);
            entity.Property(e => e.LastTransactionDate).HasColumnType("datetime");
            entity.Property(e => e.Nauto)
                .ValueGeneratedOnAdd()
                .HasColumnName("NAuto");
            entity.Property(e => e.Ninvoice)
                .HasMaxLength(100)
                .HasColumnName("NInvoice");
            entity.Property(e => e.NpolOrEndorsement)
                .HasMaxLength(50)
                .HasColumnName("NPolOrEndorsement");
            entity.Property(e => e.NpolOrScheme)
                .HasMaxLength(50)
                .HasColumnName("NPolOrScheme");
            entity.Property(e => e.PayementMode).HasMaxLength(100);
            entity.Property(e => e.PayementPeriod).HasMaxLength(100);
            entity.Property(e => e.PayerCustomerCode).HasMaxLength(50);
            entity.Property(e => e.PayerCustomerName).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.UserCode).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<IsicClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ISIC_Class");

            entity.Property(e => e.IsicClassDescription)
                .HasMaxLength(100)
                .HasColumnName("ISIC_Class_Description");
            entity.Property(e => e.IsicClassId)
                .HasMaxLength(2)
                .HasColumnName("ISIC_ClassID");
            entity.Property(e => e.IsicStatus).HasColumnName("ISIC_Status");
        });

        modelBuilder.Entity<LifeClaimsRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("LifeClaimsRegister");

            entity.Property(e => e.AnyComment).HasMaxLength(100);
            entity.Property(e => e.BeneficiaryNames).HasMaxLength(100);
            entity.Property(e => e.ClaimCurrency)
                .HasMaxLength(10)
                .HasColumnName("Claim_Currency");
            entity.Property(e => e.ClaimExpiryDate).HasColumnName("Claim_Expiry_Date");
            entity.Property(e => e.ClaimNumber)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimSettlementAmount)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate).HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(10)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimSubmissionDate).HasColumnName("Claim_Submission_Date");
            entity.Property(e => e.ClaimType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(20);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IdentificationNumber).HasMaxLength(16);
            entity.Property(e => e.IncidentDate).HasColumnName("Incident_Date");
            entity.Property(e => e.InsuranceType)
                .HasMaxLength(50)
                .HasColumnName("Insurance_Type");
            entity.Property(e => e.LastPremiumPayDate).HasColumnName("Last_Premium_Pay_Date");
            entity.Property(e => e.LifeInsuredNames).HasMaxLength(100);
            entity.Property(e => e.NumOfPersonsCovered)
                .HasColumnType("numeric(20, 0)")
                .HasColumnName("Num_Of_Persons_Covered");
            entity.Property(e => e.NumOfPreviousClaims)
                .HasColumnType("numeric(10, 0)")
                .HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.OccurrenceBookDetails)
                .HasMaxLength(45)
                .HasColumnName("Occurrence_Book_Details");
            entity.Property(e => e.PhysicalLossIncurred)
                .HasMaxLength(20)
                .HasColumnName("Physical_Loss_Incurred");
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(45)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyMaturityDate).HasColumnName("Policy_Maturity_Date");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(20)
                .HasColumnName("Policy_Number");
            entity.Property(e => e.PolicyStartDate).HasColumnName("Policy_Start_Date");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(50)
                .HasColumnName("Policy_Type");
            entity.Property(e => e.PolicyholderName).HasMaxLength(100);
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(100)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.ReportedDate).HasColumnName("Reported_Date");
            entity.Property(e => e.SchemeName).HasMaxLength(50);
            entity.Property(e => e.SumInsured).HasColumnType("numeric(23, 5)");
            entity.Property(e => e.TotalClaimAmount)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Total_Claim_Amount");
            entity.Property(e => e.TotalPremiumPaid).HasColumnType("numeric(23, 5)");
        });

        modelBuilder.Entity<ListOfPolicy>(entity =>
        {
            entity.HasKey(e => e.PolicyNumber);

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ListOfSendingList>(entity =>
        {
            entity.HasKey(e => new { e.PolicyNumber, e.DueDate, e.RemainingDays });

            entity.ToTable("ListOfSendingList");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(250);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
        });

        modelBuilder.Entity<LoanCustomer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasPrecision(3);
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
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
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

        modelBuilder.Entity<MaturedPolicy>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
        });

        modelBuilder.Entity<MedicalReport>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerNationalId)
                .HasMaxLength(50)
                .HasColumnName("CustomerNationalID");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .HasColumnName("DocID");
            entity.Property(e => e.DueRenewalDate).HasColumnType("datetime");
            entity.Property(e => e.Ecbu).HasColumnName("ECBU");
            entity.Property(e => e.Ecg).HasColumnName("ECG");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.ReportDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.Xray).HasColumnName("XRay");
        });

        modelBuilder.Entity<MifotraCommitment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MIFOTRA_Commitments");

            entity.Property(e => e.Amount).HasColumnName("amount");
            entity.Property(e => e.Comments).HasMaxLength(150);
            entity.Property(e => e.CommitmentId).HasColumnName("commitmentId");
            entity.Property(e => e.CommitmentStatus).HasMaxLength(50);
            entity.Property(e => e.Creditor)
                .HasMaxLength(255)
                .HasColumnName("creditor");
            entity.Property(e => e.CreditorAccountNumber)
                .HasMaxLength(50)
                .HasColumnName("creditorAccountNumber");
            entity.Property(e => e.CreditorId)
                .HasMaxLength(50)
                .HasColumnName("creditorId");
            entity.Property(e => e.EmployeeId).HasColumnName("employeeId");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.FirstName)
                .HasMaxLength(100)
                .HasColumnName("firstName");
            entity.Property(e => e.IdNumber)
                .HasMaxLength(50)
                .HasColumnName("idNumber");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Institution)
                .HasMaxLength(255)
                .HasColumnName("institution");
            entity.Property(e => e.InternalAction).HasMaxLength(50);
            entity.Property(e => e.InternalActionDate).HasColumnType("datetime");
            entity.Property(e => e.LastName)
                .HasMaxLength(100)
                .HasColumnName("lastName");
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.PhoneNumber)
                .HasMaxLength(50)
                .HasColumnName("phoneNumber");
            entity.Property(e => e.Position)
                .HasMaxLength(255)
                .HasColumnName("position");
            entity.Property(e => e.Reason).HasMaxLength(150);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.RequestType).HasMaxLength(50);
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("startDate");
            entity.Property(e => e.Unit)
                .HasMaxLength(255)
                .HasColumnName("unit");
            entity.Property(e => e.UserChangedBy).HasMaxLength(100);
            entity.Property(e => e.UserChangedOnDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserNameAction).HasMaxLength(100);
        });

        modelBuilder.Entity<MissingPremium>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.DateOfPayment).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(255);
            entity.Property(e => e.PaymentSource).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.ProductType).HasMaxLength(255);
            entity.Property(e => e.Schemes).HasMaxLength(255);
        });

        modelBuilder.Entity<MomoStatment>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MOMO_Statments");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.ExternalTransactionId).HasMaxLength(50);
            entity.Property(e => e.FromName).HasMaxLength(255);
            entity.Property(e => e.FromNumber).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.ToMessage).HasMaxLength(255);
            entity.Property(e => e.ToName).HasMaxLength(255);
            entity.Property(e => e.ToNumber).HasMaxLength(255);
            entity.Property(e => e.TransactionId).HasMaxLength(50);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<MomoTelephone>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("MOMO_Telephones");

            entity.Property(e => e.LastNameV)
                .HasMaxLength(255)
                .HasColumnName("last_name_v");
            entity.Property(e => e.Msisdn)
                .HasMaxLength(255)
                .HasColumnName("msisdn");
            entity.Property(e => e.MsisdnKey)
                .HasMaxLength(255)
                .HasColumnName("msisdn_key");
            entity.Property(e => e.SubsNameV)
                .HasMaxLength(255)
                .HasColumnName("subs_name_v");
        });

        modelBuilder.Entity<MortalityTableCima>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mortality_Table_CIMA");

            entity.Property(e => e.Dx).HasColumnName("dx");
            entity.Property(e => e.Lx).HasColumnName("lx");
            entity.Property(e => e.Qx).HasColumnName("qx");
            entity.Property(e => e.X).HasColumnName("x");
        });

        modelBuilder.Entity<MortalityTableKenya>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Mortality_Table_Kenya");

            entity.Property(e => e.Dx).HasColumnName("dx");
            entity.Property(e => e.Lx).HasColumnName("lx");
            entity.Property(e => e.Qx).HasColumnName("qx");
            entity.Property(e => e.X).HasColumnName("x");
        });

        modelBuilder.Entity<NipdataManagement>(entity =>
        {
            entity.HasKey(e => e.Nipcode);

            entity.ToTable("NIPDataManagement");

            entity.Property(e => e.Nipcode)
                .HasMaxLength(25)
                .HasColumnName("NIPCODE");
            entity.Property(e => e.AssignedDate).HasColumnType("datetime");
            entity.Property(e => e.AssignedDepartement).HasMaxLength(50);
            entity.Property(e => e.ClosingDate).HasColumnType("datetime");
            entity.Property(e => e.CommercialActionDate).HasColumnType("datetime");
            entity.Property(e => e.CommercialComment).HasMaxLength(255);
            entity.Property(e => e.CommercialUserLast).HasMaxLength(100);
            entity.Property(e => e.EmployeeId).HasMaxLength(50);
            entity.Property(e => e.EntityName).HasMaxLength(255);
            entity.Property(e => e.FinalFinanceComment).HasMaxLength(255);
            entity.Property(e => e.FinanceComment).HasMaxLength(255);
            entity.Property(e => e.FinanceUserClosing).HasMaxLength(100);
            entity.Property(e => e.FinanceUserName).HasMaxLength(100);
            entity.Property(e => e.FullNames).HasMaxLength(255);
            entity.Property(e => e.IdNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.OperationStatus).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.RecoredDate).HasColumnType("datetime");
            entity.Property(e => e.SalesResponsible).HasMaxLength(100);
            entity.Property(e => e.UnderwriterResponsible).HasMaxLength(100);
            entity.Property(e => e.UnderwriterUserLast).HasMaxLength(100);
            entity.Property(e => e.UnderwritingActionDate).HasColumnType("datetime");
            entity.Property(e => e.UnderwrtingComment).HasMaxLength(255);
            entity.Property(e => e.Unit).HasMaxLength(255);
        });

        modelBuilder.Entity<NovaBeneficiaire>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nova_Beneficiaires");

            entity.Property(e => e.Beneficiaries01).HasMaxLength(255);
            entity.Property(e => e.Beneficiaries02).HasMaxLength(255);
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.LienClient).HasColumnName("lienClient");
            entity.Property(e => e.Police)
                .HasMaxLength(255)
                .HasColumnName("police");
        });

        modelBuilder.Entity<NovaClient>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nova_Clients");

            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .HasColumnName("adresse");
            entity.Property(e => e.Adresse2)
                .HasMaxLength(255)
                .HasColumnName("adresse2");
            entity.Property(e => e.Codetitre)
                .HasMaxLength(255)
                .HasColumnName("codetitre");
            entity.Property(e => e.Datecre)
                .HasColumnType("datetime")
                .HasColumnName("datecre");
            entity.Property(e => e.Datemaj)
                .HasColumnType("datetime")
                .HasColumnName("datemaj");
            entity.Property(e => e.Datenaiss)
                .HasColumnType("datetime")
                .HasColumnName("datenaiss");
            entity.Property(e => e.Email)
                .HasMaxLength(255)
                .HasColumnName("email");
            entity.Property(e => e.Gestion)
                .HasMaxLength(255)
                .HasColumnName("gestion");
            entity.Property(e => e.Lienclient).HasColumnName("lienclient");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .HasColumnName("nom");
            entity.Property(e => e.Nom2)
                .HasMaxLength(255)
                .HasColumnName("nom2");
            entity.Property(e => e.Pays)
                .HasMaxLength(255)
                .HasColumnName("pays");
            entity.Property(e => e.Prenom)
                .HasMaxLength(255)
                .HasColumnName("prenom");
            entity.Property(e => e.Select2)
                .HasMaxLength(255)
                .HasColumnName("select2");
            entity.Property(e => e.Select3)
                .HasMaxLength(255)
                .HasColumnName("select3");
            entity.Property(e => e.Select4)
                .HasMaxLength(255)
                .HasColumnName("select4");
            entity.Property(e => e.Select7)
                .HasMaxLength(255)
                .HasColumnName("select7");
            entity.Property(e => e.Status)
                .HasMaxLength(255)
                .HasColumnName("status");
            entity.Property(e => e.Telephone1).HasColumnName("telephone1");
        });

        modelBuilder.Entity<NovaPolice>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Nova_Polices");

            entity.Property(e => e.Adr2scrp)
                .HasMaxLength(255)
                .HasColumnName("adr2scrp");
            entity.Property(e => e.Adrscrp)
                .HasMaxLength(255)
                .HasColumnName("adrscrp");
            entity.Property(e => e.Apporteur)
                .HasMaxLength(255)
                .HasColumnName("apporteur");
            entity.Property(e => e.Datavenant)
                .HasColumnType("datetime")
                .HasColumnName("datavenant");
            entity.Property(e => e.Dateancmaj)
                .HasColumnType("datetime")
                .HasColumnName("dateancmaj");
            entity.Property(e => e.Dateffet)
                .HasColumnType("datetime")
                .HasColumnName("dateffet");
            entity.Property(e => e.Datemaj)
                .HasColumnType("datetime")
                .HasColumnName("datemaj");
            entity.Property(e => e.Datemvt)
                .HasColumnType("datetime")
                .HasColumnName("datemvt");
            entity.Property(e => e.Id).HasColumnName("id");
            entity.Property(e => e.Lienclient).HasColumnName("lienclient");
            entity.Property(e => e.Mouvement)
                .HasMaxLength(255)
                .HasColumnName("mouvement");
            entity.Property(e => e.Netannuel).HasColumnName("netannuel");
            entity.Property(e => e.Netpreced).HasColumnName("netpreced");
            entity.Property(e => e.Nom2scrp)
                .HasMaxLength(255)
                .HasColumnName("nom2scrp");
            entity.Property(e => e.Nomscrp)
                .HasMaxLength(255)
                .HasColumnName("nomscrp");
            entity.Property(e => e.Paiement)
                .HasMaxLength(255)
                .HasColumnName("paiement");
            entity.Property(e => e.Police)
                .HasMaxLength(255)
                .HasColumnName("police");
            entity.Property(e => e.Prenomscrp)
                .HasMaxLength(255)
                .HasColumnName("prenomscrp");
            entity.Property(e => e.Titrescrp)
                .HasMaxLength(255)
                .HasColumnName("titrescrp");
            entity.Property(e => e.Ttcannuel).HasColumnName("ttcannuel");
            entity.Property(e => e.Ttcpreced).HasColumnName("ttcpreced");
            entity.Property(e => e.Typpol)
                .HasMaxLength(255)
                .HasColumnName("typpol");
            entity.Property(e => e.Utilis)
                .HasMaxLength(255)
                .HasColumnName("utilis");
        });

        modelBuilder.Entity<OccupationsClass>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("OCCUPATIONS_CLASS");

            entity.Property(e => e.OccupationClassId)
                .HasMaxLength(4)
                .HasColumnName("Occupation_ClassID");
            entity.Property(e => e.OccupationDescription)
                .HasMaxLength(100)
                .HasColumnName("Occupation_Description");
            entity.Property(e => e.OccupationId).HasColumnName("OccupationID");
            entity.Property(e => e.OccupationStatus).HasColumnName("Occupation_Status");
        });

        modelBuilder.Entity<OldPoliciesDatum>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.BusinessChannel).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_of_Birth");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(255)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.IdBankBranch).HasMaxLength(255);
            entity.Property(e => e.IdDocumentType).HasMaxLength(255);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(255);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(255);
            entity.Property(e => e.LastName)
                .HasMaxLength(255)
                .HasColumnName("Last_Name");
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
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
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ResidenceCell).HasMaxLength(255);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(255);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(255);
            entity.Property(e => e.ResidenceSector).HasMaxLength(255);
            entity.Property(e => e.ResidenceVillage).HasMaxLength(255);
            entity.Property(e => e.Salutation).HasMaxLength(255);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(255);
            entity.Property(e => e.VendorCode).HasMaxLength(255);
        });

        modelBuilder.Entity<PartnersDocumentRequired>(entity =>
        {
            entity.HasKey(e => e.DocId);

            entity.ToTable("PartnersDocumentRequired");

            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .HasColumnName("DocID");
            entity.Property(e => e.DocumentRequired).HasMaxLength(100);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Nature).HasMaxLength(50);
        });

        modelBuilder.Entity<PartnersDocumentRequiredDatum>(entity =>
        {
            entity.HasKey(e => new { e.DistributionChannelId, e.DocId });

            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .HasColumnName("DocID");
            entity.Property(e => e.DocumentRequired).HasMaxLength(100);
            entity.Property(e => e.DueRenewalDate).HasColumnType("datetime");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.RecordedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SubmisionDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<PartnersDocumentRequiredHistorical>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PartnersDocumentRequiredHistorical");

            entity.Property(e => e.DelByUser).HasMaxLength(100);
            entity.Property(e => e.DelOnDate).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .HasColumnName("DocID");
            entity.Property(e => e.DocumentRequired).HasMaxLength(100);
            entity.Property(e => e.DueRenewalDate).HasColumnType("datetime");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Name).HasMaxLength(250);
            entity.Property(e => e.RecordedDate)
                .HasDefaultValueSql("(getdate())")
                .HasColumnType("datetime");
            entity.Property(e => e.SubmisionDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<PlCell>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PL_Cells");

            entity.Property(e => e.CellId).HasMaxLength(50);
            entity.Property(e => e.CellName).HasMaxLength(50);
            entity.Property(e => e.SectorId).HasMaxLength(50);
        });

        modelBuilder.Entity<PlCountry>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PL_Countries");

            entity.Property(e => e.Country).HasMaxLength(255);
        });

        modelBuilder.Entity<PlDistrict>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PL_Districts");

            entity.Property(e => e.DistrictId).HasMaxLength(50);
            entity.Property(e => e.DistrictName).HasMaxLength(50);
            entity.Property(e => e.ProvinceId).HasMaxLength(50);
        });

        modelBuilder.Entity<PlProvince>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PL_Provinces");

            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ProvinceId).HasMaxLength(50);
        });

        modelBuilder.Entity<PlSector>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PL_Sectors");

            entity.Property(e => e.DistrictId).HasMaxLength(50);
            entity.Property(e => e.SectorId).HasMaxLength(50);
            entity.Property(e => e.SectorName).HasMaxLength(50);
        });

        modelBuilder.Entity<PlUser>(entity =>
        {
            entity.HasKey(e => e.UserName);

            entity.ToTable("PL_User");

            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.Administrator).HasMaxLength(3);
            entity.Property(e => e.ChannelId)
                .HasMaxLength(50)
                .HasColumnName("ChannelID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployeeType).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.LastModifiedPassDate).HasColumnType("datetime");
            entity.Property(e => e.Manager).HasMaxLength(3);
            entity.Property(e => e.Names).HasMaxLength(100);
            entity.Property(e => e.PassSentSms)
                .HasMaxLength(50)
                .HasColumnName("PassSentSMS");
            entity.Property(e => e.Password).HasMaxLength(50);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<PlVillage>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PL_Villages");

            entity.Property(e => e.CellId).HasMaxLength(50);
            entity.Property(e => e.VillageId).HasMaxLength(50);
            entity.Property(e => e.VillageName).HasMaxLength(50);
        });

        modelBuilder.Entity<ProposalClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("PROPOSAL_Claims");

            entity.Property(e => e.AdvanceAndInterest).HasColumnName("Advance_And_ Interest");
            entity.Property(e => e.BeneficiaryNames)
                .HasMaxLength(255)
                .HasColumnName("Beneficiary Names");
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDateLastDocument)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Last_Document");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(255)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimReserveAmount).HasColumnName("Claim_Reserve_Amount");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(255)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(255)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective date");
            entity.Property(e => e.InterestOnAdvance).HasColumnName("Interest_On_Advance");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity date");
            entity.Property(e => e.NameOfProduct)
                .HasMaxLength(255)
                .HasColumnName("Name of Product");
            entity.Property(e => e.PhysicalLossIncurred).HasColumnName("Physical_Loss_Incurred");
            entity.Property(e => e.PlaceOfIncident)
                .HasColumnType("datetime")
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.PolicyholderName)
                .HasMaxLength(255)
                .HasColumnName("Policyholder name");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(255)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(255)
                .HasColumnName("Scheme Name");
            entity.Property(e => e.SumInsured).HasColumnName("Sum insured");
            entity.Property(e => e.SurrenderType)
                .HasColumnType("datetime")
                .HasColumnName("Surrender_Type");
            entity.Property(e => e.SurrenderValue).HasColumnName("Surrender_Value");
            entity.Property(e => e.Telephone)
                .HasMaxLength(255)
                .HasColumnName("TELEPHONE");
            entity.Property(e => e.TotalLoan).HasColumnName("Total_Loan");
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
            entity.Property(e => e.UserId).HasMaxLength(255);
        });

        modelBuilder.Entity<ProposalConvertTemp>(entity =>
        {
            entity.HasKey(e => e.ProposalNumber);

            entity.ToTable("Proposal_Convert_Temp");

            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ProposalRegister>(entity =>
        {
            entity.HasKey(e => e.ProposalNumber).HasName("PK_Proposal_Register_1");

            entity.ToTable("Proposal_Register");

            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DeathTpd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dreadDesease");
            entity.Property(e => e.Funeral)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("funeral");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IdfileExtension)
                .HasMaxLength(50)
                .HasColumnName("IDFileExtension");
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lossOfRevenue");
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
           
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Ppd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.ReturnedDate).HasColumnType("datetime");
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SpouceCover).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<Query>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Query");

            entity.Property(e => e.ApprovalDate)
                .HasPrecision(3)
                .HasColumnName("Approval_Date");
            entity.Property(e => e.ApprovedBy).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasPrecision(3);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdInsuranceCompany).HasMaxLength(50);
            entity.Property(e => e.InsuranceBranchCode).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasPrecision(3);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasPrecision(3);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasPrecision(3);
            entity.Property(e => e.Reference).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasPrecision(3);
            entity.Property(e => e.UnikRow).HasMaxLength(400);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<QueryCustomer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Salutation).HasMaxLength(50);
        });

        modelBuilder.Entity<QueryEducationProposal>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("QueryEducationProposal");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasPrecision(3);
            entity.Property(e => e.DistributionChannel).HasMaxLength(50);
            entity.Property(e => e.DistributionPerson).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasPrecision(3);
            entity.Property(e => e.EndwomentType).HasMaxLength(50);
            entity.Property(e => e.IdNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(250);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasPrecision(3);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<QuerySavingsProposal>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DeathTpd).HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease).HasColumnName("dreadDesease");
            entity.Property(e => e.Funeral).HasColumnName("funeral");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue).HasColumnName("lossOfRevenue");
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<Receipting>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Receipting");

            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.CheckIsuedBank).HasMaxLength(100);
            entity.Property(e => e.ChecqueNumber).HasMaxLength(100);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InsuredCode).HasMaxLength(50);
            entity.Property(e => e.InsuredName).HasMaxLength(100);
            entity.Property(e => e.Nauto)
                .ValueGeneratedOnAdd()
                .HasColumnName("NAuto");
            entity.Property(e => e.NpolOrScheme)
                .HasMaxLength(50)
                .HasColumnName("NPolOrScheme");
            entity.Property(e => e.Nreceipt)
                .HasMaxLength(100)
                .HasColumnName("NReceipt");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.PaidNinvoice)
                .HasMaxLength(100)
                .HasColumnName("PaidNInvoice");
            entity.Property(e => e.PayementMode).HasMaxLength(100);
            entity.Property(e => e.PayerCustomerCode).HasMaxLength(50);
            entity.Property(e => e.PayerCustomerName).HasMaxLength(100);
            entity.Property(e => e.PaymentReferenceDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentReferenceNo).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.ReceiptingBanqueInfo).HasMaxLength(100);
            entity.Property(e => e.UserCode).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ReceiptingBank>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReceiptingBank");

            entity.Property(e => e.BankAccountCode).HasMaxLength(255);
            entity.Property(e => e.BankAccountName).HasMaxLength(255);
            entity.Property(e => e.ClassId).HasColumnName("ClassID");
            entity.Property(e => e.IntacctBranchName).HasMaxLength(255);
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.WiseBranchName).HasMaxLength(255);
        });

        modelBuilder.Entity<ReceivedSm>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.PhoneNumber).HasMaxLength(150);
            entity.Property(e => e.ReceivedDate).HasColumnType("datetime");
            entity.Property(e => e.ReceivedTime).HasMaxLength(50);
        });

        modelBuilder.Entity<ReinsuranceCompany>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Reinsurance_Company");
        });

        modelBuilder.Entity<ReinsuranceRate>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Reinsurance_Rate");
        });

        modelBuilder.Entity<ReinsuranceRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Reinsurance_Register");

            entity.Property(e => e.CommissionAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ConfirmationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerNationalId)
                .HasMaxLength(50)
                .HasColumnName("CustomerNationalID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumTotal).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecoredDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceId)
                .HasMaxLength(50)
                .HasColumnName("ReinsuranceID");
            entity.Property(e => e.ReinsuredAmount).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.ReinsurerName).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.TotalSumInsured).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.TypeReinsurance).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ReinsuranceTreaty>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Reinsurance_Treaty");

            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.RecoredDate).HasMaxLength(255);
            entity.Property(e => e.Tpd).HasColumnName("TPD");
        });

        modelBuilder.Entity<ReinsuranceTreaty1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("ReinsuranceTreaty");

            entity.Property(e => e.IntAuto).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductName).HasMaxLength(100);
        });

        modelBuilder.Entity<RelationshipType>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Relationship_Type");

            entity.Property(e => e.RelationshipId).HasColumnName("RelationshipID");
            entity.Property(e => e.RelationshipTypeDescription).HasColumnName("Relationship_Type_Description");
        });

        modelBuilder.Entity<RightProductsCommand>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("RightProductsCommand");

            entity.Property(e => e.CommandId)
                .HasMaxLength(50)
                .HasColumnName("CommandID");
            entity.Property(e => e.CommandName).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductId)
                .HasMaxLength(50)
                .HasColumnName("ProductID");
            entity.Property(e => e.ProductName).HasMaxLength(50);
        });

        modelBuilder.Entity<SalesTarget>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("Sales_Targets");

            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.ReportingMonths).HasMaxLength(6);
        });

        modelBuilder.Entity<TempCustomer>(entity =>
        {
            entity.HasNoKey();

            entity.Property(e => e.Beneficiary).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.DoB).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.IdNumber).HasMaxLength(255);
            entity.Property(e => e.IssuedPlace)
                .HasMaxLength(255)
                .HasColumnName("Issued place");
            entity.Property(e => e.Names).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.ResidenceCell)
                .HasMaxLength(255)
                .HasColumnName("Residence cell");
            entity.Property(e => e.ResidenceDistrict)
                .HasMaxLength(255)
                .HasColumnName("Residence district");
            entity.Property(e => e.ResidenceSector)
                .HasMaxLength(255)
                .HasColumnName("Residence sector");
            entity.Property(e => e.ResidenceVillage)
                .HasMaxLength(255)
                .HasColumnName("Residence village");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Surnames).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<TempCustomers1>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempCustomers1");

            entity.Property(e => e.Beneficiary).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.DoB).HasMaxLength(255);
            entity.Property(e => e.Email).HasMaxLength(255);
            entity.Property(e => e.Gender).HasMaxLength(255);
            entity.Property(e => e.IdNumber).HasMaxLength(255);
            entity.Property(e => e.IssuedPlace)
                .HasMaxLength(255)
                .HasColumnName("Issued place");
            entity.Property(e => e.Names).HasMaxLength(255);
            entity.Property(e => e.Phone).HasMaxLength(255);
            entity.Property(e => e.PolicyNumber).HasMaxLength(255);
            entity.Property(e => e.ResidenceCell)
                .HasMaxLength(255)
                .HasColumnName("Residence cell");
            entity.Property(e => e.ResidenceDistrict)
                .HasMaxLength(255)
                .HasColumnName("Residence district");
            entity.Property(e => e.ResidenceSector)
                .HasMaxLength(255)
                .HasColumnName("Residence sector");
            entity.Property(e => e.ResidenceVillage)
                .HasMaxLength(255)
                .HasColumnName("Residence village");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.Surnames).HasMaxLength(255);
            entity.Property(e => e.Title).HasMaxLength(255);
        });

        modelBuilder.Entity<TempInvoicing>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TempInvoicing");

            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.InsuredCode).HasMaxLength(50);
            entity.Property(e => e.InsuredName).HasMaxLength(100);
            entity.Property(e => e.LastTransactionDate).HasColumnType("datetime");
            entity.Property(e => e.NautoInvoice).HasColumnName("NAutoInvoice");
            entity.Property(e => e.Ninvoice)
                .HasMaxLength(100)
                .HasColumnName("NInvoice");
            entity.Property(e => e.NpolOrEndorsement)
                .HasMaxLength(50)
                .HasColumnName("NPolOrEndorsement");
            entity.Property(e => e.NpolOrScheme)
                .HasMaxLength(50)
                .HasColumnName("NPolOrScheme");
            entity.Property(e => e.PayementMode).HasMaxLength(100);
            entity.Property(e => e.PayementPeriod).HasMaxLength(100);
            entity.Property(e => e.PayerCustomerCode).HasMaxLength(50);
            entity.Property(e => e.PayerCustomerName).HasMaxLength(100);
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.UserCode).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<TermDeposit>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("TermDeposit");

            entity.Property(e => e.AccountType)
                .HasMaxLength(10)
                .HasColumnName("Account_Type");
            entity.Property(e => e.AccruedInterest)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Accrued_Interest");
            entity.Property(e => e.BankAccountNo)
                .HasMaxLength(30)
                .HasColumnName("Bank_Account_No");
            entity.Property(e => e.BankLeBook)
                .HasMaxLength(3)
                .HasColumnName("Bank_Le_Book");
            entity.Property(e => e.BankName)
                .HasMaxLength(80)
                .HasColumnName("Bank_Name");
            entity.Property(e => e.ChargesIncurred)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Charges_Incurred");
            entity.Property(e => e.CreditRating)
                .HasMaxLength(10)
                .HasColumnName("Credit_Rating");
            entity.Property(e => e.CreditRatingAgency)
                .HasMaxLength(10)
                .HasColumnName("Credit_Rating_Agency");
            entity.Property(e => e.InterestRate)
                .HasColumnType("numeric(10, 5)")
                .HasColumnName("Interest_Rate");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .HasColumnName("LE_Book");
            entity.Property(e => e.MaturityDate).HasColumnName("Maturity_Date");
            entity.Property(e => e.OpeningDate).HasColumnName("Opening_Date");
            entity.Property(e => e.PensionSchemeType)
                .HasMaxLength(10)
                .HasColumnName("Pension_Scheme_Type");
            entity.Property(e => e.PrincipalAmount)
                .HasColumnType("numeric(23, 5)")
                .HasColumnName("Principal_Amount");
            entity.Property(e => e.RelatedPartyFlag)
                .HasMaxLength(1)
                .HasColumnName("Related_Party_Flag");
            entity.Property(e => e.YearMonth)
                .HasColumnType("numeric(6, 0)")
                .HasColumnName("Year_Month");
        });

        modelBuilder.Entity<View1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_1");

            entity.Property(e => e.Mode)
                .HasMaxLength(255)
                .HasColumnName("MODE");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Source)
                .HasMaxLength(255)
                .HasColumnName("SOURCE");
        });

        modelBuilder.Entity<View11>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_11");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReferencePayInvoice).HasMaxLength(100);
        });

        modelBuilder.Entity<View2>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_2");

            entity.Property(e => e.Mode).HasMaxLength(255);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDetails).HasMaxLength(100);
            entity.Property(e => e.Source).HasMaxLength(255);
        });

        modelBuilder.Entity<View3>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_3");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.TrueRef)
                .HasMaxLength(100)
                .HasColumnName("True Ref");
        });

        modelBuilder.Entity<View4>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_4");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DeathTpd).HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease).HasColumnName("dreadDesease");
            entity.Property(e => e.Funeral).HasColumnName("funeral");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue).HasColumnName("lossOfRevenue");
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberFam)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumberFAM");
            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<View5>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_5");

            entity.Property(e => e.InvoiceNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberCorrect).HasMaxLength(50);
        });

        modelBuilder.Entity<View6>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_6");

            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<View7>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_7");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumberClean).HasMaxLength(50);
            entity.Property(e => e.PlaceOfBirth).HasMaxLength(50);
            entity.Property(e => e.VillageId).HasMaxLength(50);
        });

        modelBuilder.Entity<View8>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_8");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<View9>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_9");

            entity.Property(e => e.POl)
                .HasMaxLength(50)
                .HasColumnName("pOL");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewAkabandoAllPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Akabando_All_Payments");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewAkabandoAllPaymentsOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Akabando_All_Payments_Old");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.YearMonth)
                .HasMaxLength(30)
                .HasColumnName("YEAR_MONTH");
        });

        modelBuilder.Entity<ViewAkabandoAllPoliciesNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Akabando_All_Policies_New");

            entity.Property(e => e.Amount)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.NewBusiness)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.TotalPaidPolicies)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Total Paid Policies");
            entity.Property(e => e.YearMonth)
                .HasMaxLength(6)
                .HasColumnName("YEAR_MONTH");
        });

        modelBuilder.Entity<ViewAkabandoAllPoliciesOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Akabando_All_Policies_Old");

            entity.Property(e => e.CreationYearMonths)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("Creation_YearMonths");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewAkabandoAllPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Akabando_All_Policies");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewAllChannel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ALL_CHANNELS");

            entity.Property(e => e.ChannelAdress).HasMaxLength(250);
            entity.Property(e => e.ChannelContactEmail).HasMaxLength(50);
            entity.Property(e => e.ChannelContactTelephone).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.ContactPerson).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(255)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.InRecord).HasColumnName("inRecord");
            entity.Property(e => e.LicenceId)
                .HasMaxLength(50)
                .HasColumnName("LicenceID");
            entity.Property(e => e.Products)
                .HasMaxLength(26)
                .IsUnicode(false);
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewAllChannelsLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ALL_CHANNELS_LOAN");

            entity.Property(e => e.InRecord).HasColumnName("inRecord");
            entity.Property(e => e.LicenceId).HasColumnName("LicenceID");
            entity.Property(e => e.Products)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.VendorCode).HasMaxLength(255);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewAllClaimsIkimina>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Claims_Ikimina");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("PremiumPayment Date");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate).HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllCustomersNotInUse>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Customers_NotInUse");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.ProductName)
                .HasMaxLength(19)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewAllCustomersTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Customers_Tables");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.ProductName)
                .HasMaxLength(19)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewAllInvoicesEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Invoices_Education");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
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
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllInvoicesEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Invoices_EPI");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(18)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllInvoicesFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Invoices_Family");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("smalldatetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("smalldatetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType).HasMaxLength(50);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllInvoicesLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Invoices_Loan");

            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(50)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Comments)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment).HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(50)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(500)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllInvoicesProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Invoices_Products");

            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(50)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
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
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(50)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(500);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(500)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType).HasMaxLength(50);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllInvoicesPsEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Invoices_PS_Endo");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType).HasMaxLength(50);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllInvoicesPsMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Invoices_PS_Main");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType).HasMaxLength(50);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllOutStandingAllPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllOutStandingAllPolicies");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .HasColumnName("IDNumber");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllOutStandingEdu>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllOutStanding_Edu");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .HasColumnName("IDNumber");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllOutStandingEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllOutStanding_EPI");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .HasColumnName("IDNumber");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllOutStandingFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllOutStanding_Family");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .HasColumnName("IDNumber");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllOutStandingP>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllOutStanding_PS");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Expr1).HasMaxLength(100);
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .HasColumnName("IDNumber");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllOutStandingPremium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AllOutStandingPremium");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.Schemes).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewAllPaymentEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Payment_Education");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
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
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(100)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPaymentEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Payment_EPI");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPaymentFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Payment_Family");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPaymentLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Payment_Loan");

            entity.Property(e => e.AccountNumberAndBank).HasMaxLength(100);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(50)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Comments)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment).HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(50)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(50);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(500)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPaymentPsEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Payment_PS_Endo");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("PremiumPayment Date");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate).HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPaymentPsEndox>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Payment_PS_Endox");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy).HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus).HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("PremiumPayment Date");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate).HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType).HasMaxLength(50);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPaymentPsMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Payment_PS_Main");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment).HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("PremiumPayment Date");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate).HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPoliciesEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_Education");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(450)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .HasColumnName("Account_No");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DatePolicy1).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemId)
                .HasMaxLength(50)
                .HasColumnName("SchemID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(50);
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

        modelBuilder.Entity<ViewAllPoliciesEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_EPI");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(450)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .HasColumnName("Account_No");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdsi).HasColumnName("DeathTPDSI");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
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

        modelBuilder.Entity<ViewAllPoliciesFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_Family");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(450)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
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

        modelBuilder.Entity<ViewAllPoliciesLoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_LoanProtection");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.BankNames).HasMaxLength(551);
            entity.Property(e => e.BankNamesScheme).HasMaxLength(551);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(100);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
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

        modelBuilder.Entity<ViewAllPoliciesPaymentProduct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_Payment_Products");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductType).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPoliciesPaymentProductsNew>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_Payment_Products_New");

            entity.Property(e => e.AccountNumberAndBank).HasMaxLength(100);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(50)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
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
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate)
                .HasColumnType("datetime")
                .HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(50)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(100)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(500)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(20)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPoliciesPsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_PS_All");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(101)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.Channel).HasMaxLength(150);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products).HasMaxLength(50);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
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

        modelBuilder.Entity<ViewAllPoliciesPsEndorsement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_PS_Endorsement");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(101)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .HasColumnName("Account_No");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.Channel).HasMaxLength(150);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products).HasMaxLength(50);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
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

        modelBuilder.Entity<ViewAllPoliciesPsMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_PS_Main");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(101)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.Channel).HasMaxLength(150);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products).HasMaxLength(50);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
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

        modelBuilder.Entity<ViewAllPoliciesPsMainStattment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_PS_Main_Stattments");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(101)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.Channel).HasMaxLength(150);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
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

        modelBuilder.Entity<ViewAllPoliciesRecoveryReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_Recovery_Report");

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
            entity.Property(e => e.MaxPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewAllPoliciesStatment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies_Statments");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.Channel).HasMaxLength(551);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(100);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(551);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
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

        modelBuilder.Entity<ViewAllPoliciesWithoutPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_PoliciesWithoutPayments");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAllPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Policies");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AccountStatusDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Status_Date");
            entity.Property(e => e.AccountType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Account_Type");
            entity.Property(e => e.Channel).HasMaxLength(551);
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(100);
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(551);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
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

        modelBuilder.Entity<ViewAllPolicySignedReturned>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_PolicySignedReturned");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewAllPolicyWithoutBeneficiariesAndProposal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_PolicyWithoutBeneficiariesAndProposal");

            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewAllPolicyWithoutBeneficiariesAndProposalP>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_PolicyWithoutBeneficiariesAndProposalPS");

            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewAllPolicyWithoutBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_PolicyWithoutBeneficiaries");

            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewAllUsedChannel>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_All_Used_Channels");

            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.ChannelType).HasMaxLength(255);
            entity.Property(e => e.Codevendors)
                .HasMaxLength(50)
                .HasColumnName("CODEVENDORS");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(255)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.Products)
                .HasMaxLength(26)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewAssetEmployeeDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("View_AssetEmployeeDetails");

            entity.Property(e => e.DepartmentName)
                .HasMaxLength(50)
                .HasColumnName("Department_Name");
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(50)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.FirstName).HasMaxLength(100);
            entity.Property(e => e.JobTitle).HasMaxLength(200);
            entity.Property(e => e.LastName).HasMaxLength(100);
            entity.Property(e => e.NationalId)
                .HasMaxLength(20)
                .HasColumnName("NationalID");
            entity.Property(e => e.StartDate).HasPrecision(3);
        });

        modelBuilder.Entity<ViewAssetRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AssetRegister");

            entity.Property(e => e.AquisitionDate).HasColumnType("datetime");
            entity.Property(e => e.AssignedDate).HasColumnType("datetime");
            entity.Property(e => e.Barcode).HasMaxLength(20);
            entity.Property(e => e.CategoryId)
                .HasMaxLength(20)
                .HasColumnName("Category_ID");
            entity.Property(e => e.CategoryName)
                .HasMaxLength(100)
                .HasColumnName("CATEGORY_NAME");
            entity.Property(e => e.CodeItem).HasMaxLength(20);
            entity.Property(e => e.Comments).HasMaxLength(255);
            entity.Property(e => e.EmployeeId)
                .HasMaxLength(20)
                .HasColumnName("EmployeeID");
            entity.Property(e => e.FullName).HasMaxLength(100);
            entity.Property(e => e.IdJobTitle).HasMaxLength(200);
            entity.Property(e => e.ItemDescription).HasMaxLength(100);
            entity.Property(e => e.ItemLocation).HasMaxLength(255);
            entity.Property(e => e.MvtComment).HasMaxLength(255);
            entity.Property(e => e.MvtStatus).HasMaxLength(10);
            entity.Property(e => e.Nbv).HasColumnName("NBV");
            entity.Property(e => e.SerialNumber).HasMaxLength(20);
            entity.Property(e => e.Status).HasMaxLength(20);
        });

        modelBuilder.Entity<ViewAudit>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Audit");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewAxxisCustomersIngenzi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AXXIS_Customers_Ingenzi");

            entity.Property(e => e.AccountNumber).HasColumnName("ACCOUNT NUMBER");
            entity.Property(e => e.BranchId).HasColumnName("BRANCH ID");
            entity.Property(e => e.BranchName)
                .HasMaxLength(100)
                .HasColumnName("BRANCH NAME");
            entity.Property(e => e.Category)
                .HasMaxLength(50)
                .HasColumnName("CATEGORY");
            entity.Property(e => e.CategoryType)
                .HasMaxLength(50)
                .HasColumnName("CATEGORY TYPE");
            entity.Property(e => e.CreationDate).HasColumnName("CREATION DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER CODE");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("DATE OF BIRTH");
            entity.Property(e => e.Education)
                .HasMaxLength(50)
                .HasColumnName("EDUCATION");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmployerContactPerson)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER CONTACT PERSON");
            entity.Property(e => e.EmployerContactPersonNumber)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER CONTACT PERSON NUMBER");
            entity.Property(e => e.EmployerFullAddress)
                .HasMaxLength(200)
                .HasColumnName("EMPLOYER FULL ADDRESS");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER NAME");
            entity.Property(e => e.EmployerPhone)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER PHONE");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("FIRST NAME");
            entity.Property(e => e.FullName)
                .HasMaxLength(450)
                .HasColumnName("FULL NAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(50)
                .HasColumnName("GENDER");
            entity.Property(e => e.HouseNumber)
                .HasMaxLength(50)
                .HasColumnName("HOUSE NUMBER");
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("ID DOCUMENT NUMBER");
            entity.Property(e => e.IdDocumentType)
                .HasMaxLength(50)
                .HasColumnName("ID DOCUMENT TYPE");
            entity.Property(e => e.IssuedCell)
                .HasMaxLength(50)
                .HasColumnName("ISSUED CELL");
            entity.Property(e => e.IssuedDistrict)
                .HasMaxLength(50)
                .HasColumnName("ISSUED DISTRICT");
            entity.Property(e => e.IssuedProvince)
                .HasMaxLength(50)
                .HasColumnName("ISSUED PROVINCE");
            entity.Property(e => e.IssuedSector)
                .HasMaxLength(50)
                .HasColumnName("ISSUED SECTOR");
            entity.Property(e => e.IssuedVillage)
                .HasMaxLength(50)
                .HasColumnName("ISSUED VILLAGE");
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("LAST NAME");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("MARITAL STATUS");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("MIDDLE NAME");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasColumnName("NATIONALITY");
            entity.Property(e => e.NumberOfDependents).HasColumnName("NUMBER OF DEPENDENTS");
            entity.Property(e => e.Occupation)
                .HasMaxLength(50)
                .HasColumnName("OCCUPATION");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PHONE NUMBER 1");
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(50)
                .HasColumnName("PHONE NUMBER 2");
            entity.Property(e => e.PlaceOfBirth)
                .HasMaxLength(50)
                .HasColumnName("PLACE OF BIRTH");
            entity.Property(e => e.ReferenceIfJoint).HasColumnName("REFERENCE IF JOINT");
            entity.Property(e => e.RelatedParty)
                .HasMaxLength(100)
                .HasColumnName("RELATED PARTY");
            entity.Property(e => e.ResidenceCell)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE CELL");
            entity.Property(e => e.ResidenceDistrict)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE DISTRICT");
            entity.Property(e => e.ResidenceProvince)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE PROVINCE");
            entity.Property(e => e.ResidenceSector)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE SECTOR");
            entity.Property(e => e.ResidenceVillage)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE VILLAGE");
            entity.Property(e => e.Salutation)
                .HasMaxLength(50)
                .HasColumnName("SALUTATION");
            entity.Property(e => e.SocialEconomicClass).HasColumnName("SOCIAL ECONOMIC CLASS");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StreetNumber)
                .HasMaxLength(50)
                .HasColumnName("STREET NUMBER");
            entity.Property(e => e.UserId)
                .HasMaxLength(50)
                .HasColumnName("USER ID");
        });

        modelBuilder.Entity<ViewAxxisCustomersLoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AXXIS_Customers_LoanProtection");

            entity.Property(e => e.AccountNumber).HasColumnName("ACCOUNT NUMBER");
            entity.Property(e => e.BranchId)
                .HasMaxLength(50)
                .HasColumnName("BRANCH ID");
            entity.Property(e => e.BranchName).HasColumnName("BRANCH NAME");
            entity.Property(e => e.Category).HasMaxLength(50);
            entity.Property(e => e.CategoryType).HasColumnName("CATEGORY TYPE");
            entity.Property(e => e.CreationDate).HasColumnName("CREATION DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER CODE");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("DATE OF BIRTH");
            entity.Property(e => e.Education).HasColumnName("EDUCATION");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EmployerContactPerson)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER CONTACT PERSON");
            entity.Property(e => e.EmployerContactPersonNumber)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER CONTACT PERSON NUMBER");
            entity.Property(e => e.EmployerFullAddress)
                .HasMaxLength(200)
                .HasColumnName("EMPLOYER FULL ADDRESS");
            entity.Property(e => e.EmployerName)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER NAME");
            entity.Property(e => e.EmployerPhone)
                .HasMaxLength(50)
                .HasColumnName("EMPLOYER PHONE");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("FIRST NAME");
            entity.Property(e => e.FullName).HasColumnName("FULL NAME");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.HouseNumber).HasColumnName("HOUSE NUMBER");
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("ID DOCUMENT NUMBER");
            entity.Property(e => e.IdDocumentType)
                .HasMaxLength(50)
                .HasColumnName("ID DOCUMENT TYPE");
            entity.Property(e => e.IssuedCell)
                .HasMaxLength(50)
                .HasColumnName("ISSUED CELL");
            entity.Property(e => e.IssuedDistrict)
                .HasMaxLength(50)
                .HasColumnName("ISSUED DISTRICT");
            entity.Property(e => e.IssuedProvince)
                .HasMaxLength(50)
                .HasColumnName("ISSUED PROVINCE");
            entity.Property(e => e.IssuedSector)
                .HasMaxLength(50)
                .HasColumnName("ISSUED SECTOR");
            entity.Property(e => e.IssuedVillage)
                .HasMaxLength(50)
                .HasColumnName("ISSUED VILLAGE");
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("LAST NAME");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(50)
                .HasColumnName("MARITAL STATUS");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("MIDDLE NAME");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.NumberOfDependents).HasColumnName("NUMBER OF DEPENDENTS");
            entity.Property(e => e.Occupation).HasColumnName("OCCUPATION");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PHONE NUMBER 1");
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(50)
                .HasColumnName("PHONE NUMBER 2");
            entity.Property(e => e.PlaceOfBirth).HasColumnName("PLACE OF BIRTH");
            entity.Property(e => e.ReferenceIfJoint)
                .HasMaxLength(50)
                .HasColumnName("REFERENCE IF JOINT");
            entity.Property(e => e.RelatedParty).HasColumnName("RELATED PARTY");
            entity.Property(e => e.ResidenceCell)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE CELL");
            entity.Property(e => e.ResidenceDistrict)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE DISTRICT");
            entity.Property(e => e.ResidenceProvince)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE PROVINCE");
            entity.Property(e => e.ResidenceSector)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE SECTOR");
            entity.Property(e => e.ResidenceVillage)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE VILLAGE");
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SocialEconomicClass).HasColumnName("SOCIAL ECONOMIC CLASS");
            entity.Property(e => e.Status)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("STATUS");
            entity.Property(e => e.StreetNumber).HasColumnName("STREET NUMBER");
            entity.Property(e => e.UserId).HasColumnName("USER ID");
        });

        modelBuilder.Entity<ViewAxxisCustomersSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_AXXIS_Customers_Savings");

            entity.Property(e => e.AccountNumber).HasColumnName("ACCOUNT NUMBER");
            entity.Property(e => e.BranchId).HasColumnName("BRANCH ID");
            entity.Property(e => e.BranchName).HasColumnName("BRANCH NAME");
            entity.Property(e => e.Category).HasColumnName("CATEGORY");
            entity.Property(e => e.CategoryType).HasColumnName("CATEGORY TYPE");
            entity.Property(e => e.CreationDate).HasColumnName("CREATION DATE");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("CUSTOMER CODE");
            entity.Property(e => e.DateOfBirth).HasColumnName("DATE OF BIRTH");
            entity.Property(e => e.Education).HasColumnName("EDUCATION");
            entity.Property(e => e.Email)
                .HasMaxLength(50)
                .HasColumnName("EMAIL");
            entity.Property(e => e.EmployerContactPerson).HasColumnName("EMPLOYER CONTACT PERSON");
            entity.Property(e => e.EmployerContactPersonNumber).HasColumnName("EMPLOYER CONTACT PERSON NUMBER");
            entity.Property(e => e.EmployerFullAddress).HasColumnName("EMPLOYER FULL ADDRESS");
            entity.Property(e => e.EmployerName).HasColumnName("EMPLOYER NAME");
            entity.Property(e => e.EmployerPhone).HasColumnName("EMPLOYER PHONE");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("FIRST NAME");
            entity.Property(e => e.FullName).HasColumnName("FULL NAME");
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength()
                .HasColumnName("GENDER");
            entity.Property(e => e.HouseNumber).HasColumnName("HOUSE NUMBER");
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("ID DOCUMENT NUMBER");
            entity.Property(e => e.IdDocumentType)
                .HasMaxLength(50)
                .HasColumnName("ID DOCUMENT TYPE");
            entity.Property(e => e.IssuedCell).HasColumnName("ISSUED CELL");
            entity.Property(e => e.IssuedDistrict)
                .HasMaxLength(50)
                .HasColumnName("ISSUED DISTRICT");
            entity.Property(e => e.IssuedProvince)
                .HasMaxLength(50)
                .HasColumnName("ISSUED PROVINCE");
            entity.Property(e => e.IssuedSector)
                .HasMaxLength(50)
                .HasColumnName("ISSUED SECTOR");
            entity.Property(e => e.IssuedVillage).HasColumnName("ISSUED VILLAGE");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("LAST NAME");
            entity.Property(e => e.MaritalStatus).HasColumnName("MARITAL STATUS");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("MIDDLE NAME");
            entity.Property(e => e.Nationality)
                .HasMaxLength(50)
                .HasColumnName("NATIONALITY");
            entity.Property(e => e.NumberOfDependents).HasColumnName("NUMBER OF DEPENDENTS");
            entity.Property(e => e.Occupation).HasColumnName("OCCUPATION");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PHONE NUMBER 1");
            entity.Property(e => e.PhoneNumber2).HasColumnName("PHONE NUMBER 2");
            entity.Property(e => e.PlaceOfBirth).HasColumnName("PLACE OF BIRTH");
            entity.Property(e => e.ReferenceIfJoint).HasColumnName("REFERENCE IF JOINT");
            entity.Property(e => e.RelatedParty).HasColumnName("RELATED PARTY");
            entity.Property(e => e.ResidenceCell).HasColumnName("RESIDENCE CELL");
            entity.Property(e => e.ResidenceDistrict)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE DISTRICT");
            entity.Property(e => e.ResidenceProvince)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE PROVINCE");
            entity.Property(e => e.ResidenceSector)
                .HasMaxLength(50)
                .HasColumnName("RESIDENCE SECTOR");
            entity.Property(e => e.ResidenceVillage).HasColumnName("RESIDENCE VILLAGE");
            entity.Property(e => e.Salutation)
                .HasMaxLength(50)
                .HasColumnName("SALUTATION");
            entity.Property(e => e.SocialEconomicClass).HasColumnName("SOCIAL ECONOMIC CLASS");
            entity.Property(e => e.Status).HasColumnName("STATUS");
            entity.Property(e => e.StreetNumber).HasColumnName("STREET NUMBER");
            entity.Property(e => e.UserId).HasColumnName("USER ID");
        });

        modelBuilder.Entity<ViewBnrAllAcct>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_ALL_ACCT");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.InstitutionalSectorCode)
                .HasMaxLength(5)
                .IsUnicode(false)
                .HasColumnName("Institutional_Sector_Code");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfBeneficiaries).HasColumnName("Num_Of_Beneficiaries");
            entity.Property(e => e.PolicyWrittenThru).HasColumnName("Policy_Written_Thru");
            entity.Property(e => e.PublicSectorCode)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Public_Sector_Code");
            entity.Property(e => e.RenewalPolicyFlag)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Renewal_Policy_Flag");
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

        modelBuilder.Entity<ViewBnrAllCont>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_ALL_CONT");

            entity.Property(e => e.Assured).HasMaxLength(901);
            entity.Property(e => e.BenefitExpiryDate)
                .HasColumnType("datetime")
                .HasColumnName("Benefit_Expiry_Date");
            entity.Property(e => e.CommenceDate)
                .HasColumnType("datetime")
                .HasColumnName("Commence_Date");
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
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DealSubType)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Deal_Sub_Type");
            entity.Property(e => e.DealType)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Deal_Type");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity_Date");
            entity.Property(e => e.NumOfCoveredPersons).HasColumnName("Num_Of_Covered_Persons");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Policy_Type");
            entity.Property(e => e.PremiumPaymentFreq)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Premium_Payment_Freq");
            entity.Property(e => e.PrincipalAmountFcy).HasColumnName("Principal_Amount_FCY");
            entity.Property(e => e.PrincipalAmountLcy).HasColumnName("Principal_Amount_LCY");
            entity.Property(e => e.PrincipalGl)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Principal_GL");
            entity.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasColumnName("Start_Date");
            entity.Property(e => e.SumInsured).HasColumnName("Sum_Insured");
            entity.Property(e => e.SumReassured).HasColumnName("Sum_Reassured");
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
        });

        modelBuilder.Entity<ViewBnrAllCust>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_ALL_CUST");

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
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_of_Birth");
            entity.Property(e => e.EconomicSubSectorCodeIsic).HasColumnName("Economic_Sub_Sector_Code_ISIC");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("Email_ID");
            entity.Property(e => e.EmpAddress1).HasColumnName("Emp_Address_1");
            entity.Property(e => e.EmpAddress2).HasColumnName("Emp_Address_2");
            entity.Property(e => e.EmpCountry).HasColumnName("Emp_Country");
            entity.Property(e => e.EmpVillage).HasColumnName("Emp_Village");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployerName).HasColumnName("Employer_Name");
            entity.Property(e => e.FaxNumber1).HasColumnName("Fax_Number_1");
            entity.Property(e => e.FaxNumber2).HasColumnName("Fax_Number_2");
            entity.Property(e => e.Forename1)
                .HasMaxLength(450)
                .HasColumnName("Forename_1");
            entity.Property(e => e.Forename2)
                .HasMaxLength(450)
                .HasColumnName("Forename_2");
            entity.Property(e => e.HealthInsuranceNumber).HasColumnName("Health_Insurance_Number");
            entity.Property(e => e.HomeTelephone)
                .HasMaxLength(50)
                .HasColumnName("Home_Telephone");
            entity.Property(e => e.IncomeFrequency)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Income_Frequency");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.LegalStatus).HasColumnName("Legal_Status");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Marital_Status");
            entity.Property(e => e.NaicsCode).HasColumnName("NAICS_Code");
            entity.Property(e => e.NationalIdNumber)
                .HasMaxLength(50)
                .HasColumnName("National_ID_Number");
            entity.Property(e => e.NationalIdType).HasColumnName("National_ID_Type");
            entity.Property(e => e.Nationality)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NextOfKinEmailId).HasColumnName("Next_of_kin_Email_ID");
            entity.Property(e => e.NextOfKinIdNumber).HasColumnName("Next_of_kin_ID_Number");
            entity.Property(e => e.NextOfKinIdType).HasColumnName("Next_of_kin_ID_Type");
            entity.Property(e => e.NextOfKinName).HasColumnName("Next_of_kin_Name");
            entity.Property(e => e.NextOfKinTelephone).HasColumnName("Next_of_kin_Telephone");
            entity.Property(e => e.NumberOfDependants).HasColumnName("Number_Of_Dependants");
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
            entity.Property(e => e.RelatedPartyName).HasColumnName("Related_Party_Name");
            entity.Property(e => e.RelationshipType).HasColumnName("Relationship_Type");
            entity.Property(e => e.Residence)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SocialEconomicClass).HasColumnName("Social_Economic_Class");
            entity.Property(e => e.SpouseName).HasColumnName("Spouse_Name");
            entity.Property(e => e.SsnNumber).HasColumnName("SSN_Number");
            entity.Property(e => e.Surname).HasMaxLength(450);
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
            entity.Property(e => e.WorkTelephone)
                .HasMaxLength(50)
                .HasColumnName("Work_Telephone");
        });

        modelBuilder.Entity<ViewBnrAllCustomersFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_All_Customers_Family");

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
                .HasMaxLength(450)
                .HasColumnName("Customer_Acronym");
            entity.Property(e => e.CustomerGender)
                .HasMaxLength(50)
                .HasColumnName("Customer_Gender");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(450)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerOpenDate).HasColumnName("Customer_Open_Date");
            entity.Property(e => e.CustomerStatus).HasColumnName("Customer_Status");
            entity.Property(e => e.CustomerTin).HasColumnName("Customer_TIN");
            entity.Property(e => e.DateLastModified)
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date_of_Birth");
            entity.Property(e => e.EconomicSubSectorCodeIsic).HasColumnName("Economic_Sub_Sector_Code_ISIC");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("Email_ID");
            entity.Property(e => e.EmpAddress1).HasColumnName("Emp_Address_1");
            entity.Property(e => e.EmpAddress2).HasColumnName("Emp_Address_2");
            entity.Property(e => e.EmpCountry).HasColumnName("Emp_Country");
            entity.Property(e => e.EmpVillage).HasColumnName("Emp_Village");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployerName).HasColumnName("Employer_Name");
            entity.Property(e => e.FaxNumber1).HasColumnName("Fax_Number_1");
            entity.Property(e => e.FaxNumber2).HasColumnName("Fax_Number_2");
            entity.Property(e => e.Forename1)
                .HasMaxLength(450)
                .HasColumnName("Forename_1");
            entity.Property(e => e.Forename2)
                .HasMaxLength(450)
                .HasColumnName("Forename_2");
            entity.Property(e => e.HealthInsuranceNumber).HasColumnName("Health_Insurance_Number");
            entity.Property(e => e.HomeTelephone)
                .HasMaxLength(50)
                .HasColumnName("Home_Telephone");
            entity.Property(e => e.IncomeFrequency)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Income_Frequency");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.LegalStatus).HasColumnName("Legal_Status");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Marital_Status");
            entity.Property(e => e.NaicsCode).HasColumnName("NAICS_Code");
            entity.Property(e => e.NationalIdNumber)
                .HasMaxLength(50)
                .HasColumnName("National_ID_Number");
            entity.Property(e => e.NationalIdType).HasColumnName("National_ID_Type");
            entity.Property(e => e.Nationality)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NextOfKinEmailId).HasColumnName("Next_of_kin_Email_ID");
            entity.Property(e => e.NextOfKinIdNumber).HasColumnName("Next_of_kin_ID_Number");
            entity.Property(e => e.NextOfKinIdType).HasColumnName("Next_of_kin_ID_Type");
            entity.Property(e => e.NextOfKinName).HasColumnName("Next_of_kin_Name");
            entity.Property(e => e.NextOfKinTelephone).HasColumnName("Next_of_kin_Telephone");
            entity.Property(e => e.NumberOfDependants).HasColumnName("Number_Of_Dependants");
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
            entity.Property(e => e.RelatedPartyName).HasColumnName("Related_Party_Name");
            entity.Property(e => e.RelationshipType).HasColumnName("Relationship_Type");
            entity.Property(e => e.Residence)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SocialEconomicClass).HasColumnName("Social_Economic_Class");
            entity.Property(e => e.SpouseName).HasColumnName("Spouse_Name");
            entity.Property(e => e.SsnNumber).HasColumnName("SSN_Number");
            entity.Property(e => e.Surname).HasMaxLength(450);
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
            entity.Property(e => e.WorkTelephone)
                .HasMaxLength(50)
                .HasColumnName("Work_Telephone");
        });

        modelBuilder.Entity<ViewBnrAllCustomersLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_All_Customers_Loan");

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
            entity.Property(e => e.EconomicSubSectorCodeIsic).HasColumnName("Economic_Sub_Sector_Code_ISIC");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("Email_ID");
            entity.Property(e => e.EmpAddress1).HasColumnName("Emp_Address_1");
            entity.Property(e => e.EmpAddress2).HasColumnName("Emp_Address_2");
            entity.Property(e => e.EmpCountry).HasColumnName("Emp_Country");
            entity.Property(e => e.EmpVillage).HasColumnName("Emp_Village");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployerName).HasColumnName("Employer_Name");
            entity.Property(e => e.FaxNumber1).HasColumnName("Fax_Number_1");
            entity.Property(e => e.FaxNumber2).HasColumnName("Fax_Number_2");
            entity.Property(e => e.Forename1)
                .HasMaxLength(450)
                .HasColumnName("Forename_1");
            entity.Property(e => e.Forename2)
                .HasMaxLength(450)
                .HasColumnName("Forename_2");
            entity.Property(e => e.HealthInsuranceNumber).HasColumnName("Health_Insurance_Number");
            entity.Property(e => e.HomeTelephone)
                .HasMaxLength(50)
                .HasColumnName("Home_Telephone");
            entity.Property(e => e.IncomeFrequency)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Income_Frequency");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.LegalStatus).HasColumnName("Legal_Status");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Marital_Status");
            entity.Property(e => e.NaicsCode).HasColumnName("NAICS_Code");
            entity.Property(e => e.NationalIdNumber)
                .HasMaxLength(50)
                .HasColumnName("National_ID_Number");
            entity.Property(e => e.NationalIdType).HasColumnName("National_ID_Type");
            entity.Property(e => e.Nationality)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NextOfKinEmailId).HasColumnName("Next_of_kin_Email_ID");
            entity.Property(e => e.NextOfKinIdNumber).HasColumnName("Next_of_kin_ID_Number");
            entity.Property(e => e.NextOfKinIdType).HasColumnName("Next_of_kin_ID_Type");
            entity.Property(e => e.NextOfKinName).HasColumnName("Next_of_kin_Name");
            entity.Property(e => e.NextOfKinTelephone).HasColumnName("Next_of_kin_Telephone");
            entity.Property(e => e.NumberOfDependants).HasColumnName("Number_Of_Dependants");
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
            entity.Property(e => e.RelatedPartyName).HasColumnName("Related_Party_Name");
            entity.Property(e => e.RelationshipType).HasColumnName("Relationship_Type");
            entity.Property(e => e.Residence)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SocialEconomicClass).HasColumnName("Social_Economic_Class");
            entity.Property(e => e.SpouseName).HasColumnName("Spouse_Name");
            entity.Property(e => e.SsnNumber).HasColumnName("SSN_Number");
            entity.Property(e => e.Surname).HasMaxLength(450);
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
            entity.Property(e => e.WorkTelephone)
                .HasMaxLength(50)
                .HasColumnName("Work_Telephone");
        });

        modelBuilder.Entity<ViewBnrAllCustomersPensionSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_All_Customers_PensionSavings");

            entity.Property(e => e.AccountStatus).HasColumnName("Account_Status");
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
                .HasMaxLength(152)
                .HasColumnName("Customer_Acronym");
            entity.Property(e => e.CustomerGender)
                .HasMaxLength(10)
                .HasColumnName("Customer_Gender");
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.CustomerName)
                .HasMaxLength(152)
                .HasColumnName("Customer_Name");
            entity.Property(e => e.CustomerOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Customer_Open_Date");
            entity.Property(e => e.CustomerTin).HasColumnName("Customer_TIN");
            entity.Property(e => e.DateLastModified)
                .HasColumnType("datetime")
                .HasColumnName("Date_Last_Modified");
            entity.Property(e => e.DateOfBirth).HasColumnName("Date_of_Birth");
            entity.Property(e => e.EconomicSubSectorCodeIsic).HasColumnName("Economic_Sub_Sector_Code_ISIC");
            entity.Property(e => e.EmailId)
                .HasMaxLength(50)
                .HasColumnName("Email_ID");
            entity.Property(e => e.EmpAddress1).HasColumnName("Emp_Address_1");
            entity.Property(e => e.EmpAddress2).HasColumnName("Emp_Address_2");
            entity.Property(e => e.EmpCountry).HasColumnName("Emp_Country");
            entity.Property(e => e.EmpVillage).HasColumnName("Emp_Village");
            entity.Property(e => e.EmployeeId).HasColumnName("Employee_ID");
            entity.Property(e => e.EmployerName).HasColumnName("Employer_Name");
            entity.Property(e => e.FaxNumber1).HasColumnName("Fax_Number_1");
            entity.Property(e => e.FaxNumber2).HasColumnName("Fax_Number_2");
            entity.Property(e => e.Forename1)
                .HasMaxLength(152)
                .HasColumnName("Forename_1");
            entity.Property(e => e.Forename2)
                .HasMaxLength(152)
                .HasColumnName("Forename_2");
            entity.Property(e => e.HealthInsuranceNumber).HasColumnName("Health_Insurance_Number");
            entity.Property(e => e.HomeTelephone).HasColumnName("Home_Telephone");
            entity.Property(e => e.IncomeFrequency)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Income_Frequency");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.LegalStatus).HasColumnName("Legal_Status");
            entity.Property(e => e.MaritalStatus)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Marital_Status");
            entity.Property(e => e.NaicsCode).HasColumnName("NAICS_Code");
            entity.Property(e => e.NationalIdNumber)
                .HasMaxLength(50)
                .HasColumnName("National_ID_Number");
            entity.Property(e => e.NationalIdType).HasColumnName("National_ID_Type");
            entity.Property(e => e.Nationality)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.NextOfKinEmailId).HasColumnName("Next_of_kin_Email_ID");
            entity.Property(e => e.NextOfKinIdNumber).HasColumnName("Next_of_kin_ID_Number");
            entity.Property(e => e.NextOfKinIdType).HasColumnName("Next_of_kin_ID_Type");
            entity.Property(e => e.NextOfKinName).HasColumnName("Next_of_kin_Name");
            entity.Property(e => e.NextOfKinTelephone).HasColumnName("Next_of_kin_Telephone");
            entity.Property(e => e.NumberOfDependants).HasColumnName("Number_Of_Dependants");
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
            entity.Property(e => e.RelatedPartyName).HasColumnName("Related_Party_Name");
            entity.Property(e => e.RelationshipType).HasColumnName("Relationship_Type");
            entity.Property(e => e.Residence)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SocialEconomicClass).HasColumnName("Social_Economic_Class");
            entity.Property(e => e.SpouseName).HasColumnName("Spouse_Name");
            entity.Property(e => e.SsnNumber).HasColumnName("SSN_Number");
            entity.Property(e => e.Surname).HasMaxLength(152);
            entity.Property(e => e.VisionOuc)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_OUC");
            entity.Property(e => e.VisionSbu)
                .HasMaxLength(4)
                .IsUnicode(false)
                .HasColumnName("Vision_SBU");
            entity.Property(e => e.WorkTelephone)
                .HasMaxLength(50)
                .HasColumnName("Work_Telephone");
        });

        modelBuilder.Entity<ViewBnrAllLifeClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_ALL_LIFE_CLAIMS");

            entity.Property(e => e.ClaimCurrency)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("Claim_Currency");
            entity.Property(e => e.ClaimExpiryDate)
                .HasMaxLength(10)
                .IsUnicode(false)
                .HasColumnName("Claim_Expiry_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(255)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimSubmissionDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Submission_Date");
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.IncidentDate)
                .HasColumnType("datetime")
                .HasColumnName("Incident_Date");
            entity.Property(e => e.IncidentReportDate)
                .HasColumnType("datetime")
                .HasColumnName("Incident_Report_Date");
            entity.Property(e => e.LeBook)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("LE_Book");
            entity.Property(e => e.NumOfPreviousClaims).HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.OccurrenceBookDetails).HasColumnName("Occurrence_Book_Details");
            entity.Property(e => e.PhysicalLossIncurred).HasColumnName("Physical_Loss_Incurred");
            entity.Property(e => e.PlaceOfIncident)
                .HasColumnType("datetime")
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(255)
                .HasColumnName("Policy_Number");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(255)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.SurrenderType)
                .HasMaxLength(2)
                .IsUnicode(false)
                .HasColumnName("Surrender_Type");
            entity.Property(e => e.SurrenderValue).HasColumnName("Surrender_Value");
            entity.Property(e => e.TotalClaimAmount).HasColumnName("TOTAL_CLAIM_AMOUNT");
            entity.Property(e => e.TotalLoan).HasColumnName("Total_Loan");
            entity.Property(e => e.YearMonth)
                .HasMaxLength(6)
                .IsUnicode(false)
                .HasColumnName("Year_Month");
        });

        modelBuilder.Entity<ViewBnrValidCastomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_BNR_VALID_CASTOMERS");

            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.Channel).HasMaxLength(551);
            entity.Property(e => e.Country)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.EfectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Efective Date");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("End Date");
            entity.Property(e => e.Forename).HasMaxLength(150);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(551);
            entity.Property(e => e.Surname).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.ValidIdfromNida)
                .HasMaxLength(50)
                .HasColumnName("ValidIDFromNIDA");
            entity.Property(e => e.VendorCode).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewCardsPoliciesFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CardsPoliciesFamily");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCardsPoliciesFamilySina>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CardsPoliciesFamily_Sina");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCheckDuplicationAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Duplication_All");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Keyid)
                .HasMaxLength(180)
                .HasColumnName("KEYID");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RiskPremium).HasColumnName("Risk Premium");
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StatusPolicy).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewCheckDuplicationEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Duplication_Education");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Keyid)
                .HasMaxLength(180)
                .HasColumnName("KEYID");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RiskPremium).HasColumnName("Risk Premium");
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StatusPolicy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCheckDuplicationEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Duplication_EPI");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Keyid)
                .HasMaxLength(130)
                .HasColumnName("KEYID");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RiskPremium1).HasColumnName("Risk Premium");
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.StatusPolicy)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewCheckDuplicationFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Duplication_Family");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Keyid)
                .HasMaxLength(130)
                .HasColumnName("KEYID");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RiskPremium1).HasColumnName("Risk Premium");
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewCheckDuplicationSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Check_Duplication_Savings");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.Keyid)
                .HasMaxLength(130)
                .HasColumnName("KEYID");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RiskPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RiskPremium).HasColumnName("Risk Premium");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewClaimsAmountDueUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Claims_Amount_Due_Update");

            entity.Property(e => e.ClaimAmountDue).HasColumnName("Claim_Amount_Due");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
        });

        modelBuilder.Entity<ViewClaimsRegisterAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegister_All");

            entity.Property(e => e.AmountOfClaimReserveCfv).HasColumnName("AmountOfClaimReserve_CFV");
            entity.Property(e => e.ApprovedModByUser).HasMaxLength(100);
            entity.Property(e => e.ApprovedModDate).HasColumnType("datetime");
            entity.Property(e => e.BeneficiaryNames).HasMaxLength(901);
            entity.Property(e => e.ClaimDeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(150);
            entity.Property(e => e.ClaimNumberUpdate).HasMaxLength(100);
            entity.Property(e => e.ClaimSettlementDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimStatus).HasMaxLength(80);
            entity.Property(e => e.ClaimsSource)
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("Claims Source");
            entity.Property(e => e.CreatedByUser).HasMaxLength(100);
            entity.Property(e => e.Dob)
                .HasColumnType("datetime")
                .HasColumnName("DOB");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdentificationNumber).HasMaxLength(50);
            entity.Property(e => e.IncidentDate).HasColumnType("datetime");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.NameOfProduct).HasMaxLength(50);
            entity.Property(e => e.NumOfPreviousClaims).HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.PenaltiesAdvanceSurrender).HasColumnName("PenaltiesAdvance_Surrender");
            entity.Property(e => e.PlaceOfIncident).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.PolicyStatus).HasMaxLength(50);
            entity.Property(e => e.PolicyholderName).HasMaxLength(901);
            entity.Property(e => e.RecoredDate).HasColumnType("datetime");
            entity.Property(e => e.RelationshipPolicyholder).HasMaxLength(100);
            entity.Property(e => e.SalesAgent).HasMaxLength(255);
            entity.Property(e => e.SchemeName).HasMaxLength(551);
            entity.Property(e => e.SubmissionDateOfLastDocument).HasColumnType("datetime");
            entity.Property(e => e.Telephone).HasMaxLength(50);
            entity.Property(e => e.TypeofClaim).HasMaxLength(80);
        });

        modelBuilder.Entity<ViewClaimsRegisterEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegister_Education");

            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AmountOfClaimReserveCfv).HasColumnName("AmountOfClaimReserve_CFV");
            entity.Property(e => e.BeneficiaryNames).HasMaxLength(901);
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimNumberUpdate).HasMaxLength(30);
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(50)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.CmapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CMApprovedDate");
            entity.Property(e => e.CmapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CMApprovedUserName");
            entity.Property(e => e.DateLastDocument).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.NumOfPreviousClaims).HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.PenaltiesAdvanceSurrender).HasColumnName("PenaltiesAdvance_Surrender");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(150)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordUserName).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(10)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(551);
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewClaimsRegisterIkimina>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegister_Ikimina");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AmountOfClaimReserveCfv).HasColumnName("AmountOfClaimReserve_CFV");
            entity.Property(e => e.ApprovedModByUser).HasMaxLength(50);
            entity.Property(e => e.ApprovedModDate).HasColumnType("datetime");
            entity.Property(e => e.BeneficiaryNames).HasMaxLength(901);
            entity.Property(e => e.ClaimDeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(150);
            entity.Property(e => e.ClaimNumberUpdate).HasMaxLength(50);
            entity.Property(e => e.ClaimSettlementDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.Comment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByUser).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IncidentDate).HasColumnType("datetime");
            entity.Property(e => e.NameOfProduct)
                .HasMaxLength(13)
                .IsUnicode(false);
            entity.Property(e => e.NumOfPreviousClaims).HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.PenaltiesAdvanceSurrender).HasColumnName("PenaltiesAdvance_Surrender");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(12)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecoredDate).HasColumnType("datetime");
            entity.Property(e => e.RelationshipPolicyholde)
                .HasMaxLength(4)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName).HasMaxLength(551);
            entity.Property(e => e.SubmissionDateOfLastDocument).HasColumnType("datetime");
            entity.Property(e => e.TypeofClaim)
                .HasMaxLength(25)
                .IsUnicode(false);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewClaimsRegisterLoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegister_LoanProtection");

            entity.Property(e => e.AccountClosingDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Closing_Date");
            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AccountStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Account_Status");
            entity.Property(e => e.AmountOfClaimReserveCfv).HasColumnName("AmountOfClaimReserve_CFV");
            entity.Property(e => e.ApprovedModByUser).HasMaxLength(50);
            entity.Property(e => e.ApprovedModDate).HasColumnType("datetime");
            entity.Property(e => e.BeneficiaryNames).HasMaxLength(901);
            entity.Property(e => e.ClaimDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimNumber).HasMaxLength(100);
            entity.Property(e => e.ClaimNumberUpdate).HasMaxLength(100);
            entity.Property(e => e.ClaimSettlementDate).HasColumnType("datetime");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ClaimType).HasMaxLength(50);
            entity.Property(e => e.Comment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.Comments)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CreatedByUser).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeclarationDate).HasColumnType("datetime");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.NumOfPreviousClaims).HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.PenaltiesAdvanceSurrender).HasColumnName("PenaltiesAdvance_Surrender");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.Products).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RelationshipPolicyholde)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName).HasMaxLength(551);
            entity.Property(e => e.SubmissionDateOfLastDocument).HasColumnType("datetime");
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewClaimsRegisterSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ClaimsRegister_Savings");

            entity.Property(e => e.BeneficiaryName).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryRelationshipType).HasMaxLength(50);
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber).HasMaxLength(50);
            entity.Property(e => e.ClaimNumberUpdate).HasMaxLength(50);
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(80)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.CmapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CMApprovedDate");
            entity.Property(e => e.CmapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CMApprovedUserName");
            entity.Property(e => e.CoinsuranceRecoverable).HasColumnName("Coinsurance_Recoverable");
            entity.Property(e => e.DateLastDocument).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullNames).HasMaxLength(152);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.NumOfPreviousClaims).HasColumnName("Num_Of_Previous_Claims");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(100)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicySatatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordUserName).HasMaxLength(100);
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
            entity.Property(e => e.TypeofClaim).HasMaxLength(80);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewClaimsSavingsValidation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Claims_Savings_Validations");

            entity.Property(e => e.AmountOfClaimReserveCfv).HasColumnName("AmountOfClaimReserve_CFV");
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimDeclarationDate1)
                .HasColumnType("datetime")
                .HasColumnName("ClaimDeclarationDate");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(50)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimNumberUpdate).HasMaxLength(50);
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimSettlementDate1)
                .HasColumnType("datetime")
                .HasColumnName("ClaimSettlementDate");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(80)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimStatus1)
                .HasMaxLength(50)
                .HasColumnName("ClaimStatus");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdentificationNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.NameOfProduct).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberComb).HasMaxLength(50);
            entity.Property(e => e.PolicyholderName).HasMaxLength(100);
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
        });

        modelBuilder.Entity<ViewCommissionsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_All");

            entity.Property(e => e.BusinessChannel).HasMaxLength(255);
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(901);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Products)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(553);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(21);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewCommissionsAllReport>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_All_Reports");

            entity.Property(e => e.BusinessChannel).HasMaxLength(255);
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.CommissionPaymentDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Commission Payment Date");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Effective Date");
            entity.Property(e => e.Expr1)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(901);
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentDueDate)
                .HasColumnType("datetime")
                .HasColumnName("Payment Due Date");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Policy Recorded Date");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Premium Payment Date");
            entity.Property(e => e.Products)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(553);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(21);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewCommissionsEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_Education");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewCommissionsEducationOld>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_Education_old");

            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.DistributionChannel).HasMaxLength(50);
            entity.Property(e => e.DistributionPerson).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(300);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewCommissionsEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_EPI");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Products)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewCommissionsFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_Family");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Products)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewCommissionsLoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_LoanProtection");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.ControllerId).HasColumnName("ControllerID");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(901);
            entity.Property(e => e.PayFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Products)
                .HasMaxLength(15)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(553);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorCode).HasMaxLength(50);
            entity.Property(e => e.VendorName).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewCommissionsPensionSavingsEndorsement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_PensionSavings_Endorsement");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(101);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewCommissionsPensionSavingsMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Commissions_PensionSavings_Main");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CommissionPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.CommissionRate).HasColumnName("Commission_Rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DifferedTerm).HasColumnName("Differed_Term");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(101);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyAgeMonths).HasColumnName("Policy_Age_Months");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths)
                .HasMaxLength(21)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewConvertedProposalPerAgent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ConvertedProposalPerAgents");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateConverted)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DateProposal)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserNamePs)
                .HasMaxLength(100)
                .HasColumnName("UserNamePS");
        });

        modelBuilder.Entity<ViewCustomerDetailsCleaningLife>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CustomerDetailsCleaningLife");

            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Forename).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(150);
            entity.Property(e => e.Village).HasMaxLength(50);
            entity.Property(e => e.VillageId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCustomerLoan>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Customer_Loan");

            entity.Property(e => e.AccountStatus).HasColumnName("Account_Status");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName)
                .HasMaxLength(1352)
                .HasColumnName("Full name");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PhoneNumber2)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_2");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.Salutation).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCustomerUpdateNidum>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CustomerUpdateNIDA");

            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.DateOfBirthFam)
                .HasColumnType("datetime")
                .HasColumnName("DateOfBirthFAM");
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Forename).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.GenderFam)
                .HasMaxLength(50)
                .HasColumnName("GenderFAM");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IssuedCell).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.IssuedVillage).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SalutationFam)
                .HasMaxLength(50)
                .HasColumnName("SalutationFAM");
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(150);
            entity.Property(e => e.Village).HasMaxLength(50);
            entity.Property(e => e.VillageId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCustomerValidation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CustomerValidation");

            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewCustomersValidList>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_CustomersValidList");

            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.Forename).HasMaxLength(150);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(20);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.Surname).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.Village).HasMaxLength(50);
            entity.Property(e => e.VillageId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewDigitalAllPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Digital_AllPayments");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewDigitalCalimsUmurage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_DigitalCalims_Umurage");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndwomentType).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SendContract).HasColumnName("Send_Contract");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewDigitalCorrectFamillyPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Digital_Correct_Familly_Payments");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.ExternalReference).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(10)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransactionId).HasMaxLength(450);
        });

        modelBuilder.Entity<ViewDigitalNotConvertedReminder>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_DigitalNotConvertedReminder");

            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewEdicationPaymentStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Edication_Payment_Statements");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndwomentType).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewEducationClaimsProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_Claims_Process");

            entity.Property(e => e.Ceoaction)
                .HasMaxLength(50)
                .HasColumnName("CEOAction");
            entity.Property(e => e.CeoapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CEOApprovedDate");
            entity.Property(e => e.CeoapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CEOApprovedUserName");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ClaimDateIncident)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Date_Incident");
            entity.Property(e => e.ClaimDeclarationDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Declaration_Date");
            entity.Property(e => e.ClaimNumber)
                .HasMaxLength(30)
                .HasColumnName("Claim_Number");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.ClaimSettlementDate)
                .HasColumnType("datetime")
                .HasColumnName("Claim_Settlement_Date");
            entity.Property(e => e.ClaimStatus)
                .HasMaxLength(50)
                .HasColumnName("Claim_Status");
            entity.Property(e => e.ClaimTotalAmount).HasColumnName("Claim_Total_Amount");
            entity.Property(e => e.ClaimType)
                .HasMaxLength(50)
                .HasColumnName("Claim_Type");
            entity.Property(e => e.ClaimentId)
                .HasMaxLength(50)
                .HasColumnName("ClaimentID");
            entity.Property(e => e.ClaimentNames).HasMaxLength(450);
            entity.Property(e => e.Cmaction)
                .HasMaxLength(50)
                .HasColumnName("CMAction");
            entity.Property(e => e.CmapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("CMApprovedDate");
            entity.Property(e => e.CmapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("CMApprovedUserName");
            entity.Property(e => e.CustomerCode).HasMaxLength(30);
            entity.Property(e => e.DateLastDocument).HasColumnType("datetime");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Extn).HasMaxLength(5);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdlifeInsured).HasColumnName("IDLifeInsured");
            entity.Property(e => e.IdofBeneficiary).HasColumnName("IDOfBeneficiary");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(250);
            entity.Property(e => e.OperationStatus).HasMaxLength(50);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PhysicalLossIncurred).HasColumnName("Physical_Loss_Incurred");
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(150)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordUserName).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason)
                .HasMaxLength(10)
                .HasColumnName("Rejection_Reason");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SurrenderType)
                .HasMaxLength(50)
                .HasColumnName("Surrender_Type");
            entity.Property(e => e.SurrenderValue).HasColumnName("Surrender_Value");
            entity.Property(e => e.Tdaction)
                .HasMaxLength(50)
                .HasColumnName("TDAction");
            entity.Property(e => e.TdapprovedDate)
                .HasColumnType("datetime")
                .HasColumnName("TDApprovedDate");
            entity.Property(e => e.TdapprovedUserName)
                .HasMaxLength(50)
                .HasColumnName("TDApprovedUserName");
            entity.Property(e => e.TotalLoan).HasColumnName("Total_Loan");
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
        });

        modelBuilder.Entity<ViewEducationClaimsUpdate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_Claims_Update");

            entity.Property(e => e.ClaimAmountDue).HasColumnName("Claim_Amount_Due");
            entity.Property(e => e.ClaimSettlementAmount).HasColumnName("Claim_Settlement_Amount");
            entity.Property(e => e.PolicyNumber).HasMaxLength(30);
        });

        modelBuilder.Entity<ViewEducationMainDdg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_Main_DDG");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateAnnul).HasColumnName("Date_Annul");
            entity.Property(e => e.DateEffet)
                .HasColumnType("datetime")
                .HasColumnName("Date_Effet");
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.DateTrait).HasColumnName("Date_Trait");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.ProductType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.XFraisDAcquisition).HasColumnName("xFrais d'acquisition'");
            entity.Property(e => e.XFraisDeGestionG1)
                .HasColumnType("numeric(1, 1)")
                .HasColumnName("xFrais de gestion g1");
            entity.Property(e => e.XFraisDeGestionG2)
                .HasColumnType("numeric(1, 1)")
                .HasColumnName("xFrais de gestion g2");
        });

        modelBuilder.Entity<ViewEducationMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_Member");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.Expr1)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Expr2).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewEducationMigrationCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_Migration_Customer");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName).HasColumnName("First_Name");
            entity.Property(e => e.FullName).HasMaxLength(300);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.LastName).HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName).HasColumnName("Middle_Name");
            entity.Property(e => e.NumberOfDependants).HasColumnName("Number_Of_Dependants");
            entity.Property(e => e.Occupation).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PhoneNumber2).HasColumnName("PhoneNumber_2");
            entity.Property(e => e.RelatedParty).HasColumnName("Related_Party");
            entity.Property(e => e.ResidenceCell).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.ResidenceVillage).HasMaxLength(50);
            entity.Property(e => e.Salutation)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.SocialEconomicClass).HasColumnName("Social_Economic_Class");
            entity.Property(e => e.UserId).HasColumnName("UserID");
        });

        modelBuilder.Entity<ViewEducationNewPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EducationNewPayment");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewEducationPaymentTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EducationPaymentTemp");

            entity.Property(e => e.AccountNumberAndBank)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.AdministrationFee).HasColumnName("Administration fee");
            entity.Property(e => e.BankBranchName)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Bank branch name");
            entity.Property(e => e.BankName)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.BasicPremium).HasColumnName("Basic premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
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
            entity.Property(e => e.FinanceUserId).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.InsurancePeriodInMonths).HasColumnName("Insurance Period in months");
            entity.Property(e => e.InsuranceRate).HasColumnName("Insurance rate");
            entity.Property(e => e.JointPolicy)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Joint policy");
            entity.Property(e => e.LoadingRate).HasColumnName("Loading Rate");
            entity.Property(e => e.LoanEndDate).HasColumnName("Loan end date");
            entity.Property(e => e.LoanType)
                .HasMaxLength(1)
                .IsUnicode(false)
                .HasColumnName("Loan Type");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentProof)
                .HasMaxLength(50)
                .HasColumnName("Payment proof");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalFuneralFee).HasColumnName("Policy total funeral fee");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PolicyholderDeathTpdSumInsured).HasColumnName("Policyholder death/TPD sum insured");
            entity.Property(e => e.PolicyholderLossOfIncomeSumInsured).HasColumnName("Policyholder loss of income sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.PremiumRecordedDate)
                .HasColumnType("datetime")
                .HasColumnName("Premium Recorded Date");
            entity.Property(e => e.PrimeBranchName)
                .HasMaxLength(2)
                .IsUnicode(false);
            entity.Property(e => e.ProductType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.Retrenchment)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.SpouseDeathSumInsured).HasColumnName("Spouse death sum insured");
            entity.Property(e => e.SubProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewEducationPolicyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_PolicyDetails");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndwomentType).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.ResidenceCell).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.ResidenceVillage).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.StartDateMain).HasColumnType("datetime");
            entity.Property(e => e.SubscriberFullName).HasMaxLength(450);
            entity.Property(e => e.SubscriberId)
                .HasMaxLength(50)
                .HasColumnName("SubscriberID");
            entity.Property(e => e.SubscriberIdDocument).HasMaxLength(50);
            entity.Property(e => e.SubscriberPhoneNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewEducationPolicyDetail1>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EducationPolicyDetails");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewEducationPolicyMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_PolicyMember");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewEducationPolicyWithoutBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_PolicyWithoutBeneficiaries");

            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewEducationPolicyWithoutPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_PolicyWithoutPayment");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DatePolicy)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.Expr1)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.Expr2)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewEducationSignedReturned>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EducationSignedReturned");

            entity.Property(e => e.DatePolicy).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewEducationUpdatePremium>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_Update_Premium");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEducationUpdateScheme>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Education_Update_Scheme");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewEligiblePoliciesAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_All");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaxPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewEligiblePoliciesAllY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_All_Y");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEligiblePoliciesEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Education");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaxPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEligiblePoliciesEducationY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Education_Y");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEligiblePoliciesEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_EPI");

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
            entity.Property(e => e.MaxPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewEligiblePoliciesEpiY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_EPI_Y");

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
            entity.Property(e => e.Product)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewEligiblePoliciesFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Family");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.EndorsementNumber)
                .HasMaxLength(50)
                .HasColumnName("Endorsement Number");
            entity.Property(e => e.IdDocument)
                .HasMaxLength(50)
                .HasColumnName("ID document");
            entity.Property(e => e.MaxPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Product)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewEligiblePoliciesFamilyY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Family_Y");

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
            entity.Property(e => e.Product)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewEligiblePoliciesSavingsEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Savings_Endo");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementNumber).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaxPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewEligiblePoliciesSavingsEndoY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Savings_Endo_Y");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.Names).HasMaxLength(152);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewEligiblePoliciesSavingsMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Savings_Main");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementNumber).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaxPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewEligiblePoliciesSavingsMainY>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Eligible_Policies_Savings_Main_Y");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
            entity.Property(e => e.Names).HasMaxLength(152);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
        });

        modelBuilder.Entity<ViewEmailsAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Emails_All");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(4000);
        });

        modelBuilder.Entity<ViewEmailsEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Emails_Education");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(300);
        });

        modelBuilder.Entity<ViewEmailsFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Emails_Family");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
        });

        modelBuilder.Entity<ViewEmailsLoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Emails_LoanProtection");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullNames).HasMaxLength(4000);
        });

        modelBuilder.Entity<ViewEmailsSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Emails_Savings");

            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(4000);
        });

        modelBuilder.Entity<ViewEmployeProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EmployeProtection");

            entity.Property(e => e.ChannelAdress).HasMaxLength(250);
            entity.Property(e => e.ChannelContactEmail).HasMaxLength(50);
            entity.Property(e => e.ChannelContactTelephone).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(50);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.InRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("inRecord");
            entity.Property(e => e.LicenceId)
                .HasMaxLength(50)
                .HasColumnName("LicenceID");
            entity.Property(e => e.Username).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewEpiClaimsProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_Claims_Process");

            entity.Property(e => e.BeneficiaryAccounts).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryId)
                .HasMaxLength(50)
                .HasColumnName("BeneficiaryID");
            entity.Property(e => e.BeneficiaryInstitution).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryPhone).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryRelationshipType).HasMaxLength(50);
            entity.Property(e => e.BenefitsPayment).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
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
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.OperationStatus).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(100)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordUserName).HasMaxLength(100);
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
        });

        modelBuilder.Entity<ViewEpiCombained>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_Combained");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DeathTpdsi).HasColumnName("DeathTPDSI");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.FuneralSi).HasColumnName("FuneralSI");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("LossOfRevenueSI");
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.RecordedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SpouseCoverSi).HasColumnName("SpouseCoverSI");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.ValidPaymentDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Valid_PaymentDate");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewEpiPaymentStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_Payment_Statements");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewEpiPaymentsDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_PaymentsDetails");

            entity.Property(e => e.Advisor).HasMaxLength(100);
            entity.Property(e => e.Channel).HasMaxLength(100);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(50)
                .HasColumnName("customerName");
            entity.Property(e => e.CustomerNumber).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdpremium).HasColumnName("deathTPDPremium");
            entity.Property(e => e.DeathTpdsi).HasColumnName("deathTPDSI");
            entity.Property(e => e.DeathTpdsis).HasColumnName("deathTPDSIS");
            entity.Property(e => e.DreadDeseasePremium).HasColumnName("dreadDeseasePremium");
            entity.Property(e => e.DreadDeseaseSi).HasColumnName("dreadDeseaseSI");
            entity.Property(e => e.DreadDeseaseSis).HasColumnName("dreadDeseaseSIS");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Fees).HasColumnName("fees");
            entity.Property(e => e.FuneralPremium).HasColumnName("funeralPremium");
            entity.Property(e => e.FuneralSi).HasColumnName("funeralSI");
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("lossOfRevenueSI");
            entity.Property(e => e.LossOfRevenueSis).HasColumnName("lossOfRevenueSIS");
            entity.Property(e => e.LossOfrevenuePremium).HasColumnName("lossOfrevenuePremium");
            entity.Property(e => e.Numberofpyt).HasColumnName("numberofpyt");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.Ppdpremium).HasColumnName("PPDPremium");
            entity.Property(e => e.Ppdsi).HasColumnName("PPDSI");
            entity.Property(e => e.Ppdsis).HasColumnName("PPDSIS");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.RiskPremium).HasColumnName("riskPremium");
            entity.Property(e => e.SalaryOrFixedAmount).HasColumnName("salaryOrFixedAmount");
            entity.Property(e => e.TotalPremium).HasColumnName("totalPremium");
        });

        modelBuilder.Entity<ViewEpiPc>(entity =>
        {
            entity
                .HasNoKey()
                .ToTable("View_EPI_PC");

            entity.Property(e => e.Advisor).HasMaxLength(255);
            entity.Property(e => e.BranchName)
                .HasMaxLength(255)
                .HasColumnName("branchName");
            entity.Property(e => e.Channel).HasMaxLength(255);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.CustomerCode).HasMaxLength(255);
            entity.Property(e => e.CustomerName)
                .HasMaxLength(255)
                .HasColumnName("customerName");
            entity.Property(e => e.PaymentChannel).HasMaxLength(255);
            entity.Property(e => e.PaymentDetails).HasMaxLength(255);
            entity.Property(e => e.PolicyPytPlan).HasMaxLength(255);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(255);
            entity.Property(e => e.Saving).HasColumnName("saving");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(255)
                .HasColumnName("schemeNumber");
            entity.Property(e => e.UserName)
                .HasMaxLength(255)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<ViewEpiPolicyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_PolicyDetails");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdsi).HasColumnName("DeathTPDSI");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDeseaseSi).HasColumnName("DreadDeseaseSI");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.FuneralSi).HasColumnName("FuneralSI");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IssuedCell).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.IssuedVillage).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("LossOfRevenueSI");
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Ppdsi).HasColumnName("PPDSI");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SavingPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.SpouseCoverSi).HasColumnName("SpouseCoverSI");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEpiPolicyWithoutBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_PolicyWithoutBeneficiaries");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product)
                .HasMaxLength(19)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewEpiPolicyWithoutPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_PolicyWithoutPayment");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewEpiReportRegisterPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_ReportRegisterPayment");

            entity.Property(e => e.Advisor).HasMaxLength(100);
            entity.Property(e => e.BranchName).HasMaxLength(100);
            entity.Property(e => e.Channel).HasMaxLength(100);
            entity.Property(e => e.CheckIsuedBank).HasMaxLength(100);
            entity.Property(e => e.ChecqueNumber).HasMaxLength(100);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpdsis).HasColumnName("deathTPDSIS");
            entity.Property(e => e.DreadDeseaseSis).HasColumnName("dreadDeseaseSIS");
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.InsuredCode).HasMaxLength(50);
            entity.Property(e => e.InsuredName).HasMaxLength(100);
            entity.Property(e => e.LossOfRevenueSis).HasColumnName("lossOfRevenueSIS");
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.Nauto).HasColumnName("NAuto");
            entity.Property(e => e.NpolOrScheme)
                .HasMaxLength(50)
                .HasColumnName("NPolOrScheme");
            entity.Property(e => e.Nreceipt)
                .HasMaxLength(100)
                .HasColumnName("NReceipt");
            entity.Property(e => e.PaidDate).HasColumnType("datetime");
            entity.Property(e => e.PaidNinvoice)
                .HasMaxLength(100)
                .HasColumnName("PaidNInvoice");
            entity.Property(e => e.PayementMode).HasMaxLength(100);
            entity.Property(e => e.PayerCustomerCode).HasMaxLength(50);
            entity.Property(e => e.PayerCustomerName).HasMaxLength(100);
            entity.Property(e => e.PaymentReferenceDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentReferenceNo).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.Ppdsis).HasColumnName("PPDSIS");
            entity.Property(e => e.ProductName).HasMaxLength(100);
            entity.Property(e => e.ReceiptingBanqueInfo).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(50)
                .HasColumnName("schemeNumber");
            entity.Property(e => e.UserCode).HasMaxLength(100);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewEpiSignedReturned>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EPI_SignedReturned");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.Product)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewExpoCustomerIdentification>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EXPO_CustomerIdentification");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerType).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewExpoPensionDetailsTable>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EXPO_PensionDetailsTable");

            entity.Property(e => e.Commission)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.IdentityRecord).HasMaxLength(50);
            entity.Property(e => e.InstallmentFees)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.ManagementFees)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PensionAmt)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Rate).HasColumnName("rate");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewExpoSavingsPayement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EXPO_SavingsPayements");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.IntegratedAcc)
                .HasMaxLength(5)
                .IsUnicode(false);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonth).HasMaxLength(10);
            entity.Property(e => e.ReportingYear).HasMaxLength(10);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewExpoSavingsPolicyRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EXPO_SavingsPolicyRegister");

            entity.Property(e => e.BenefitsPaymentsMode).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.InsuranceBranchCode)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumberBase)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Base");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SumAssuredType).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
            entity.Property(e => e.VendorCode).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewExpoSavingsPolicyRegisterDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_EXPO_SavingsPolicyRegisterDetails");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade)
                .HasMaxLength(50)
                .HasColumnName("Endorsement_Made");
            entity.Property(e => e.IdRecord)
                .ValueGeneratedOnAdd()
                .HasColumnName("Id_Record");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFamilyClaimsProcess>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_Claims_Process");

            entity.Property(e => e.BeneficiaryAccounts).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryId)
                .HasMaxLength(50)
                .HasColumnName("BeneficiaryID");
            entity.Property(e => e.BeneficiaryInstitution).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryName).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryPhone).HasMaxLength(50);
            entity.Property(e => e.BeneficiaryRelationshipType).HasMaxLength(50);
            entity.Property(e => e.BenefitsPayment).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
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
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.OperationStatus).HasMaxLength(50);
            entity.Property(e => e.PlaceOfIncident)
                .HasMaxLength(100)
                .HasColumnName("Place_Of_Incident");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProductName).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.RecordUserName).HasMaxLength(100);
            entity.Property(e => e.ReinsuranceRecoverable).HasColumnName("Reinsurance_Recoverable");
            entity.Property(e => e.RejectionReason).HasMaxLength(100);
            entity.Property(e => e.TotalPremiumPaid).HasColumnName("Total_Premium_Paid");
        });

        modelBuilder.Entity<ViewFamilyCleanCustomer>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FamilyCleanCustomers");

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

        modelBuilder.Entity<ViewFamilyInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FamilyInvoices");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.InvoicesNumber).HasMaxLength(100);
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewFamilyMemberCreationDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FamilyMember_CreationDate");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("smalldatetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.MobileNumber).HasMaxLength(50);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFamilyPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_Payments");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyCreationDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.ValidPaymentDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Valid_PaymentDate");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewFamilyPaymentStatement>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_Payment_Statements");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewFamilyPaymentStatementMax>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_Payment_Statement_MAX");

            entity.Property(e => e.AmountPaid).HasColumnName("Amount paid");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MaxPayDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Max pay date");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.NumberOfInsuredLife).HasColumnName("Number of insured life");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Surrendered).HasColumnName("surrendered");
        });

        modelBuilder.Entity<ViewFamilyPolicyWithoutBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_PolicyWithoutBeneficiaries");

            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(9)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFamilyPolicyWithoutPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_PolicyWithoutPayment");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewFamilyProvision>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FamilyProvisions");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.LivesInsured).HasColumnName("Lives insured");
            entity.Property(e => e.MaturityDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.MaxPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("Max Payment Date");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.TotaLSumInsured).HasColumnName("Tota lSum Insured");
            entity.Property(e => e.TotalAmountPayed).HasColumnName("Total Amount Payed");
            entity.Property(e => e.TotalPremium).HasColumnName("Total Premium");
        });

        modelBuilder.Entity<ViewFamilyRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_Register");

            entity.Property(e => e.ChannelName).HasMaxLength(50);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFamilySaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Family_Savings");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FirstName)
                .HasMaxLength(450)
                .HasColumnName("First_Name");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(450)
                .HasColumnName("Last_Name");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumberBase)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumber_Base");
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeName).HasMaxLength(200);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFamilySignedReturned>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FamilySignedReturned");

            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SignedDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewFirstPaymentEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FirstPayment_Education");

            entity.Property(e => e.MainPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFirstPaymentEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FirstPayment_EPI");

            entity.Property(e => e.MainPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewFirstPaymentFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_FirstPayment_Family");

            entity.Property(e => e.MainPaymentDate).HasColumnType("datetime");
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewGroupBusinessDataCollection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_GROUP BUSINESS-DATA COLLECTION");

            entity.Property(e => e.AnnualMainBenefitPremium).HasColumnName("ANNUAL - MAIN BENEFIT PREMIUM");
            entity.Property(e => e.AnnualPremiumCriticalIllnessCoverRiderBenefit).HasColumnName("ANNUAL PREMIUM - CRITICAL ILLNESS COVER RIDER BENEFIT");
            entity.Property(e => e.AnnualPremiumLastExpenseFuneralCoverRider).HasColumnName("ANNUAL PREMIUM - LAST EXPENSE/FUNERAL COVER RIDER");
            entity.Property(e => e.AnnualPremiumTotalAndPermanentDisabilityRider).HasColumnName("ANNUAL PREMIUM - TOTAL AND PERMANENT DISABILITY RIDER");
            entity.Property(e => e.CompanyName)
                .HasMaxLength(25)
                .IsUnicode(false)
                .HasColumnName("COMPANY NAME");
            entity.Property(e => e.CoverEndDateOfPolicy)
                .HasColumnType("datetime")
                .HasColumnName("COVER END DATE OF POLICY");
            entity.Property(e => e.CoverStartDateOfPolicy)
                .HasColumnType("datetime")
                .HasColumnName("COVER START DATE OF POLICY");
            entity.Property(e => e.CriticalIllnessRider).HasColumnName("CRITICAL ILLNESS RIDER");
            entity.Property(e => e.DateOfBirthOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("DATE OF BIRTH OF BIRTH");
            entity.Property(e => e.ExitDateOfTheLifeAssuredDate)
                .HasColumnType("datetime")
                .HasColumnName("EXIT DATE OF THE LIFE ASSURED DATE");
            entity.Property(e => e.ExtraAnnualPremiumMainBenefitForImpairedLives).HasColumnName("EXTRA ANNUAL PREMIUM - MAIN BENEFIT (FOR IMPAIRED LIVES)");
            entity.Property(e => e.FrequencyOfPremiumPayment)
                .HasMaxLength(50)
                .HasColumnName("FREQUENCY OF PREMIUM PAYMENT");
            entity.Property(e => e.GroupPolicyNumber)
                .HasMaxLength(500)
                .HasColumnName("GROUP POLICY NUMBER");
            entity.Property(e => e.LastExpenseFuneralCoverRider).HasColumnName("LAST EXPENSE/FUNERAL COVER RIDER");
            entity.Property(e => e.LifeNumber)
                .HasMaxLength(100)
                .HasColumnName("LIFE NUMBER");
            entity.Property(e => e.LoanInterestRate).HasColumnName("LOAN INTEREST RATE");
            entity.Property(e => e.NameOfGroupSchemeCovered)
                .HasMaxLength(500)
                .HasColumnName("NAME OF GROUP SCHEME COVERED");
            entity.Property(e => e.NameOfPolicyholder)
                .HasMaxLength(901)
                .HasColumnName("NAME OF POLICYHOLDER");
            entity.Property(e => e.Periodyear).HasColumnName("PERIODYEAR");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("POLICY STATUS");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(12)
                .IsUnicode(false)
                .HasColumnName("POLICY TYPE");
            entity.Property(e => e.Sex)
                .HasMaxLength(50)
                .HasColumnName("SEX");
            entity.Property(e => e.SumsAssuredCriticalIllnessCoverRiderBenefitRwf).HasColumnName("SUMS ASSURED-CRITICAL ILLNESS COVER RIDER BENEFIT (RWF)");
            entity.Property(e => e.SumsAssuredLastExpenseFuneralCoverRiderBenefit).HasColumnName("SUMS ASSURED-LAST EXPENSE/FUNERAL COVER RIDER BENEFIT");
            entity.Property(e => e.SumsAssuredMainBenefitRwf).HasColumnName("SUMS ASSURED-MAIN BENEFIT (Rwf)");
            entity.Property(e => e.SumsAssuredTotalAndPermanentDisabilityRiderRwf).HasColumnName("SUMS ASSURED-TOTAL AND PERMANENT DISABILITY RIDER (RWF)");
            entity.Property(e => e.TotalAndPermanentDisabilityCover).HasColumnName("TOTAL AND PERMANENT DISABILITY COVER");
        });

        modelBuilder.Entity<ViewIkiminaOnLinePayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_IKIMINA_OnLine_Payments");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.SavingsId)
                .HasMaxLength(50)
                .HasColumnName("SavingsID");
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransactionId).HasMaxLength(450);
        });

        modelBuilder.Entity<ViewIkiminaPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_IKIMINA_Payments");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.SavingsId)
                .HasMaxLength(50)
                .HasColumnName("SavingsID");
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewInvoiceDuplication>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Invoice Duplication");

            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewInvoicingEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Invoicing_EPI");

            entity.Property(e => e.DueAmount).HasColumnName("Due Amount");
            entity.Property(e => e.DueDate)
                .HasColumnType("datetime")
                .HasColumnName("Due Date");
            entity.Property(e => e.InsuredCode).HasMaxLength(50);
            entity.Property(e => e.InsuredName).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewListAllVendor>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_LIST_ALL_VENDORS");

            entity.Property(e => e.Products)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.VendorCode).HasMaxLength(255);
            entity.Property(e => e.VendorName).HasMaxLength(255);
            entity.Property(e => e.VendorType).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewListOfAllProposal>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListOfAllProposals");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpd).HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease).HasColumnName("dreadDesease");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Funeral).HasColumnName("funeral");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue).HasColumnName("lossOfRevenue");
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewListPolicyEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ListPolicyEducation");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewListSalesAgent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_List_SalesAgents");

            entity.Property(e => e.ChannelContactEmail).HasMaxLength(50);
            entity.Property(e => e.ChannelContactTelephone).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DocId)
                .HasMaxLength(50)
                .HasColumnName("DocID");
            entity.Property(e => e.DocumentRequired).HasMaxLength(100);
            entity.Property(e => e.DueRenewalDate).HasColumnType("datetime");
            entity.Property(e => e.Idnumber)
                .HasMaxLength(50)
                .HasColumnName("IDNumber");
            entity.Property(e => e.InRecord).HasColumnName("inRecord");
            entity.Property(e => e.SubmisionDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewMigrationEpiInvoice>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Migration_EPI_Invoices");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewMigrationEpiMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Migration_EPI_Members");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.FirstName).HasColumnName("First_Name");
            entity.Property(e => e.LastName).HasColumnName("Last_Name");
            entity.Property(e => e.MemberCode).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(500);
            entity.Property(e => e.MiddleName).HasColumnName("Middle_Name");
            entity.Property(e => e.NextOfKin)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Relationship).HasMaxLength(500);
        });

        modelBuilder.Entity<ViewMigrationEpiPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Migration_EPI_Policies");

            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DeathTpdsi).HasColumnName("deathTPDSI");
            entity.Property(e => e.DreadDeseaseSi).HasColumnName("dreadDeseaseSI");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.FuneralSi).HasColumnName("funeralSI");
            entity.Property(e => e.LossOfRevenueSi).HasColumnName("lossOfRevenueSI");
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyComponentType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.Ppdsi).HasColumnName("PPDSI");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(100);
            entity.Property(e => e.ProductCategory)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.RiskPremium).HasColumnName("riskPremium");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SpouseCoverSi).HasColumnName("SpouseCoverSI");
            entity.Property(e => e.TotalPremium).HasColumnName("totalPremium");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewMigrationEpiReceipting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Migration_EPI_Receipting");

            entity.Property(e => e.Branch).HasMaxLength(100);
            entity.Property(e => e.Comments).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.ProofOfPayment).HasMaxLength(100);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewMomoAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_All");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_Education");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_EPI");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_Family");

            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoNotAllocatedEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_NotAllocated_Education");

            entity.Property(e => e.AccountNo)
                .HasMaxLength(50)
                .HasColumnName("Account_No");
            entity.Property(e => e.Comments)
                .HasMaxLength(23)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.ProofOfPayment).HasMaxLength(450);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemId)
                .HasMaxLength(50)
                .HasColumnName("SchemID");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoNotAllocatedIkimina>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_NotAllocated_Ikimina");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.Comments)
                .HasMaxLength(23)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(450);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeNumber).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoNotAllocatedP>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_NotAllocated_PS");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.Comments)
                .HasMaxLength(23)
                .IsUnicode(false);
            entity.Property(e => e.CustomerId)
                .HasMaxLength(50)
                .HasColumnName("Customer_ID");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(450);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoPensionSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_PensionSavings");

            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewMomoStatmentOnlineTransaction>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_MOMO_Statment_OnlineTransactions");

            entity.Property(e => e.Date).HasColumnType("datetime");
            entity.Property(e => e.FromName).HasMaxLength(255);
            entity.Property(e => e.FromNumber).HasMaxLength(255);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Status).HasMaxLength(255);
            entity.Property(e => e.StatusOnline).HasMaxLength(50);
            entity.Property(e => e.ToName).HasMaxLength(255);
            entity.Property(e => e.TransactionId).HasMaxLength(50);
            entity.Property(e => e.TransactionOnline).HasMaxLength(450);
            entity.Property(e => e.Type).HasMaxLength(255);
        });

        modelBuilder.Entity<ViewNewBusinessAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_NewBusiness_All");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(255);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewNewBusinessEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_NewBusiness_Education");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewNewBusinessEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_NewBusiness_EPI");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Expr1).HasMaxLength(150);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.ProductType)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewNewBusinessFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_NewBusiness_Family");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Expr1).HasMaxLength(150);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MainPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.ProductType)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.RecordDate).HasColumnType("datetime");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewNkunganireAllPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Nkunganire_All_Payments");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewNkunganireAllPaymentsPartner>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Nkunganire_All_Payments_Partners");

            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(100);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.YearMonth)
                .HasMaxLength(30)
                .HasColumnName("YEAR_MONTH");
        });

        modelBuilder.Entity<ViewNkunganireAllPoliciesPartner>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Nkunganire_All_Policies_Partners");

            entity.Property(e => e.CreationYearMonths)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("Creation_YearMonths");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewNkunganireAllPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Nkunganire_All_Policies");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewNovanet>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Novanet");

            entity.Property(e => e.Adresse)
                .HasMaxLength(255)
                .HasColumnName("adresse");
            entity.Property(e => e.Beneficiaries01).HasMaxLength(255);
            entity.Property(e => e.Beneficiaries02).HasMaxLength(255);
            entity.Property(e => e.Datecre)
                .HasColumnType("datetime")
                .HasColumnName("datecre");
            entity.Property(e => e.Dateffet)
                .HasColumnType("datetime")
                .HasColumnName("dateffet");
            entity.Property(e => e.Lienclient).HasColumnName("lienclient");
            entity.Property(e => e.Nom)
                .HasMaxLength(255)
                .HasColumnName("nom");
            entity.Property(e => e.Paiement)
                .HasMaxLength(255)
                .HasColumnName("paiement");
            entity.Property(e => e.Police)
                .HasMaxLength(255)
                .HasColumnName("police");
            entity.Property(e => e.Prenom)
                .HasMaxLength(255)
                .HasColumnName("prenom");
            entity.Property(e => e.Telephone1).HasColumnName("telephone1");
            entity.Property(e => e.Ttcannuel).HasColumnName("ttcannuel");
        });

        modelBuilder.Entity<ViewOk>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ok");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductType)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ReportingMonths).HasMaxLength(10);
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewOldPymt>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_OldPYMT");

            entity.Property(e => e.Branch).HasMaxLength(50);
            entity.Property(e => e.Comments).HasMaxLength(250);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.Oldpayments)
                .HasMaxLength(120)
                .HasColumnName("oldpayments");
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ProofOfPayment).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.UserId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewPoliciesAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Policies_All");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDeferredPeriod).HasColumnName("Endowment amount after deferred period");
            entity.Property(e => e.EndowmentAmountDuringDeferredPeriod).HasColumnName("Endowment amount during deferred period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewPoliciesAllEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Policies_All_Education");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDeferredPeriod).HasColumnName("Endowment amount after deferred period");
            entity.Property(e => e.EndowmentAmountDuringDeferredPeriod).HasColumnName("Endowment amount during deferred period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.Product)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ProductCategory)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewPoliciesAllEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Policies_All_EPI");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.EndowmentAmountAfterDeferredPeriod).HasColumnName("Endowment amount after deferred period");
            entity.Property(e => e.EndowmentAmountDuringDeferredPeriod).HasColumnName("Endowment amount during deferred period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.IdDocument)
                .HasMaxLength(50)
                .HasColumnName("ID document");
            entity.Property(e => e.MaturityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Names).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.Product)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ProductCategory)
                .HasMaxLength(29)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
        });

        modelBuilder.Entity<ViewPoliciesAllFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Policies_All_Family");

            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.EndowmentAmountAfterDeferredPeriod).HasColumnName("Endowment amount after deferred period");
            entity.Property(e => e.EndowmentAmountDuringDeferredPeriod).HasColumnName("Endowment amount during deferred period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.IdDocument)
                .HasMaxLength(50)
                .HasColumnName("ID document");
            entity.Property(e => e.MaturityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.Names).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy number");
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.Product)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
        });

        modelBuilder.Entity<ViewPoliciesAllGroupLife>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Policies_All_GroupLife");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.EndowmentAmountAfterDeferredPeriod).HasColumnName("Endowment amount after deferred period");
            entity.Property(e => e.EndowmentAmountDuringDeferredPeriod).HasColumnName("Endowment amount during deferred period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.Expr1ProductCategory)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.MaturityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.Product)
                .HasMaxLength(10)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName).HasMaxLength(200);
            entity.Property(e => e.SchemePolicy)
                .HasMaxLength(50)
                .HasColumnName("Scheme Policy");
        });

        modelBuilder.Entity<ViewPoliciesAllSavingsEndorsment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Policies_All_Savings_Endorsment");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.EndowmentAmountAfterDeferredPeriod).HasColumnName("Endowment amount after deferred period");
            entity.Property(e => e.EndowmentAmountDuringDeferredPeriod).HasColumnName("Endowment amount during deferred period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewPoliciesAllSavingsMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Policies_All_Savings_Main");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.EndowmentAmountAfterDeferredPeriod).HasColumnName("Endowment amount after deferred period");
            entity.Property(e => e.EndowmentAmountDuringDeferredPeriod).HasColumnName("Endowment amount during deferred period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityStatus)
                .HasMaxLength(11)
                .IsUnicode(false);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyType).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewPolicyDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PolicyDetails");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.Expr1).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.IssuedCell).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.IssuedVillage).HasMaxLength(50);
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SavingPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewPolicyFamilly>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PolicyFamilly");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewPolicyPerUser>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_PolicyPerUsers");

            entity.Property(e => e.CreationDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(1352);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(250);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalConvertedStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Proposal_Converted_Status");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ConvertedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateProposal)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DueDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewProposalCoverter>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalCoverter");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DeathTpd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("dreadDesease");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Funeral)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("funeral");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("lossOfRevenue");
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Ppd)
                .HasColumnType("numeric(18, 0)")
                .HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.ReturnedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SpouceCover).HasColumnType("numeric(18, 0)");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalDetail>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalDetails");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.IssuedCell).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.IssuedVillage).HasMaxLength(50);
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewProposalDetailsPrinting>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalDetailsPrinting");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DeathTpd).HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease).HasColumnName("dreadDesease");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Funeral).HasColumnName("funeral");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentType).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.IssuedCell).HasMaxLength(50);
            entity.Property(e => e.IssuedDistrict).HasMaxLength(50);
            entity.Property(e => e.IssuedProvince).HasMaxLength(50);
            entity.Property(e => e.IssuedSector).HasMaxLength(50);
            entity.Property(e => e.IssuedVillage).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue).HasColumnName("lossOfRevenue");
            entity.Property(e => e.MartialStatus).HasMaxLength(50);
            entity.Property(e => e.Nationality).HasMaxLength(50);
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName).HasMaxLength(200);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalDueDate>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Proposal_DueDate");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ConvertedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateProposal)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalDueDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
        });

        modelBuilder.Entity<ViewProposalEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalEducation");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalEducationCombo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalEducationCombo");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserNameCombo).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalEmployeeProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalEmployeeProtection");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DeathTpd).HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease).HasColumnName("dreadDesease");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Funeral).HasColumnName("funeral");
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue).HasColumnName("lossOfRevenue");
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalRegister");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ConvertedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DueDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Proposal_Date");
            entity.Property(e => e.ProposalDate1)
                .HasColumnType("datetime")
                .HasColumnName("ProposalDate");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate)
                .HasMaxLength(30)
                .IsUnicode(false);
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.ReturnedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
            entity.Property(e => e.UserNamePolicy).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalRegisterNoMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalRegister_NoMembers");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Cancelled Date");
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChannelContactTelephone).HasMaxLength(50);
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ConvertedDate)
                .HasColumnType("datetime")
                .HasColumnName("Converted Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DueDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Due Date");
            entity.Property(e => e.Email).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Proposal Date");
            entity.Property(e => e.ProposalDate1)
                .HasColumnType("datetime")
                .HasColumnName("ProposalDate");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Recorded Date");
            entity.Property(e => e.RecordedDate1)
                .HasColumnType("datetime")
                .HasColumnName("RecordedDate");
            entity.Property(e => e.ReturnedDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Returned Date");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.SubscriberFullName).HasMaxLength(450);
            entity.Property(e => e.SubscriberId)
                .HasMaxLength(50)
                .HasColumnName("SubscriberID");
            entity.Property(e => e.SubscriberPhone).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalRegistersTemp>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalRegistersTemp");

            entity.Property(e => e.AccountNumber).HasMaxLength(50);
            entity.Property(e => e.BenefitPaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ChildCovered).HasMaxLength(100);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CycleAssured).HasMaxLength(50);
            entity.Property(e => e.DeathTpd).HasColumnName("deathTPD");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DreadDesease).HasColumnName("dreadDesease");
            entity.Property(e => e.Funeral).HasColumnName("funeral");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.LossOfRevenue).HasColumnName("lossOfRevenue");
            entity.Property(e => e.NextOfKinNames).HasMaxLength(100);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Ppd).HasColumnName("PPD");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.ReciptingBankId)
                .HasMaxLength(50)
                .HasColumnName("ReciptingBankID");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StaffId)
                .HasMaxLength(50)
                .HasColumnName("StaffID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_proposal_Savings");

            entity.Property(e => e.BusinessChannel).HasMaxLength(50);
            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewProposalWithoutBeneficiary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ProposalWithoutBeneficiaries");

            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewReceiptingEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Receipting_EPI");

            entity.Property(e => e.InsuredCode).HasMaxLength(50);
            entity.Property(e => e.InsuredName).HasMaxLength(100);
            entity.Property(e => e.MaxPaidDate)
                .HasColumnType("datetime")
                .HasColumnName("Max Paid Date");
            entity.Property(e => e.PaidAmount).HasColumnName("Paid Amount");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(50)
                .HasColumnName("Scheme Number");
        });

        modelBuilder.Entity<ViewReinsuranceDataAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReinsuranceData_ALL");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewReinsuranceDataEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReinsuranceData_EPI");

            entity.Property(e => e.DeathTpdsi).HasColumnName("DeathTPDSI");
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewReinsuranceDataFamilly>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReinsuranceData_Familly");

            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewReinsuranceDataGpl>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReinsuranceData_GPL");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumberDetails).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewReinsuranceDataLoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReinsuranceData_LoanProtection");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewReinsuranceDataPensionEndo>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReinsuranceData_PensionEndo");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewReinsuranceDataPensionMain>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ReinsuranceData_PensionMain");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewRiskSavingsFamEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_RiskSavings_FAM_EPI");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.SavingPolicy).HasMaxLength(50);
            entity.Property(e => e.SavingsFullName).HasMaxLength(4000);
        });

        modelBuilder.Entity<ViewSalesAgentEligibleStatus>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SalesAgent_Eligible_Status");

            entity.Property(e => e.Academic)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Applicationletter)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("APPLICATIONLETTER");
            entity.Property(e => e.Bnrform)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("BNRform");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.Crbreport)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CRBReport");
            entity.Property(e => e.CriminalRecord)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Cvsigned)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("CVSigned");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.DocumentRequired).HasMaxLength(100);
            entity.Property(e => e.EmploymentAgreement)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Idcopy)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("IDCopy");
            entity.Property(e => e.Passport)
                .HasMaxLength(3)
                .IsUnicode(false);
            entity.Property(e => e.Pip)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("PIP");
            entity.Property(e => e.Rraclearance)
                .HasMaxLength(3)
                .IsUnicode(false)
                .HasColumnName("RRAClearance");
        });

        modelBuilder.Entity<ViewSavingsPaymentEndoDdg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SavingsPayment_Endo_DDG");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("PremiumPayment Date");
            entity.Property(e => e.ProductType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TaxeOuQuitancemet).HasColumnName("Taxe ou Quitancemet");
            entity.Property(e => e.XFraisFractionnement).HasColumnName("xFraisFractionnement");
        });

        modelBuilder.Entity<ViewSavingsPaymentMainDdg>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SavingsPayment_Main_DDG");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.FullName).HasMaxLength(152);
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberMain).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTermInYear).HasColumnName("Policy Term in year");
            entity.Property(e => e.PolicyTotalSumInsured).HasColumnName("Policy total sum insured");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPaymentDate)
                .HasColumnType("datetime")
                .HasColumnName("PremiumPayment Date");
            entity.Property(e => e.ProductType)
                .HasMaxLength(17)
                .IsUnicode(false);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TaxeOuQuitancemet).HasColumnName("Taxe ou Quitancemet");
            entity.Property(e => e.XFraisFractionnement).HasColumnName("xFraisFractionnement");
        });

        modelBuilder.Entity<ViewSavingsTelephoneValidation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Savings_Telephone_Validations");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FirstName)
                .HasMaxLength(50)
                .HasColumnName("First_Name");
            entity.Property(e => e.LastName)
                .HasMaxLength(50)
                .HasColumnName("Last_Name");
            entity.Property(e => e.LastNameV)
                .HasMaxLength(255)
                .HasColumnName("last_name_v");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(50)
                .HasColumnName("Middle_Name");
            entity.Property(e => e.Msisdn)
                .HasMaxLength(255)
                .HasColumnName("msisdn");
            entity.Property(e => e.MsisdnKey)
                .HasMaxLength(255)
                .HasColumnName("msisdn_key");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.SubsNameV)
                .HasMaxLength(255)
                .HasColumnName("subs_name_v");
        });

        modelBuilder.Entity<ViewSingleInvoiceAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SingleInvoice_ALL");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DueDate).HasColumnType("datetime");
            entity.Property(e => e.EndDateEndo).HasColumnType("datetime");
            entity.Property(e => e.FullNames).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdentityRecord).HasMaxLength(100);
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
            entity.Property(e => e.PolicyType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SchemeName).HasMaxLength(150);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSingleInvoiceEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SingleInvoice_Education");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberInvoice).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType)
                .HasMaxLength(9)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(50);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewSingleInvoiceEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SingleInvoice_EPI");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberInvoice).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType)
                .HasMaxLength(19)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewSingleInvoiceFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SingleInvoice_Family");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("Creation Date");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth)
                .HasColumnType("datetime")
                .HasColumnName("Date of birth");
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasColumnType("datetime")
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber)
                .HasMaxLength(50)
                .HasColumnName("Id Document Number");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PaymentStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberEndo).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberInvoice).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PremiumFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Frequency");
            entity.Property(e => e.PremiumPayingTermInYear).HasColumnName("Premium Paying Term in year");
            entity.Property(e => e.PremiumPerFrequency).HasColumnName("Premium per frequency");
            entity.Property(e => e.ProductType)
                .HasMaxLength(16)
                .IsUnicode(false);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.UnderwritingUserName).HasMaxLength(100);
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewSms15LoanProtection>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_15_LoanProtection");

            entity.Property(e => e.BankName).HasMaxLength(500);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.IdBankBranch).HasMaxLength(50);
            entity.Property(e => e.LoanEndDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(1352);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewSms5Education>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_Education");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.Names).HasMaxLength(300);
            entity.Property(e => e.PaymentFrequency).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSms5Epi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_EPI");

            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSms5Family>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_Family");

            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PremiumFrequency).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewSms5PsEndoPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_PS_Endo_Pension");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSms5PsEndoSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_PS_Endo_Savings");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSms5PsMainPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_PS_Main_Pension");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSms5PsMainSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_PS_Main_Savings");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSms5PsPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_PS_Pension");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSms5PsSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_5_PS_Savings");

            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(4000);
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewSmsAnniversary>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_Anniversary");

            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewSmsAnniversarySend>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_Anniversary_Send");

            entity.Property(e => e.AccountName)
                .HasMaxLength(901)
                .HasColumnName("Account_Name");
            entity.Property(e => e.AccountOpenDate)
                .HasColumnType("datetime")
                .HasColumnName("Account_Open_Date");
            entity.Property(e => e.AnniversaryDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewSmsDigitalFamilyNotConverted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_Digital_FamilyNotConverted");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewSmsDigitalIkiminaNotConverted>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_Digital_IkiminaNotConverted");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewSmsDigitalPendingPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_DigitalPendingPayment");

            entity.Property(e => e.ExternalReference).HasMaxLength(50);
            entity.Property(e => e.IdRecord).ValueGeneratedOnAdd();
            entity.Property(e => e.PhonNumber).HasMaxLength(10);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReferenceId).HasMaxLength(50);
            entity.Property(e => e.Status).HasMaxLength(50);
            entity.Property(e => e.TransactionId).HasMaxLength(450);
        });

        modelBuilder.Entity<ViewSmsLapsedEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_Lapsed_EPI");

            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
        });

        modelBuilder.Entity<ViewSmsLapsedFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_SMS_Lapsed_Family");

            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
        });

        modelBuilder.Entity<ViewTransUnionCustomersAll>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_Customers_All");

            entity.Property(e => e.Cell).HasMaxLength(50);
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
            entity.Property(e => e.EmailAddress).HasColumnName("Email Address");
            entity.Property(e => e.EmployerAddressLine1).HasColumnName("Employer Address Line 1");
            entity.Property(e => e.EmployerCountry).HasColumnName("Employer Country");
            entity.Property(e => e.EmployerDurationMonths).HasColumnName("Employer Duration (Months)");
            entity.Property(e => e.EmployerDurationYears).HasColumnName("Employer Duration (Years)");
            entity.Property(e => e.EmployerName).HasColumnName("Employer Name");
            entity.Property(e => e.EmployerTown).HasColumnName("Employer Town");
            entity.Property(e => e.FascimileFax).HasColumnName("Fascimile / Fax");
            entity.Property(e => e.FirstNameTradingName)
                .HasMaxLength(450)
                .HasColumnName("First Name/Trading Name");
            entity.Property(e => e.Gender)
                .HasMaxLength(14)
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
                .HasMaxLength(22)
                .IsUnicode(false)
                .HasColumnName("Marital Status");
            entity.Property(e => e.MiddleName)
                .HasMaxLength(450)
                .HasColumnName("Middle Name");
            entity.Property(e => e.MobileTelephone)
                .HasMaxLength(50)
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

        modelBuilder.Entity<ViewTransUnionCustomersIngenzi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_Customers_Ingenzi");

            entity.Property(e => e.Cell).HasMaxLength(50);
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
                .HasMaxLength(1)
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
            entity.Property(e => e.PlaceOfBirthRegistration)
                .HasMaxLength(50)
                .HasColumnName("Place Of Birth/ Registration");
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(450)
                .HasColumnName("Surname/Institution Name");
            entity.Property(e => e.WorkTelephone).HasColumnName("Work Telephone");
        });

        modelBuilder.Entity<ViewTransUnionPolicyDetailsEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_PolicyDetails_Education");

            entity.Property(e => e.BasePolicyNumber)
                .HasMaxLength(50)
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
            entity.Property(e => e.EndorsementDate)
                .HasMaxLength(30)
                .IsUnicode(false)
                .HasColumnName("Endorsement Date");
            entity.Property(e => e.EndorsementNumber)
                .HasMaxLength(50)
                .HasColumnName("Endorsement Number");
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
            entity.Property(e => e.ReportingMonth)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(450)
                .HasColumnName("Surname/Institution Name");
        });

        modelBuilder.Entity<ViewTransUnionPolicyDetailsEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_PolicyDetails_EPI");

            entity.Property(e => e.BasePolicyNumber)
                .HasMaxLength(50)
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
            entity.Property(e => e.ReportingMonth)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(450)
                .HasColumnName("Surname/Institution Name");
        });

        modelBuilder.Entity<ViewTransUnionPolicyDetailsFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_TransUnion_PolicyDetails_Family");

            entity.Property(e => e.BasePolicyNumber)
                .HasMaxLength(50)
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
            entity.Property(e => e.ReportingMonth)
                .HasMaxLength(6)
                .IsUnicode(false);
            entity.Property(e => e.SurnameInstitutionName)
                .HasMaxLength(450)
                .HasColumnName("Surname/Institution Name");
        });

        modelBuilder.Entity<ViewUmurageActuarialValuation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Umurage_Actuarial_Valuation");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CommissionRate).HasColumnName("Commission rate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DateOfBirth).HasColumnType("datetime");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
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
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.InstallementFee).HasColumnName("Installement fee");
            entity.Property(e => e.InterestRate).HasColumnType("numeric(2, 1)");
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.ManagementFee).HasColumnName("Management fee");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.MaxDateFormated)
                .HasColumnType("datetime")
                .HasColumnName("Max dateFormated");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy Status");
            entity.Property(e => e.PolicyTerm).HasColumnName("Policy Term");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
        });

        modelBuilder.Entity<ViewUmurageAllPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Umurage_All_Payments");

            entity.Property(e => e.Comments)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentMode)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PaymentSource)
                .HasMaxLength(1)
                .IsUnicode(false);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.UserId).HasMaxLength(50);
            entity.Property(e => e.YearMonth)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("YEAR_MONTH");
        });

        modelBuilder.Entity<ViewUmurageAllPolicy>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Umurage_All_Policies");

            entity.Property(e => e.CreationYearMonths)
                .HasMaxLength(61)
                .IsUnicode(false)
                .HasColumnName("Creation_YearMonths");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewUpdateCustomerEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateCustomerEducation");

            entity.Property(e => e.Cell).HasMaxLength(50);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.District).HasMaxLength(50);
            entity.Property(e => e.DoB).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(301);
            entity.Property(e => e.Gender)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.GenderNida).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.IssuedPlace).HasMaxLength(50);
            entity.Property(e => e.MaritalStatus).HasMaxLength(50);
            entity.Property(e => e.Names).HasMaxLength(300);
            entity.Property(e => e.PolicyNumber).HasMaxLength(250);
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false);
            entity.Property(e => e.Province).HasMaxLength(50);
            entity.Property(e => e.ResidenceCell).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceSector).HasMaxLength(50);
            entity.Property(e => e.ResidenceVillage).HasMaxLength(50);
            entity.Property(e => e.Salutation).HasMaxLength(50);
            entity.Property(e => e.Sector).HasMaxLength(50);
            entity.Property(e => e.Title)
                .HasMaxLength(10)
                .IsFixedLength();
            entity.Property(e => e.Village).HasMaxLength(50);
            entity.Property(e => e.VillageId).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdateCustomerIngenzi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateCustomerIngenzi");

            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.FullNameNida)
                .HasMaxLength(301)
                .HasColumnName("FullNameNIDA");
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdDocumentNumberNida)
                .HasMaxLength(50)
                .HasColumnName("IdDocumentNumberNIDA");
        });

        modelBuilder.Entity<ViewUpdateCustomersInPayementFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateCustomersInPayement_Family");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.CustomerCodePyt).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberPyt)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumberPYT");
        });

        modelBuilder.Entity<ViewUpdateEdicationRegisterClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateEdicationRegisterClaims");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyDate).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
        });

        modelBuilder.Entity<ViewUpdateEpiSaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Update_EPI_Savings");

            entity.Property(e => e.CancelledEpi).HasColumnName("CancelledEPI");
            entity.Property(e => e.ClaimedEpi).HasColumnName("ClaimedEPI");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.FullNamesSavings).HasMaxLength(152);
            entity.Property(e => e.Nid)
                .HasMaxLength(13)
                .HasColumnName("NID");
            entity.Property(e => e.Nidsavings)
                .HasMaxLength(13)
                .HasColumnName("NIDSavings");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.PolicyStatusEpi)
                .HasMaxLength(50)
                .HasColumnName("PolicyStatusEPI");
            entity.Property(e => e.ProductCategory).HasMaxLength(50);
            entity.Property(e => e.SavingPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SubPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SubProductType).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdateEpiregisterClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateEPIRegisterClaims");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("datetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("datetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyStatus).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdateFamilyInvPayment>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Update_Family_INV_Payment");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.PaymentDate).HasColumnType("datetime");
            entity.Property(e => e.PaymentPeriod).HasColumnType("datetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberInv)
                .HasMaxLength(50)
                .HasColumnName("PolicyNumberINV");
            entity.Property(e => e.ReferencePay).HasMaxLength(100);
            entity.Property(e => e.ReferencePayInv)
                .HasMaxLength(100)
                .HasColumnName("ReferencePayINV");
        });

        modelBuilder.Entity<ViewUpdateFamilyRegisterClaim>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateFamilyRegisterClaims");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdateFamilySaving>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_Update_Family_Savings");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.FullNamesSavings).HasMaxLength(152);
            entity.Property(e => e.Nid)
                .HasMaxLength(13)
                .HasColumnName("NID");
            entity.Property(e => e.Nidsavings)
                .HasMaxLength(13)
                .HasColumnName("NIDSavings");
            entity.Property(e => e.PolicyComponentType).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.SavingPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SubPolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SubProductType).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewUpdatePolicyEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePolicyEducation");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SendContract).HasColumnName("Send_Contract");
        });

        modelBuilder.Entity<ViewUpdatePolicyEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePolicyEPI");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SendContract).HasColumnName("Send_Contract");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewUpdatePolicyFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePolicyFamily");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SendContract).HasColumnName("Send_Contract");
            entity.Property(e => e.VendorId)
                .HasMaxLength(50)
                .HasColumnName("VendorID");
        });

        modelBuilder.Entity<ViewUpdatePolicyPension>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdatePolicyPension");

            entity.Property(e => e.Channel).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EndorsementMade).HasColumnName("Endorsement_Made");
            entity.Property(e => e.FullName).HasMaxLength(101);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdRecord).HasColumnName("Id_Record");
            entity.Property(e => e.PaymentChannel).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.PolicyNumberChild).HasMaxLength(50);
            entity.Property(e => e.SchemeId).HasMaxLength(50);
            entity.Property(e => e.SendContract).HasColumnName("Send_Contract");
            entity.Property(e => e.StartDate).HasColumnType("datetime");
            entity.Property(e => e.VendorCode)
                .HasMaxLength(10)
                .IsFixedLength();
        });

        modelBuilder.Entity<ViewUpdateProposalRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateProposalRegister");

            entity.Property(e => e.CancelledDate).HasColumnType("datetime");
            entity.Property(e => e.CancelledRaison).HasMaxLength(100);
            entity.Property(e => e.ConvertedDate).HasColumnType("datetime");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.IdDocumentNumber).HasMaxLength(50);
            entity.Property(e => e.IdfileExtension)
                .HasMaxLength(50)
                .HasColumnName("IDFileExtension");
            entity.Property(e => e.Institutions).HasMaxLength(50);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.Product).HasMaxLength(50);
            entity.Property(e => e.ProposalDate).HasColumnType("datetime");
            entity.Property(e => e.ProposalNumber).HasMaxLength(50);
            entity.Property(e => e.RecordedDate).HasColumnType("datetime");
            entity.Property(e => e.ReturnedDate).HasColumnType("datetime");
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewUpdateRegisterEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateRegister_EPI");

            entity.Property(e => e.CreationDate)
                .HasColumnType("datetime")
                .HasColumnName("creationDate");
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate)
                .HasColumnType("datetime")
                .HasColumnName("effectiveDate");
            entity.Property(e => e.EndDate)
                .HasColumnType("datetime")
                .HasColumnName("endDate");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("policyNumber");
            entity.Property(e => e.RiskPremium).HasColumnName("riskPremium");
            entity.Property(e => e.Savings).HasColumnName("savings");
            entity.Property(e => e.SchemeNumber)
                .HasMaxLength(50)
                .HasColumnName("schemeNumber");
            entity.Property(e => e.TotalPremium).HasColumnName("totalPremium");
            entity.Property(e => e.UserName)
                .HasMaxLength(50)
                .HasColumnName("userName");
        });

        modelBuilder.Entity<ViewUpdateRegisterFamilly>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateRegister_Familly");

            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.EffectiveDate).HasColumnType("smalldatetime");
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.MaturityDate).HasColumnType("smalldatetime");
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(100);
        });

        modelBuilder.Entity<ViewUpdateSchemeEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateScheme_EPI");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeIdn)
                .HasMaxLength(50)
                .HasColumnName("SchemeIDN");
        });

        modelBuilder.Entity<ViewUpdateSchemeEpiRegister>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateScheme_EPI_Register");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
        });

        modelBuilder.Entity<ViewUpdateSchemeFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UpdateScheme_Family");

            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CustomerCode).HasMaxLength(50);
            entity.Property(e => e.FullName).HasMaxLength(450);
            entity.Property(e => e.PaymentMode).HasMaxLength(50);
            entity.Property(e => e.PaymentSource).HasMaxLength(150);
            entity.Property(e => e.PolicyNumber).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeIdn)
                .HasMaxLength(50)
                .HasColumnName("SchemeIDN");
        });

        modelBuilder.Entity<ViewUsersInactiveAgent>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_UsersInactiveAgents");

            entity.Property(e => e.ChannelId)
                .HasMaxLength(50)
                .HasColumnName("ChannelID");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.ChannelType).HasMaxLength(50);
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.Names).HasMaxLength(100);
            entity.Property(e => e.Phone).HasMaxLength(50);
            entity.Property(e => e.UserName).HasMaxLength(50);
        });

        modelBuilder.Entity<ViewZamaraActuarialValuationEducation>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Actuarial_Valuation_Education");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CommissionRate)
                .HasColumnType("numeric(13, 1)")
                .HasColumnName("Commission rate");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Date of Birth");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.InstallementFee).HasColumnName("Installement fee");
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.ManagementFee).HasColumnName("Management fee");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max dateFormated");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTerm).HasColumnName("Policy Term");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPayingTerm).HasColumnName("Premium Paying Term");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeId)
                .HasMaxLength(50)
                .HasColumnName("SchemeID");
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
        });

        modelBuilder.Entity<ViewZamaraActuarialValuationEpi>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Actuarial_Valuation_EPI");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
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
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.InstallementFee).HasColumnName("Installement fee");
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.ManagementFee).HasColumnName("Management fee");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.MaturityDateForamted)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Maturity Date Foramted");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max date Formated");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTerm).HasColumnName("Policy Term");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PolicyholderSumInsured).HasColumnName("Policyholder sum insured");
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
            entity.Property(e => e.TotalSumInsuredForOtherFamilyMembers).HasColumnName("Total sum insured for other family members");
        });

        modelBuilder.Entity<ViewZamaraActuarialValuationEpiMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Actuarial_Valuation_EPI_Member");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
            entity.Property(e => e.CommissionRate).HasColumnName("Commission rate");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Date of Birth");
            entity.Property(e => e.DateOfBirth1)
                .HasColumnType("datetime")
                .HasColumnName("DateOfBirth");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Effective Date");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.GenderMember).HasMaxLength(50);
            entity.Property(e => e.InstallementFee).HasColumnName("Installement fee");
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.ManagementFee).HasColumnName("Management fee");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.MaturityDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Maturity Date Formated");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max Date Formated");
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTerm).HasColumnName("Policy Term");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(19)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PolicyholderSumInsured).HasColumnName("Policyholder sum insured");
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
            entity.Property(e => e.TotalSumInsuredForOtherFamilyMembers).HasColumnName("Total sum insured for other family members");
        });

        modelBuilder.Entity<ViewZamaraActuarialValuationFamily>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Actuarial_Valuation_Family");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
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
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.InstallementFee).HasColumnName("Installement fee");
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.ManagementFee).HasColumnName("Management fee");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.MaturityDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Maturity Date formated");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max date Formated");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTerm).HasColumnName("Policy Term");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PolicyholderSumInsured).HasColumnName("Policyholder sum insured");
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
            entity.Property(e => e.TotalSumInsuredForOtherFamilyMembers).HasColumnName("Total sum insured for other family members");
        });

        modelBuilder.Entity<ViewZamaraActuarialValuationFamilyMember>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Actuarial_Valuation_Family_Member");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.ChannelName).HasMaxLength(150);
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
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.GenderMember).HasMaxLength(50);
            entity.Property(e => e.InstallementFee).HasColumnName("Installement fee");
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.ManagementFee).HasColumnName("Management fee");
            entity.Property(e => e.MaturityDate)
                .HasColumnType("datetime")
                .HasColumnName("Maturity Date");
            entity.Property(e => e.MaturityDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Maturity Date Formated");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max date Formated");
            entity.Property(e => e.MemberDob)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("MemberDOB");
            entity.Property(e => e.MemberFullName).HasMaxLength(100);
            entity.Property(e => e.NextOfKin).HasMaxLength(3);
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTerm).HasColumnName("Policy Term");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(16)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PolicyholderSumInsured).HasColumnName("Policyholder sum insured");
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.Relationship).HasMaxLength(50);
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
            entity.Property(e => e.TotalSumInsuredForOtherFamilyMembers).HasColumnName("Total sum insured for other family members");
        });

        modelBuilder.Entity<ViewZamaraActuarialValuationUmurage>(entity =>
        {
            entity
                .HasNoKey()
                .ToView("View_ZAMARA_Actuarial_Valuation_Umurage");

            entity.Property(e => e.AnnualPremium).HasColumnName("Annual Premium");
            entity.Property(e => e.CommissionRate)
                .HasColumnType("numeric(13, 1)")
                .HasColumnName("Commission rate");
            entity.Property(e => e.CustomerCode)
                .HasMaxLength(50)
                .HasColumnName("Customer code");
            entity.Property(e => e.DateOfBirth)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Date of Birth");
            entity.Property(e => e.DistributionChannelId)
                .HasMaxLength(50)
                .HasColumnName("DistributionChannelID");
            entity.Property(e => e.EffectiveDate)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Effective Date");
            entity.Property(e => e.EndDateOfEndowmentPayment)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("End Date of Endowment Payment");
            entity.Property(e => e.EndDateOfPremiumPayment)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("End Date of Premium Payment");
            entity.Property(e => e.EndowmentAmountAfterDifferedPeriod).HasColumnName("Endowment amount after differed period");
            entity.Property(e => e.EndowmentAmountDuringDifferedPeriod).HasColumnName("Endowment amount during differed period");
            entity.Property(e => e.EndowmentNumberInYear).HasColumnName("Endowment Number in year");
            entity.Property(e => e.Gender).HasMaxLength(50);
            entity.Property(e => e.InstallementFee).HasColumnName("Installement fee");
            entity.Property(e => e.LifeAssuredName)
                .HasMaxLength(450)
                .HasColumnName("Life Assured Name");
            entity.Property(e => e.ManagementFee).HasColumnName("Management fee");
            entity.Property(e => e.MaxDate)
                .HasColumnType("datetime")
                .HasColumnName("Max date");
            entity.Property(e => e.MaxDateFormated)
                .HasMaxLength(8000)
                .IsUnicode(false)
                .HasColumnName("Max dateFormated");
            entity.Property(e => e.OutstandingAmount).HasColumnName("Outstanding amount");
            entity.Property(e => e.PhoneNumber1)
                .HasMaxLength(50)
                .HasColumnName("PhoneNumber_1");
            entity.Property(e => e.PolicyNumber)
                .HasMaxLength(50)
                .HasColumnName("Policy Number");
            entity.Property(e => e.PolicyStatus)
                .HasMaxLength(8)
                .IsUnicode(false)
                .HasColumnName("Policy status");
            entity.Property(e => e.PolicyTerm).HasColumnName("Policy Term");
            entity.Property(e => e.PolicyType)
                .HasMaxLength(17)
                .IsUnicode(false)
                .HasColumnName("Policy Type");
            entity.Property(e => e.PremiumAmountAsPerFrequency).HasColumnName("Premium amount as per frequency");
            entity.Property(e => e.PremiumPayingTerm).HasColumnName("Premium Paying Term");
            entity.Property(e => e.PremiumPaymentFrequency)
                .HasMaxLength(50)
                .HasColumnName("Premium Payment Frequency");
            entity.Property(e => e.ProfitSharing).HasColumnName("Profit Sharing");
            entity.Property(e => e.ResidenceDistrict).HasMaxLength(50);
            entity.Property(e => e.ResidenceProvince).HasMaxLength(50);
            entity.Property(e => e.SchemeName)
                .HasMaxLength(150)
                .HasColumnName("Scheme name");
            entity.Property(e => e.TotalPaidAmount).HasColumnName("Total paid amount");
        });

        OnModelCreatingPartial(modelBuilder);
    }

    partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
}
