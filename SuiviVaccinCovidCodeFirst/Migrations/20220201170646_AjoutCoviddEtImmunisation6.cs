using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace SuiviVaccinCovidCodeFirst.Migrations
{
    public partial class AjoutCoviddEtImmunisation6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.CreateTable(
                name: "Immunisations",
                columns: table => new
                {
                    ImmunisationID = table.Column<int>(nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(nullable: false),
                    NAMPatient = table.Column<string>(nullable: true),
                    Discriminator = table.Column<string>(nullable: false),
                    Variant = table.Column<string>(nullable: true),
                    TypeVaccinId = table.Column<int>(nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Immunisations", x => x.ImmunisationID);
                    table.ForeignKey(
                        name: "FK_Immunisations_TypesVaccin_TypeVaccinId",
                        column: x => x.TypeVaccinId,
                        principalTable: "TypesVaccin",
                        principalColumn: "TypeVaccinId",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Immunisations_TypeVaccinId",
                table: "Immunisations",
                column: "TypeVaccinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Immunisations");

            migrationBuilder.DropTable(
                name: "TypesVaccin");
        }
    }
}
