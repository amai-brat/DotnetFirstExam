using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace BusinessLogic.Migrations
{
    /// <inheritdoc />
    public partial class SeedMonsters : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Monsters",
                columns: new[] { "Id", "ArmorClass", "AttackModifier", "AttackPerRound", "Damage", "DamageModifier", "HitPoints", "Weapon" },
                values: new object[,]
                {
                    { 1, 13, -2, 1, "3d4", 2, 10, 1 },
                    { 2, 13, 2, 1, "5d8", 2, 27, 1 },
                    { 3, 12, 0, 1, "3d8", 2, 19, 0 }
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Monsters",
                keyColumn: "Id",
                keyValue: 3);
        }
    }
}
