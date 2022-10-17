using Microsoft.EntityFrameworkCore.Migrations;

namespace Booking.Web.Migrations
{
    public partial class fixfirst1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Droped_Drivers_DriverSystemEntityDriver_ID",
                table: "Droped");

            migrationBuilder.DropForeignKey(
                name: "FK_Droped_Riders_RiderSystemEntityRider_ID",
                table: "Droped");

            migrationBuilder.DropIndex(
                name: "IX_Droped_DriverSystemEntityDriver_ID",
                table: "Droped");

            migrationBuilder.DropIndex(
                name: "IX_Droped_RiderSystemEntityRider_ID",
                table: "Droped");

            migrationBuilder.DropColumn(
                name: "DriverSystemEntityDriver_ID",
                table: "Droped");

            migrationBuilder.DropColumn(
                name: "RiderSystemEntityRider_ID",
                table: "Droped");

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

            migrationBuilder.CreateIndex(
                name: "IX_Droped_DriverID",
                table: "Droped",
                column: "DriverID");

            migrationBuilder.CreateIndex(
                name: "IX_Droped_RiderID",
                table: "Droped",
                column: "RiderID");

            migrationBuilder.AddForeignKey(
                name: "FK_Droped_Drivers_DriverID",
                table: "Droped",
                column: "DriverID",
                principalTable: "Drivers",
                principalColumn: "Driver_ID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Droped_Riders_RiderID",
                table: "Droped",
                column: "RiderID",
                principalTable: "Riders",
                principalColumn: "Rider_ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Droped_Drivers_DriverID",
                table: "Droped");

            migrationBuilder.DropForeignKey(
                name: "FK_Droped_Riders_RiderID",
                table: "Droped");

            migrationBuilder.DropIndex(
                name: "IX_Droped_DriverID",
                table: "Droped");

            migrationBuilder.DropIndex(
                name: "IX_Droped_RiderID",
                table: "Droped");

            migrationBuilder.DropColumn(
                name: "DriverID",
                table: "Droped");

            migrationBuilder.DropColumn(
                name: "RiderID",
                table: "Droped");

            migrationBuilder.AddColumn<long>(
                name: "DriverSystemEntityDriver_ID",
                table: "Droped",
                type: "bigint",
                nullable: true);

            migrationBuilder.AddColumn<long>(
                name: "RiderSystemEntityRider_ID",
                table: "Droped",
                type: "bigint",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Droped_DriverSystemEntityDriver_ID",
                table: "Droped",
                column: "DriverSystemEntityDriver_ID");

            migrationBuilder.CreateIndex(
                name: "IX_Droped_RiderSystemEntityRider_ID",
                table: "Droped",
                column: "RiderSystemEntityRider_ID");

            migrationBuilder.AddForeignKey(
                name: "FK_Droped_Drivers_DriverSystemEntityDriver_ID",
                table: "Droped",
                column: "DriverSystemEntityDriver_ID",
                principalTable: "Drivers",
                principalColumn: "Driver_ID",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_Droped_Riders_RiderSystemEntityRider_ID",
                table: "Droped",
                column: "RiderSystemEntityRider_ID",
                principalTable: "Riders",
                principalColumn: "Rider_ID",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
