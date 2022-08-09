using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class gestor3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Edad",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                defaultValue: "")
                .Annotation("Relational:ColumnOrder", 15);

            migrationBuilder.AddColumn<string>(
                name: "NiveldeInstruccion",
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
                name: "Edad",
                table: "Gestores");

            migrationBuilder.DropColumn(
                name: "NiveldeInstruccion",
                table: "Gestores");
        }
    }
}
