using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBOperationsWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class addedLanguageTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "languageId",
                table: "Books",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateTable(
                name: "Languages",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Languages", x => x.Id);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Books_languageId",
                table: "Books",
                column: "languageId");

            migrationBuilder.AddForeignKey(
                name: "FK_Books_Languages_languageId",
                table: "Books",
                column: "languageId",
                principalTable: "Languages",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Books_Languages_languageId",
                table: "Books");

            migrationBuilder.DropTable(
                name: "Languages");

            migrationBuilder.DropIndex(
                name: "IX_Books_languageId",
                table: "Books");

            migrationBuilder.DropColumn(
                name: "languageId",
                table: "Books");
        }
    }
}
