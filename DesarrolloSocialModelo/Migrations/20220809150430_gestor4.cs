using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class gestor4 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<int>(
                name: "Edad",
                table: "Gestores",
                type: "INT",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "Edad",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "INT");
        }
    }
}
