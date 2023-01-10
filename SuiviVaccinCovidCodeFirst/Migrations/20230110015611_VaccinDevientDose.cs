using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuiviVaccinCovidCodeFirst.Migrations
{
    public partial class VaccinDevientDose : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Immunisations_TypesVaccin_TypeVaccinId",
                table: "Immunisations");

            migrationBuilder.DropTable(
                name: "TypesVaccin");

            migrationBuilder.RenameColumn(
                name: "TypeVaccinId",
                table: "Immunisations",
                newName: "VaccinId");

            migrationBuilder.RenameIndex(
                name: "IX_Immunisations_TypeVaccinId",
                table: "Immunisations",
                newName: "IX_Immunisations_VaccinId");

            migrationBuilder.CreateTable(
                name: "Vaccins",
                columns: table => new
                {
                    VaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vaccins", x => x.VaccinId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Immunisations_Vaccins_VaccinId",
                table: "Immunisations",
                column: "VaccinId",
                principalTable: "Vaccins",
                principalColumn: "VaccinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Immunisations_Vaccins_VaccinId",
                table: "Immunisations");

            migrationBuilder.DropTable(
                name: "Vaccins");

            migrationBuilder.RenameColumn(
                name: "VaccinId",
                table: "Immunisations",
                newName: "TypeVaccinId");

            migrationBuilder.RenameIndex(
                name: "IX_Immunisations_VaccinId",
                table: "Immunisations",
                newName: "IX_Immunisations_TypeVaccinId");

            migrationBuilder.CreateTable(
                name: "TypesVaccin",
                columns: table => new
                {
                    TypeVaccinId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesVaccin", x => x.TypeVaccinId);
                });

            migrationBuilder.AddForeignKey(
                name: "FK_Immunisations_TypesVaccin_TypeVaccinId",
                table: "Immunisations",
                column: "TypeVaccinId",
                principalTable: "TypesVaccin",
                principalColumn: "TypeVaccinId");
        }
    }
}
