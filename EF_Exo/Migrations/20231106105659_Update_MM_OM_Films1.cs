using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Exo.Migrations
{
    public partial class Update_MM_OM_Films1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "AnneeSortie", "Genre", "RealisateursID", "Titre" },
                values: new object[,]
                {
                    { 1, 1977, "Science-Fiction", 1, "Star Wars : Un nouvel espoir" },
                    { 2, 1980, "Science-Fiction", 1, "Star Wars : L'empire contre-attaque" },
                    { 3, 1983, "Science-Fiction", 1, "Star Wars : Le retour du Jedi" },
                    { 4, 2005, "Société", 2, "Hooligans" },
                    { 5, 2001, "Heroic-Fantasy", 3, "LOTR - La communauté de l'anneau" },
                    { 6, 2002, "Heroic-Fantasy", 3, "LOTR - Les deux tours" },
                    { 7, 2003, "Heroic-Fantasy", 3, "LOTR - Le retour du roi" }
                });

            migrationBuilder.InsertData(
                table: "MM_Films_Acteurs",
                columns: new[] { "ActeursID", "FilmsID" },
                values: new object[,]
                {
                    { 1, 1 },
                    { 1, 2 },
                    { 1, 3 },
                    { 2, 4 },
                    { 3, 5 },
                    { 3, 6 },
                    { 3, 7 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "MM_Films_Acteurs",
                keyColumns: new[] { "ActeursID", "FilmsID" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "MM_Films_Acteurs",
                keyColumns: new[] { "ActeursID", "FilmsID" },
                keyValues: new object[] { 1, 2 });

            migrationBuilder.DeleteData(
                table: "MM_Films_Acteurs",
                keyColumns: new[] { "ActeursID", "FilmsID" },
                keyValues: new object[] { 1, 3 });

            migrationBuilder.DeleteData(
                table: "MM_Films_Acteurs",
                keyColumns: new[] { "ActeursID", "FilmsID" },
                keyValues: new object[] { 2, 4 });

            migrationBuilder.DeleteData(
                table: "MM_Films_Acteurs",
                keyColumns: new[] { "ActeursID", "FilmsID" },
                keyValues: new object[] { 3, 5 });

            migrationBuilder.DeleteData(
                table: "MM_Films_Acteurs",
                keyColumns: new[] { "ActeursID", "FilmsID" },
                keyValues: new object[] { 3, 6 });

            migrationBuilder.DeleteData(
                table: "MM_Films_Acteurs",
                keyColumns: new[] { "ActeursID", "FilmsID" },
                keyValues: new object[] { 3, 7 });

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Films",
                keyColumn: "Id",
                keyValue: 7);
        }
    }
}
