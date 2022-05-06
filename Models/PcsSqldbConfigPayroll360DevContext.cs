using System;
using System.Collections.Generic;
using System.Data.SqlClient;
//using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ExternalFTPInjestion.Models
{
    public partial class pcssqldbconfigpayroll360devContext : DbContext
    {
        

        public pcssqldbconfigpayroll360devContext()
        {
        }

        public pcssqldbconfigpayroll360devContext(DbContextOptions<pcssqldbconfigpayroll360devContext> options)
            : base(options)
        {
            
        }

        public virtual DbSet<TblControlTable> TblControlTable { get; set; }
        public virtual DbSet<TblDestinationSetup> TblDestinationSetup { get; set; }
        public virtual DbSet<TblErrorMaster> TblErrorMaster { get; set; }
        public virtual DbSet<TblErrorMessageSetup> TblErrorMessageSetup { get; set; }
        public virtual DbSet<TblFileReceived> TblFileReceived { get; set; }
        public virtual DbSet<TblFrequency> TblFrequency { get; set; }
        public virtual DbSet<TblHeaderMetadataTable> TblHeaderMetadataTable { get; set; }
        public virtual DbSet<TblHeaderReceived> TblHeaderReceived { get; set; }
        public virtual DbSet<TblInboundSourceSetup> TblInboundSourceSetup { get; set; }
        public virtual DbSet<TblLookup> TblLookup { get; set; }
        public virtual DbSet<TblMasterMetadataMapping> TblMasterMetadataMapping { get; set; }
        public virtual DbSet<TblMetadataMapping> TblMetadataMapping { get; set; }
        public virtual DbSet<TblPayrollProvider> TblPayrollProvider { get; set; }
        public virtual DbSet<TblTriggerWebhook> TblTriggerWebhook { get; set; }
        public virtual DbSet<TblWebhookMsgHandled> TblWebhookMsgHandled { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
               // optionsBuilder.UseSqlServer("Server=tcp:pcs-sql-payroll360-dev.database.windows.net;Database=pcs-sqldb-config-payroll360-dev;Trusted_Connection=False;Encrypt=True;User=serveradmin;password=NcPtpjfp7jsfWUzE");

                optionsBuilder.UseSqlServer("Server=tcp:pcs-sql-payroll360-qa.database.windows.net;Database=config-qa;Trusted_Connection=False;Encrypt=True;User=serveradmin;password=Welcome@123");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<TblControlTable>(entity =>
            {
                entity.HasKey(e => e.ControlTableId);

                entity.ToTable("tbl_Control_Table");

                entity.Property(e => e.ControlTableId).HasColumnName("Control_Table_ID");

                entity.Property(e => e.AcquisitionControlAmount).HasColumnName("Acquisition_control_Amount");

                entity.Property(e => e.AcquisitionErrorRowCount).HasColumnName("Acquisition_Error_Row_Count");

                entity.Property(e => e.AcquisitionRowCount).HasColumnName("Acquisition_Row_Count");

                entity.Property(e => e.CleansingControlAmount).HasColumnName("Cleansing_Control_Amount");

                entity.Property(e => e.CleansingErrorRowCount).HasColumnName("Cleansing_Error_Row_Count");

                entity.Property(e => e.CleansingRowCount).HasColumnName("Cleansing_Row_Count");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileFooter1ControlAmount).HasColumnName("File_footer1_Control_Amount");

                entity.Property(e => e.FileFooter1RowCount).HasColumnName("File_footer1_row_count");

                entity.Property(e => e.FileFooter2ControlAmount).HasColumnName("File_footer2_Control_Amount");

                entity.Property(e => e.FileFooter2RowCount).HasColumnName("File_footer2_row_count");

                entity.Property(e => e.FileFooter3ControlAmount).HasColumnName("File_footer3_Control_Amount");

                entity.Property(e => e.FileFooter3RowCount).HasColumnName("File_footer3_row_count");

                entity.Property(e => e.FileHeader1ControlAmount).HasColumnName("File_header1_Control_Amount");

                entity.Property(e => e.FileHeader1RowCount).HasColumnName("File_header1_row_count");

                entity.Property(e => e.FileHeader2ControlAmount).HasColumnName("File_header2_Control_Amount");

                entity.Property(e => e.FileHeader2RowCount).HasColumnName("File_header2_row_count");

                entity.Property(e => e.FileHeader3ControlAmount).HasColumnName("File_header3_Control_Amount");

                entity.Property(e => e.FileHeader3RowCount).HasColumnName("File_header3_row_count");

                entity.Property(e => e.FileReceivedId).HasColumnName("File_Received_ID");

                entity.Property(e => e.FileRowCount).HasColumnName("File_Row_Count");

                entity.Property(e => e.Status)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblDestinationSetup>(entity =>
            {
                entity.HasKey(e => e.DestinationSetupId);

                entity.ToTable("tbl_Destination_Setup");

                entity.Property(e => e.DestinationSetupId).HasColumnName("Destination_Setup_ID");

                entity.Property(e => e.ConnectionPort)
                    .HasColumnName("connection_port")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestinationFolderPath)
                    .HasColumnName("destination_folder_path")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationUrl)
                    .HasColumnName("Destination_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorFolderPath)
                    .HasColumnName("Error_Folder_Path")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblErrorMaster>(entity =>
            {
                entity.HasKey(e => e.ErrorMessageSetupId);

                entity.ToTable("tbl_Error_Master");

                entity.Property(e => e.ErrorMessageSetupId).HasColumnName("Error_Message_Setup_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorCategory)
                    .HasColumnName("Error_Category")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorCode)
                    .HasColumnName("Error_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorMsg)
                    .HasColumnName("Error_msg")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorTypeId).HasColumnName("Error_Type_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblErrorMessageSetup>(entity =>
            {
                entity.HasKey(e => e.ErrorMessageSetupId);

                entity.ToTable("tbl_Error_Message_Setup");

                entity.Property(e => e.ErrorMessageSetupId).HasColumnName("Error_Message_Setup_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorDate)
                    .HasColumnName("Error_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ErrorId).HasColumnName("Error_ID");

                entity.Property(e => e.ErrorName)
                    .HasColumnName("Error_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ErrorType)
                    .HasColumnName("Error_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblFileReceived>(entity =>
            {
                entity.HasKey(e => e.FileReceivedId);

                entity.ToTable("tbl_File_Received");

                entity.Property(e => e.FileReceivedId).HasColumnName("File_Received_ID");

                entity.Property(e => e.ActualFile)
                    .HasColumnName("Actual_File")
                    .HasMaxLength(1000)
                    .IsUnicode(false);

                entity.Property(e => e.AsOfDate)
                    .HasColumnName("As_OF_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileName)
                    .HasColumnName("File_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeLkId).HasColumnName("File_Type_LK_ID");

                entity.Property(e => e.FromEmailId)
                    .HasColumnName("From_Email_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InboundSourceSetupId).HasColumnName("Inbound_Source_Setup_ID");

                entity.Property(e => e.LoadedBy)
                    .HasColumnName("Loaded_By")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.ReceivedDateAndTime)
                    .HasColumnName("Received_Date_And_Time")
                    .HasColumnType("datetime");

                entity.Property(e => e.Status)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FileTypeLk)
                    .WithMany(p => p.TblFileReceived)
                    .HasForeignKey(d => d.FileTypeLkId)
                    .HasConstraintName("FK__tbl_File___File___395884C4");
            });

            modelBuilder.Entity<TblFrequency>(entity =>
            {
                entity.HasKey(e => e.FrequencyId);

                entity.ToTable("tbl_Frequency");

                entity.Property(e => e.FrequencyId).HasColumnName("Frequency_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FrequencyDuration)
                    .HasColumnName("Frequency_Duration")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblHeaderMetadataTable>(entity =>
            {
                entity.HasKey(e => e.HeaderMetadataTableId);

                entity.ToTable("tbl_Header_Metadata_Table");

                entity.Property(e => e.HeaderMetadataTableId).HasColumnName("Header_Metadata_Table_ID");

                entity.Property(e => e.ColumnFormat)
                    .HasColumnName("Column_Format")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.HeaderColumnMeaning)
                    .HasColumnName("Header_Column_Meaning")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderColumnName)
                    .HasColumnName("Header_Column_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.InboundSourceSetupId).HasColumnName("Inbound_Source_Setup_ID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                //entity.HasOne(d => d.InboundSourceSetup)
                //    .WithMany(p => p.TblHeaderMetadataTable)
                //    .HasForeignKey(d => d.InboundSourceSetupId)
                //    .HasConstraintName("FK__tbl_Heade__Inbou__76619304");
            });

            modelBuilder.Entity<TblHeaderReceived>(entity =>
            {
                entity.HasKey(e => e.HeaderReceivedId);

                entity.ToTable("tbl_Header_Received");

                entity.Property(e => e.HeaderReceivedId).HasColumnName("Header_Received_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.FileReceivedId).HasColumnName("File_Received_ID");

                entity.Property(e => e.HeaderMetadataTableId).HasColumnName("Header_Metadata_Table_ID");

                entity.Property(e => e.HeaderName)
                    .HasColumnName("Header_Name")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.HeaderType)
                    .HasColumnName("Header_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InboundSourceSetupId).HasColumnName("Inbound_Source_Setup_ID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.FileReceived)
                    .WithMany(p => p.TblHeaderReceived)
                    .HasForeignKey(d => d.FileReceivedId)
                    .HasConstraintName("FK__tbl_Heade__File___7849DB76");

                entity.HasOne(d => d.HeaderMetadataTable)
                    .WithMany(p => p.TblHeaderReceived)
                    .HasForeignKey(d => d.HeaderMetadataTableId)
                    .HasConstraintName("FK__tbl_Heade__Heade__6FB49575");

                //entity.HasOne(d => d.InboundSourceSetup)
                //    .WithMany(p => p.TblHeaderReceived)
                //    .HasForeignKey(d => d.InboundSourceSetupId)
                //    .HasConstraintName("FK__tbl_Heade__Inbou__7755B73D");
            });

            modelBuilder.Entity<TblInboundSourceSetup>(entity =>
            {
                entity.HasKey(e => e.InboundSourceSetupId);

                entity.ToTable("tbl_Inbound_Source_Setup");

                entity.Property(e => e.InboundSourceSetupId).HasColumnName("Inbound_Source_SetupID");

                entity.Property(e => e.ApiName)
                    .HasColumnName("API_Name")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.ConnectionPort)
                    .HasColumnName("Connection_Port")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DataHeaderRow).HasColumnName("Data_Header_Row");

                entity.Property(e => e.DataStartRow).HasColumnName("Data_Start_Row");

                entity.Property(e => e.Delimiter)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationSetupId).HasColumnName("Destination_Setup_ID");

                entity.Property(e => e.FileNamePattern)
                    .HasColumnName("File_Name_Pattern")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.FileTypeLkId).HasColumnName("File_Type_LK_ID");

                entity.Property(e => e.FilenameStructureParts).HasColumnName("Filename_Structure_Parts");

                entity.Property(e => e.FooterStartRow).HasColumnName("Footer_Start_Row");

                entity.Property(e => e.FrequencyId).HasColumnName("Frequency_ID");

                entity.Property(e => e.FromEmailId)
                    .HasColumnName("From_Email_ID")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.GetOrPut)
                    .HasColumnName("Get_Or_Put")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.HierarchialData)
                    .HasColumnName("Hierarchial_Data")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive).HasColumnName("Is_Active");

                entity.Property(e => e.IsColumnFooterHeaderAvailable)
                    .HasColumnName("Is_Column_Footer_Header_Available")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsColumnHeaderAvailable)
                    .HasColumnName("Is_Column_Header_Available")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsFooterRowAvailable)
                    .HasColumnName("Is_Footer_Row_Available")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.IsHeaderRowAvailable)
                    .HasColumnName("Is_Header_Row_Available")
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.Password)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollProviderId).HasColumnName("Payroll_Provider_ID");

                entity.Property(e => e.PayrollProviderTypeLkId).HasColumnName("Payroll_Provider_Type_LK_ID");

                entity.Property(e => e.SheetName)
                    .HasColumnName("Sheet_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceFolderPath)
                    .HasColumnName("Source_Folder_Path")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.SourceUrl)
                    .HasColumnName("Source_URL")
                    .HasMaxLength(500)
                    .IsUnicode(false);

                entity.Property(e => e.StorageFolderName)
                    .HasColumnName("Storage_Folder_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.TypeOfIngestionLkId).HasColumnName("Type_Of_Ingestion_LK_ID");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.UserId)
                    .HasColumnName("User_ID")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.DestinationSetup)
                    .WithMany(p => p.TblInboundSourceSetup)
                    .HasForeignKey(d => d.DestinationSetupId)
                    .HasConstraintName("FK__tbl_Inbou__Desti__31B762FC");

                entity.HasOne(d => d.FileTypeLk)
                    .WithMany(p => p.TblInboundSourceSetupFileTypeLk)
                    .HasForeignKey(d => d.FileTypeLkId)
                    .HasConstraintName("FK__tbl_Inbou__File___32AB8735");

                entity.HasOne(d => d.PayrollProvider)
                    .WithMany(p => p.TblInboundSourceSetup)
                    .HasForeignKey(d => d.PayrollProviderId)
                    .HasConstraintName("FK__tbl_Inbou__Payro__339FAB6E");

                entity.HasOne(d => d.PayrollProviderTypeLk)
                    .WithMany(p => p.TblInboundSourceSetupPayrollProviderTypeLk)
                    .HasForeignKey(d => d.PayrollProviderTypeLkId)
                    .HasConstraintName("FK__tbl_Inbou__Payro__30C33EC3");

                entity.HasOne(d => d.TypeOfIngestionLk)
                    .WithMany(p => p.TblInboundSourceSetupTypeOfIngestionLk)
                    .HasForeignKey(d => d.TypeOfIngestionLkId)
                    .HasConstraintName("FK__tbl_Inbou__Type___2FCF1A8A");
            });

            modelBuilder.Entity<TblLookup>(entity =>
            {
                entity.HasKey(e => e.LookupId);

                entity.ToTable("tbl_Lookup");

                entity.Property(e => e.LookupId).HasColumnName("Lookup_ID");

                entity.Property(e => e.Category)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('SYSTEM')");

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime")
                    .HasDefaultValueSql("(getdate())");

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.LongName)
                    .HasColumnName("Long_Name")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.LookupCode)
                    .HasColumnName("Lookup_Code")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.OrganisationId).HasColumnName("Organisation_ID");

                entity.Property(e => e.PrintLookupId).HasColumnName("Print_Lookup_ID");

                entity.Property(e => e.SetName)
                    .HasColumnName("Set_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.ShortName)
                    .HasColumnName("Short_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SortOrder).HasColumnName("Sort_Order");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.SystemYn)
                    .HasColumnName("System_YN")
                    .HasMaxLength(1)
                    .IsUnicode(false)
                    .HasDefaultValueSql("('Y')");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<TblMasterMetadataMapping>(entity =>
            {
                entity.HasKey(e => e.MasterMetadataMappingId);

                entity.ToTable("tbl_Master_Metadata_Mapping");

                entity.Property(e => e.MasterMetadataMappingId).HasColumnName("Master_Metadata_Mapping_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.InboundSourceSetupId).HasColumnName("Inbound_Source_Setup_ID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MappingName)
                    .HasColumnName("Mapping_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                //entity.HasOne(d => d.InboundSourceSetup)
                //    .WithMany(p => p.TblMasterMetadataMapping)
                //    .HasForeignKey(d => d.InboundSourceSetupId)
                //    .HasConstraintName("FK__tbl_Maste__Inbou__3C34F16F");
            });

            modelBuilder.Entity<TblMetadataMapping>(entity =>
            {
                entity.HasKey(e => e.MetadataMappingId);

                entity.ToTable("tbl_Metadata_Mapping");

                entity.Property(e => e.MetadataMappingId).HasColumnName("Metadata_Mapping_ID");

                entity.Property(e => e.ColumnOrder).HasColumnName("Column_Order");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestinationColumnName)
                    .HasColumnName("Destination_Column_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.DestinationTableName)
                    .HasColumnName("Destination_Table_name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.Format)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.InboundSourceSetupId).HasColumnName("Inbound_Source_Setup_ID");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.MasterMetadataMappingId).HasColumnName("Master_Metadata_Mapping_ID");

                entity.Property(e => e.SourceColumnName)
                    .HasColumnName("Source_Column_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceDataType)
                    .HasColumnName("Source_Data_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SourceTableName)
                    .HasColumnName("Source_Table_Name")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.SourceType)
                    .HasColumnName("Source_Type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                //entity.HasOne(d => d.InboundSourceSetup)
                //    .WithMany(p => p.TblMetadataMapping)
                //    .HasForeignKey(d => d.InboundSourceSetupId)
                //    .HasConstraintName("FK__tbl_Metad__Inbou__40F9A68C");

                entity.HasOne(d => d.MasterMetadataMapping)
                    .WithMany(p => p.TblMetadataMapping)
                    .HasForeignKey(d => d.MasterMetadataMappingId)
                    .HasConstraintName("FK__tbl_Metad__Maste__40058253");
            });

            modelBuilder.Entity<TblPayrollProvider>(entity =>
            {
                entity.HasKey(e => e.PayrollProviderId);

                entity.ToTable("tbl_Payroll_Provider");

                entity.Property(e => e.PayrollProviderId).HasColumnName("Payroll_Provider_ID");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("Created_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("Created_Date")
                    .HasColumnType("datetime");

                entity.Property(e => e.IsActive).HasDefaultValueSql("((1))");

                entity.Property(e => e.PayrollProviderCode)
                    .HasColumnName("Payroll_Provider_Code")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollProviderName)
                    .HasColumnName("Payroll_Provider_Name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollProviderTypeLkId).HasColumnName("Payroll_Provider_Type_LK_ID");

                entity.Property(e => e.SysEndTime).HasDefaultValueSql("(CONVERT([datetime2],'9999-12-31 23:59:59.9999999'))");

                entity.Property(e => e.SysStartTime).HasDefaultValueSql("(sysutcdatetime())");

                entity.Property(e => e.UpdatedBy)
                    .HasColumnName("Updated_By")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UpdatedDate)
                    .HasColumnName("Updated_Date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.PayrollProviderTypeLk)
                    .WithMany(p => p.TblPayrollProvider)
                    .HasForeignKey(d => d.PayrollProviderTypeLkId)
                    .HasConstraintName("FK__tbl_Payro__Payro__1F98B2C1");
            });

            modelBuilder.Entity<TblTriggerWebhook>(entity =>
            {
                entity.HasKey(e => e.TriggerWebhookId);

                entity.ToTable("tblTriggerWebhook");

                entity.Property(e => e.TriggerWebhookId).HasColumnName("TriggerWebhookID");

                entity.Property(e => e.CreateDttm).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.TriggerMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDttm).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TblWebhookMsgHandled>(entity =>
            {
                entity.HasKey(e => e.MessageHandledId);

                entity.ToTable("tblWebhookMsgHandled");

                entity.Property(e => e.MessageHandledId).HasColumnName("MessageHandledID");

                entity.Property(e => e.CreateDttm).HasColumnType("datetime");

                entity.Property(e => e.CreateUserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.HandledMessage)
                    .HasMaxLength(255)
                    .IsUnicode(false);

                entity.Property(e => e.IsActive)
                    .HasMaxLength(1)
                    .IsUnicode(false);

                entity.Property(e => e.UpdateDttm).HasColumnType("datetime");

                entity.Property(e => e.UpdateUserId)
                    .HasMaxLength(255)
                    .IsUnicode(false);
            });

            modelBuilder.Query<SPInsertStatusIntoFileReceived>();
        }

        public async Task<List<SPInsertStatusIntoFileReceived>> InsertIntoFileReceived(string fileName, string fromEmailID )
        {
            // Initialization.  
            List<SPInsertStatusIntoFileReceived> lst = new List<SPInsertStatusIntoFileReceived>();

            try
            {
                
                //System.Diagnostics.Trace.TraceError("SP Execution Started");
                // Settings.  
                SqlParameter Param1 = new SqlParameter("@File_Name", fileName.ToString() ?? (object)DBNull.Value);
                SqlParameter Param2 = new SqlParameter("@From_Email_ID", fromEmailID.ToString() ?? (object)DBNull.Value);
               
                Database.ExecuteSqlCommand("SP_InsertStatusIntoFileReceived @p0, @p1", fromEmailID, fileName);
                
                //// Processing.  
                string sqlQuery = "EXEC [dbo].[SP_InsertStatusIntoFileReceived] " +
                                    "@From_Email_ID" + "," + "@File_Name";
                lst = await this.Query<SPInsertStatusIntoFileReceived>().FromSql(sqlQuery, Param2, Param1).ToListAsync();

                
                //System.Diagnostics.Trace.TraceError("SP Execution Finished");
                //string StoredProc = "exec [dbo].[SP_InsertStatusIntoFileReceived] " +
                //    "@FromEmailId = " + fromEmailID + "," +

                //    "@FileName = '" + fileName + "'";


                //return await _context.output.FromSqlRaw(StoredProc).ToListAsync();
            }
            catch (Exception ex)
            {
                throw ex;
            }

            // Info.  
            return lst;
        }

    }
}
