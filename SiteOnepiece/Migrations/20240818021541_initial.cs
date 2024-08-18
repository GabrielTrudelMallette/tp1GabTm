using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteOnepiece.Migrations
{
    public partial class initial : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "parents",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Nom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    MoyennePrime = table.Column<int>(type: "int", nullable: false),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    nombreUtilisateur = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_parents", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "enfants",
                columns: table => new
                {
                    id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    ImageURL = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Description = table.Column<string>(type: "nvarchar(200)", maxLength: 200, nullable: true),
                    Prime = table.Column<double>(type: "float", nullable: false),
                    NomFruitDemon = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Occupation = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    Nom = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: true),
                    EstVedette = table.Column<bool>(type: "bit", nullable: false),
                    Equipage = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    ageDebut = table.Column<int>(type: "int", nullable: false),
                    agePrensent = table.Column<int>(type: "int", nullable: false),
                    typeDeFruit = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    IdParent = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_enfants", x => x.id);
                    table.ForeignKey(
                        name: "FK_enfants_parents_IdParent",
                        column: x => x.IdParent,
                        principalTable: "parents",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_enfants_IdParent",
                table: "enfants",
                column: "IdParent");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "enfants");

            migrationBuilder.DropTable(
                name: "parents");
        }
    }
}
