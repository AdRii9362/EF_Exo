using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Exo.Migrations
{
    public partial class M_EF_Exo : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Films",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Titre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AnneeSortie = table.Column<int>(type: "int", nullable: false),
                    Realisateur = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    ActeurPrincipale = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Genre = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Films", x => x.Id);
                    table.CheckConstraint("CK_AnneeSortie", "AnneeSortie>1975");
                });

            migrationBuilder.CreateIndex(
                name: "IX_Films_Titre",
                table: "Films",
                column: "Titre");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Films");
        }
    }
}
