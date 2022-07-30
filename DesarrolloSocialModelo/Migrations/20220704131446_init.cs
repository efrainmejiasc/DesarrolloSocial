using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class init : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "RespuestasDeFormulario",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    MarcaTemporal = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    NummeroIdentificacion = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Nombre = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Apellido = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CorreoElectronioco = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TienesLasVacunasContraElCovid19 = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    ConQueFRecuenciaTeHacesUnChequeoMedico = table.Column<string>(type: "VARCHAR(50)", nullable: true),
                    PadecesDeAlgunaEnfermedadActualmente = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    TienesAlgunaEnfermedadOCondicionHederitaria = table.Column<string>(type: "VARCHAR(10)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestasDeFormulario", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "RespuestasDeFormulario");
        }
    }
}
