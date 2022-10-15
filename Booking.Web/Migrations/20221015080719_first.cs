using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Web.Migrations
{
    public partial class first : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Drivers",
                columns: table => new
                {
                    Driver_ID = table.Column<long>(type: "bigint", nullable: false),
                    Age = table.Column<byte>(type: "tinyint", nullable: false),
                    DrivingLicence = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Drivers", x => x.Driver_ID);
                });

            migrationBuilder.CreateTable(
                name: "Riders",
                columns: table => new
                {
                    Rider_ID = table.Column<long>(type: "bigint", nullable: false),
                    Created = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CreatedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    LastModified = table.Column<DateTime>(type: "datetime2", nullable: false),
                    LastModifiedBy = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    PhoneNumber = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ImageUrl = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Riders", x => x.Rider_ID);
                });

            migrationBuilder.CreateTable(
                name: "Droped",
                columns: table => new
                {
                    Droped_ID = table.Column<long>(type: "bigint", nullable: false),
                    DriverID = table.Column<long>(type: "bigint", nullable: false),
                    RiderID = table.Column<long>(type: "bigint", nullable: false),
                    DriverSystemEntityDriver_ID = table.Column<long>(type: "bigint", nullable: true),
                    RiderSystemEntityRider_ID = table.Column<long>(type: "bigint", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Droped", x => x.Droped_ID);
                    table.ForeignKey(
                        name: "FK_Droped_Drivers_DriverSystemEntityDriver_ID",
                        column: x => x.DriverSystemEntityDriver_ID,
                        principalTable: "Drivers",
                        principalColumn: "Driver_ID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Droped_Riders_RiderSystemEntityRider_ID",
                        column: x => x.RiderSystemEntityRider_ID,
                        principalTable: "Riders",
                        principalColumn: "Rider_ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Droped_DriverSystemEntityDriver_ID",
                table: "Droped",
                column: "DriverSystemEntityDriver_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Droped_RiderSystemEntityRider_ID",
                table: "Droped",
                column: "RiderSystemEntityRider_ID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Droped");

            migrationBuilder.DropTable(
                name: "Drivers");

            migrationBuilder.DropTable(
                name: "Riders");
        }
    }
}
