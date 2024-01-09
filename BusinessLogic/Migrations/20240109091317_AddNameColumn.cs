using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class AddNameColumn : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Monsters",
                type: "text",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 1,
                column: "Name",
                value: "Imp");

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 2,
                column: "Name",
                value: "Kysh");

            migrationBuilder.UpdateData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 3,
                column: "Name",
                value: "Creeper");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Name",
                table: "Monsters");
        }
    }
}
