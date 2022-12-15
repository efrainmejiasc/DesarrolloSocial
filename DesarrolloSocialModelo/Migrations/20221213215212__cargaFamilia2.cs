using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class _cargaFamilia2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CargaFAdultosyores",
                table: "CargaFAdultosyores");

            migrationBuilder.RenameTable(
                name: "CargaFAdultosyores",
                newName: "CargaFAdultosMayores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargaFAdultosMayores",
                table: "CargaFAdultosMayores",
                column: "Id");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_CargaFAdultosMayores",
                table: "CargaFAdultosMayores");

            migrationBuilder.RenameTable(
                name: "CargaFAdultosMayores",
                newName: "CargaFAdultosyores");

            migrationBuilder.AddPrimaryKey(
                name: "PK_CargaFAdultosyores",
                table: "CargaFAdultosyores",
                column: "Id");
        }
    }
}
