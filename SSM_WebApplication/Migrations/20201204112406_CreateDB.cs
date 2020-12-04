using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SSM_WebApplication.Migrations
{
    public partial class CreateDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    CustomerId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Company = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ICE = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ContactName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.CustomerId);
                });

            migrationBuilder.CreateTable(
                name: "Fuels",
                columns: table => new
                {
                    FuelId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FuelName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    FuelPrice = table.Column<float>(type: "real", nullable: false),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Fuels", x => x.FuelId);
                });

            migrationBuilder.CreateTable(
                name: "JobTitles",
                columns: table => new
                {
                    JobId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    JobName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobTitles", x => x.JobId);
                });

            migrationBuilder.CreateTable(
                name: "PaymentTypes",
                columns: table => new
                {
                    PaymentTypeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PaymentTypeName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ShortDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PaymentTypes", x => x.PaymentTypeId);
                });

            migrationBuilder.CreateTable(
                name: "Pumps",
                columns: table => new
                {
                    PumpId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PumpName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PumpDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pumps", x => x.PumpId);
                });

            migrationBuilder.CreateTable(
                name: "FuelPrices",
                columns: table => new
                {
                    FuelPriceId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Price = table.Column<float>(type: "real", nullable: false),
                    Comment = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_FuelPrices", x => x.FuelPriceId);
                    table.ForeignKey(
                        name: "FK_FuelPrices_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "FuelId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Employees",
                columns: table => new
                {
                    EmployeeId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Adresse2 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Tel1 = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    HiringDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    JobId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Employees", x => x.EmployeeId);
                    table.ForeignKey(
                        name: "FK_Employees_JobTitles_JobId",
                        column: x => x.JobId,
                        principalTable: "JobTitles",
                        principalColumn: "JobId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Distributors",
                columns: table => new
                {
                    DistributorId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DistributorName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DistributorDescription = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AddDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Status = table.Column<bool>(type: "bit", nullable: false),
                    FuelId = table.Column<int>(type: "int", nullable: false),
                    PumpId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Distributors", x => x.DistributorId);
                    table.ForeignKey(
                        name: "FK_Distributors_Fuels_FuelId",
                        column: x => x.FuelId,
                        principalTable: "Fuels",
                        principalColumn: "FuelId",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Distributors_Pumps_PumpId",
                        column: x => x.PumpId,
                        principalTable: "Pumps",
                        principalColumn: "PumpId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Customers",
                columns: new[] { "CustomerId", "AddDate", "Adresse1", "Adresse2", "City", "Company", "ContactName", "Email", "FirstName", "ICE", "LastName", "Status", "Tel1", "Tel2" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 4, 12, 24, 5, 100, DateTimeKind.Local).AddTicks(4824), "adresse 1", "adresse 2", "city 1", "company 1", "contact name 1", "email 1", "name 1", "ice1", " name 1", true, "tel 1", "tel 2" },
                    { 2, new DateTime(2020, 12, 4, 12, 24, 5, 100, DateTimeKind.Local).AddTicks(5761), "adresse 2", "adresse 2", "city 2", "company 2", "contact name ", "email 2", "name 2", "ice2", " name 2", true, "tel 2", "tel 2" },
                    { 3, new DateTime(2020, 12, 4, 12, 24, 5, 100, DateTimeKind.Local).AddTicks(5820), "adresse 1", "adresse 2", "city 1", null, "", "email 1", "name 1", null, " name 1", true, "tel 1", "tel 2" }
                });

            migrationBuilder.InsertData(
                table: "Fuels",
                columns: new[] { "FuelId", "AddDate", "FuelName", "FuelPrice", "ShortDescription", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 4, 12, 24, 5, 85, DateTimeKind.Local).AddTicks(6465), "Gasoil", 10f, "d1", true },
                    { 2, new DateTime(2020, 12, 4, 12, 24, 5, 94, DateTimeKind.Local).AddTicks(5891), "Super Sans Plombe", 20f, "d2", true },
                    { 3, new DateTime(2020, 12, 4, 12, 24, 5, 94, DateTimeKind.Local).AddTicks(6288), "Excellium", 11f, "d3", false }
                });

            migrationBuilder.InsertData(
                table: "JobTitles",
                columns: new[] { "JobId", "AddDate", "JobName", "ShortDescription", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 12, 0, 0, 0, 0, DateTimeKind.Unspecified), "J1", "Job 1", false },
                    { 2, new DateTime(2020, 11, 11, 0, 0, 0, 0, DateTimeKind.Unspecified), "J2", "Job 2", false },
                    { 3, new DateTime(2020, 2, 10, 0, 0, 0, 0, DateTimeKind.Unspecified), "J3", "Job 3", false }
                });

            migrationBuilder.InsertData(
                table: "Pumps",
                columns: new[] { "PumpId", "AddDate", "PumpDescription", "PumpName", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 4, 12, 24, 5, 95, DateTimeKind.Local).AddTicks(1949), "Pompe 1", "P1", true },
                    { 2, new DateTime(2020, 12, 4, 12, 24, 5, 95, DateTimeKind.Local).AddTicks(4971), "Pompe 2", "P2", true },
                    { 3, new DateTime(2020, 12, 4, 12, 24, 5, 95, DateTimeKind.Local).AddTicks(5176), "Pompe 3", "P3", true },
                    { 4, new DateTime(2020, 12, 4, 12, 24, 5, 95, DateTimeKind.Local).AddTicks(5242), "Pompe 4", "P4", true }
                });

            migrationBuilder.InsertData(
                table: "Distributors",
                columns: new[] { "DistributorId", "AddDate", "DistributorDescription", "DistributorName", "FuelId", "PumpId", "Status" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 11, 15, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 1", "d1", 2, 1, true },
                    { 2, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 2", "d2", 2, 1, false },
                    { 3, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 3", "d3", 1, 2, false },
                    { 4, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 4", "d4", 3, 2, false },
                    { 5, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 5", "d5", 1, 3, false },
                    { 6, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 6", "d6", 3, 3, false },
                    { 7, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 7", "d7", 2, 4, false },
                    { 8, new DateTime(2020, 10, 20, 0, 0, 0, 0, DateTimeKind.Unspecified), "Pistolet 8", "d8", 1, 4, false }
                });

            migrationBuilder.InsertData(
                table: "Employees",
                columns: new[] { "EmployeeId", "Adresse1", "Adresse2", "City", "Email", "FirstName", "HiringDate", "JobId", "LastName", "Status", "Tel1" },
                values: new object[,]
                {
                    { 1, "adresse 1", "adresse 2", "city 1", "email 1", "name 1", new DateTime(2020, 12, 4, 12, 24, 5, 101, DateTimeKind.Local).AddTicks(1477), 1, " name 1", true, "tel 1" },
                    { 2, "adresse 2", "adresse 2", "city 1", "email 1", "name 2", new DateTime(2020, 12, 4, 12, 24, 5, 101, DateTimeKind.Local).AddTicks(2924), 2, " name 2", true, "tel 1" }
                });

            migrationBuilder.InsertData(
                table: "FuelPrices",
                columns: new[] { "FuelPriceId", "AddDate", "Comment", "FuelId", "Price" },
                values: new object[,]
                {
                    { 1, new DateTime(2020, 12, 4, 12, 24, 5, 99, DateTimeKind.Local).AddTicks(5236), "Comment 1", 1, 10f },
                    { 2, new DateTime(2020, 12, 4, 12, 24, 5, 99, DateTimeKind.Local).AddTicks(6651), "Comment 2", 2, 20f },
                    { 3, new DateTime(2020, 12, 4, 12, 24, 5, 99, DateTimeKind.Local).AddTicks(6710), "Comment 3", 3, 11f }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_FuelId",
                table: "Distributors",
                column: "FuelId");

            migrationBuilder.CreateIndex(
                name: "IX_Distributors_PumpId",
                table: "Distributors",
                column: "PumpId");

            migrationBuilder.CreateIndex(
                name: "IX_Employees_JobId",
                table: "Employees",
                column: "JobId");

            migrationBuilder.CreateIndex(
                name: "IX_FuelPrices_FuelId",
                table: "FuelPrices",
                column: "FuelId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "Distributors");

            migrationBuilder.DropTable(
                name: "Employees");

            migrationBuilder.DropTable(
                name: "FuelPrices");

            migrationBuilder.DropTable(
                name: "PaymentTypes");

            migrationBuilder.DropTable(
                name: "Pumps");

            migrationBuilder.DropTable(
                name: "JobTitles");

            migrationBuilder.DropTable(
                name: "Fuels");
        }
    }
}
