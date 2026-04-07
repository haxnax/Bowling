using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Bowling.Migrations
{
    /// <inheritdoc />
    public partial class test5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "BowlingLaneId",
                table: "Games",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "GameId",
                table: "BowlingLanes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Games_BowlingLaneId",
                table: "Games",
                column: "BowlingLaneId");

            migrationBuilder.AddForeignKey(
                name: "FK_Games_BowlingLanes_BowlingLaneId",
                table: "Games",
                column: "BowlingLaneId",
                principalTable: "BowlingLanes",
                principalColumn: "BowlingLaneId",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Games_BowlingLanes_BowlingLaneId",
                table: "Games");

            migrationBuilder.DropIndex(
                name: "IX_Games_BowlingLaneId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "BowlingLaneId",
                table: "Games");

            migrationBuilder.DropColumn(
                name: "GameId",
                table: "BowlingLanes");
        }
    }
}
