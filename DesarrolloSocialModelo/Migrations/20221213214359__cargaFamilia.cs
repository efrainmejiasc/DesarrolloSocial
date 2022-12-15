using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class _cargaFamilia : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargaFAdolescentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadPersonasaCargo = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Estudia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Trabaja = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ingreso = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCultural = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Embarazos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Tratamiento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFAdolescentes", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargaFAdultos",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Cantidad = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Estudia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Trabaja = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ingreso = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    ActividadCultural = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Embarazos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Tratamiento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFAdultos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargaFAdultosyores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadPersonasAcargo = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Estudia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Trabaja = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ingreso = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCultural = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Embarazos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Tratamiento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFAdultosyores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargaFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadDepersonasBajosuCargo = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NiñosEstudian = table.Column<string>(type: "VARCHAR(100)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFamiliar", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargaFJefeDefamilia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadPersonasAcargo = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Estudia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Trabaja = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ingreso = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCultural = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Embarazos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Tratamiento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFJefeDefamilia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargaFNiños",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadPersonasACargo = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Estudia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Trabaja = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Ingreso = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCultural = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Embarazos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Tratamiento = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFNiños", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Responsabledefamilia",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nombres = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Apellidos = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    Nacionalidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Documento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    NumerodeDocumento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Edad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Sexo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EstadoCivil = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NiveldeInstruccion = table.Column<int>(type: "INT", nullable: false),
                    Profesion = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Habilidades = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Trabaja = table.Column<int>(type: "INT", nullable: false),
                    CondicionLaboral = table.Column<int>(type: "INT", nullable: false),
                    NivelInstruccion = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipodeNegocio = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MediodeTransporte = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TieneHijos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    NumerodeHijos = table.Column<int>(type: "INT", nullable: false),
                    TieneDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipodeDiscapacidad = table.Column<int>(type: "INT", nullable: false),
                    PadeceEnfermedad = table.Column<int>(type: "INT", nullable: false),
                    TipoEnfermedad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Tienetratamiento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipodeTratamiento = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsabledefamilia", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "SoloParaUsoDelGestor",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    NecesidadDelEncuestado = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NombredelGestor = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NumerodeDocumento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Telefono = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_SoloParaUsoDelGestor", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Vivienda",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TipodeVivienda = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    CondiciondelaVivienda = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    RequerimientodelaVivienda = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TEnenciadelaVivienda = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    ServiciosBasicosdelaVivienda = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    AseguraqueTodosLosDatosIngresadosSonCorrectos = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Vivienda", x => x.Id);
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargaFAdolescentes");

            migrationBuilder.DropTable(
                name: "CargaFAdultos");

            migrationBuilder.DropTable(
                name: "CargaFAdultosyores");

            migrationBuilder.DropTable(
                name: "CargaFamiliar");

            migrationBuilder.DropTable(
                name: "CargaFJefeDefamilia");

            migrationBuilder.DropTable(
                name: "CargaFNiños");

            migrationBuilder.DropTable(
                name: "Responsabledefamilia");

            migrationBuilder.DropTable(
                name: "SoloParaUsoDelGestor");

            migrationBuilder.DropTable(
                name: "Vivienda");
        }
    }
}
