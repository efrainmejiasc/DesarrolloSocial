using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class gestor5 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "NiveldeInstruccion",
                table: "Gestores",
                newName: "NivelInstruccion");

            migrationBuilder.AddColumn<string>(
                name: "LugarNacimiento",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 16);

            migrationBuilder.AddColumn<string>(
                name: "MunicioProvincia",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 16);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "LugarNacimiento",
                table: "Gestores");

            migrationBuilder.DropColumn(
                name: "MunicioProvincia",
                table: "Gestores");

            migrationBuilder.RenameColumn(
                name: "NivelInstruccion",
                table: "Gestores",
                newName: "NiveldeInstruccion");
        }
    }
}
