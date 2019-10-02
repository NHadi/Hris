using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Hris.Infrastructure.Database.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "absence_type",
                columns: table => new
                {
                    AbsenceTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AbsenceTypeCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    AbsenceTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    LeavingDeduction = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Present = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Alpha = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_absence_type", x => x.AbsenceTypeId);
                });

            migrationBuilder.CreateTable(
                name: "action_taken",
                columns: table => new
                {
                    ActionTakenId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActionTakenCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    ActionTakenName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_action_taken", x => x.ActionTakenId);
                });

            migrationBuilder.CreateTable(
                name: "asset",
                columns: table => new
                {
                    AssetId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    AssetCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    AssetName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_asset", x => x.AssetId);
                });

            migrationBuilder.CreateTable(
                name: "branch",
                columns: table => new
                {
                    BranchId = table.Column<Guid>(nullable: false),
                    BranchCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    BranchName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_branch", x => x.BranchId);
                });

            migrationBuilder.CreateTable(
                name: "day_type",
                columns: table => new
                {
                    DayTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DayTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    DefaultIn = table.Column<TimeSpan>(nullable: true),
                    DefaultOut = table.Column<TimeSpan>(nullable: true),
                    FridayIn = table.Column<TimeSpan>(nullable: true),
                    FridayOut = table.Column<TimeSpan>(nullable: true),
                    SaturdayIn = table.Column<TimeSpan>(nullable: true),
                    SaturdayOut = table.Column<TimeSpan>(nullable: true),
                    SundayIn = table.Column<TimeSpan>(nullable: true),
                    SundayOut = table.Column<TimeSpan>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_day_type", x => x.DayTypeId);
                });

            migrationBuilder.CreateTable(
                name: "department",
                columns: table => new
                {
                    DepartmentId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DepartmentCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    DepartmentName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_department", x => x.DepartmentId);
                });

            migrationBuilder.CreateTable(
                name: "education",
                columns: table => new
                {
                    EducationId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EducationCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    EducationName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_education", x => x.EducationId);
                });

            migrationBuilder.CreateTable(
                name: "employee_status",
                columns: table => new
                {
                    EmployeeStatusId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeStatusCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    EmployeeStatusName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_status", x => x.EmployeeStatusId);
                });

            migrationBuilder.CreateTable(
                name: "employee_type",
                columns: table => new
                {
                    EmployeeTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeTypeCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    EmployeeTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_type", x => x.EmployeeTypeId);
                });

            migrationBuilder.CreateTable(
                name: "grade",
                columns: table => new
                {
                    GradeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    GradeCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    GradeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_grade", x => x.GradeId);
                });

            migrationBuilder.CreateTable(
                name: "leaving_type",
                columns: table => new
                {
                    LeavingTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    LeavingTypeCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    LeavingTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    LeavingDeduction = table.Column<bool>(nullable: true, defaultValueSql: "((0))"),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaving_type", x => x.LeavingTypeId);
                });

            migrationBuilder.CreateTable(
                name: "medical_type",
                columns: table => new
                {
                    MedicalTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    MedicalTypeCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    MedicalTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medical_type", x => x.MedicalTypeId);
                });

            migrationBuilder.CreateTable(
                name: "payroll_type",
                columns: table => new
                {
                    PayrollTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PayrollTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_payroll_type", x => x.PayrollTypeId);
                });

            migrationBuilder.CreateTable(
                name: "position",
                columns: table => new
                {
                    PositionId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    PositionCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    PositionName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    PositionLevel = table.Column<int>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_position", x => x.PositionId);
                });

            migrationBuilder.CreateTable(
                name: "tax_rate",
                columns: table => new
                {
                    TaxRateId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    RatePercent = table.Column<double>(nullable: true),
                    FromAmount = table.Column<double>(nullable: true),
                    ToAmount = table.Column<double>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tax_rate", x => x.TaxRateId);
                });

            migrationBuilder.CreateTable(
                name: "tax_status",
                columns: table => new
                {
                    TaxStatusId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TaxStatusName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ptkp = table.Column<double>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_tax_status", x => x.TaxStatusId);
                });

            migrationBuilder.CreateTable(
                name: "training_type",
                columns: table => new
                {
                    TrainingTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TrainingTypeCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    TrainingTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_training_type", x => x.TrainingTypeId);
                });

            migrationBuilder.CreateTable(
                name: "travelling_type",
                columns: table => new
                {
                    TravellingTypeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    TravellingTypeCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    TravellingTypeName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travelling_type", x => x.TravellingTypeId);
                });

            migrationBuilder.CreateTable(
                name: "division",
                columns: table => new
                {
                    DivisionId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    DepartmentId = table.Column<Guid>(nullable: false),
                    DivisionCode = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    DivisionName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_division", x => x.DivisionId);
                    table.ForeignKey(
                        name: "FK_division_department",
                        column: x => x.DepartmentId,
                        principalTable: "department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee",
                columns: table => new
                {
                    EmployeeId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    FingerCode = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    nik = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    FullName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    NickName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    IdentityType = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    IdentityNo = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    gender = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    religion = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    birthplace = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    birthdate = table.Column<DateTime>(type: "date", nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 200, nullable: true),
                    province = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    city = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    PhoneNo = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    MobileNo = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    JoinDate = table.Column<DateTime>(type: "date", nullable: true),
                    GradeId = table.Column<Guid>(nullable: true),
                    BranchId = table.Column<Guid>(nullable: true),
                    DepartmentId = table.Column<Guid>(nullable: true),
                    DivisionId = table.Column<Guid>(nullable: true),
                    PositionId = table.Column<Guid>(nullable: true),
                    EmployeeTypeId = table.Column<Guid>(nullable: true),
                    EmployeeTypeValidDate = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeStatusId = table.Column<Guid>(nullable: true),
                    ParentEmployeeId = table.Column<Guid>(nullable: true),
                    EducationId = table.Column<Guid>(nullable: true),
                    NpwpNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    TaxStatusId = table.Column<Guid>(nullable: true),
                    DayTypeId = table.Column<Guid>(nullable: true),
                    PayrollTypeId = table.Column<Guid>(nullable: true),
                    email = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    password = table.Column<string>(unicode: false, maxLength: 150, nullable: true),
                    shift = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    tall = table.Column<int>(nullable: true),
                    weight = table.Column<int>(nullable: true),
                    blood = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    PaymentType = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    MaritalStatus = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    nationality = table.Column<string>(unicode: false, maxLength: 10, nullable: true),
                    bank = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BankBranch = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BankAccountNo = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_employee_branch",
                        column: x => x.BranchId,
                        principalTable: "branch",
                        principalColumn: "BranchId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_day_type",
                        column: x => x.DayTypeId,
                        principalTable: "day_type",
                        principalColumn: "DayTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_department",
                        column: x => x.DepartmentId,
                        principalTable: "department",
                        principalColumn: "DepartmentId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_division",
                        column: x => x.DivisionId,
                        principalTable: "division",
                        principalColumn: "DivisionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_education",
                        column: x => x.EducationId,
                        principalTable: "education",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_employee_status",
                        column: x => x.EmployeeStatusId,
                        principalTable: "employee_status",
                        principalColumn: "EmployeeStatusId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_employee_type",
                        column: x => x.EmployeeTypeId,
                        principalTable: "employee_type",
                        principalColumn: "EmployeeTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_grade",
                        column: x => x.GradeId,
                        principalTable: "grade",
                        principalColumn: "GradeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_payroll_type",
                        column: x => x.PayrollTypeId,
                        principalTable: "payroll_type",
                        principalColumn: "PayrollTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_position",
                        column: x => x.PositionId,
                        principalTable: "position",
                        principalColumn: "PositionId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_tax_status",
                        column: x => x.TaxStatusId,
                        principalTable: "tax_status",
                        principalColumn: "TaxStatusId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "attendance",
                columns: table => new
                {
                    AttendanceId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    FingerCode = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    DayTypeId = table.Column<Guid>(nullable: true),
                    AbsenceTypeId = table.Column<Guid>(nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    DefaultIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    DefaultOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActualIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    ActualOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    BreakIn = table.Column<DateTime>(type: "datetime", nullable: true),
                    BreakOut = table.Column<DateTime>(type: "datetime", nullable: true),
                    LateIn = table.Column<TimeSpan>(nullable: true),
                    WorkHour = table.Column<TimeSpan>(nullable: true),
                    EffectiveHour = table.Column<TimeSpan>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_attendance", x => x.AttendanceId);
                    table.ForeignKey(
                        name: "FK_attendance_absence_type",
                        column: x => x.AbsenceTypeId,
                        principalTable: "absence_type",
                        principalColumn: "AbsenceTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_attendance_day_type",
                        column: x => x.DayTypeId,
                        principalTable: "day_type",
                        principalColumn: "DayTypeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_attendance_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_asset",
                columns: table => new
                {
                    EmployeeAssetId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    AssetId = table.Column<Guid>(nullable: true),
                    LendDate = table.Column<DateTime>(type: "date", nullable: true),
                    ReturnDate = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_asset", x => x.EmployeeAssetId);
                    table.ForeignKey(
                        name: "FK_employee_asset_asset",
                        column: x => x.AssetId,
                        principalTable: "asset",
                        principalColumn: "AssetId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_asset_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_education_formal",
                columns: table => new
                {
                    EmployeeEducationFormalId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    LevelEducationName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SchoolName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    majors = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    from = table.Column<DateTime>(type: "date", nullable: true),
                    until = table.Column<DateTime>(type: "date", nullable: true),
                    gpa = table.Column<byte[]>(maxLength: 10, nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_education_formal", x => x.EmployeeEducationFormalId);
                    table.ForeignKey(
                        name: "FK_employee_education_formal_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_education_unformal",
                columns: table => new
                {
                    EmployeeEducationUnformalId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    CourseType = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    @object = table.Column<string>(name: "object", unicode: false, maxLength: 30, nullable: true),
                    HeldBy = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    from = table.Column<DateTime>(type: "date", nullable: true),
                    until = table.Column<DateTime>(type: "date", nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_education_unformal", x => x.EmployeeEducationUnformalId);
                    table.ForeignKey(
                        name: "FK_employee_education_unformal_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_experience",
                columns: table => new
                {
                    EmployeeExperienceId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    from = table.Column<DateTime>(type: "date", nullable: true),
                    until = table.Column<DateTime>(type: "date", nullable: true),
                    CompanyName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    address = table.Column<string>(unicode: false, maxLength: 100, nullable: true),
                    BusinessType = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    LastPosition = table.Column<string>(unicode: false, maxLength: 30, nullable: true),
                    LastSalary = table.Column<double>(nullable: true),
                    ReasonSeparation = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_experience", x => x.EmployeeExperienceId);
                    table.ForeignKey(
                        name: "FK_employee_experience_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_family",
                columns: table => new
                {
                    EmployeeFamilyId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    name = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    relation = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    gender = table.Column<string>(unicode: false, maxLength: 15, nullable: true),
                    birthdate = table.Column<DateTime>(type: "date", nullable: true),
                    birthplace = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    EducationId = table.Column<Guid>(nullable: false),
                    job = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_family", x => x.EmployeeFamilyId);
                    table.ForeignKey(
                        name: "FK_employee_family_employee_family",
                        column: x => x.EducationId,
                        principalTable: "education",
                        principalColumn: "EducationId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_employee_family_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_salary",
                columns: table => new
                {
                    EmployeeSalaryId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    BasicSalary = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    PositionAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    AttendanceAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    MealAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    TransportAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    PlacementAllowance = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    BbmAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    TelecommunicationAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    PlaceAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true),
                    FunctionalAllowance = table.Column<string>(unicode: false, maxLength: 250, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_salary", x => x.EmployeeSalaryId);
                    table.ForeignKey(
                        name: "FK_employee_salary_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "employee_skill",
                columns: table => new
                {
                    EmployeeSkillId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: false),
                    SkillName = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    SkillLevel = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_employee_skill", x => x.EmployeeSkillId);
                    table.ForeignKey(
                        name: "FK_employee_skill_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "leave_remaining",
                columns: table => new
                {
                    LeaveRemainingId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    year = table.Column<int>(nullable: true),
                    plafon = table.Column<int>(nullable: true),
                    used = table.Column<int>(nullable: true),
                    AdjLeave = table.Column<int>(nullable: true),
                    remaining = table.Column<int>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leave_remaining", x => x.LeaveRemainingId);
                    table.ForeignKey(
                        name: "FK_leave_remaining_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "leaving_request",
                columns: table => new
                {
                    LeavingRequestId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NoTransaction = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    LeavingTypeId = table.Column<Guid>(nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    UntilDate = table.Column<DateTime>(type: "date", nullable: true),
                    days = table.Column<int>(nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ReasonRejected = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_leaving_request", x => x.LeavingRequestId);
                    table.ForeignKey(
                        name: "FK_leaving_request_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_leaving_request_leaving_type",
                        column: x => x.LeavingTypeId,
                        principalTable: "leaving_type",
                        principalColumn: "LeavingTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "medical_reimbursement",
                columns: table => new
                {
                    MedicalReimbursementId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NoTransaction = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    MedicalTypeId = table.Column<Guid>(nullable: true),
                    DateMedical = table.Column<DateTime>(type: "date", nullable: true),
                    PatientName = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ClaimAmount = table.Column<double>(nullable: true),
                    status = table.Column<string>(unicode: false, maxLength: 20, nullable: true, defaultValueSql: "((0))"),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_medical_reimbursement", x => x.MedicalReimbursementId);
                    table.ForeignKey(
                        name: "FK_medical_reimbursement_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_medical_reimbursement_medical_type",
                        column: x => x.MedicalTypeId,
                        principalTable: "medical_type",
                        principalColumn: "MedicalTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "permit_request",
                columns: table => new
                {
                    PermitRequestId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NoTransaction = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    PermitDate = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    FromHour = table.Column<TimeSpan>(nullable: true),
                    UntilHour = table.Column<TimeSpan>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    ReasonRejected = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_permit_request", x => x.PermitRequestId);
                    table.ForeignKey(
                        name: "FK_permit_request_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "punishment",
                columns: table => new
                {
                    PunishmentId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NoTransaction = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    ActionTakenId = table.Column<Guid>(nullable: true),
                    ValidDate = table.Column<DateTime>(type: "date", nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_punishment", x => x.PunishmentId);
                    table.ForeignKey(
                        name: "FK_punishment_action_taken",
                        column: x => x.ActionTakenId,
                        principalTable: "action_taken",
                        principalColumn: "ActionTakenId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_punishment_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "training",
                columns: table => new
                {
                    TrainingId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NoTransaction = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    TrainingTypeId = table.Column<Guid>(nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    UntilDate = table.Column<DateTime>(type: "date", nullable: true),
                    subject = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    fasilitator = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    provider = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    instructure = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    certified = table.Column<bool>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_training", x => x.TrainingId);
                    table.ForeignKey(
                        name: "FK_training_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_training_training_type",
                        column: x => x.TrainingTypeId,
                        principalTable: "training_type",
                        principalColumn: "TrainingTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "travelling_expense",
                columns: table => new
                {
                    TravellingExpenseId = table.Column<Guid>(nullable: false),
                    CreatedBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    CreatedDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    ModifyBy = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    ModifyDate = table.Column<DateTime>(type: "datetime", nullable: true),
                    NoTransaction = table.Column<string>(unicode: false, maxLength: 20, nullable: true),
                    Date = table.Column<DateTime>(type: "date", nullable: true),
                    EmployeeId = table.Column<Guid>(nullable: true),
                    TravellingTypeId = table.Column<Guid>(nullable: true),
                    Destination = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    FromDate = table.Column<DateTime>(type: "date", nullable: true),
                    UntilDate = table.Column<DateTime>(type: "date", nullable: true),
                    Amount = table.Column<double>(nullable: true),
                    Description = table.Column<string>(unicode: false, maxLength: 50, nullable: true),
                    Deleted = table.Column<bool>(nullable: true, defaultValueSql: "((0))")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_travelling_expense", x => x.TravellingExpenseId);
                    table.ForeignKey(
                        name: "FK_travelling_expense_employee",
                        column: x => x.EmployeeId,
                        principalTable: "employee",
                        principalColumn: "EmployeeId",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_travelling_expense_travelling_type",
                        column: x => x.TravellingTypeId,
                        principalTable: "travelling_type",
                        principalColumn: "TravellingTypeId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_attendance_AbsenceTypeId",
                table: "attendance",
                column: "AbsenceTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_attendance_DayTypeId",
                table: "attendance",
                column: "DayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_attendance_EmployeeId",
                table: "attendance",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_division_DepartmentId",
                table: "division",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_BranchId",
                table: "employee",
                column: "BranchId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_DayTypeId",
                table: "employee",
                column: "DayTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_DepartmentId",
                table: "employee",
                column: "DepartmentId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_DivisionId",
                table: "employee",
                column: "DivisionId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_EducationId",
                table: "employee",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_EmployeeStatusId",
                table: "employee",
                column: "EmployeeStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_EmployeeTypeId",
                table: "employee",
                column: "EmployeeTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_GradeId",
                table: "employee",
                column: "GradeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_PayrollTypeId",
                table: "employee",
                column: "PayrollTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_PositionId",
                table: "employee",
                column: "PositionId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_TaxStatusId",
                table: "employee",
                column: "TaxStatusId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_asset_AssetId",
                table: "employee_asset",
                column: "AssetId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_asset_EmployeeId",
                table: "employee_asset",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_education_formal_EmployeeId",
                table: "employee_education_formal",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_education_unformal_EmployeeId",
                table: "employee_education_unformal",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_experience_EmployeeId",
                table: "employee_experience",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_family_EducationId",
                table: "employee_family",
                column: "EducationId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_family_EmployeeId",
                table: "employee_family",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_salary_EmployeeId",
                table: "employee_salary",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_employee_skill_EmployeeId",
                table: "employee_skill",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_leave_remaining_EmployeeId",
                table: "leave_remaining",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_leaving_request_EmployeeId",
                table: "leaving_request",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_leaving_request_LeavingTypeId",
                table: "leaving_request",
                column: "LeavingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_medical_reimbursement_EmployeeId",
                table: "medical_reimbursement",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_medical_reimbursement_MedicalTypeId",
                table: "medical_reimbursement",
                column: "MedicalTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_permit_request_EmployeeId",
                table: "permit_request",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_punishment_ActionTakenId",
                table: "punishment",
                column: "ActionTakenId");

            migrationBuilder.CreateIndex(
                name: "IX_punishment_EmployeeId",
                table: "punishment",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_training_EmployeeId",
                table: "training",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_training_TrainingTypeId",
                table: "training",
                column: "TrainingTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_travelling_expense_EmployeeId",
                table: "travelling_expense",
                column: "EmployeeId");

            migrationBuilder.CreateIndex(
                name: "IX_travelling_expense_TravellingTypeId",
                table: "travelling_expense",
                column: "TravellingTypeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "attendance");

            migrationBuilder.DropTable(
                name: "employee_asset");

            migrationBuilder.DropTable(
                name: "employee_education_formal");

            migrationBuilder.DropTable(
                name: "employee_education_unformal");

            migrationBuilder.DropTable(
                name: "employee_experience");

            migrationBuilder.DropTable(
                name: "employee_family");

            migrationBuilder.DropTable(
                name: "employee_salary");

            migrationBuilder.DropTable(
                name: "employee_skill");

            migrationBuilder.DropTable(
                name: "leave_remaining");

            migrationBuilder.DropTable(
                name: "leaving_request");

            migrationBuilder.DropTable(
                name: "medical_reimbursement");

            migrationBuilder.DropTable(
                name: "permit_request");

            migrationBuilder.DropTable(
                name: "punishment");

            migrationBuilder.DropTable(
                name: "tax_rate");

            migrationBuilder.DropTable(
                name: "training");

            migrationBuilder.DropTable(
                name: "travelling_expense");

            migrationBuilder.DropTable(
                name: "absence_type");

            migrationBuilder.DropTable(
                name: "asset");

            migrationBuilder.DropTable(
                name: "leaving_type");

            migrationBuilder.DropTable(
                name: "medical_type");

            migrationBuilder.DropTable(
                name: "action_taken");

            migrationBuilder.DropTable(
                name: "training_type");

            migrationBuilder.DropTable(
                name: "employee");

            migrationBuilder.DropTable(
                name: "travelling_type");

            migrationBuilder.DropTable(
                name: "branch");

            migrationBuilder.DropTable(
                name: "day_type");

            migrationBuilder.DropTable(
                name: "division");

            migrationBuilder.DropTable(
                name: "education");

            migrationBuilder.DropTable(
                name: "employee_status");

            migrationBuilder.DropTable(
                name: "employee_type");

            migrationBuilder.DropTable(
                name: "grade");

            migrationBuilder.DropTable(
                name: "payroll_type");

            migrationBuilder.DropTable(
                name: "position");

            migrationBuilder.DropTable(
                name: "tax_status");

            migrationBuilder.DropTable(
                name: "department");
        }
    }
}
