using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class Inhitiaql : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "DatosPrincipalesRG",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FechaRegistro = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Pais = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Estado = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Ciudad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Municipio = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CodigoPostal = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Parroquia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Urbanizacion = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Avenida = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    EdifioCasa = table.Column<string>(type: "VARCHAR (50)", nullable: false),
                    Piso = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Numerodecasa = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    PuntodeReferencia = table.Column<int>(type: "INT", nullable: false),
                    Telefono = table.Column<string>(type: "varchar(50)", nullable: false),
                    TelefonoAlternativo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Correo = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_DatosPrincipalesRG", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Gestores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Apellidos = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Email = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Telefono = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Pais = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Estado = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ciudad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Password = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IdEstado = table.Column<int>(type: "INT", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    TipoDocumento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    NumeroDocumento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IdRol = table.Column<int>(type: "INT", nullable: false),
                    Edad = table.Column<int>(type: "INT", nullable: false),
                    NivelInstruccion = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    LugarNacimiento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MunicipioProvincia = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Gestores", x => x.Email);
                });

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
                    PadecesDeAlgunaEnfermedadActualmente = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    TienesAlgunaEnfermedadOCondicionHederitaria = table.Column<string>(type: "VARCHAR(10)", nullable: true),
                    ConQueFRecuenciaTeHacesUnChequeoMedico = table.Column<string>(type: "VARCHAR(50)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RespuestasDeFormulario", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Roles",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Rol = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Roles", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "DatosPrincipalesRG");

            migrationBuilder.DropTable(
                name: "Gestores");

            migrationBuilder.DropTable(
                name: "RespuestasDeFormulario");

            migrationBuilder.DropTable(
                name: "Roles");
        }
    }
}
