using System;
using Hris.Infrastructure.Database.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hris.Infrastructure.Database.Contexts
{
    public partial class HrisContext : DbContext
    {
        public HrisContext()
        {
        }

        public HrisContext(DbContextOptions<HrisContext> options)
            : base(options)
        {
            this.Database.EnsureCreated();
        }

        public virtual DbSet<AbsenceType> AbsenceType { get; set; }
        public virtual DbSet<ActionTaken> ActionTaken { get; set; }
        public virtual DbSet<Asset> Asset { get; set; }
        public virtual DbSet<Attendance> Attendance { get; set; }
        public virtual DbSet<Branch> Branch { get; set; }
        public virtual DbSet<DayType> DayType { get; set; }
        public virtual DbSet<Department> Department { get; set; }
        public virtual DbSet<Division> Division { get; set; }
        public virtual DbSet<Education> Education { get; set; }
        public virtual DbSet<Employee> Employee { get; set; }
        public virtual DbSet<EmployeeAsset> EmployeeAsset { get; set; }
        public virtual DbSet<EmployeeEducationFormal> EmployeeEducationFormal { get; set; }
        public virtual DbSet<EmployeeEducationUnformal> EmployeeEducationUnformal { get; set; }
        public virtual DbSet<EmployeeExperience> EmployeeExperience { get; set; }
        public virtual DbSet<EmployeeFamily> EmployeeFamily { get; set; }
        public virtual DbSet<EmployeeSalary> EmployeeSalary { get; set; }
        public virtual DbSet<EmployeeSkill> EmployeeSkill { get; set; }
        public virtual DbSet<EmployeeStatus> EmployeeStatus { get; set; }
        public virtual DbSet<EmployeeType> EmployeeType { get; set; }
        public virtual DbSet<Grade> Grade { get; set; }
        public virtual DbSet<LeaveRemaining> LeaveRemaining { get; set; }
        public virtual DbSet<LeavingRequest> LeavingRequest { get; set; }
        public virtual DbSet<LeavingType> LeavingType { get; set; }
        public virtual DbSet<MedicalReimbursement> MedicalReimbursement { get; set; }
        public virtual DbSet<MedicalType> MedicalType { get; set; }
        public virtual DbSet<PayrollType> PayrollType { get; set; }
        public virtual DbSet<PermitRequest> PermitRequest { get; set; }
        public virtual DbSet<Position> Position { get; set; }
        public virtual DbSet<Punishment> Punishment { get; set; }
        public virtual DbSet<TaxRate> TaxRate { get; set; }
        public virtual DbSet<TaxStatus> TaxStatus { get; set; }
        public virtual DbSet<Training> Training { get; set; }
        public virtual DbSet<TrainingType> TrainingType { get; set; }
        public virtual DbSet<TravellingExpense> TravellingExpense { get; set; }
        public virtual DbSet<TravellingType> TravellingType { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.0-rtm-35687");

            modelBuilder.Entity<AbsenceType>(entity =>
            {
                entity.ToTable("absence_type");

                entity.Property(e => e.AbsenceTypeId).HasColumnName("absence_type_id");

                entity.Property(e => e.AbsenceTypeCode)
                    .HasColumnName("absence_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AbsenceTypeName)
                    .HasColumnName("absence_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Alpha)
                    .HasColumnName("alpha")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeavingDeduction)
                    .HasColumnName("leaving_deduction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Present)
                    .HasColumnName("present")
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ActionTaken>(entity =>
            {
                entity.ToTable("action_taken");

                entity.Property(e => e.ActionTakenId).HasColumnName("action_taken_id");

                entity.Property(e => e.ActionTakenCode)
                    .HasColumnName("action_taken_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActionTakenName)
                    .HasColumnName("action_taken_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("asset");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.AssetCode)
                    .HasColumnName("asset_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssetName)
                    .HasColumnName("asset_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("attendance");

                entity.Property(e => e.AttendanceId).HasColumnName("attendance_id");

                entity.Property(e => e.AbsenceTypeId).HasColumnName("absence_type_id");

                entity.Property(e => e.ActualIn)
                    .HasColumnName("actual_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualOut)
                    .HasColumnName("actual_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.BreakIn)
                    .HasColumnName("break_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.BreakOut)
                    .HasColumnName("break_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DayTypeId).HasColumnName("day_type_id");

                entity.Property(e => e.DefaultIn)
                    .HasColumnName("default_in")
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultOut)
                    .HasColumnName("default_out")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveHour).HasColumnName("effective_hour");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FingerCode)
                    .HasColumnName("finger_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LateIn).HasColumnName("late_in");

                entity.Property(e => e.WorkHour).HasColumnName("work_hour");

                entity.HasOne(d => d.AbsenceType)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.AbsenceTypeId)
                    .HasConstraintName("FK_attendance_absence_type");

                entity.HasOne(d => d.DayType)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.DayTypeId)
                    .HasConstraintName("FK_attendance_day_type");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Attendance)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_attendance_employee");
            });

            modelBuilder.Entity<Branch>(entity =>
            {
                entity.ToTable("branch");

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.BranchCode)
                    .HasColumnName("branch_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasColumnName("branch_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DayType>(entity =>
            {
                entity.ToTable("day_type");

                entity.Property(e => e.DayTypeId).HasColumnName("day_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.DayTypeName)
                    .HasColumnName("day_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultIn).HasColumnName("default_in");

                entity.Property(e => e.DefaultOut).HasColumnName("default_out");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FridayIn).HasColumnName("friday_in");

                entity.Property(e => e.FridayOut).HasColumnName("friday_out");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SaturdayIn).HasColumnName("saturday_in");

                entity.Property(e => e.SaturdayOut).HasColumnName("saturday_out");

                entity.Property(e => e.SundayIn).HasColumnName("sunday_in");

                entity.Property(e => e.SundayOut).HasColumnName("sunday_out");
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentCode)
                    .HasColumnName("department_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasColumnName("department_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("division");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .HasColumnName("division_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionName)
                    .HasColumnName("division_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Division)
                    .HasForeignKey(d => d.DepartmentId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_division_department");
            });

            modelBuilder.Entity<Education>(entity =>
            {
                entity.ToTable("education");

                entity.Property(e => e.EducationId).HasColumnName("education_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EducationCode)
                    .HasColumnName("education_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EducationName)
                    .HasColumnName("education_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasColumnName("bank_account_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranch)
                    .HasColumnName("bank_branch")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Birthplace)
                    .HasColumnName("birthplace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Blood)
                    .HasColumnName("blood")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchId).HasColumnName("branch_id");

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DayTypeId).HasColumnName("day_type_id");

                entity.Property(e => e.DepartmentId).HasColumnName("department_id");

                entity.Property(e => e.DivisionId).HasColumnName("division_id");

                entity.Property(e => e.EducationId).HasColumnName("education_id");

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusId).HasColumnName("employee_status_id");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("employee_type_id");

                entity.Property(e => e.EmployeeTypeValidDate)
                    .HasColumnName("employee_type_valid_date")
                    .HasColumnType("date");

                entity.Property(e => e.FingerCode)
                    .HasColumnName("finger_code")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasColumnName("full_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.IdentityNo)
                    .HasColumnName("identity_no")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityType)
                    .HasColumnName("identity_type")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate)
                    .HasColumnName("join_date")
                    .HasColumnType("date");

                entity.Property(e => e.MaritalStatus)
                    .HasColumnName("marital_status")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasColumnName("mobile_no")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasColumnName("nick_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nik)
                    .HasColumnName("nik")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NpwpNo)
                    .HasColumnName("npwp_no")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentEmployeeId).HasColumnName("parent_employee_id");

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasColumnName("payment_type")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollTypeId).HasColumnName("payroll_type_id");

                entity.Property(e => e.PhoneNo)
                    .HasColumnName("phone_no")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.Province)
                    .HasColumnName("province")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Religion)
                    .HasColumnName("religion")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Shift)
                    .HasColumnName("shift")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.Tall).HasColumnName("tall");

                entity.Property(e => e.TaxStatusId).HasColumnName("tax_status_id");

                entity.Property(e => e.Weight).HasColumnName("weight");

                entity.HasOne(d => d.Branch)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.BranchId)
                    .HasConstraintName("FK_employee_branch");

                entity.HasOne(d => d.DayType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DayTypeId)
                    .HasConstraintName("FK_employee_day_type");

                entity.HasOne(d => d.Department)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DepartmentId)
                    .HasConstraintName("FK_employee_department");

                entity.HasOne(d => d.Division)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.DivisionId)
                    .HasConstraintName("FK_employee_division");

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EducationId)
                    .HasConstraintName("FK_employee_education");

                entity.HasOne(d => d.EmployeeStatus)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeStatusId)
                    .HasConstraintName("FK_employee_employee_status");

                entity.HasOne(d => d.EmployeeType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.EmployeeTypeId)
                    .HasConstraintName("FK_employee_employee_type");

                entity.HasOne(d => d.Grade)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.GradeId)
                    .HasConstraintName("FK_employee_grade");

                entity.HasOne(d => d.PayrollType)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PayrollTypeId)
                    .HasConstraintName("FK_employee_payroll_type");

                entity.HasOne(d => d.Position)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.PositionId)
                    .HasConstraintName("FK_employee_position");

                entity.HasOne(d => d.TaxStatus)
                    .WithMany(p => p.Employee)
                    .HasForeignKey(d => d.TaxStatusId)
                    .HasConstraintName("FK_employee_tax_status");
            });

            modelBuilder.Entity<EmployeeAsset>(entity =>
            {
                entity.ToTable("employee_asset");

                entity.Property(e => e.EmployeeAssetId).HasColumnName("employee_asset_id");

                entity.Property(e => e.AssetId).HasColumnName("asset_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.LendDate)
                    .HasColumnName("lend_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReturnDate)
                    .HasColumnName("return_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Asset)
                    .WithMany(p => p.EmployeeAsset)
                    .HasForeignKey(d => d.AssetId)
                    .HasConstraintName("FK_employee_asset_asset");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeAsset)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_asset_employee");
            });

            modelBuilder.Entity<EmployeeEducationFormal>(entity =>
            {
                entity.ToTable("employee_education_formal");

                entity.Property(e => e.EmployeeEducationFormalId).HasColumnName("employee_education_formal_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("date");

                entity.Property(e => e.Gpa)
                    .HasColumnName("gpa")
                    .HasMaxLength(10);

                entity.Property(e => e.LevelEducationName)
                    .HasColumnName("level_education_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Majors)
                    .HasColumnName("majors")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SchoolName)
                    .HasColumnName("school_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Until)
                    .HasColumnName("until")
                    .HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeEducationFormal)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_education_formal_employee");
            });

            modelBuilder.Entity<EmployeeEducationUnformal>(entity =>
            {
                entity.ToTable("employee_education_unformal");

                entity.Property(e => e.EmployeeEducationUnformalId).HasColumnName("employee_education_unformal_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseType)
                    .HasColumnName("course_type")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("date");

                entity.Property(e => e.HeldBy)
                    .HasColumnName("held_by")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Object)
                    .HasColumnName("object")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.Until)
                    .HasColumnName("until")
                    .HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeEducationUnformal)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_education_unformal_employee");
            });

            modelBuilder.Entity<EmployeeExperience>(entity =>
            {
                entity.ToTable("employee_experience");

                entity.Property(e => e.EmployeeExperienceId).HasColumnName("employee_experience_id");

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessType)
                    .HasColumnName("business_type")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasColumnName("company_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("date");

                entity.Property(e => e.LastPosition)
                    .HasColumnName("last_position")
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastSalary).HasColumnName("last_salary");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonSeparation)
                    .HasColumnName("reason_separation")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Until)
                    .HasColumnName("until")
                    .HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeExperience)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_experience_employee");
            });

            modelBuilder.Entity<EmployeeFamily>(entity =>
            {
                entity.ToTable("employee_family");

                entity.Property(e => e.EmployeeFamilyId).HasColumnName("employee_family_id");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Birthplace)
                    .HasColumnName("birthplace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EducationId).HasColumnName("education_id");

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Relation)
                    .HasColumnName("relation")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.HasOne(d => d.Education)
                    .WithMany(p => p.EmployeeFamily)
                    .HasForeignKey(d => d.EducationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_family_employee_family");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeFamily)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employee_family_employee");
            });

            modelBuilder.Entity<EmployeeSalary>(entity =>
            {
                entity.ToTable("employee_salary");

                entity.Property(e => e.EmployeeSalaryId).HasColumnName("employee_salary_id");

                entity.Property(e => e.AttendanceAllowance)
                    .HasColumnName("attendance_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BasicSalary)
                    .HasColumnName("basic_salary")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BbmAllowance)
                    .HasColumnName("bbm_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FunctionalAllowance)
                    .HasColumnName("functional_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MealAllowance)
                    .HasColumnName("meal_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlaceAllowance)
                    .HasColumnName("place_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlacementAllowance)
                    .HasColumnName("placement_allowance")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionAllowance)
                    .HasColumnName("position_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TelecommunicationAllowance)
                    .HasColumnName("telecommunication_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TransportAllowance)
                    .HasColumnName("transport_allowance")
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSalary)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_employee_salary_employee");
            });

            modelBuilder.Entity<EmployeeSkill>(entity =>
            {
                entity.ToTable("employee_skill");

                entity.Property(e => e.EmployeeSkillId).HasColumnName("employee_skill_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.SkillLevel)
                    .HasColumnName("skill_level")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SkillName)
                    .HasColumnName("skill_name")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.EmployeeSkill)
                    .HasForeignKey(d => d.EmployeeId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_employee_skill_employee");
            });

            modelBuilder.Entity<EmployeeStatus>(entity =>
            {
                entity.ToTable("employee_status");

                entity.Property(e => e.EmployeeStatusId).HasColumnName("employee_status_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusCode)
                    .HasColumnName("employee_status_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusName)
                    .HasColumnName("employee_status_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("employee_type");

                entity.Property(e => e.EmployeeTypeId).HasColumnName("employee_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeCode)
                    .HasColumnName("employee_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeName)
                    .HasColumnName("employee_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grade");

                entity.Property(e => e.GradeId).HasColumnName("grade_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GradeCode)
                    .HasColumnName("grade_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GradeName)
                    .HasColumnName("grade_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LeaveRemaining>(entity =>
            {
                entity.ToTable("leave_remaining");

                entity.Property(e => e.LeaveRemainingId).HasColumnName("leave_remaining_id");

                entity.Property(e => e.AdjLeave).HasColumnName("adj_leave");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Plafon).HasColumnName("plafon");

                entity.Property(e => e.Remaining).HasColumnName("remaining");

                entity.Property(e => e.Used).HasColumnName("used");

                entity.Property(e => e.Year).HasColumnName("year");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeaveRemaining)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_leave_remaining_employee");
            });

            modelBuilder.Entity<LeavingRequest>(entity =>
            {
                entity.ToTable("leaving_request");

                entity.Property(e => e.LeavingRequestId).HasColumnName("leaving_request_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.LeavingTypeId).HasColumnName("leaving_type_id");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasColumnName("no_transaction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonRejected)
                    .HasColumnName("reason_rejected")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UntilDate)
                    .HasColumnName("until_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.LeavingRequest)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_leaving_request_employee");

                entity.HasOne(d => d.LeavingType)
                    .WithMany(p => p.LeavingRequest)
                    .HasForeignKey(d => d.LeavingTypeId)
                    .HasConstraintName("FK_leaving_request_leaving_type");
            });

            modelBuilder.Entity<LeavingType>(entity =>
            {
                entity.ToTable("leaving_type");

                entity.Property(e => e.LeavingTypeId).HasColumnName("leaving_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeavingDeduction)
                    .HasColumnName("leaving_deduction")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeavingTypeCode)
                    .HasColumnName("leaving_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeavingTypeName)
                    .HasColumnName("leaving_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalReimbursement>(entity =>
            {
                entity.ToTable("medical_reimbursement");

                entity.Property(e => e.MedicalReimbursementId).HasColumnName("medical_reimbursement_id");

                entity.Property(e => e.ClaimAmount).HasColumnName("claim_amount");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.DateMedical)
                    .HasColumnName("date_medical")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.MedicalTypeId).HasColumnName("medical_type_id");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasColumnName("no_transaction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
                    .HasColumnName("patient_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false)
                    .HasDefaultValueSql("((0))");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.MedicalReimbursement)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_medical_reimbursement_employee");

                entity.HasOne(d => d.MedicalType)
                    .WithMany(p => p.MedicalReimbursement)
                    .HasForeignKey(d => d.MedicalTypeId)
                    .HasConstraintName("FK_medical_reimbursement_medical_type");
            });

            modelBuilder.Entity<MedicalType>(entity =>
            {
                entity.ToTable("medical_type");

                entity.Property(e => e.MedicalTypeId).HasColumnName("medical_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalTypeCode)
                    .HasColumnName("medical_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalTypeName)
                    .HasColumnName("medical_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollType>(entity =>
            {
                entity.ToTable("payroll_type");

                entity.Property(e => e.PayrollTypeId).HasColumnName("payroll_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PayrollTypeName)
                    .HasColumnName("payroll_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermitRequest>(entity =>
            {
                entity.ToTable("permit_request");

                entity.Property(e => e.PermitRequestId).HasColumnName("permit_request_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FromHour).HasColumnName("from_hour");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasColumnName("no_transaction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PermitDate)
                    .HasColumnName("permit_date")
                    .HasColumnType("date");

                entity.Property(e => e.ReasonRejected)
                    .HasColumnName("reason_rejected")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UntilHour).HasColumnName("until_hour");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PermitRequest)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_permit_request_employee");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("position");

                entity.Property(e => e.PositionId).HasColumnName("position_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.PositionCode)
                    .HasColumnName("position_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PositionLevel).HasColumnName("position_level");

                entity.Property(e => e.PositionName)
                    .HasColumnName("position_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Punishment>(entity =>
            {
                entity.ToTable("punishment");

                entity.Property(e => e.PunishmentId).HasColumnName("punishment_id");

                entity.Property(e => e.ActionTakenId).HasColumnName("action_taken_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasColumnName("no_transaction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValidDate)
                    .HasColumnName("valid_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.ActionTaken)
                    .WithMany(p => p.Punishment)
                    .HasForeignKey(d => d.ActionTakenId)
                    .HasConstraintName("FK_punishment_action_taken");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Punishment)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_punishment_employee");
            });

            modelBuilder.Entity<TaxRate>(entity =>
            {
                entity.ToTable("tax_rate");

                entity.Property(e => e.TaxRateId).HasColumnName("tax_rate_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromAmount).HasColumnName("from_amount");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.RatePercent).HasColumnName("rate_percent");

                entity.Property(e => e.ToAmount).HasColumnName("to_amount");
            });

            modelBuilder.Entity<TaxStatus>(entity =>
            {
                entity.ToTable("tax_status");

                entity.Property(e => e.TaxStatusId).HasColumnName("tax_status_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Ptkp).HasColumnName("ptkp");

                entity.Property(e => e.TaxStatusName)
                    .HasColumnName("tax_status_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.ToTable("training");

                entity.Property(e => e.TrainingId).HasColumnName("training_id");

                entity.Property(e => e.Certified).HasColumnName("certified");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.Fasilitator)
                    .HasColumnName("fasilitator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.Instructure)
                    .HasColumnName("instructure")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasColumnName("no_transaction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Provider)
                    .HasColumnName("provider")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Subject)
                    .HasColumnName("subject")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingTypeId).HasColumnName("training_type_id");

                entity.Property(e => e.UntilDate)
                    .HasColumnName("until_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_training_employee");

                entity.HasOne(d => d.TrainingType)
                    .WithMany(p => p.Training)
                    .HasForeignKey(d => d.TrainingTypeId)
                    .HasConstraintName("FK_training_training_type");
            });

            modelBuilder.Entity<TrainingType>(entity =>
            {
                entity.ToTable("training_type");

                entity.Property(e => e.TrainingTypeId).HasColumnName("training_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TrainingTypeCode)
                    .HasColumnName("training_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingTypeName)
                    .HasColumnName("training_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TravellingExpense>(entity =>
            {
                entity.ToTable("travelling_expense");

                entity.Property(e => e.TravellingExpenseId).HasColumnName("travelling_expense_id");

                entity.Property(e => e.Amount).HasColumnName("amount");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnName("date")
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasColumnName("destination")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId).HasColumnName("employee_id");

                entity.Property(e => e.FromDate)
                    .HasColumnName("from_date")
                    .HasColumnType("date");

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasColumnName("no_transaction")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TravellingTypeId).HasColumnName("travelling_type_id");

                entity.Property(e => e.UntilDate)
                    .HasColumnName("until_date")
                    .HasColumnType("date");

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.TravellingExpense)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_travelling_expense_employee");

                entity.HasOne(d => d.TravellingType)
                    .WithMany(p => p.TravellingExpense)
                    .HasForeignKey(d => d.TravellingTypeId)
                    .HasConstraintName("FK_travelling_expense_travelling_type");
            });

            modelBuilder.Entity<TravellingType>(entity =>
            {
                entity.ToTable("travelling_type");

                entity.Property(e => e.TravellingTypeId).HasColumnName("travelling_type_id");

                entity.Property(e => e.CreatedBy)
                    .HasColumnName("created_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnName("created_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasColumnName("deleted")
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasColumnName("description")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasColumnName("modify_by")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnName("modify_date")
                    .HasColumnType("datetime");

                entity.Property(e => e.TravellingTypeCode)
                    .HasColumnName("travelling_type_code")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TravellingTypeName)
                    .HasColumnName("travelling_type_name")
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}