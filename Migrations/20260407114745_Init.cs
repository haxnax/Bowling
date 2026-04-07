using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bowling.Migrations
{
    /// <inheritdoc />
    public partial class Init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "BowlingHalls",
                columns: table => new
                {
                    BowlingHallId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BowlingHallName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Street = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlingHalls", x => x.BowlingHallId);
                });

            migrationBuilder.CreateTable(
                name: "Customers",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BookingCount = table.Column<int>(type: "int", nullable: false),
                    IsMember = table.Column<bool>(type: "bit", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Customers", x => x.id);
                });

            migrationBuilder.CreateTable(
                name: "BowlingLanes",
                columns: table => new
                {
                    BowlingLaneId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IsAvailable = table.Column<bool>(type: "bit", nullable: false),
                    BowlingHallId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_BowlingLanes", x => x.BowlingLaneId);
                    table.ForeignKey(
                        name: "FK_BowlingLanes_BowlingHalls_BowlingHallId",
                        column: x => x.BowlingHallId,
                        principalTable: "BowlingHalls",
                        principalColumn: "BowlingHallId",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Bookings",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    BookingDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    HoursToPlay = table.Column<int>(type: "int", nullable: false),
                    Customersid = table.Column<int>(type: "int", nullable: false),
                    PricePerHour = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    BowlingLaneId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Bookings", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Bookings_BowlingLanes_BowlingLaneId",
                        column: x => x.BowlingLaneId,
                        principalTable: "BowlingLanes",
                        principalColumn: "BowlingLaneId");
                    table.ForeignKey(
                        name: "FK_Bookings_Customers_Customersid",
                        column: x => x.Customersid,
                        principalTable: "Customers",
                        principalColumn: "id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_BowlingLaneId",
                table: "Bookings",
                column: "BowlingLaneId");

            migrationBuilder.CreateIndex(
                name: "IX_Bookings_Customersid",
                table: "Bookings",
                column: "Customersid");

            migrationBuilder.CreateIndex(
                name: "IX_BowlingLanes_BowlingHallId",
                table: "BowlingLanes",
                column: "BowlingHallId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Bookings");

            migrationBuilder.DropTable(
                name: "BowlingLanes");

            migrationBuilder.DropTable(
                name: "Customers");

            migrationBuilder.DropTable(
                name: "BowlingHalls");
        }
    }
}
