using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace WebApIContacts.Migrations
{
    public partial class updateContactModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "FirtsName",
                table: "contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Rol",
                table: "contact",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "FirtsName",
                table: "contact");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "contact");

            migrationBuilder.DropColumn(
                name: "Rol",
                table: "contact");
        }
    }
}
