using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace sky_webapi.Migrations
{
    /// <inheritdoc />
    public partial class FixedInitialMigration : Migration
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
                    CompanyName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ContactTitle = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    ContactFirstNames = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    ContactSurname = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Line1 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Line2 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Line3 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Line4 = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: true),
                    Postcode = table.Column<string>(type: "nvarchar(10)", maxLength: 10, nullable: false),
                    Telephone = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    Fax = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: true),
                    Email = table.Column<string>(type: "nvarchar(254)", maxLength: 254, nullable: true)
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
                name: "Ledgers",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    InvoiceDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CustomerName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    InvoiceRef = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    SubTotal = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    VAT = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Total = table.Column<decimal>(type: "decimal(18,2)", precision: 18, scale: 2, nullable: false),
                    Settled = table.Column<bool>(type: "bit", nullable: false),
                    ReferenceWithoutInitials = table.Column<string>(type: "nvarchar(450)", nullable: false, computedColumnSql: "CAST(SUBSTRING(InvoiceRef, CHARINDEX('/', InvoiceRef), LEN(InvoiceRef) - CHARINDEX('/', InvoiceRef) + 1) AS nvarchar(100))", stored: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Ledgers", x => x.Id);
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
                name: "RevokedTokens",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TokenId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    UserId = table.Column<string>(type: "nvarchar(450)", nullable: false),
                    RevokedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    ExpiresAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Reason = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    RevokedBy = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RevokedTokens", x => x.Id);
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

            migrationBuilder.CreateTable(
                name: "ScheduledInspections",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HoldingID = table.Column<int>(type: "int", nullable: false),
                    ScheduledDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Location = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Notes = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    InspectorID = table.Column<int>(type: "int", nullable: true),
                    IsCompleted = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ScheduledInspections", x => x.Id);
                    table.ForeignKey(
                        name: "FK_ScheduledInspections_Inspectors_InspectorID",
                        column: x => x.InspectorID,
                        principalTable: "Inspectors",
                        principalColumn: "InspectorID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_ScheduledInspections_PlantHoldings_HoldingID",
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
                    { "1", "00000000-0000-0000-0000-000000000001", "Administrator", "ADMINISTRATOR" },
                    { "2", "00000000-0000-0000-0000-000000000002", "User", "USER" }
                });

            migrationBuilder.InsertData(
                table: "AspNetUsers",
                columns: new[] { "Id", "AccessFailedCount", "ConcurrencyStamp", "CustomerId", "Email", "EmailConfirmed", "FirstName", "IsCustomer", "LastName", "LockoutEnabled", "LockoutEnd", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[] { "1", 0, "00000000-0000-0000-0000-000000000001", null, "admin@skyapp.com", true, null, false, null, false, null, "ADMIN@SKYAPP.COM", "ADMIN@SKYAPP.COM", "AQAAAAIAAYagAAAAELGL2lkp7s2nk8eQVUDtZFjZ5b+cL+Z2klExMBPkzOtqTiNn2Fr2tg++R5BVtS5rsQ==", null, false, "00000000-0000-0000-0000-000000000001", false, "admin@skyapp.com" });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustID", "CompanyName", "ContactFirstNames", "ContactSurname", "ContactTitle", "Email", "Fax", "Line1", "Line2", "Line3", "Line4", "Postcode", "Telephone" },
                values: new object[,]
                {
                    { 1, "Company A", "John", "Doe", "Mr.", "john.doe@companya.com", "123-456-7891", "123 Main St", "", "", "", "SO14 1KX", "123-456-7890" },
                    { 2, "Company B", "Jane", "Smith", "Ms.", "jane.smith@companyb.com", "123-456-7893", "456 Oak Ave", "", "", "", "PL4 6LU", "123-456-7892" },
                    { 3, "Company C", "Mike", "Johnson", "Mr.", "mike.johnson@companyc.com", "123-456-7895", "789 Pine Rd", "", "", "", "PO1 8VI", "123-456-7894" },
                    { 4, "Company D", "Sarah", "Williams", "Mrs.", "sarah.williams@companyd.com", "123-456-7897", "321 Elm St", "", "", "", "CT3 8AB", "123-456-7896" },
                    { 5, "Company E", "David", "Brown", "Mr.", "david.brown@companye.com", "123-456-7899", "654 Maple Dr", "", "", "", "TR2 7VM", "123-456-7898" },
                    { 6, "Company F", "Lisa", "Davis", "Ms.", "lisa.davis@companyf.com", "123-456-7801", "987 Cedar Ln", "", "", "", "SW1 5RZ", "123-456-7800" },
                    { 7, "Company G", "Robert", "Miller", "Mr.", "robert.miller@companyg.com", "123-456-7803", "147 Birch Way", "", "", "", "SW9 1JP", "123-456-7802" },
                    { 8, "Company H", "Jennifer", "Wilson", "Mrs.", "jennifer.wilson@companyh.com", "123-456-7805", "258 Spruce St", "", "", "", "SW2 9FA", "123-456-7804" },
                    { 9, "Company I", "Michael", "Moore", "Mr.", "michael.moore@companyi.com", "123-456-7807", "369 Willow Ave", "", "", "", "PO3 8UT", "123-456-7806" },
                    { 10, "Company J", "Amanda", "Taylor", "Ms.", "amanda.taylor@companyj.com", "123-456-7809", "741 Poplar Rd", "", "", "", "PL4 9DV", "123-456-7808" }
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
                table: "AspNetUserRoles",
                columns: new[] { "RoleId", "UserId" },
                values: new object[] { "1", "1" });

            migrationBuilder.InsertData(
                table: "PlantHoldings",
                columns: new[] { "HoldingID", "CustID", "InspectionFee", "InspectionFrequency", "PlantNameID", "SWL", "SerialNumber", "StatusID" },
                values: new object[,]
                {
                    { 1, 1, 105m, 12, 2, "500kg", "B2D4F6H8J0", 2 },
                    { 2, 2, 170m, 12, 3, "300kg", "C3E5G7I9K1", 3 },
                    { 3, 3, 110m, 12, 4, "N/A", "D4F6H8J0L2", 4 },
                    { 4, 4, 175m, 12, 5, "150kg", "E5G7I9K1M3", 5 },
                    { 5, 5, 115m, 12, 1, "2000kg", "F6H8J0L2N4", 1 },
                    { 6, 6, 180m, 12, 2, "500kg", "G7I9K1M3O5", 2 },
                    { 7, 7, 120m, 12, 3, "300kg", "H8J0L2N4P6", 3 },
                    { 8, 8, 185m, 12, 4, "N/A", "I9K1M3O5Q7", 4 },
                    { 9, 9, 125m, 12, 5, "150kg", "J0L2N4P6R8", 5 },
                    { 10, 10, 190m, 12, 1, "2000kg", "K1M3O5Q7S9", 1 }
                });

            migrationBuilder.InsertData(
                table: "Inspections",
                columns: new[] { "UniqueRef", "Defects", "HoldingID", "InspectionDate", "InspectorID", "LatestDate", "Location", "MiscNotes", "PreviousCheck", "RecentCheck", "Rectified", "SafeWorking", "TestDetails" },
                values: new object[,]
                {
                    { 1, "None", 1, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 5, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 1", "Annual inspection for plant holding 1", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 2, "None", 2, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 4, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 2", "Annual inspection for plant holding 2", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 3, "None", 3, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 3, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 3", "Annual inspection for plant holding 3", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 4, "None", 4, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 1, new DateTime(2025, 2, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 4", "Annual inspection for plant holding 4", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" },
                    { 5, "None", 5, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), 2, new DateTime(2025, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified), "Site 5", "Annual inspection for plant holding 5", "N/A", "Completed", "N/A", "Yes", "Standard inspection completed" }
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
                name: "IX_Ledgers_ReferenceWithoutInitials",
                table: "Ledgers",
                column: "ReferenceWithoutInitials",
                unique: true);

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

            migrationBuilder.CreateIndex(
                name: "IX_RevokedTokens_ExpiresAt",
                table: "RevokedTokens",
                column: "ExpiresAt");

            migrationBuilder.CreateIndex(
                name: "IX_RevokedTokens_TokenId",
                table: "RevokedTokens",
                column: "TokenId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_RevokedTokens_UserId",
                table: "RevokedTokens",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledInspections_HoldingID",
                table: "ScheduledInspections",
                column: "HoldingID");

            migrationBuilder.CreateIndex(
                name: "IX_ScheduledInspections_InspectorID",
                table: "ScheduledInspections",
                column: "InspectorID");
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
                name: "Ledgers");

            migrationBuilder.DropTable(
                name: "Notes");

            migrationBuilder.DropTable(
                name: "RevokedTokens");

            migrationBuilder.DropTable(
                name: "ScheduledInspections");

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
