using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    public partial class newm : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "CargaFAdolescentes",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadAdolecente = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumentoAdolecente = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    EstudiaAdolecente = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TrabajaAdolecente = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IngresoAdolecente = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCulturalAdolecente = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    EmbarazosAdolecente = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidadAdolecente = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TratamientoAdolecente = table.Column<string>(type: "VARCHAR(100)", nullable: false),
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
                    CantidadAdultos = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumentoAdultos = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    EstudiaAdultos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TrabajaAdultos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IngresoAdultos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    ActividadCulturalAdultos = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    EmbarazosAdultos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidadAdultos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TratamientoAdultos = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFAdultos", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargaFAdultosMayores",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadAdultosMayores = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumentoAdultosMayores = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    EstudiaAdultosMayores = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TrabajaAdultosMayores = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IngresoAdultosMayores = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCulturalAdultosMayores = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    EmbarazosAdultosMayores = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidadAdultosMayores = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TratamientoAdultosMayores = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFAdultosMayores", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "CargaFamiliar",
                columns: table => new
                {
                    Id = table.Column<int>(type: "INT", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CantidadDepersonasBajosuCargo = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NiñosEstudian = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IdCargaFJefeDeFamilia = table.Column<int>(type: "INT", nullable: false)
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
                    TienenDocumentoJefeDeFamilia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    CantidadJefeDeFamilia = table.Column<int>(type: "INT", nullable: false),
                    EstudiaJefeDeFamilia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TrabajaJefeDeFamilia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IngresoJefeDeFamilia = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCulturalJefeDeFamilia = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    EmbarazosJefeDeFamilia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidadJefeDeFamilia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TratamientoJefeDeFamilia = table.Column<string>(type: "VARCHAR(250)", nullable: false),
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
                    CantidadNiños = table.Column<int>(type: "INT", nullable: false),
                    TienenDocumentoNiños = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    EstudiaNiños = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TrabajaNiños = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    IngresoNiños = table.Column<double>(type: "FLOAT", nullable: false),
                    ActividadCulturalNiños = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    EmbarazosNiños = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EnfermedadDiscapacidadNiños = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TratamientoNiños = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    IDCargaFamiliar = table.Column<int>(type: "INT", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_CargaFNiños", x => x.Id);
                });

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
                    PuntodeReferencia = table.Column<string>(type: "VARCHAR(50)", nullable: false),
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
                    lugardeNacimiento = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    FechaNacimiento = table.Column<DateTime>(type: "DATETIME", nullable: false),
                    Edad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Sexo = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    EstadoCivil = table.Column<string>(type: "VARCHAR(100)", nullable: false),
                    NiveldeInstruccion = table.Column<int>(type: "INT", nullable: false),
                    Profesion = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Habilidades = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    Trabaja = table.Column<int>(type: "INT", nullable: false),
                    CondicionLaboral = table.Column<int>(type: "INT", nullable: false),
                    TipodeNegocio = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    MediodeTransporte = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TieneHijos = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    NumerodeHijos = table.Column<int>(type: "INT", nullable: false),
                    TieneDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TieneTratamientoD = table.Column<int>(type: "INT", nullable: false),
                    TipodeDiscapacidad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    PadeceEnfermedad = table.Column<int>(type: "INT", nullable: false),
                    TipoEnfermedad = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TienetratamientoE = table.Column<string>(type: "VARCHAR(50)", nullable: false),
                    TipodeTratamiento = table.Column<string>(type: "VARCHAR(50)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Responsabledefamilia", x => x.Id);
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

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "CargaFAdolescentes");

            migrationBuilder.DropTable(
                name: "CargaFAdultos");

            migrationBuilder.DropTable(
                name: "CargaFAdultosMayores");

            migrationBuilder.DropTable(
                name: "CargaFamiliar");

            migrationBuilder.DropTable(
                name: "CargaFJefeDefamilia");

            migrationBuilder.DropTable(
                name: "CargaFNiños");

            migrationBuilder.DropTable(
                name: "DatosPrincipalesRG");

            migrationBuilder.DropTable(
                name: "Gestores");

            migrationBuilder.DropTable(
                name: "Responsabledefamilia");

            migrationBuilder.DropTable(
                name: "RespuestasDeFormulario");

            migrationBuilder.DropTable(
                name: "Roles");

            migrationBuilder.DropTable(
                name: "SoloParaUsoDelGestor");

            migrationBuilder.DropTable(
                name: "Vivienda");
        }
    }
}
