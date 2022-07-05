using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace IdentityApp.Data.Migrations
{
    public partial class addedCreatorAndStatusToInvoice : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CreatorId",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Status",
                table: "Invoice",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CreatorId",
                table: "Invoice");

            migrationBuilder.DropColumn(
                name: "Status",
                table: "Invoice");
        }
    }
}
