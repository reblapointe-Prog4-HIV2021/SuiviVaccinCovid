using Microsoft.EntityFrameworkCore.Migrations;

namespace SuiviVaccinCovidCodeFirst.Migrations
{
    public partial class ModificationPasDeDiscriminateur : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "typeImmunisation",
                table: "Immunisations");

            migrationBuilder.AddColumn<string>(
                name: "Discriminator",
                table: "Immunisations",
                nullable: false,
                defaultValue: "");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Discriminator",
                table: "Immunisations");

            migrationBuilder.AddColumn<string>(
                name: "typeImmunisation",
                table: "Immunisations",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }
    }
}
