using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace SiteOnepiece.Migrations
{
    public partial class ajoutSeedParent : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_enfants_parents_IdParent",
                table: "enfants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_parents",
                table: "parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_enfants",
                table: "enfants");

            migrationBuilder.RenameTable(
                name: "parents",
                newName: "Parents");

            migrationBuilder.RenameTable(
                name: "enfants",
                newName: "Enfants");

            migrationBuilder.RenameIndex(
                name: "IX_enfants_IdParent",
                table: "Enfants",
                newName: "IX_Enfants_IdParent");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Parents",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "Enfants",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(200)",
                oldMaxLength: 200,
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_Parents",
                table: "Parents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_Enfants",
                table: "Enfants",
                column: "id");

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "MoyennePrime", "Nom", "nombreUtilisateur" },
                values: new object[] { 1, "Logia est le nom donné à un type de Fruit du Démon. Il est caractérisé par\r\nle fait qu'il donne à son utilisateur le pouvoir de prendre la forme\r\nd'un élément naturel, de le produire et le contrôler à volonté.", "/images/Suna_Suna_no_Mi_Infobox.jpg", 170, "Logia", 17 });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "MoyennePrime", "Nom", "nombreUtilisateur" },
                values: new object[] { 2, "Zoan est le nom donné à un type de Fruit du Démon permettant à son utilisateur de se transformer en animal ou en une créature hybride (moitié espèce animale et moitié espèce de l'utilisateur, souvent humain) à volonté.", "/images/Gomu_Gomu_no_Mi_Infobox.jpg", 636, "Zoan", 80 });

            migrationBuilder.InsertData(
                table: "Parents",
                columns: new[] { "Id", "Description", "ImageURL", "MoyennePrime", "Nom", "nombreUtilisateur" },
                values: new object[] { 3, "Paramecia donnent aux utilisateurs un pouvoir \"surhumain\" qui peut affecter son corps, manipuler l'environnement ou produire une substance quelconque. Modifier. Permet de durcir son corps à volonté et augmenté la température des parties tempérés.", "/images/Ope_Ope_no_Mi_Infobox.jpg", 162, "Paramecia", 96 });

            migrationBuilder.AddForeignKey(
                name: "FK_Enfants_Parents_IdParent",
                table: "Enfants",
                column: "IdParent",
                principalTable: "Parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Enfants_Parents_IdParent",
                table: "Enfants");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Parents",
                table: "Parents");

            migrationBuilder.DropPrimaryKey(
                name: "PK_Enfants",
                table: "Enfants");

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Parents",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.RenameTable(
                name: "Parents",
                newName: "parents");

            migrationBuilder.RenameTable(
                name: "Enfants",
                newName: "enfants");

            migrationBuilder.RenameIndex(
                name: "IX_Enfants_IdParent",
                table: "enfants",
                newName: "IX_enfants_IdParent");

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "parents",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Description",
                table: "enfants",
                type: "nvarchar(200)",
                maxLength: 200,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_parents",
                table: "parents",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_enfants",
                table: "enfants",
                column: "id");

            migrationBuilder.AddForeignKey(
                name: "FK_enfants_parents_IdParent",
                table: "enfants",
                column: "IdParent",
                principalTable: "parents",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}
