using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SuiviVaccinCovidCodeFirst.Migrations
{
    public partial class VaccinDevientDoseBis : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doses",
                columns: table => new
                {
                    DoseId = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    NAMPatient = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    VaccinId = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doses", x => x.DoseId);
                    table.ForeignKey(
                        name: "FK_Doses_Vaccins_VaccinId",
                        column: x => x.VaccinId,
                        principalTable: "Vaccins",
                        principalColumn: "VaccinId");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doses_VaccinId",
                table: "Doses",
                column: "VaccinId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doses");
        }
    }
}
