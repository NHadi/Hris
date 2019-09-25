using System;
using System.Collections.Generic;

namespace Hris.Infrastructure.Database.Models
{
    public partial class Employee
    {
        public Employee()
        {
            Attendance = new HashSet<Attendance>();
            EmployeeAsset = new HashSet<EmployeeAsset>();
            EmployeeEducationFormal = new HashSet<EmployeeEducationFormal>();
            EmployeeEducationUnformal = new HashSet<EmployeeEducationUnformal>();
            EmployeeExperience = new HashSet<EmployeeExperience>();
            EmployeeFamily = new HashSet<EmployeeFamily>();
            EmployeeSalary = new HashSet<EmployeeSalary>();
            EmployeeSkill = new HashSet<EmployeeSkill>();
            LeaveRemaining = new HashSet<LeaveRemaining>();
            LeavingRequest = new HashSet<LeavingRequest>();
            MedicalReimbursement = new HashSet<MedicalReimbursement>();
            PermitRequest = new HashSet<PermitRequest>();
            Punishment = new HashSet<Punishment>();
            Training = new HashSet<Training>();
            TravellingExpense = new HashSet<TravellingExpense>();
        }

        public int EmployeeId { get; set; }
        public string FingerCode { get; set; }
        public string Nik { get; set; }
        public string FullName { get; set; }
        public string NickName { get; set; }
        public string IdentityType { get; set; }
        public string IdentityNo { get; set; }
        public string Gender { get; set; }
        public string Religion { get; set; }
        public string Birthplace { get; set; }
        public DateTime? Birthdate { get; set; }
        public string Address { get; set; }
        public string Province { get; set; }
        public string City { get; set; }
        public string PhoneNo { get; set; }
        public string MobileNo { get; set; }
        public DateTime? JoinDate { get; set; }
        public int? GradeId { get; set; }
        public int? BranchId { get; set; }
        public int? DepartmentId { get; set; }
        public int? DivisionId { get; set; }
        public int? PositionId { get; set; }
        public int? EmployeeTypeId { get; set; }
        public DateTime? EmployeeTypeValidDate { get; set; }
        public int? EmployeeStatusId { get; set; }
        public int? ParentEmployeeId { get; set; }
        public int? EducationId { get; set; }
        public string NpwpNo { get; set; }
        public int? TaxStatusId { get; set; }
        public int? DayTypeId { get; set; }
        public int? PayrollTypeId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Shift { get; set; }
        public int? Tall { get; set; }
        public int? Weight { get; set; }
        public string Blood { get; set; }
        public string PaymentType { get; set; }
        public string MaritalStatus { get; set; }
        public string Nationality { get; set; }
        public string Bank { get; set; }
        public string BankBranch { get; set; }
        public string BankAccountNo { get; set; }

        public virtual Branch Branch { get; set; }
        public virtual DayType DayType { get; set; }
        public virtual Department Department { get; set; }
        public virtual Division Division { get; set; }
        public virtual Education Education { get; set; }
        public virtual EmployeeStatus EmployeeStatus { get; set; }
        public virtual EmployeeType EmployeeType { get; set; }
        public virtual Grade Grade { get; set; }
        public virtual PayrollType PayrollType { get; set; }
        public virtual Position Position { get; set; }
        public virtual TaxStatus TaxStatus { get; set; }
        public virtual ICollection<Attendance> Attendance { get; set; }
        public virtual ICollection<EmployeeAsset> EmployeeAsset { get; set; }
        public virtual ICollection<EmployeeEducationFormal> EmployeeEducationFormal { get; set; }
        public virtual ICollection<EmployeeEducationUnformal> EmployeeEducationUnformal { get; set; }
        public virtual ICollection<EmployeeExperience> EmployeeExperience { get; set; }
        public virtual ICollection<EmployeeFamily> EmployeeFamily { get; set; }
        public virtual ICollection<EmployeeSalary> EmployeeSalary { get; set; }
        public virtual ICollection<EmployeeSkill> EmployeeSkill { get; set; }
        public virtual ICollection<LeaveRemaining> LeaveRemaining { get; set; }
        public virtual ICollection<LeavingRequest> LeavingRequest { get; set; }
        public virtual ICollection<MedicalReimbursement> MedicalReimbursement { get; set; }
        public virtual ICollection<PermitRequest> PermitRequest { get; set; }
        public virtual ICollection<Punishment> Punishment { get; set; }
        public virtual ICollection<Training> Training { get; set; }
        public virtual ICollection<TravellingExpense> TravellingExpense { get; set; }
    }
}