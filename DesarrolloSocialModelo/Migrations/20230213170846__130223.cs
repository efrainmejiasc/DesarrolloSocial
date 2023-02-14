using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    public partial class _130223 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "TienetratamientoE",
                table: "Responsabledefamilia",
                newName: "Tienetratamiento");

            migrationBuilder.RenameColumn(
                name: "TieneTratamientoD",
                table: "Responsabledefamilia",
                newName: "Tratamiento");

            migrationBuilder.AlterColumn<string>(
                name: "NiveldeInstruccion",
                table: "Responsabledefamilia",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Tratamiento",
                table: "Responsabledefamilia",
                newName: "TieneTratamientoD");

            migrationBuilder.RenameColumn(
                name: "Tienetratamiento",
                table: "Responsabledefamilia",
                newName: "TienetratamientoE");

            migrationBuilder.AlterColumn<int>(
                name: "NiveldeInstruccion",
                table: "Responsabledefamilia",
                type: "INT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }
    }
}
