using Microsoft.EntityFrameworkCore.Migrations;

namespace SuiviVaccinCovidCodeFirst.Migrations
{
    public partial class AjoutTableTypeVaccin : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Nom",
                table: "Vaccins");

            migrationBuilder.AddColumn<int>(
                name: "TypeVaccinId",
                table: "Vaccins",
                nullable: true);

            migrationBuilder.CreateTable(
                name: "TypesVaccin",
                columns: table => new
                {
                    TypeVaccinId = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_TypesVaccin", x => x.TypeVaccinId);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Vaccins_TypeVaccinId",
                table: "Vaccins",
                column: "TypeVaccinId");

            migrationBuilder.AddForeignKey(
                name: "FK_Vaccins_TypesVaccin_TypeVaccinId",
                table: "Vaccins",
                column: "TypeVaccinId",
                principalTable: "TypesVaccin",
                principalColumn: "TypeVaccinId",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Vaccins_TypesVaccin_TypeVaccinId",
                table: "Vaccins");

            migrationBuilder.DropTable(
                name: "TypesVaccin");

            migrationBuilder.DropIndex(
                name: "IX_Vaccins_TypeVaccinId",
                table: "Vaccins");

            migrationBuilder.DropColumn(
                name: "TypeVaccinId",
                table: "Vaccins");

            migrationBuilder.AddColumn<string>(
                name: "Nom",
                table: "Vaccins",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
