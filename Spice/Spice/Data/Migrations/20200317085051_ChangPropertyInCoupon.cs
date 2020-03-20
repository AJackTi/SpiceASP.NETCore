using Microsoft.EntityFrameworkCore.Migrations;

namespace Spice.Data.Migrations
{
    public partial class ChangPropertyInCoupon : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "isActive",
                table: "Coupon",
                newName: "IsActive");

            migrationBuilder.RenameColumn(
                name: "Minimumamount",
                table: "Coupon",
                newName: "MinimumAmount");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "MinimumAmount",
                table: "Coupon",
                newName: "Minimumamount");

            migrationBuilder.RenameColumn(
                name: "IsActive",
                table: "Coupon",
                newName: "isActive");
        }
    }
}
