using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Test2.Models.DTO
{
    public class TblFileProcessingErrorDTO
    {
        public TblFileProcessingErrorDTO()
        {

        }

        public int FileProcessingErrorId { get; set; }
        public int? LandingContributionDataId { get; set; }
        public int? StagingContributionDataId { get; set; }
        public int? FileReceivedId { get; set; }
        public int? InboundFileSetupId { get; set; }
        public string Attribute { get; set; }
        public DateTime? CheckDate { get; set; }
        public long? Ssn { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string Title { get; set; }
        public string EmployeeId { get; set; }
        public string Gender { get; set; }
        public string EmployeeStatus { get; set; }
        public string MaritalStatus { get; set; }
        public string CompanyOrDivisionCode { get; set; }
        public string UnionStatus { get; set; }
        public string Address1 { get; set; }
        public string Address2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public long? Zip { get; set; }
        public DateTime? BirthDate { get; set; }
        public DateTime? HireDate { get; set; }
        public DateTime? TerminationDate { get; set; }
        public DateTime? RehireDate { get; set; }
        public decimal? GrossEarnings { get; set; }
        public decimal? PayPeriodHours { get; set; }
        public decimal? EmployeeDeferral { get; set; }
        public decimal? EmployeeRoth { get; set; }
        public decimal? LoanPayments { get; set; }
        public decimal? EmployeeAfterTax { get; set; }
        public decimal? EmployerMatch { get; set; }
        public decimal? SafeHarborMatch { get; set; }
        public decimal? SafeHarborNonElective { get; set; }
        public decimal? QualifiedMatchingContribution { get; set; }
        public decimal? QualifiedNonElectiveContribution { get; set; }
        public decimal? ProfitSharing { get; set; }
        public decimal? MoneyPurchase { get; set; }
        public string PayFrequency { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string PayType { get; set; }
        public DateTime? AdjustedSeniorityDate { get; set; }
        public DateTime? LeaveOfAbsenceBeginDate { get; set; }
        public DateTime? LeaveOfAbsenceEndDate { get; set; }
        public DateTime? PayrollBeginDate { get; set; }
        public DateTime? PayrollEndDate { get; set; }
        public string CostCenter1Code { get; set; }
        public string CostCenter2Code { get; set; }
        public string CostCenter3Code { get; set; }
        public decimal? PlanEarnings { get; set; }
        public decimal? ExcludedEarnings { get; set; }
        public string Section125 { get; set; }
        public decimal? LoanAdditionalPrincipalPayments { get; set; }
        public long? LoanNumber { get; set; }
        public decimal? Rollover { get; set; }
        public decimal? RolloverRoth { get; set; }
        public decimal? YtdGrossEarnings { get; set; }
        public decimal? PlanYtdEarnings { get; set; }
        public decimal? PlanYtdHours { get; set; }
        public decimal? PlanYtdExcludedEarnings { get; set; }
        public string PlanYtdSection125 { get; set; }
        public decimal? PlanYtdEmployeeDeferral { get; set; }
        public decimal? PlanYtdEmployeeRoth { get; set; }
        public decimal? PlanYtdEmployeeAfterTax { get; set; }
        public decimal? PlanYtdLoanPayments { get; set; }
        public long? PlanYtdLoanNumber { get; set; }
        public decimal? PlanYtdEmployerMatch { get; set; }
        public decimal? PlanYtdSafeHarborMatch { get; set; }
        public decimal? PlanYtdQualifiedMatchingContribution { get; set; }
        public decimal? PlanYtdSafeHarborNonElective { get; set; }
        public decimal? PlanYtdQualifiedNonElectiveContribution { get; set; }
        public decimal? PlanYtdProfitSharing { get; set; }
        public decimal? PlanYtdMoneyPurchase { get; set; }
        public decimal? PlanYtdRollover { get; set; }
        public decimal? PlanYtdRolloverRoth { get; set; }
        public int? PlanId { get; set; }
        public int? RecipientVendorPlanId { get; set; }
        public string Detail { get; set; }
        public int? EmployerEin { get; set; }
        public string EmployerName { get; set; }
        public int? EmployerPlanId { get; set; }
        public int? EmployerSubPlanId { get; set; }
        public int? OriginatingVendorId { get; set; }
        public int? OriginatingVendorSubPlanId { get; set; }
        public int? RecipientVendorSubPlanId { get; set; }
        public string TypeOfAccount403b { get; set; }
        public string HrAreaOrLocationCode { get; set; }
        public string HrSubArea { get; set; }
        public DateTime? AdjustedDateOfHire { get; set; }
        public string PayrollMode { get; set; }
        public string ContributionSourceCode1 { get; set; }
        public decimal? ContributionSourceAmount1 { get; set; }
        public string ContributionSourceCode2 { get; set; }
        public decimal? ContributionSourceAmount2 { get; set; }
        public string ContributionSourceCode3 { get; set; }
        public decimal? ContributionSourceAmount3 { get; set; }
        public string ContributionSourceCode4 { get; set; }
        public decimal? ContributionSourceAmount4 { get; set; }
        public string ContributionSourceCode5 { get; set; }
        public decimal? ContributionSourceAmount5 { get; set; }
        public string ContributionSourceCode6 { get; set; }
        public decimal? ContributionSourceAmount6 { get; set; }
        public string ContributionSourceCode7 { get; set; }
        public decimal? ContributionSourceAmount7 { get; set; }
        public string ContributionSourceCode8 { get; set; }
        public decimal? ContributionSourceAmount8 { get; set; }
        public string FinalContributionIndicator { get; set; }
        public long? LoanNumber1 { get; set; }
        public decimal? LoanRepaymentAmount1 { get; set; }
        public long? LoanNumber2 { get; set; }
        public decimal? LoanRepaymentAmout2 { get; set; }
        public long? LoanNumber3 { get; set; }
        public decimal? LoanRepaymentAmount4 { get; set; }
        public long? LoanNumber5 { get; set; }
        public decimal? LoanRepaymentAmount5 { get; set; }
        public string HeaderColumn1 { get; set; }
        public string HeaderColumn2 { get; set; }
        public string HeaderColumn3 { get; set; }
        public string HeaderColumn4 { get; set; }
        public string HeaderColumn5 { get; set; }
        public string HeaderColumn6 { get; set; }
        public string HeaderColumn7 { get; set; }
        public string HeaderColumn8 { get; set; }
        public string HeaderColumn9 { get; set; }
        public string HeaderColumn10 { get; set; }
        public string FooterColumn1 { get; set; }
        public string FooterColumn2 { get; set; }
        public string FooterColumn3 { get; set; }
        public string FooterColumn4 { get; set; }
        public string FooterColumn5 { get; set; }
        public string FooterColumn6 { get; set; }
        public string FooterColumn7 { get; set; }
        public string FooterColumn8 { get; set; }
        public string FooterColumn9 { get; set; }
        public string FooterColumn10 { get; set; }
        public string ErrorRemark { get; set; }
        public string FileProcessingStage { get; set; }
        public string Status { get; set; }
    }
}
