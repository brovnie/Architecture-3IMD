using Microsoft.EntityFrameworkCore.Migrations;

namespace Architecture_3IMD.Migrations
{
    public partial class stores_migration : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Adress",
                table: "Stores");

            migrationBuilder.AddColumn<string>(
                name: "Address",
                table: "Stores",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Address",
                table: "Stores");

            migrationBuilder.AddColumn<string>(
                name: "Adress",
                table: "Stores",
                type: "longtext CHARACTER SET utf8mb4",
                nullable: true);
        }
    }
}
