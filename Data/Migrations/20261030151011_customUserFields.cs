using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Chessly.Web.Data.Migrations
{
    /// <inheritdoc />
    public partial class customUserFields : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Country",
                table: "AspNetUsers",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Draws",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Elo",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Losses",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Wins",
                table: "AspNetUsers",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Country",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Draws",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Elo",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Losses",
                table: "AspNetUsers");

            migrationBuilder.DropColumn(
                name: "Wins",
                table: "AspNetUsers");
        }
    }
}
