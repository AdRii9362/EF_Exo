using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace EF_Exo.Migrations
{
    public partial class Update_MM_OM_Films2 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Films_Titre",
                table: "Films");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Titre",
                table: "Films",
                column: "Titre",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropIndex(
                name: "IX_Films_Titre",
                table: "Films");

            migrationBuilder.CreateIndex(
                name: "IX_Films_Titre",
                table: "Films",
                column: "Titre");
        }
    }
}
