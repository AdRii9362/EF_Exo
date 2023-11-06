using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Exo.Migrations
{
    public partial class Update_MM_OM : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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

            migrationBuilder.DropColumn(
                name: "ActeurPrincipale",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "Realisateur",
                table: "Films");

            migrationBuilder.AddColumn<int>(
                name: "RealisateursID",
                table: "Films",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Acteurs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Acteurs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Realisateurs",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Prenom = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Realisateurs", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "MM_Films_Acteurs",
                columns: table => new
                {
                    ActeursID = table.Column<int>(type: "int", nullable: false),
                    FilmsID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MM_Films_Acteurs", x => new { x.ActeursID, x.FilmsID });
                    table.ForeignKey(
                        name: "FK_MM_Films_Acteurs_Acteurs_ActeursID",
                        column: x => x.ActeursID,
                        principalTable: "Acteurs",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MM_Films_Acteurs_Films_FilmsID",
                        column: x => x.FilmsID,
                        principalTable: "Films",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Acteurs",
                columns: new[] { "ID", "Nom", "Prenom" },
                values: new object[] { 1, "Hammil", "Mark" });

            migrationBuilder.InsertData(
                table: "Acteurs",
                columns: new[] { "ID", "Nom", "Prenom" },
                values: new object[] { 2, "Hunnam", "Charlie" });

            migrationBuilder.InsertData(
                table: "Acteurs",
                columns: new[] { "ID", "Nom", "Prenom" },
                values: new object[] { 3, "Wood", "Elijah" });

            migrationBuilder.CreateIndex(
                name: "IX_Films_RealisateursID",
                table: "Films",
                column: "RealisateursID");

            migrationBuilder.CreateIndex(
                name: "IX_MM_Films_Acteurs_FilmsID",
                table: "MM_Films_Acteurs",
                column: "FilmsID");

            migrationBuilder.AddForeignKey(
                name: "FK_Films_Realisateurs_RealisateursID",
                table: "Films",
                column: "RealisateursID",
                principalTable: "Realisateurs",
                principalColumn: "ID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Films_Realisateurs_RealisateursID",
                table: "Films");

            migrationBuilder.DropTable(
                name: "MM_Films_Acteurs");

            migrationBuilder.DropTable(
                name: "Realisateurs");

            migrationBuilder.DropTable(
                name: "Acteurs");

            migrationBuilder.DropIndex(
                name: "IX_Films_RealisateursID",
                table: "Films");

            migrationBuilder.DropColumn(
                name: "RealisateursID",
                table: "Films");

            migrationBuilder.AddColumn<string>(
                name: "ActeurPrincipale",
                table: "Films",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Realisateur",
                table: "Films",
                type: "nvarchar(100)",
                maxLength: 100,
                nullable: false,
                defaultValue: "");

            migrationBuilder.InsertData(
                table: "Films",
                columns: new[] { "Id", "ActeurPrincipale", "AnneeSortie", "Genre", "Realisateur", "Titre" },
                values: new object[,]
                {
                    { 1, "Mark Hammil", 1977, "Science-Fiction", "Georges Lucas", "Star Wars : Un nouvel espoir" },
                    { 2, "Mark Hammil", 1980, "Science-Fiction", "Georges Lucas", "Star Wars : L'empire contre-attaque" },
                    { 3, "Mark Hammil", 1983, "Science-Fiction", "Georges Lucas", "Star Wars : Le retour du Jedi" },
                    { 4, "Charlie Hunnam", 2005, "Société", "Lexi Alexander", "Hooligans" },
                    { 5, "Elijah Wood", 2001, "Heroic-Fantasy", "Peter Jackson", "LOTR - La communauté de l'anneau" },
                    { 6, "Elijah Wood", 2002, "Heroic-Fantasy", "Peter Jackson", "LOTR - Les deux tours" },
                    { 7, "Elijah Wood", 2003, "Heroic-Fantasy", "Peter Jackson", "LOTR - Le retour du roi" }
                });
        }
    }
}
