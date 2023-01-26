using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class changeint : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "PuntodeReferencia",
                table: "DatosPrincipalesRG",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "PuntodeReferencia",
                table: "DatosPrincipalesRG",
                type: "INT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }
    }
}
