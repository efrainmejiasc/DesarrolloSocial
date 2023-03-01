using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    public partial class _nueva : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "ActividadCulturalNiños",
                table: "CargaFNiños",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<string>(
                name: "ActividadCulturalJefeDeFamilia",
                table: "CargaFJefeDefamilia",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<string>(
                name: "ActividadCulturalAdultosMayores",
                table: "CargaFAdultosMayores",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<string>(
                name: "ActividadCulturalAdultos",
                table: "CargaFAdultos",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");

            migrationBuilder.AlterColumn<string>(
                name: "ActividadCulturalAdolecente",
                table: "CargaFAdolescentes",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(DateTime),
                oldType: "DATETIME");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<DateTime>(
                name: "ActividadCulturalNiños",
                table: "CargaFNiños",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActividadCulturalJefeDeFamilia",
                table: "CargaFJefeDefamilia",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActividadCulturalAdultosMayores",
                table: "CargaFAdultosMayores",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActividadCulturalAdultos",
                table: "CargaFAdultos",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");

            migrationBuilder.AlterColumn<DateTime>(
                name: "ActividadCulturalAdolecente",
                table: "CargaFAdolescentes",
                type: "DATETIME",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }
    }
}
