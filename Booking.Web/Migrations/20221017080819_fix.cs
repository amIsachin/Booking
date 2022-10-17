using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Web.Migrations
{
    public partial class fix : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "DriverID",
                table: "Droped");

            migrationBuilder.DropColumn(
                name: "RiderID",
                table: "Droped");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<long>(
                name: "DriverID",
                table: "Droped",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);

            migrationBuilder.AddColumn<long>(
                name: "RiderID",
                table: "Droped",
                type: "bigint",
                nullable: false,
                defaultValue: 0L);
        }
    }
}
