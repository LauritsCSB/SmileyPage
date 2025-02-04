using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SmileyPage.Migrations
{
    /// <inheritdoc />
    public partial class ModelUpdates : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Smiley");

            migrationBuilder.AddColumn<string>(
                name: "CurrrentSmiley",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "SecondSmiley",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "ThirdSmiley",
                table: "Restaurant",
                type: "nvarchar(max)",
                nullable: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CurrrentSmiley",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "SecondSmiley",
                table: "Restaurant");

            migrationBuilder.DropColumn(
                name: "ThirdSmiley",
                table: "Restaurant");

            migrationBuilder.CreateTable(
                name: "Smiley",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    IssueDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    RestaurantId = table.Column<int>(type: "int", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Smiley", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Smiley_Restaurant_RestaurantId",
                        column: x => x.RestaurantId,
                        principalTable: "Restaurant",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Smiley_RestaurantId",
                table: "Smiley",
                column: "RestaurantId");
        }
    }
}
