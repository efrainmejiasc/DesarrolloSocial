using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DesarrolloSocialModelo.Migrations
{
    /// <inheritdoc />
    public partial class errorBrusmary : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Gestores",
                table: "Gestores");

            migrationBuilder.RenameColumn(
                name: "MunicioProvincia",
                table: "Gestores",
                newName: "MunicipioProvincia");

            migrationBuilder.AlterColumn<string>(
                name: "LugarNacimiento",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)")
                .Annotation("Relational:ColumnOrder", 17)
                .OldAnnotation("Relational:ColumnOrder", 16);

            migrationBuilder.AlterColumn<string>(
                name: "MunicipioProvincia",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)")
                .Annotation("Relational:ColumnOrder", 18)
                .OldAnnotation("Relational:ColumnOrder", 16);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gestores",
                table: "Gestores",
                column: "Email");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_Gestores",
                table: "Gestores");

            migrationBuilder.RenameColumn(
                name: "MunicipioProvincia",
                table: "Gestores",
                newName: "MunicioProvincia");

            migrationBuilder.AlterColumn<string>(
                name: "LugarNacimiento",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)")
                .Annotation("Relational:ColumnOrder", 16)
                .OldAnnotation("Relational:ColumnOrder", 17);

            migrationBuilder.AlterColumn<string>(
                name: "MunicioProvincia",
                table: "Gestores",
                type: "VARCHAR(50)",
                nullable: false,
                oldClrType: typeof(string),
                oldType: "VARCHAR(50)")
                .Annotation("Relational:ColumnOrder", 16)
                .OldAnnotation("Relational:ColumnOrder", 18);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Gestores",
                table: "Gestores",
                column: "Id");
        }
    }
}
