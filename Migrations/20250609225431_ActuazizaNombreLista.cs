using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Ramon_Lopez_AP1_P1.Migrations
{
    /// <inheritdoc />
    public partial class ActuazizaNombreLista : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Registros",
                table: "Registros");

            migrationBuilder.RenameTable(
                name: "Registros",
                newName: "Aportes");

            migrationBuilder.RenameColumn(
                name: "RegistroId",
                table: "Aportes",
                newName: "AporteId");

            migrationBuilder.AddColumn<decimal>(
                name: "Monto",
                table: "Aportes",
                type: "numeric",
                nullable: false,
                defaultValue: 0m);

            migrationBuilder.AddColumn<string>(
                name: "Nombre",
                table: "Aportes",
                type: "character varying(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "fecha",
                table: "Aportes",
                type: "timestamp with time zone",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddPrimaryKey(
                name: "PK_Aportes",
                table: "Aportes",
                column: "AporteId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Aportes",
                table: "Aportes");

            migrationBuilder.DropColumn(
                name: "Monto",
                table: "Aportes");

            migrationBuilder.DropColumn(
                name: "Nombre",
                table: "Aportes");

            migrationBuilder.DropColumn(
                name: "fecha",
                table: "Aportes");

            migrationBuilder.RenameTable(
                name: "Aportes",
                newName: "Registros");

            migrationBuilder.RenameColumn(
                name: "AporteId",
                table: "Registros",
                newName: "RegistroId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Registros",
                table: "Registros",
                column: "RegistroId");
        }
    }
}
