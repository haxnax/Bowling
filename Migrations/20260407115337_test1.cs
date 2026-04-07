using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bowling.Migrations
{
    /// <inheritdoc />
    public partial class test1 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_Customersid",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "id",
                table: "Customers",
                newName: "Id");

            migrationBuilder.RenameColumn(
                name: "name",
                table: "Customers",
                newName: "CustomerName");

            migrationBuilder.RenameColumn(
                name: "Customersid",
                table: "Bookings",
                newName: "CustomersId");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_Customersid",
                table: "Bookings",
                newName: "IX_Bookings_CustomersId");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_CustomersId",
                table: "Bookings",
                column: "CustomersId",
                principalTable: "Customers",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Bookings_Customers_CustomersId",
                table: "Bookings");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "Customers",
                newName: "id");

            migrationBuilder.RenameColumn(
                name: "CustomerName",
                table: "Customers",
                newName: "name");

            migrationBuilder.RenameColumn(
                name: "CustomersId",
                table: "Bookings",
                newName: "Customersid");

            migrationBuilder.RenameIndex(
                name: "IX_Bookings_CustomersId",
                table: "Bookings",
                newName: "IX_Bookings_Customersid");

            migrationBuilder.AddForeignKey(
                name: "FK_Bookings_Customers_Customersid",
                table: "Bookings",
                column: "Customersid",
                principalTable: "Customers",
                principalColumn: "id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
