using Hris.Domain.Models;
using Microsoft.EntityFrameworkCore;

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

                entity.Property(e => e.AbsenceTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsenceTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AbsenceTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Alpha)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeavingDeduction)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Present)
                    .HasDefaultValueSql("((0))");
            });

            modelBuilder.Entity<ActionTaken>(entity =>
            {
                entity.ToTable("action_taken");

                entity.Property(e => e.ActionTakenId)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionTakenCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.ActionTakenName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Asset>(entity =>
            {
                entity.ToTable("asset");

                entity.Property(e => e.AssetId)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssetCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.AssetName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Attendance>(entity =>
            {
                entity.ToTable("attendance");

                entity.Property(e => e.AttendanceId)
                    .ValueGeneratedNever();

                entity.Property(e => e.AbsenceTypeId);

                entity.Property(e => e.ActualIn)
                    .HasColumnType("datetime");

                entity.Property(e => e.ActualOut)
                    .HasColumnType("datetime");

                entity.Property(e => e.BreakIn)
                    .HasColumnType("datetime");

                entity.Property(e => e.BreakOut)
                    .HasColumnType("datetime");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnType("date");

                entity.Property(e => e.DayTypeId);

                entity.Property(e => e.DefaultIn)
                    .HasColumnType("datetime");

                entity.Property(e => e.DefaultOut)
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EffectiveHour);

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.FingerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.LateIn);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)

                    .HasColumnType("datetime");

                entity.Property(e => e.WorkHour);

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
                entity.Property(e => e.BranchId)
                    .ValueGeneratedNever();

                entity.Property(e => e.BranchCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.BranchName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<DayType>(entity =>
            {
                entity.ToTable("day_type");

                entity.Property(e => e.DayTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.DayTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.DefaultIn);

                entity.Property(e => e.DefaultOut);

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FridayIn);

                entity.Property(e => e.FridayOut);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.SaturdayIn);

                entity.Property(e => e.SaturdayOut);

                entity.Property(e => e.SundayIn);

                entity.Property(e => e.SundayOut);
            });

            modelBuilder.Entity<Department>(entity =>
            {
                entity.ToTable("department");

                entity.Property(e => e.DepartmentId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DepartmentName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Division>(entity =>
            {
                entity.ToTable("division");

                entity.Property(e => e.DivisionId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.DepartmentId);

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.DivisionName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
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

                entity.Property(e => e.EducationId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EducationCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EducationName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Employee>(entity =>
            {
                entity.ToTable("employee");

                entity.Property(e => e.EmployeeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(200)
                    .IsUnicode(false);

                entity.Property(e => e.Bank)
                    .HasColumnName("bank")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankAccountNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.BankBranch)
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

                entity.Property(e => e.BranchId);

                entity.Property(e => e.City)
                    .HasColumnName("city")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)

                    .HasColumnType("datetime");

                entity.Property(e => e.DayTypeId);

                entity.Property(e => e.DepartmentId);

                entity.Property(e => e.DivisionId);

                entity.Property(e => e.EducationId);

                entity.Property(e => e.Email)
                    .HasColumnName("email")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusId);

                entity.Property(e => e.EmployeeTypeId);

                entity.Property(e => e.EmployeeTypeValidDate)
                    .HasColumnType("date");

                entity.Property(e => e.FingerCode)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.FullName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.GradeId);

                entity.Property(e => e.IdentityNo)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.IdentityType)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.JoinDate)
                    .HasColumnType("date");

                entity.Property(e => e.MaritalStatus)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MobileNo)
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Nationality)
                    .HasColumnName("nationality")
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.NickName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.Nik)
                    .HasColumnName("nik")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.NpwpNo)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ParentEmployeeId);

                entity.Property(e => e.Password)
                    .HasColumnName("password")
                    .HasMaxLength(150)
                    .IsUnicode(false);

                entity.Property(e => e.PaymentType)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PayrollTypeId);

                entity.Property(e => e.PhoneNo)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PositionId);

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

                entity.Property(e => e.TaxStatusId);

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

                entity.Property(e => e.EmployeeAssetId)
                    .ValueGeneratedNever();

                entity.Property(e => e.AssetId);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.LendDate)
                    .HasColumnType("date");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.ReturnDate)
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

                entity.Property(e => e.EmployeeEducationFormalId)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("date");

                entity.Property(e => e.Gpa)
                    .HasColumnName("gpa")
                    .HasMaxLength(10);

                entity.Property(e => e.LevelEducationName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Majors)
                    .HasColumnName("majors")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.SchoolName)
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

                entity.Property(e => e.EmployeeEducationUnformalId)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CourseType)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("date");

                entity.Property(e => e.HeldBy)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
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

                entity.Property(e => e.EmployeeExperienceId)
                    .ValueGeneratedNever();

                entity.Property(e => e.Address)
                    .HasColumnName("address")
                    .HasMaxLength(100)
                    .IsUnicode(false);

                entity.Property(e => e.BusinessType)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.CompanyName)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)

                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.From)
                    .HasColumnName("from")
                    .HasColumnType("date");

                entity.Property(e => e.LastPosition)
                    .HasMaxLength(30)
                    .IsUnicode(false);

                entity.Property(e => e.LastSalary);

                entity.Property(e => e.ModifyBy)

                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)

                    .HasColumnType("datetime");

                entity.Property(e => e.ReasonSeparation)
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

                entity.Property(e => e.EmployeeFamilyId)
                    .ValueGeneratedNever();

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("date");

                entity.Property(e => e.Birthplace)
                    .HasColumnName("birthplace")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)

                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EducationId);

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.Gender)
                    .HasColumnName("gender")
                    .HasMaxLength(15)
                    .IsUnicode(false);

                entity.Property(e => e.Job)
                    .HasColumnName("job")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)

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

                entity.Property(e => e.EmployeeSalaryId)
                    .ValueGeneratedNever();

                entity.Property(e => e.AttendanceAllowance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BasicSalary)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.BbmAllowance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.FunctionalAllowance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.MealAllowance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.PlaceAllowance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.PlacementAllowance)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.PositionAllowance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TelecommunicationAllowance)
                    .HasMaxLength(250)
                    .IsUnicode(false);

                entity.Property(e => e.TransportAllowance)
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

                entity.Property(e => e.EmployeeSkillId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.SkillLevel)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.SkillName)
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

                entity.Property(e => e.EmployeeStatusId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeStatusName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<EmployeeType>(entity =>
            {
                entity.ToTable("employee_type");

                entity.Property(e => e.EmployeeTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<Grade>(entity =>
            {
                entity.ToTable("grade");

                entity.Property(e => e.GradeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.GradeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.GradeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)

                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<LeaveRemaining>(entity =>
            {
                entity.ToTable("leave_remaining");

                entity.Property(e => e.LeaveRemainingId)
                    .ValueGeneratedNever();

                entity.Property(e => e.AdjLeave);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId); ;

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

                entity.Property(e => e.LeavingRequestId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)

                    .HasColumnType("date");

                entity.Property(e => e.Days).HasColumnName("days");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId); ;

                entity.Property(e => e.FromDate)
                    .HasColumnType("date");

                entity.Property(e => e.LeavingTypeId);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ReasonRejected)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Status)
                    .HasColumnName("status")
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.UntilDate)
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

                entity.Property(e => e.LeavingTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.LeavingDeduction)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.LeavingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.LeavingTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<MedicalReimbursement>(entity =>
            {
                entity.ToTable("medical_reimbursement");

                entity.Property(e => e.MedicalReimbursementId)
                    .ValueGeneratedNever();

                entity.Property(e => e.ClaimAmount);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)

                    .HasColumnType("date");

                entity.Property(e => e.DateMedical)
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId);

                entity.Property(e => e.MedicalTypeId);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PatientName)
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

                entity.Property(e => e.MedicalTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.MedicalTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");
            });

            modelBuilder.Entity<PayrollType>(entity =>
            {
                entity.ToTable("payroll_type");

                entity.Property(e => e.PayrollTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.PayrollTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<PermitRequest>(entity =>
            {
                entity.ToTable("permit_request");

                entity.Property(e => e.PermitRequestId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)

                    .HasColumnType("date");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId);

                entity.Property(e => e.FromHour);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.PermitDate)
                    .HasColumnType("date");

                entity.Property(e => e.ReasonRejected)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.UntilHour);

                entity.HasOne(d => d.Employee)
                    .WithMany(p => p.PermitRequest)
                    .HasForeignKey(d => d.EmployeeId)
                    .HasConstraintName("FK_permit_request_employee");
            });

            modelBuilder.Entity<Position>(entity =>
            {
                entity.ToTable("position");

                entity.Property(e => e.PositionId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.PositionCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PositionLevel);

                entity.Property(e => e.PositionName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Punishment>(entity =>
            {
                entity.ToTable("punishment");

                entity.Property(e => e.PunishmentId)
                    .ValueGeneratedNever();

                entity.Property(e => e.ActionTakenId);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)

                    .HasColumnType("date");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ValidDate)
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

                entity.Property(e => e.TaxRateId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromAmount);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.RatePercent);

                entity.Property(e => e.ToAmount);
            });

            modelBuilder.Entity<TaxStatus>(entity =>
            {
                entity.ToTable("tax_status");

                entity.Property(e => e.TaxStatusId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Ptkp).HasColumnName("ptkp");

                entity.Property(e => e.TaxStatusName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<Training>(entity =>
            {
                entity.ToTable("training");

                entity.Property(e => e.TrainingId)
                    .ValueGeneratedNever();

                entity.Property(e => e.Certified).HasColumnName("certified");

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)

                    .HasColumnType("date");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId);

                entity.Property(e => e.Fasilitator)
                    .HasColumnName("fasilitator")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.FromDate)
                    .HasColumnType("date");

                entity.Property(e => e.Instructure)
                    .HasColumnName("instructure")
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)

                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
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

                entity.Property(e => e.TrainingTypeId);

                entity.Property(e => e.UntilDate)
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

                entity.Property(e => e.TrainingTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)

                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)

                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.TrainingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TrainingTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            modelBuilder.Entity<TravellingExpense>(entity =>
            {
                entity.ToTable("travelling_expense");

                entity.Property(e => e.TravellingExpenseId)
                    .ValueGeneratedNever();

                entity.Property(e => e.Amount);

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Date)
                    .HasColumnType("date");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.Destination)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.EmployeeId);

                entity.Property(e => e.FromDate)
                    .HasColumnType("date");

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.NoTransaction)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.TravellingTypeId);

                entity.Property(e => e.UntilDate)
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

                entity.Property(e => e.TravellingTypeId)
                    .ValueGeneratedNever();

                entity.Property(e => e.CreatedBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.CreatedDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.Deleted)
                    .HasDefaultValueSql("((0))");

                entity.Property(e => e.Description)
                    .HasMaxLength(50)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyBy)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.ModifyDate)
                    .HasColumnType("datetime");

                entity.Property(e => e.TravellingTypeCode)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.TravellingTypeName)
                    .HasMaxLength(20)
                    .IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}