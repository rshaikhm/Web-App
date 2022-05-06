using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Test2.Models
{
    public partial class pcssqldbIngestionpayroll360devContext : DbContext
    {
        public pcssqldbIngestionpayroll360devContext()
        {
        }

        public pcssqldbIngestionpayroll360devContext(DbContextOptions<pcssqldbIngestionpayroll360devContext> options)
            : base(options)
        {
        }

        public virtual DbSet<TblFileProcessingError> TblFileProcessingError { get; set; }
        public virtual DbSet<TblLandingContributionData> TblLandingContributionData { get; set; }
        public virtual DbSet<TblStagingContributionData> TblStagingContributionData { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=tcp:pcs-sql-payroll360-dev.database.windows.net;Database=pcs-sqldb-Ingestion-payroll360-dev;Trusted_Connection=False;Encrypt=True;User=serveradmin;password=NcPtpjfp7jsfWUzE");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblFileProcessingError>(entity =>
            {
                entity.HasKey(e => e.FileProcessingErrorId);

                entity.ToTable("tbl_File_Processing_Error");

                entity.Property(e => e.FileProcessingErrorId)
                    .HasColumnName("File_Processing_Error_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("Address_1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address_2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustedDateOfHire)
                    .HasColumnName("Adjusted_Date_of_Hire")
                    .HasColumnType("date");

                entity.Property(e => e.AdjustedSeniorityDate)
                    .HasColumnName("Adjusted_Seniority_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Attribute)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("Birth_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyOrDivisionCode)
                    .HasColumnName("Company_Or_Division_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceAmount1).HasColumnName("Contribution_Source_Amount_1");

                entity.Property(e => e.ContributionSourceAmount2).HasColumnName("Contribution_Source_Amount_2");

                entity.Property(e => e.ContributionSourceAmount3).HasColumnName("Contribution_Source_Amount_3");

                entity.Property(e => e.ContributionSourceAmount4).HasColumnName("Contribution_Source_Amount_4");

                entity.Property(e => e.ContributionSourceAmount5).HasColumnName("Contribution_Source_Amount_5");

                entity.Property(e => e.ContributionSourceAmount6).HasColumnName("Contribution_Source_Amount_6");

                entity.Property(e => e.ContributionSourceAmount7).HasColumnName("Contribution_Source_Amount_7");

                entity.Property(e => e.ContributionSourceAmount8).HasColumnName("Contribution_Source_Amount_8");

                entity.Property(e => e.ContributionSourceCode1)
                    .HasColumnName("Contribution_Source_Code_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode2)
                    .HasColumnName("Contribution_Source_Code_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode3)
                    .HasColumnName("Contribution_Source_Code_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode4)
                    .HasColumnName("Contribution_Source_Code_4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode5)
                    .HasColumnName("Contribution_Source_Code_5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode6)
                    .HasColumnName("Contribution_Source_Code_6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode7)
                    .HasColumnName("Contribution_Source_Code_7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode8)
                    .HasColumnName("Contribution_Source_Code_8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter1Code)
                    .HasColumnName("Cost_Center_1_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter2Code)
                    .HasColumnName("Cost_Center_2_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter3Code)
                    .HasColumnName("Cost_Center_3_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeAfterTax).HasColumnName("Employee_After_Tax");

                entity.Property(e => e.EmployeeDeferral).HasColumnName("Employee_Deferral");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeRoth).HasColumnName("Employee_Roth");

                entity.Property(e => e.EmployeeStatus)
                    .HasColumnName("Employee_Status")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerEin).HasColumnName("Employer_EIN");

                entity.Property(e => e.EmployerMatch).HasColumnName("Employer_Match");

                entity.Property(e => e.EmployerName)
                    .HasColumnName("Employer_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerPlanId).HasColumnName("Employer_Plan_ID");

                entity.Property(e => e.EmployerSubPlanId).HasColumnName("Employer_Sub_Plan_ID");

                entity.Property(e => e.ErrorRemark)
                    .HasColumnName("Error_Remark")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ExcludedEarnings).HasColumnName("Excluded_Earnings");

                entity.Property(e => e.FileProcessingStage)
                    .HasColumnName("File_Processing_Stage")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FileReceivedId).HasColumnName("File_received_ID");

                entity.Property(e => e.FinalContributionIndicator)
                    .HasColumnName("Final_Contribution_Indicator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn1)
                    .HasColumnName("Footer_Column_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn10)
                    .HasColumnName("Footer_Column_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn2)
                    .HasColumnName("Footer_Column_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn3)
                    .HasColumnName("Footer_Column_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn4)
                    .HasColumnName("Footer_Column_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn5)
                    .HasColumnName("Footer_Column_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn6)
                    .HasColumnName("Footer_Column_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn7)
                    .HasColumnName("Footer_Column_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn8)
                    .HasColumnName("Footer_Column_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn9)
                    .HasColumnName("Footer_Column_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossEarnings).HasColumnName("Gross_Earnings");

                entity.Property(e => e.HeaderColumn1)
                    .HasColumnName("Header_Column_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn10)
                    .HasColumnName("Header_Column_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn2)
                    .HasColumnName("Header_Column_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn3)
                    .HasColumnName("Header_Column_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn4)
                    .HasColumnName("Header_Column_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn5)
                    .HasColumnName("Header_Column_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn6)
                    .HasColumnName("Header_Column_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn7)
                    .HasColumnName("Header_Column_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn8)
                    .HasColumnName("Header_Column_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn9)
                    .HasColumnName("Header_Column_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasColumnName("Hire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HrAreaOrLocationCode)
                    .HasColumnName("HR_Area_Or_Location_Code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrSubArea)
                    .HasColumnName("HR_Sub_Area")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InboundFileSetupId).HasColumnName("Inbound_File_Setup_ID");

                entity.Property(e => e.LandingContributionDataId).HasColumnName("Landing_Contribution_Data_ID");

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveOfAbsenceBeginDate)
                    .HasColumnName("Leave_Of_Absence_Begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeaveOfAbsenceEndDate)
                    .HasColumnName("Leave_Of_Absence_End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoanAdditionalPrincipalPayments).HasColumnName("Loan_Additional_Principal_Payments");

                entity.Property(e => e.LoanNumber).HasColumnName("Loan_Number");

                entity.Property(e => e.LoanNumber1).HasColumnName("Loan_Number_1");

                entity.Property(e => e.LoanNumber2).HasColumnName("Loan_Number_2");

                entity.Property(e => e.LoanNumber3).HasColumnName("Loan_Number_3");

                entity.Property(e => e.LoanNumber5).HasColumnName("Loan_Number_5");

                entity.Property(e => e.LoanPayments).HasColumnName("Loan_Payments");

                entity.Property(e => e.LoanRepaymentAmount1).HasColumnName("Loan_Repayment_Amount_1");

                entity.Property(e => e.LoanRepaymentAmount4).HasColumnName("Loan_Repayment_Amount_4");

                entity.Property(e => e.LoanRepaymentAmount5).HasColumnName("Loan_Repayment_Amount_5");

                entity.Property(e => e.LoanRepaymentAmout2).HasColumnName("Loan_Repayment_Amout_2");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("Marital_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("Middle_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoneyPurchase).HasColumnName("Money_Purchase");

                entity.Property(e => e.OriginatingVendorId).HasColumnName("Originating_Vendor_ID");

                entity.Property(e => e.OriginatingVendorSubPlanId).HasColumnName("Originating_Vendor_Sub_Plan_ID");

                entity.Property(e => e.PayFrequency)
                    .HasColumnName("Pay_Frequency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodHours).HasColumnName("Pay_Period_Hours");

                entity.Property(e => e.PayType)
                    .HasColumnName("Pay_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollBeginDate)
                    .HasColumnName("Payroll_Begin_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PayrollEndDate)
                    .HasColumnName("Payroll_End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PayrollMode)
                    .HasColumnName("Payroll_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanEarnings).HasColumnName("Plan_Earnings");

                entity.Property(e => e.PlanId).HasColumnName("Plan_ID");

                entity.Property(e => e.PlanYtdEarnings).HasColumnName("Plan_YTD_Earnings");

                entity.Property(e => e.PlanYtdEmployeeAfterTax).HasColumnName("Plan_YTD_Employee_After_Tax");

                entity.Property(e => e.PlanYtdEmployeeDeferral).HasColumnName("Plan_YTD_Employee_Deferral");

                entity.Property(e => e.PlanYtdEmployeeRoth).HasColumnName("Plan_YTD_Employee_Roth");

                entity.Property(e => e.PlanYtdEmployerMatch).HasColumnName("Plan_YTD_Employer_Match");

                entity.Property(e => e.PlanYtdExcludedEarnings).HasColumnName("Plan_YTD_Excluded_Earnings");

                entity.Property(e => e.PlanYtdHours).HasColumnName("Plan_YTD_Hours");

                entity.Property(e => e.PlanYtdLoanNumber).HasColumnName("Plan_YTD_Loan_Number");

                entity.Property(e => e.PlanYtdLoanPayments).HasColumnName("Plan_YTD_Loan_Payments");

                entity.Property(e => e.PlanYtdMoneyPurchase).HasColumnName("Plan_YTD_Money_Purchase");

                entity.Property(e => e.PlanYtdProfitSharing).HasColumnName("Plan_YTD_Profit_Sharing");

                entity.Property(e => e.PlanYtdQualifiedMatchingContribution).HasColumnName("Plan_YTD_Qualified_Matching_Contribution");

                entity.Property(e => e.PlanYtdQualifiedNonElectiveContribution).HasColumnName("Plan_YTD_Qualified_Non_Elective_Contribution");

                entity.Property(e => e.PlanYtdRollover).HasColumnName("Plan_YTD_Rollover");

                entity.Property(e => e.PlanYtdRolloverRoth).HasColumnName("Plan_YTD_Rollover_Roth");

                entity.Property(e => e.PlanYtdSafeHarborMatch).HasColumnName("Plan_YTD_Safe_Harbor_Match");

                entity.Property(e => e.PlanYtdSafeHarborNonElective).HasColumnName("Plan_YTD_Safe_Harbor_Non_Elective");

                entity.Property(e => e.PlanYtdSection125)
                    .HasColumnName("Plan_YTD_Section_125")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitSharing).HasColumnName("Profit_Sharing");

                entity.Property(e => e.QualifiedMatchingContribution).HasColumnName("Qualified_Matching_Contribution");

                entity.Property(e => e.QualifiedNonElectiveContribution).HasColumnName("Qualified_Non_Elective_Contribution");

                entity.Property(e => e.RecipientVendorPlanId).HasColumnName("Recipient_Vendor_Plan_ID");

                entity.Property(e => e.RecipientVendorSubPlanId).HasColumnName("Recipient_Vendor_Sub_Plan_ID");

                entity.Property(e => e.RehireDate)
                    .HasColumnName("Rehire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RolloverRoth).HasColumnName("Rollover_Roth");

                entity.Property(e => e.SafeHarborMatch).HasColumnName("Safe_Harbor_Match");

                entity.Property(e => e.SafeHarborNonElective).HasColumnName("Safe_Harbor_Non_Elective");

                entity.Property(e => e.Section125)
                    .HasColumnName("Section_125")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.StagingContributionDataId).HasColumnName("Staging_Contribution_Data_ID");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate)
                    .HasColumnName("Termination_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfAccount403b)
                    .HasColumnName("Type_of_Account_403b")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnionStatus)
                    .HasColumnName("Union_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YtdGrossEarnings).HasColumnName("YTD_Gross_Earnings");
            });

            modelBuilder.Entity<TblLandingContributionData>(entity =>
            {
                entity.HasKey(e => e.LandingContributionDataId);

                entity.ToTable("tbl_Landing_Contribution_Data");

                entity.Property(e => e.LandingContributionDataId)
                    .HasColumnName("Landing_Contribution_Data_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("Address_1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address_2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustedDateOfHire)
                    .HasColumnName("Adjusted_Date_of_Hire")
                    .HasColumnType("date");

                entity.Property(e => e.AdjustedSeniorityDate)
                    .HasColumnName("Adjusted_Seniority_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Attribute)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("Birth_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyOrDivisionCode)
                    .HasColumnName("Company_Or_Division_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceAmount1).HasColumnName("Contribution_Source_Amount_1");

                entity.Property(e => e.ContributionSourceAmount2).HasColumnName("Contribution_Source_Amount_2");

                entity.Property(e => e.ContributionSourceAmount3).HasColumnName("Contribution_Source_Amount_3");

                entity.Property(e => e.ContributionSourceAmount4).HasColumnName("Contribution_Source_Amount_4");

                entity.Property(e => e.ContributionSourceAmount5).HasColumnName("Contribution_Source_Amount_5");

                entity.Property(e => e.ContributionSourceAmount6).HasColumnName("Contribution_Source_Amount_6");

                entity.Property(e => e.ContributionSourceAmount7).HasColumnName("Contribution_Source_Amount_7");

                entity.Property(e => e.ContributionSourceAmount8).HasColumnName("Contribution_Source_Amount_8");

                entity.Property(e => e.ContributionSourceCode1)
                    .HasColumnName("Contribution_Source_Code_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode2)
                    .HasColumnName("Contribution_Source_Code_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode3)
                    .HasColumnName("Contribution_Source_Code_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode4)
                    .HasColumnName("Contribution_Source_Code_4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode5)
                    .HasColumnName("Contribution_Source_Code_5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode6)
                    .HasColumnName("Contribution_Source_Code_6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode7)
                    .HasColumnName("Contribution_Source_Code_7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode8)
                    .HasColumnName("Contribution_Source_Code_8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter1Code)
                    .HasColumnName("Cost_Center_1_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter2Code)
                    .HasColumnName("Cost_Center_2_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter3Code)
                    .HasColumnName("Cost_Center_3_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeAfterTax).HasColumnName("Employee_After_Tax");

                entity.Property(e => e.EmployeeDeferral).HasColumnName("Employee_Deferral");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeRoth).HasColumnName("Employee_Roth");

                entity.Property(e => e.EmployeeStatus)
                    .HasColumnName("Employee_Status")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerEin).HasColumnName("Employer_EIN");

                entity.Property(e => e.EmployerMatch).HasColumnName("Employer_Match");

                entity.Property(e => e.EmployerName)
                    .HasColumnName("Employer_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerPlanId).HasColumnName("Employer_Plan_ID");

                entity.Property(e => e.EmployerSubPlanId).HasColumnName("Employer_Sub_Plan_ID");

                entity.Property(e => e.ExcludedEarnings).HasColumnName("Excluded_Earnings");

                entity.Property(e => e.FileReceivedId).HasColumnName("File_received_ID");

                entity.Property(e => e.FinalContributionIndicator)
                    .HasColumnName("Final_Contribution_Indicator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn1)
                    .HasColumnName("Footer_Column_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn10)
                    .HasColumnName("Footer_Column_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn2)
                    .HasColumnName("Footer_Column_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn3)
                    .HasColumnName("Footer_Column_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn4)
                    .HasColumnName("Footer_Column_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn5)
                    .HasColumnName("Footer_Column_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn6)
                    .HasColumnName("Footer_Column_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn7)
                    .HasColumnName("Footer_Column_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn8)
                    .HasColumnName("Footer_Column_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn9)
                    .HasColumnName("Footer_Column_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossEarnings).HasColumnName("Gross_Earnings");

                entity.Property(e => e.HeaderColumn1)
                    .HasColumnName("Header_Column_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn10)
                    .HasColumnName("Header_Column_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn2)
                    .HasColumnName("Header_Column_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn3)
                    .HasColumnName("Header_Column_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn4)
                    .HasColumnName("Header_Column_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn5)
                    .HasColumnName("Header_Column_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn6)
                    .HasColumnName("Header_Column_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn7)
                    .HasColumnName("Header_Column_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn8)
                    .HasColumnName("Header_Column_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn9)
                    .HasColumnName("Header_Column_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasColumnName("Hire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HrAreaOrLocationCode)
                    .HasColumnName("HR_Area_Or_Location_Code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrSubArea)
                    .HasColumnName("HR_Sub_Area")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InboundFileSetupId).HasColumnName("Inbound_File_Setup_ID");

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveOfAbsenceBeginDate)
                    .HasColumnName("Leave_Of_Absence_Begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeaveOfAbsenceEndDate)
                    .HasColumnName("Leave_Of_Absence_End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoanAdditionalPrincipalPayments).HasColumnName("Loan_Additional_Principal_Payments");

                entity.Property(e => e.LoanNumber).HasColumnName("Loan_Number");

                entity.Property(e => e.LoanNumber1).HasColumnName("Loan_Number_1");

                entity.Property(e => e.LoanNumber2).HasColumnName("Loan_Number_2");

                entity.Property(e => e.LoanNumber3).HasColumnName("Loan_Number_3");

                entity.Property(e => e.LoanNumber5).HasColumnName("Loan_Number_5");

                entity.Property(e => e.LoanPayments).HasColumnName("Loan_Payments");

                entity.Property(e => e.LoanRepaymentAmount1).HasColumnName("Loan_Repayment_Amount_1");

                entity.Property(e => e.LoanRepaymentAmount4).HasColumnName("Loan_Repayment_Amount_4");

                entity.Property(e => e.LoanRepaymentAmount5).HasColumnName("Loan_Repayment_Amount_5");

                entity.Property(e => e.LoanRepaymentAmout2).HasColumnName("Loan_Repayment_Amout_2");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("Marital_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("Middle_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoneyPurchase).HasColumnName("Money_Purchase");

                entity.Property(e => e.OriginatingVendorId).HasColumnName("Originating_Vendor_ID");

                entity.Property(e => e.OriginatingVendorSubPlanId).HasColumnName("Originating_Vendor_Sub_Plan_ID");

                entity.Property(e => e.PayFrequency)
                    .HasColumnName("Pay_Frequency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodHours).HasColumnName("Pay_Period_Hours");

                entity.Property(e => e.PayType)
                    .HasColumnName("Pay_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollBeginDate)
                    .HasColumnName("Payroll_Begin_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PayrollEndDate)
                    .HasColumnName("Payroll_End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PayrollMode)
                    .HasColumnName("Payroll_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanEarnings).HasColumnName("Plan_Earnings");

                entity.Property(e => e.PlanId).HasColumnName("Plan_ID");

                entity.Property(e => e.PlanYtdEarnings).HasColumnName("Plan_YTD_Earnings");

                entity.Property(e => e.PlanYtdEmployeeAfterTax).HasColumnName("Plan_YTD_Employee_After_Tax");

                entity.Property(e => e.PlanYtdEmployeeDeferral).HasColumnName("Plan_YTD_Employee_Deferral");

                entity.Property(e => e.PlanYtdEmployeeRoth).HasColumnName("Plan_YTD_Employee_Roth");

                entity.Property(e => e.PlanYtdEmployerMatch).HasColumnName("Plan_YTD_Employer_Match");

                entity.Property(e => e.PlanYtdExcludedEarnings).HasColumnName("Plan_YTD_Excluded_Earnings");

                entity.Property(e => e.PlanYtdHours).HasColumnName("Plan_YTD_Hours");

                entity.Property(e => e.PlanYtdLoanNumber).HasColumnName("Plan_YTD_Loan_Number");

                entity.Property(e => e.PlanYtdLoanPayments).HasColumnName("Plan_YTD_Loan_Payments");

                entity.Property(e => e.PlanYtdMoneyPurchase).HasColumnName("Plan_YTD_Money_Purchase");

                entity.Property(e => e.PlanYtdProfitSharing).HasColumnName("Plan_YTD_Profit_Sharing");

                entity.Property(e => e.PlanYtdQualifiedMatchingContribution).HasColumnName("Plan_YTD_Qualified_Matching_Contribution");

                entity.Property(e => e.PlanYtdQualifiedNonElectiveContribution).HasColumnName("Plan_YTD_Qualified_Non_Elective_Contribution");

                entity.Property(e => e.PlanYtdRollover).HasColumnName("Plan_YTD_Rollover");

                entity.Property(e => e.PlanYtdRolloverRoth).HasColumnName("Plan_YTD_Rollover_Roth");

                entity.Property(e => e.PlanYtdSafeHarborMatch).HasColumnName("Plan_YTD_Safe_Harbor_Match");

                entity.Property(e => e.PlanYtdSafeHarborNonElective).HasColumnName("Plan_YTD_Safe_Harbor_Non_Elective");

                entity.Property(e => e.PlanYtdSection125)
                    .HasColumnName("Plan_YTD_Section_125")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitSharing).HasColumnName("Profit_Sharing");

                entity.Property(e => e.QualifiedMatchingContribution).HasColumnName("Qualified_Matching_Contribution");

                entity.Property(e => e.QualifiedNonElectiveContribution).HasColumnName("Qualified_Non_Elective_Contribution");

                entity.Property(e => e.RecipientVendorPlanId).HasColumnName("Recipient_Vendor_Plan_ID");

                entity.Property(e => e.RecipientVendorSubPlanId).HasColumnName("Recipient_Vendor_Sub_Plan_ID");

                entity.Property(e => e.RehireDate)
                    .HasColumnName("Rehire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RolloverRoth).HasColumnName("Rollover_Roth");

                entity.Property(e => e.SafeHarborMatch).HasColumnName("Safe_Harbor_Match");

                entity.Property(e => e.SafeHarborNonElective).HasColumnName("Safe_Harbor_Non_Elective");

                entity.Property(e => e.Section125)
                    .HasColumnName("Section_125")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate)
                    .HasColumnName("Termination_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfAccount403b)
                    .HasColumnName("Type_of_Account_403b")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnionStatus)
                    .HasColumnName("Union_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YtdGrossEarnings).HasColumnName("YTD_Gross_Earnings");
            });

            modelBuilder.Entity<TblStagingContributionData>(entity =>
            {
                entity.HasKey(e => e.StagingContributionDataId);

                entity.ToTable("tbl_Staging_Contribution_Data");

                entity.Property(e => e.StagingContributionDataId)
                    .HasColumnName("Staging_Contribution_Data_ID")
                    .ValueGeneratedNever();

                entity.Property(e => e.Address1)
                    .HasColumnName("Address_1")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.Address2)
                    .HasColumnName("Address_2")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.AdjustedDateOfHire)
                    .HasColumnName("Adjusted_Date_of_Hire")
                    .HasColumnType("date");

                entity.Property(e => e.AdjustedSeniorityDate)
                    .HasColumnName("Adjusted_Seniority_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Attribute)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BirthDate)
                    .HasColumnName("Birth_Date")
                    .HasColumnType("date");

                entity.Property(e => e.CheckDate)
                    .HasColumnName("Check_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.City)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyOrDivisionCode)
                    .HasColumnName("Company_Or_Division_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceAmount1).HasColumnName("Contribution_Source_Amount_1");

                entity.Property(e => e.ContributionSourceAmount2).HasColumnName("Contribution_Source_Amount_2");

                entity.Property(e => e.ContributionSourceAmount3).HasColumnName("Contribution_Source_Amount_3");

                entity.Property(e => e.ContributionSourceAmount4).HasColumnName("Contribution_Source_Amount_4");

                entity.Property(e => e.ContributionSourceAmount5).HasColumnName("Contribution_Source_Amount_5");

                entity.Property(e => e.ContributionSourceAmount6).HasColumnName("Contribution_Source_Amount_6");

                entity.Property(e => e.ContributionSourceAmount7).HasColumnName("Contribution_Source_Amount_7");

                entity.Property(e => e.ContributionSourceAmount8).HasColumnName("Contribution_Source_Amount_8");

                entity.Property(e => e.ContributionSourceCode1)
                    .HasColumnName("Contribution_Source_Code_1")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode2)
                    .HasColumnName("Contribution_Source_Code_2")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode3)
                    .HasColumnName("Contribution_Source_Code_3")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode4)
                    .HasColumnName("Contribution_Source_Code_4")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode5)
                    .HasColumnName("Contribution_Source_Code_5")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode6)
                    .HasColumnName("Contribution_Source_Code_6")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode7)
                    .HasColumnName("Contribution_Source_Code_7")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ContributionSourceCode8)
                    .HasColumnName("Contribution_Source_Code_8")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter1Code)
                    .HasColumnName("Cost_Center_1_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter2Code)
                    .HasColumnName("Cost_Center_2_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CostCenter3Code)
                    .HasColumnName("Cost_Center_3_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Detail)
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Email)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeAfterTax).HasColumnName("Employee_After_Tax");

                entity.Property(e => e.EmployeeDeferral).HasColumnName("Employee_Deferral");

                entity.Property(e => e.EmployeeId)
                    .HasColumnName("Employee_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeRoth).HasColumnName("Employee_Roth");

                entity.Property(e => e.EmployeeStatus)
                    .HasColumnName("Employee_Status")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerEin).HasColumnName("Employer_EIN");

                entity.Property(e => e.EmployerMatch).HasColumnName("Employer_Match");

                entity.Property(e => e.EmployerName)
                    .HasColumnName("Employer_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.EmployerPlanId).HasColumnName("Employer_Plan_ID");

                entity.Property(e => e.EmployerSubPlanId).HasColumnName("Employer_Sub_Plan_ID");

                entity.Property(e => e.ExcludedEarnings).HasColumnName("Excluded_Earnings");

                entity.Property(e => e.FileReceivedId).HasColumnName("File_received_ID");

                entity.Property(e => e.FinalContributionIndicator)
                    .HasColumnName("Final_Contribution_Indicator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FirstName)
                    .HasColumnName("First_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn1)
                    .HasColumnName("Footer_Column_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn10)
                    .HasColumnName("Footer_Column_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn2)
                    .HasColumnName("Footer_Column_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn3)
                    .HasColumnName("Footer_Column_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn4)
                    .HasColumnName("Footer_Column_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn5)
                    .HasColumnName("Footer_Column_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn6)
                    .HasColumnName("Footer_Column_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn7)
                    .HasColumnName("Footer_Column_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn8)
                    .HasColumnName("Footer_Column_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.FooterColumn9)
                    .HasColumnName("Footer_Column_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.GrossEarnings).HasColumnName("Gross_Earnings");

                entity.Property(e => e.HeaderColumn1)
                    .HasColumnName("Header_Column_1")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn10)
                    .HasColumnName("Header_Column_10")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn2)
                    .HasColumnName("Header_Column_2")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn3)
                    .HasColumnName("Header_Column_3")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn4)
                    .HasColumnName("Header_Column_4")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn5)
                    .HasColumnName("Header_Column_5")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn6)
                    .HasColumnName("Header_Column_6")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn7)
                    .HasColumnName("Header_Column_7")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn8)
                    .HasColumnName("Header_Column_8")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumn9)
                    .HasColumnName("Header_Column_9")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HireDate)
                    .HasColumnName("Hire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.HrAreaOrLocationCode)
                    .HasColumnName("HR_Area_Or_Location_Code")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HrSubArea)
                    .HasColumnName("HR_Sub_Area")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.InboundFileSetupId).HasColumnName("Inbound_File_Setup_ID");

                entity.Property(e => e.LastName)
                    .HasColumnName("Last_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeaveOfAbsenceBeginDate)
                    .HasColumnName("Leave_Of_Absence_Begin_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LeaveOfAbsenceEndDate)
                    .HasColumnName("Leave_Of_Absence_End_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.LoanAdditionalPrincipalPayments).HasColumnName("Loan_Additional_Principal_Payments");

                entity.Property(e => e.LoanNumber).HasColumnName("Loan_Number");

                entity.Property(e => e.LoanNumber1).HasColumnName("Loan_Number_1");

                entity.Property(e => e.LoanNumber2).HasColumnName("Loan_Number_2");

                entity.Property(e => e.LoanNumber3).HasColumnName("Loan_Number_3");

                entity.Property(e => e.LoanNumber5).HasColumnName("Loan_Number_5");

                entity.Property(e => e.LoanPayments).HasColumnName("Loan_Payments");

                entity.Property(e => e.LoanRepaymentAmount1).HasColumnName("Loan_Repayment_Amount_1");

                entity.Property(e => e.LoanRepaymentAmount4).HasColumnName("Loan_Repayment_Amount_4");

                entity.Property(e => e.LoanRepaymentAmount5).HasColumnName("Loan_Repayment_Amount_5");

                entity.Property(e => e.LoanRepaymentAmout2).HasColumnName("Loan_Repayment_Amout_2");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("Marital_Status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.MiddleName)
                    .HasColumnName("Middle_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MoneyPurchase).HasColumnName("Money_Purchase");

                entity.Property(e => e.OriginatingVendorId).HasColumnName("Originating_Vendor_ID");

                entity.Property(e => e.OriginatingVendorSubPlanId).HasColumnName("Originating_Vendor_Sub_Plan_ID");

                entity.Property(e => e.PayFrequency)
                    .HasColumnName("Pay_Frequency")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayPeriodHours).HasColumnName("Pay_Period_Hours");

                entity.Property(e => e.PayType)
                    .HasColumnName("Pay_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollBeginDate)
                    .HasColumnName("Payroll_Begin_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PayrollEndDate)
                    .HasColumnName("Payroll_End_Date")
                    .HasColumnType("date");

                entity.Property(e => e.PayrollMode)
                    .HasColumnName("Payroll_Mode")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasColumnName("Phone_Number")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PlanEarnings).HasColumnName("Plan_Earnings");

                entity.Property(e => e.PlanId).HasColumnName("Plan_ID");

                entity.Property(e => e.PlanYtdEarnings).HasColumnName("Plan_YTD_Earnings");

                entity.Property(e => e.PlanYtdEmployeeAfterTax).HasColumnName("Plan_YTD_Employee_After_Tax");

                entity.Property(e => e.PlanYtdEmployeeDeferral).HasColumnName("Plan_YTD_Employee_Deferral");

                entity.Property(e => e.PlanYtdEmployeeRoth).HasColumnName("Plan_YTD_Employee_Roth");

                entity.Property(e => e.PlanYtdEmployerMatch).HasColumnName("Plan_YTD_Employer_Match");

                entity.Property(e => e.PlanYtdExcludedEarnings).HasColumnName("Plan_YTD_Excluded_Earnings");

                entity.Property(e => e.PlanYtdHours).HasColumnName("Plan_YTD_Hours");

                entity.Property(e => e.PlanYtdLoanNumber).HasColumnName("Plan_YTD_Loan_Number");

                entity.Property(e => e.PlanYtdLoanPayments).HasColumnName("Plan_YTD_Loan_Payments");

                entity.Property(e => e.PlanYtdMoneyPurchase).HasColumnName("Plan_YTD_Money_Purchase");

                entity.Property(e => e.PlanYtdProfitSharing).HasColumnName("Plan_YTD_Profit_Sharing");

                entity.Property(e => e.PlanYtdQualifiedMatchingContribution).HasColumnName("Plan_YTD_Qualified_Matching_Contribution");

                entity.Property(e => e.PlanYtdQualifiedNonElectiveContribution).HasColumnName("Plan_YTD_Qualified_Non_Elective_Contribution");

                entity.Property(e => e.PlanYtdRollover).HasColumnName("Plan_YTD_Rollover");

                entity.Property(e => e.PlanYtdRolloverRoth).HasColumnName("Plan_YTD_Rollover_Roth");

                entity.Property(e => e.PlanYtdSafeHarborMatch).HasColumnName("Plan_YTD_Safe_Harbor_Match");

                entity.Property(e => e.PlanYtdSafeHarborNonElective).HasColumnName("Plan_YTD_Safe_Harbor_Non_Elective");

                entity.Property(e => e.PlanYtdSection125)
                    .HasColumnName("Plan_YTD_Section_125")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ProfitSharing).HasColumnName("Profit_Sharing");

                entity.Property(e => e.QualifiedMatchingContribution).HasColumnName("Qualified_Matching_Contribution");

                entity.Property(e => e.QualifiedNonElectiveContribution).HasColumnName("Qualified_Non_Elective_Contribution");

                entity.Property(e => e.RecipientVendorPlanId).HasColumnName("Recipient_Vendor_Plan_ID");

                entity.Property(e => e.RecipientVendorSubPlanId).HasColumnName("Recipient_Vendor_Sub_Plan_ID");

                entity.Property(e => e.RehireDate)
                    .HasColumnName("Rehire_Date")
                    .HasColumnType("date");

                entity.Property(e => e.RolloverRoth).HasColumnName("Rollover_Roth");

                entity.Property(e => e.SafeHarborMatch).HasColumnName("Safe_Harbor_Match");

                entity.Property(e => e.SafeHarborNonElective).HasColumnName("Safe_Harbor_Non_Elective");

                entity.Property(e => e.Section125)
                    .HasColumnName("Section_125")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Ssn).HasColumnName("SSN");

                entity.Property(e => e.State)
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.TerminationDate)
                    .HasColumnName("Termination_Date")
                    .HasColumnType("date");

                entity.Property(e => e.Title)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TypeOfAccount403b)
                    .HasColumnName("Type_of_Account_403b")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UnionStatus)
                    .HasColumnName("Union_Status")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.YtdGrossEarnings).HasColumnName("YTD_Gross_Earnings");
            });
        }
    }
}
