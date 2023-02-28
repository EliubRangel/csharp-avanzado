using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Calendarios.Migrations
{
    public partial class RelacionCalendarioEventos : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CalendarioId",
                table: "Eventos",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_Eventos_CalendarioId",
                table: "Eventos",
                column: "CalendarioId");

            migrationBuilder.AddForeignKey(
                name: "FK_Eventos_Calendarios_CalendarioId",
                table: "Eventos",
                column: "CalendarioId",
                principalTable: "Calendarios",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Eventos_Calendarios_CalendarioId",
                table: "Eventos");

            migrationBuilder.DropIndex(
                name: "IX_Eventos_CalendarioId",
                table: "Eventos");

            migrationBuilder.DropColumn(
                name: "CalendarioId",
                table: "Eventos");
        }
    }
}
