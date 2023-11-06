using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Exo.Migrations
{
    public partial class Update_MM_OM_Realisateurs : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Realisateurs",
                columns: new[] { "ID", "Nom", "Prenom" },
                values: new object[] { 1, "Lucas", "Georges" });

            migrationBuilder.InsertData(
                table: "Realisateurs",
                columns: new[] { "ID", "Nom", "Prenom" },
                values: new object[] { 2, "Alexander", "Lexi" });

            migrationBuilder.InsertData(
                table: "Realisateurs",
                columns: new[] { "ID", "Nom", "Prenom" },
                values: new object[] { 3, "Jackson", "Peter" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Realisateurs",
                keyColumn: "ID",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Realisateurs",
                keyColumn: "ID",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Realisateurs",
                keyColumn: "ID",
                keyValue: 3);
        }
    }
}
