using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AspNetRoles",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUsers",
                columns: table => new
                {
                    Id = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IsCustomer = table.Column<bool>(type: "bit", nullable: false),
                    CustomerId = table.Column<int>(type: "int", nullable: true),
                    UserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedUserName = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    NormalizedEmail = table.Column<string>(type: "nvarchar(256)", maxLength: 256, nullable: true),
                    EmailConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    PasswordHash = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SecurityStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ConcurrencyStamp = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumberConfirmed = table.Column<bool>(type: "bit", nullable: false),
                    TwoFactorEnabled = table.Column<bool>(type: "bit", nullable: false),
                    LockoutEnd = table.Column<DateTimeOffset>(type: "datetimeoffset", nullable: true),
                    LockoutEnabled = table.Column<bool>(type: "bit", nullable: false),
                    AccessFailedCount = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUsers", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CompanyName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactTitle = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactFirstNames = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    ContactSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Line1 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Line2 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Line3 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Line4 = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustID);
                });

            migrationBuilder.CreateTable(
                name: "Inspectors",
                columns: table => new
                {
                    InspectorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InspectorsName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspectors", x => x.InspectorID);
                });

            migrationBuilder.CreateTable(
                name: "PlantCategories",
                columns: table => new
                {
                    CategoryID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CategoryDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantCategories", x => x.CategoryID);
                });

            migrationBuilder.CreateTable(
                name: "Status",
                columns: table => new
                {
                    StatusID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    StatusDescription = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Status", x => x.StatusID);
                });

            migrationBuilder.CreateTable(
                name: "Summaries",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Summaries", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AspNetRoleClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetRoleClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetRoleClaims_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserClaims",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ClaimType = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ClaimValue = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserClaims", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AspNetUserClaims_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserLogins",
                columns: table => new
                {
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderKey = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    ProviderDisplayName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserLogins", x => new { x.LoginProvider, x.ProviderKey });
                    table.ForeignKey(
                        name: "FK_AspNetUserLogins_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserRoles",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RoleId = table.Column<string>(type: "nvarchar(450)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserRoles", x => new { x.UserId, x.RoleId });
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetRoles_RoleId",
                        column: x => x.RoleId,
                        principalTable: "AspNetRoles",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AspNetUserRoles_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AspNetUserTokens",
                columns: table => new
                {
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    LoginProvider = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    Value = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AspNetUserTokens", x => new { x.UserId, x.LoginProvider, x.Name });
                    table.ForeignKey(
                        name: "FK_AspNetUserTokens_AspNetUsers_UserId",
                        column: x => x.UserId,
                        principalTable: "AspNetUsers",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Notes",
                columns: table => new
                {
                    NoteID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustID = table.Column<int>(type: "int", nullable: true),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Notes", x => x.NoteID);
                    table.ForeignKey(
                        name: "FK_Notes_Customers_CustID",
                        column: x => x.CustID,
                        principalTable: "Customers",
                        principalColumn: "CustID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AllPlant",
                columns: table => new
                {
                    PlantNameID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PlantCategory = table.Column<int>(type: "int", nullable: true),
                    PlantDescription = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    NormalPrice = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AllPlant", x => x.PlantNameID);
                    table.ForeignKey(
                        name: "FK_AllPlant_PlantCategories_PlantCategory",
                        column: x => x.PlantCategory,
                        principalTable: "PlantCategories",
                        principalColumn: "CategoryID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PlantHoldings",
                columns: table => new
                {
                    HoldingID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CustID = table.Column<int>(type: "int", nullable: true),
                    PlantNameID = table.Column<int>(type: "int", nullable: true),
                    SerialNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    StatusID = table.Column<int>(type: "int", nullable: true),
                    SWL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectionFrequency = table.Column<int>(type: "int", nullable: false),
                    InspectionFee = table.Column<decimal>(type: "decimal(18,2)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PlantHoldings", x => x.HoldingID);
                    table.ForeignKey(
                        name: "FK_PlantHoldings_AllPlant_PlantNameID",
                        column: x => x.PlantNameID,
                        principalTable: "AllPlant",
                        principalColumn: "PlantNameID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantHoldings_Customers_CustID",
                        column: x => x.CustID,
                        principalTable: "Customers",
                        principalColumn: "CustID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PlantHoldings_Status_StatusID",
                        column: x => x.StatusID,
                        principalTable: "Status",
                        principalColumn: "StatusID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Inspections",
                columns: table => new
                {
                    UniqueRef = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoldingID = table.Column<int>(type: "int", nullable: true),
                    InspectionDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RecentCheck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PreviousCheck = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SafeWorking = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Defects = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Rectified = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LatestDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    TestDetails = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    MiscNotes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectorID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Inspections", x => x.UniqueRef);
                    table.ForeignKey(
                        name: "FK_Inspections_Inspectors_InspectorID",
                        column: x => x.InspectorID,
                        principalTable: "Inspectors",
                        principalColumn: "InspectorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Inspections_PlantHoldings_HoldingID",
                        column: x => x.HoldingID,
                        principalTable: "PlantHoldings",
                        principalColumn: "HoldingID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "AspNetRoles",
                columns: new[] { "Id", "ConcurrencyStamp", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "8920f4b6-7671-4c8b-9c5d-1f23fe76f236", "Staff", "STAFF" },
                    { "7f3d65e1-e472-4e90-8158-9d60b5b7d123", "55f53c36-8b15-4ef1-a7d2-94946c14c716", "Customer", "CUSTOMER" },
                    { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "79202516-5691-4c00-8fdc-5c472cc112a1", "Admin", "ADMIN" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "FirstName", "IsCustomer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "6aa33e39-8591-4bff-9001-bc58c0313c89", 0, "42a75722-9d32-4242-9eac-0d0c5a80e63a", null, "admin@example.com", true, "Admin", false, "User", false, null, "ADMIN@EXAMPLE.COM", "ADMIN@EXAMPLE.COM", "AQAAAAIAAYagAAAAELPDyn6G7TKxOvThBltjPcf3ieDXUmVaZlKK3Q4Qf3jTIgyCFjPXDSOixax8c/UHVg==", null, false, "JIRVGNRNQ7Z3TPFRS4YPFN5QVMPXQY2K", false, "admin@example.com" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustID", "CompanyName", "ContactFirstNames", "ContactSurname", "ContactTitle", "Email", "Fax", "Line1", "Line2", "Line3", "Line4", "Postcode", "Telephone" },
                values: new object[,]
                {
                    { 1, "Company B", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 2, "Company C", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 3, "Company D", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 4, "Company E", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 5, "Company F", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 6, "Company G", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 7, "Company H", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 8, "Company I", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 9, "Company J", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 10, "Company K", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 11, "Company L", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 12, "Company M", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 13, "Company N", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 14, "Company O", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 15, "Company P", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 16, "Company Q", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 17, "Company R", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 18, "Company S", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 19, "Company T", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 20, "Company U", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 21, "Company V", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 22, "Company W", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 23, "Company X", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 24, "Company Y", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 25, "Company Z", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 26, "Company A", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 27, "Company B", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 28, "Company C", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 29, "Company D", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 30, "Company E", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 31, "Company F", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 32, "Company G", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 33, "Company H", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 34, "Company I", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 35, "Company J", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 36, "Company K", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 37, "Company L", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 38, "Company M", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 39, "Company N", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 40, "Company O", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 41, "Company P", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 42, "Company Q", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 43, "Company R", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 44, "Company S", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 45, "Company T", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 46, "Company U", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 47, "Company V", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 48, "Company W", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 49, "Company X", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 50, "Company Y", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 51, "Company Z", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 52, "Company A", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 53, "Company B", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 54, "Company C", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 55, "Company D", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 56, "Company E", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 57, "Company F", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 58, "Company G", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 59, "Company H", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 60, "Company I", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 61, "Company J", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 62, "Company K", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 63, "Company L", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 64, "Company M", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 65, "Company N", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 66, "Company O", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 67, "Company P", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 68, "Company Q", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 69, "Company R", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 70, "Company S", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 71, "Company T", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 72, "Company U", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 73, "Company V", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 74, "Company W", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 75, "Company X", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 76, "Company Y", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 77, "Company Z", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 78, "Company A", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 79, "Company B", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 80, "Company C", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 81, "Company D", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 82, "Company E", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 83, "Company F", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 84, "Company G", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 85, "Company H", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 86, "Company I", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 87, "Company J", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 88, "Company K", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 89, "Company L", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 90, "Company M", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 91, "Company N", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 92, "Company O", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 93, "Company P", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 94, "Company Q", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 95, "Company R", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 96, "Company S", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 97, "Company T", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 98, "Company U", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 99, "Company V", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" },
                    { 100, "Company W", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "12345", "123-456-7890" }
                });

            migrationBuilder.InsertData(
                table: "Inspectors",
                columns: new[] { "InspectorID", "InspectorsName" },
                values: new object[,]
                {
                    { 1, "Allen Lee" },
                    { 2, "Aidan Lee" }
                });

            migrationBuilder.InsertData(
                table: "PlantCategories",
                columns: new[] { "CategoryID", "CategoryDescription" },
                values: new object[,]
                {
                    { 1, "Heavy Plant" },
                    { 2, "Small Plant" },
                    { 3, "Access Equipment" },
                    { 4, "Power Tools" },
                    { 5, "Safety Equipment" }
                });

            migrationBuilder.InsertData(
                table: "Status",
                columns: new[] { "StatusID", "StatusDescription" },
                values: new object[,]
                {
                    { 1, "Available" },
                    { 2, "In Use" },
                    { 3, "Under Maintenance" },
                    { 4, "Out of Service" },
                    { 5, "Reserved" }
                });

            migrationBuilder.InsertData(
                table: "Summaries",
                columns: new[] { "Id", "Description", "Title" },
                values: new object[,]
                {
                    { 1, "Freezing", null },
                    { 2, "Bracing", null },
                    { 3, "Chilly", null },
                    { 4, "Cool", null },
                    { 5, "Mild", null },
                    { 6, "Warm", null },
                    { 7, "Balmy", null },
                    { 8, "Hot", null },
                    { 9, "Sweltering", null },
                    { 10, "Scorching", null }
                });

            migrationBuilder.InsertData(
                table: "AllPlant",
                columns: new[] { "PlantNameID", "NormalPrice", "PlantCategory", "PlantDescription" },
                values: new object[,]
                {
                    { 1, "150.00", 1, "Excavator 2T" },
                    { 2, "95.00", 3, "Scissor Lift" },
                    { 3, "45.00", 2, "Concrete Mixer" },
                    { 4, "25.00", 4, "Power Drill" },
                    { 5, "15.00", 5, "Safety Harness" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUserClaims",
                columns: new[] { "Id", "ClaimType", "ClaimValue", "UserId" },
                values: new object[] { 1, "IsCustomer", "False", "6aa33e39-8591-4bff-9001-bc58c0313c89" });

            migrationBuilder.InsertData(
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { "64f2f5e1-e472-4e90-8158-9d60b5b7d0fe", "6aa33e39-8591-4bff-9001-bc58c0313c89" },
                    { "d4b74547-1385-4c44-88ab-1b3dd647be9c", "6aa33e39-8591-4bff-9001-bc58c0313c89" }
                });

            migrationBuilder.InsertData(
                table: "PlantHoldings",
                columns: new[] { "HoldingID", "CustID", "InspectionFee", "InspectionFrequency", "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[,]
                {
                    { 1, 1, null, 12, 4, "Standard", "FESGJ0SG1I", 2 },
                    { 2, 2, null, 12, 3, "Standard", "LNJSB3UOFD", 4 },
                    { 3, 3, null, 12, 5, "Standard", "TBZF6YSGBL", 3 },
                    { 4, 4, null, 12, 5, "Standard", "AT20NFAB2W", 1 },
                    { 5, 5, null, 12, 2, "Standard", "1KXFBVSBPZ", 4 },
                    { 6, 6, null, 12, 2, "Standard", "ANJCZCQA2P", 3 },
                    { 7, 7, null, 12, 3, "Standard", "A3AACXB67Q", 2 },
                    { 8, 8, null, 12, 4, "Standard", "BNFP2TOK6V", 4 },
                    { 9, 9, null, 12, 1, "Standard", "58LZFDQL1F", 1 },
                    { 10, 10, null, 12, 2, "Standard", "VS91YZKT9X", 1 },
                    { 11, 11, null, 12, 2, "Standard", "7AHJBHVPD9", 1 },
                    { 12, 12, null, 12, 1, "Standard", "LL13AB46I7", 5 },
                    { 13, 13, null, 12, 2, "Standard", "TWWGKGBI79", 4 },
                    { 14, 14, null, 12, 1, "Standard", "5GKUUZEVO5", 3 },
                    { 15, 15, null, 12, 2, "Standard", "8QT83EDAG7", 4 },
                    { 16, 16, null, 12, 3, "Standard", "VOE686GMTW", 5 },
                    { 17, 17, null, 12, 5, "Standard", "0KMS2I5XGJ", 2 },
                    { 18, 18, null, 12, 5, "Standard", "XCP25287Q6", 5 },
                    { 19, 19, null, 12, 1, "Standard", "VHWSZD3MSZ", 2 },
                    { 20, 20, null, 12, 3, "Standard", "2UH7BCHLGK", 2 },
                    { 21, 21, null, 12, 5, "Standard", "QNQ1X9M4LG", 5 },
                    { 22, 22, null, 12, 3, "Standard", "WN8CQ5L756", 1 },
                    { 23, 23, null, 12, 2, "Standard", "UA6OYX9K71", 1 },
                    { 24, 24, null, 12, 2, "Standard", "XBYSNMHVXV", 2 },
                    { 25, 25, null, 12, 4, "Standard", "DE4K9MAUMF", 1 },
                    { 26, 26, null, 12, 4, "Standard", "D8GXHXX4MW", 3 },
                    { 27, 27, null, 12, 3, "Standard", "H2TTYOX9ZI", 2 },
                    { 28, 28, null, 12, 3, "Standard", "3YLV1Q9S4B", 3 },
                    { 29, 29, null, 12, 3, "Standard", "FUOA8QLRZO", 1 },
                    { 30, 30, null, 12, 1, "Standard", "2Q67SH85WX", 5 },
                    { 31, 31, null, 12, 3, "Standard", "LCD6W7UFNE", 2 },
                    { 32, 32, null, 12, 1, "Standard", "AXAI633OVE", 4 },
                    { 33, 33, null, 12, 2, "Standard", "TBAXDT2SZ6", 4 },
                    { 34, 34, null, 12, 5, "Standard", "MO42473XD2", 5 },
                    { 35, 35, null, 12, 5, "Standard", "GZ833P6HJ3", 2 },
                    { 36, 36, null, 12, 3, "Standard", "77C4M4OD9E", 5 },
                    { 37, 37, null, 12, 3, "Standard", "8BTXLEH0EF", 3 },
                    { 38, 38, null, 12, 2, "Standard", "U9ZJ9RWTBK", 5 },
                    { 39, 39, null, 12, 5, "Standard", "58LIO35B3Q", 5 },
                    { 40, 40, null, 12, 4, "Standard", "6J5FWWQ1QY", 2 },
                    { 41, 41, null, 12, 2, "Standard", "FEDRSMQYFW", 4 },
                    { 42, 42, null, 12, 2, "Standard", "38MKKOTDF7", 2 },
                    { 43, 43, null, 12, 4, "Standard", "VR6P3ERHY8", 1 },
                    { 44, 44, null, 12, 2, "Standard", "ZNTR9FWJRS", 2 },
                    { 45, 45, null, 12, 4, "Standard", "JGRBEGIH0N", 5 },
                    { 46, 46, null, 12, 1, "Standard", "PB5BFUY55B", 3 },
                    { 47, 47, null, 12, 5, "Standard", "5CE9KEJCFI", 1 },
                    { 48, 48, null, 12, 4, "Standard", "WPCS05UMRS", 1 },
                    { 49, 49, null, 12, 5, "Standard", "KVD64Q2IWU", 1 },
                    { 50, 50, null, 12, 1, "Standard", "BI7VD35G5H", 3 },
                    { 51, 51, null, 12, 4, "Standard", "RFF9RHOMBG", 4 },
                    { 52, 52, null, 12, 4, "Standard", "ANIYQ7BBJB", 3 },
                    { 53, 53, null, 12, 3, "Standard", "88JYW4CCGN", 3 },
                    { 54, 54, null, 12, 4, "Standard", "L31OF3A5TH", 3 },
                    { 55, 55, null, 12, 4, "Standard", "VG08GNRQZX", 1 },
                    { 56, 56, null, 12, 3, "Standard", "800HEWTW8T", 2 },
                    { 57, 57, null, 12, 4, "Standard", "GW5PAV81NT", 1 },
                    { 58, 58, null, 12, 3, "Standard", "DD62689X3I", 3 },
                    { 59, 59, null, 12, 3, "Standard", "C317Y82B3E", 4 },
                    { 60, 60, null, 12, 3, "Standard", "RBPDZIEOXL", 1 },
                    { 61, 61, null, 12, 1, "Standard", "Z009TZ37GQ", 2 },
                    { 62, 62, null, 12, 2, "Standard", "4BDP1BV9LN", 2 },
                    { 63, 63, null, 12, 5, "Standard", "S58UDB11Z0", 2 },
                    { 64, 64, null, 12, 5, "Standard", "I2SDL5NBYH", 2 },
                    { 65, 65, null, 12, 4, "Standard", "FZXWZEZMP4", 3 },
                    { 66, 66, null, 12, 4, "Standard", "0I3EYVSD3F", 1 },
                    { 67, 67, null, 12, 5, "Standard", "SRYQ9JHLVK", 3 },
                    { 68, 68, null, 12, 2, "Standard", "NFCVB4SNL4", 2 },
                    { 69, 69, null, 12, 1, "Standard", "BIMDZG49TZ", 1 },
                    { 70, 70, null, 12, 2, "Standard", "QJMFXFCQ3P", 4 },
                    { 71, 71, null, 12, 3, "Standard", "T6B9X2XYEV", 3 },
                    { 72, 72, null, 12, 4, "Standard", "7EVPQP4YC4", 1 },
                    { 73, 73, null, 12, 4, "Standard", "RM0F26IVR3", 3 },
                    { 74, 74, null, 12, 4, "Standard", "F5M0BOC44V", 2 },
                    { 75, 75, null, 12, 3, "Standard", "UXAOVCQY1J", 3 },
                    { 76, 76, null, 12, 2, "Standard", "CS6IM2KDU3", 2 },
                    { 77, 77, null, 12, 3, "Standard", "CEXX2K76EG", 3 },
                    { 78, 78, null, 12, 1, "Standard", "63AON5A6NB", 4 },
                    { 79, 79, null, 12, 3, "Standard", "S4RCKE90NP", 2 },
                    { 80, 80, null, 12, 3, "Standard", "P35QLUF571", 2 },
                    { 81, 81, null, 12, 3, "Standard", "160Y2NHAQE", 1 },
                    { 82, 82, null, 12, 5, "Standard", "35WAH41QRU", 5 },
                    { 83, 83, null, 12, 3, "Standard", "AUU362V0R8", 2 },
                    { 84, 84, null, 12, 2, "Standard", "NL89HLALX7", 4 },
                    { 85, 85, null, 12, 3, "Standard", "8FYCA5BH7G", 4 },
                    { 86, 86, null, 12, 2, "Standard", "2NEYSPQ4VI", 4 },
                    { 87, 87, null, 12, 5, "Standard", "51JGTX6C6F", 5 },
                    { 88, 88, null, 12, 4, "Standard", "DS0W7CQHX0", 1 },
                    { 89, 89, null, 12, 5, "Standard", "HM2IQ24ZS2", 2 },
                    { 90, 90, null, 12, 2, "Standard", "W4XJKVLXSN", 3 },
                    { 91, 91, null, 12, 5, "Standard", "Y47S1PIEVP", 5 },
                    { 92, 92, null, 12, 2, "Standard", "5YVDLFIKLS", 5 },
                    { 93, 93, null, 12, 1, "Standard", "PG7BPTL412", 3 },
                    { 94, 94, null, 12, 4, "Standard", "5M8DTCWH5Q", 3 },
                    { 95, 95, null, 12, 4, "Standard", "9HMNEJYG45", 1 },
                    { 96, 96, null, 12, 3, "Standard", "RGZBDFQCE9", 2 },
                    { 97, 97, null, 12, 5, "Standard", "GE1I52G81L", 1 },
                    { 98, 98, null, 12, 2, "Standard", "H8ZREN1AJN", 4 },
                    { 99, 99, null, 12, 2, "Standard", "NVD0AMRA8N", 1 },
                    { 100, 100, null, 12, 5, "Standard", "SPKCYE2GEQ", 5 }
                });

            migrationBuilder.InsertData(
                table: "Inspections",
                columns: new[] { "UniqueRef", "Defects", "HoldingID", "InspectionDate", "InspectorID", "LatestDate", "Location", "MiscNotes", "PreviousCheck", "RecentCheck", "Rectified", "SafeWorking", "TestDetails" },
                values: new object[,]
                {
                    { 1, "None", 1, new DateTime(2025, 4, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 1", "Annual inspection for plant holding 1", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 2, "None", 2, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 6, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 2", "Annual inspection for plant holding 2", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 3, "None", 3, new DateTime(2025, 3, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 3", "Annual inspection for plant holding 3", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 4, "None", 4, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 11, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 4", "Annual inspection for plant holding 4", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 5, "None", 5, new DateTime(2025, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 5", "Annual inspection for plant holding 5", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 6, "None", 6, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 6, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 6", "Annual inspection for plant holding 6", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 7, "None", 7, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 7", "Annual inspection for plant holding 7", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 8, "None", 8, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 8", "Annual inspection for plant holding 8", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 9, "None", 9, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 9", "Annual inspection for plant holding 9", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 10, "None", 10, new DateTime(2025, 2, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 10", "Annual inspection for plant holding 10", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 11, "None", 11, new DateTime(2024, 12, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 11", "Annual inspection for plant holding 11", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 12, "None", 12, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 12", "Annual inspection for plant holding 12", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 13, "None", 13, new DateTime(2025, 5, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 13", "Annual inspection for plant holding 13", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 14, "None", 14, new DateTime(2024, 8, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 14", "Annual inspection for plant holding 14", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 15, "None", 15, new DateTime(2025, 1, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 15", "Annual inspection for plant holding 15", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 16, "None", 16, new DateTime(2024, 12, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 11, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 16", "Annual inspection for plant holding 16", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 17, "None", 17, new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 17", "Annual inspection for plant holding 17", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 18, "None", 18, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 18", "Annual inspection for plant holding 18", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 19, "None", 19, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 19", "Annual inspection for plant holding 19", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 20, "None", 20, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 6, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 20", "Annual inspection for plant holding 20", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 21, "None", 21, new DateTime(2024, 12, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 12, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 21", "Annual inspection for plant holding 21", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 22, "None", 22, new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 22", "Annual inspection for plant holding 22", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 23, "None", 23, new DateTime(2024, 6, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 23", "Annual inspection for plant holding 23", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 24, "None", 24, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 24", "Annual inspection for plant holding 24", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 25, "None", 25, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 25", "Annual inspection for plant holding 25", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 26, "None", 26, new DateTime(2025, 3, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 26", "Annual inspection for plant holding 26", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 27, "None", 27, new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 27", "Annual inspection for plant holding 27", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 28, "None", 28, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 28", "Annual inspection for plant holding 28", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 29, "None", 29, new DateTime(2025, 3, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 29", "Annual inspection for plant holding 29", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 30, "None", 30, new DateTime(2024, 9, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 30", "Annual inspection for plant holding 30", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 31, "None", 31, new DateTime(2024, 11, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 31", "Annual inspection for plant holding 31", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 32, "None", 32, new DateTime(2025, 4, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 32", "Annual inspection for plant holding 32", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 33, "None", 33, new DateTime(2025, 5, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 33", "Annual inspection for plant holding 33", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 34, "None", 34, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 6, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 34", "Annual inspection for plant holding 34", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 35, "None", 35, new DateTime(2024, 10, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 35", "Annual inspection for plant holding 35", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 36, "None", 36, new DateTime(2025, 1, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 36", "Annual inspection for plant holding 36", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 37, "None", 37, new DateTime(2024, 9, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 37", "Annual inspection for plant holding 37", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 38, "None", 38, new DateTime(2024, 12, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 38", "Annual inspection for plant holding 38", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 39, "None", 39, new DateTime(2024, 11, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 39", "Annual inspection for plant holding 39", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 40, "None", 40, new DateTime(2024, 10, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 40", "Annual inspection for plant holding 40", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 41, "None", 41, new DateTime(2025, 5, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 41", "Annual inspection for plant holding 41", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 42, "None", 42, new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 42", "Annual inspection for plant holding 42", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 43, "None", 43, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 43", "Annual inspection for plant holding 43", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 44, "None", 44, new DateTime(2024, 9, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 44", "Annual inspection for plant holding 44", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 45, "None", 45, new DateTime(2024, 7, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 45", "Annual inspection for plant holding 45", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 46, "None", 46, new DateTime(2024, 10, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 11, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 46", "Annual inspection for plant holding 46", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 47, "None", 47, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 47", "Annual inspection for plant holding 47", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 48, "None", 48, new DateTime(2025, 2, 2, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 3, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 48", "Annual inspection for plant holding 48", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 49, "None", 49, new DateTime(2024, 11, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 49", "Annual inspection for plant holding 49", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 50, "None", 50, new DateTime(2025, 4, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 50", "Annual inspection for plant holding 50", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 51, "None", 51, new DateTime(2025, 5, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 51", "Annual inspection for plant holding 51", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 52, "None", 52, new DateTime(2025, 1, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 52", "Annual inspection for plant holding 52", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 53, "None", 53, new DateTime(2024, 9, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 17, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 53", "Annual inspection for plant holding 53", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 54, "None", 54, new DateTime(2025, 1, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 54", "Annual inspection for plant holding 54", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 55, "None", 55, new DateTime(2024, 8, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 55", "Annual inspection for plant holding 55", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 56, "None", 56, new DateTime(2024, 9, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 9, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 56", "Annual inspection for plant holding 56", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 57, "None", 57, new DateTime(2024, 11, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 57", "Annual inspection for plant holding 57", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 58, "None", 58, new DateTime(2024, 8, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 58", "Annual inspection for plant holding 58", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 59, "None", 59, new DateTime(2025, 3, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 59", "Annual inspection for plant holding 59", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 60, "None", 60, new DateTime(2024, 8, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 60", "Annual inspection for plant holding 60", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 61, "None", 61, new DateTime(2024, 6, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 61", "Annual inspection for plant holding 61", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 62, "None", 62, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 62", "Annual inspection for plant holding 62", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 63, "None", 63, new DateTime(2025, 4, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 4, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 63", "Annual inspection for plant holding 63", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 64, "None", 64, new DateTime(2025, 3, 8, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 3, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 64", "Annual inspection for plant holding 64", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 65, "None", 65, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 12, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 65", "Annual inspection for plant holding 65", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 66, "None", 66, new DateTime(2024, 12, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 12, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 66", "Annual inspection for plant holding 66", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 67, "None", 67, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 67", "Annual inspection for plant holding 67", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 68, "None", 68, new DateTime(2024, 10, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 68", "Annual inspection for plant holding 68", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 69, "None", 69, new DateTime(2024, 9, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 9, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 69", "Annual inspection for plant holding 69", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 70, "None", 70, new DateTime(2024, 7, 28, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 7, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 70", "Annual inspection for plant holding 70", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 71, "None", 71, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 71", "Annual inspection for plant holding 71", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 72, "None", 72, new DateTime(2025, 4, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 4, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 72", "Annual inspection for plant holding 72", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 73, "None", 73, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 73", "Annual inspection for plant holding 73", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 74, "None", 74, new DateTime(2025, 5, 16, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 6, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 74", "Annual inspection for plant holding 74", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 75, "None", 75, new DateTime(2025, 1, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 75", "Annual inspection for plant holding 75", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 76, "None", 76, new DateTime(2025, 2, 21, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 76", "Annual inspection for plant holding 76", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 77, "None", 77, new DateTime(2025, 5, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 77", "Annual inspection for plant holding 77", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 78, "None", 78, new DateTime(2025, 2, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 9, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 78", "Annual inspection for plant holding 78", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 79, "None", 79, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 31, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 79", "Annual inspection for plant holding 79", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 80, "None", 80, new DateTime(2024, 9, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 9, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 80", "Annual inspection for plant holding 80", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 81, "None", 81, new DateTime(2024, 6, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 6, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 81", "Annual inspection for plant holding 81", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 82, "None", 82, new DateTime(2024, 10, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 10, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 82", "Annual inspection for plant holding 82", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 83, "None", 83, new DateTime(2025, 2, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 83", "Annual inspection for plant holding 83", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 84, "None", 84, new DateTime(2025, 3, 19, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 3, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 84", "Annual inspection for plant holding 84", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 85, "None", 85, new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 85", "Annual inspection for plant holding 85", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 86, "None", 86, new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 11, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 86", "Annual inspection for plant holding 86", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 87, "None", 87, new DateTime(2024, 11, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 11, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 87", "Annual inspection for plant holding 87", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 88, "None", 88, new DateTime(2025, 2, 7, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 88", "Annual inspection for plant holding 88", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 89, "None", 89, new DateTime(2025, 5, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 89", "Annual inspection for plant holding 89", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 90, "None", 90, new DateTime(2025, 3, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 90", "Annual inspection for plant holding 90", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 91, "None", 91, new DateTime(2024, 6, 25, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 7, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 91", "Annual inspection for plant holding 91", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 92, "None", 92, new DateTime(2024, 6, 29, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 6, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 92", "Annual inspection for plant holding 92", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 93, "None", 93, new DateTime(2024, 10, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 10, 27, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 93", "Annual inspection for plant holding 93", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 94, "None", 94, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 5, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 94", "Annual inspection for plant holding 94", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 95, "None", 95, new DateTime(2025, 2, 6, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 2, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 95", "Annual inspection for plant holding 95", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 96, "None", 96, new DateTime(2024, 7, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 7, 23, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 96", "Annual inspection for plant holding 96", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 97, "None", 97, new DateTime(2024, 12, 24, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 12, 30, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 97", "Annual inspection for plant holding 97", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 98, "None", 98, new DateTime(2024, 8, 26, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 8, 13, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 98", "Annual inspection for plant holding 98", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 99, "None", 99, new DateTime(2024, 12, 14, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2024, 12, 18, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 99", "Annual inspection for plant holding 99", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 100, "None", 100, new DateTime(2024, 6, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2024, 6, 22, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 100", "Annual inspection for plant holding 100", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_AllPlant_PlantCategory",
                table: "AllPlant",
                column: "PlantCategory");

            migrationBuilder.CreateIndex(
                name: "IX_AllPlant_PlantDescription",
                table: "AllPlant",
                column: "PlantDescription",
                unique: true,
                filter: "[PlantDescription] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetRoleClaims_RoleId",
                table: "AspNetRoleClaims",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "RoleNameIndex",
                table: "AspNetRoles",
                column: "NormalizedName",
                unique: true,
                filter: "[NormalizedName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserClaims_UserId",
                table: "AspNetUserClaims",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserLogins_UserId",
                table: "AspNetUserLogins",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_AspNetUserRoles_RoleId",
                table: "AspNetUserRoles",
                column: "RoleId");

            migrationBuilder.CreateIndex(
                name: "EmailIndex",
                table: "AspNetUsers",
                column: "NormalizedEmail");

            migrationBuilder.CreateIndex(
                name: "UserNameIndex",
                table: "AspNetUsers",
                column: "NormalizedUserName",
                unique: true,
                filter: "[NormalizedUserName] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_HoldingID",
                table: "Inspections",
                column: "HoldingID");

            migrationBuilder.CreateIndex(
                name: "IX_Inspections_InspectorID",
                table: "Inspections",
                column: "InspectorID");

            migrationBuilder.CreateIndex(
                name: "IX_Notes_CustID",
                table: "Notes",
                column: "CustID");

            migrationBuilder.CreateIndex(
                name: "IX_PlantHoldings_CustID",
                table: "PlantHoldings",
                column: "CustID");

            migrationBuilder.CreateIndex(
                name: "IX_PlantHoldings_PlantNameID",
                table: "PlantHoldings",
                column: "PlantNameID");

            migrationBuilder.CreateIndex(
                name: "IX_PlantHoldings_StatusID",
                table: "PlantHoldings",
                column: "StatusID");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AspNetRoleClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserClaims");

            migrationBuilder.DropTable(
                name: "AspNetUserLogins");

            migrationBuilder.DropTable(
                name: "AspNetUserRoles");

            migrationBuilder.DropTable(
                name: "AspNetUserTokens");

            migrationBuilder.DropTable(
                name: "Inspections");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "Summaries");

            migrationBuilder.DropTable(
                name: "AspNetRoles");

            migrationBuilder.DropTable(
                name: "AspNetUsers");

            migrationBuilder.DropTable(
                name: "Inspectors");

            migrationBuilder.DropTable(
                name: "PlantHoldings");

            migrationBuilder.DropTable(
                name: "AllPlant");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Status");

            migrationBuilder.DropTable(
                name: "PlantCategories");
        }
    }
}
