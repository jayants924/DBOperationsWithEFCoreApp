using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace DBOperationsWithEFCoreApp.Migrations
{
    /// <inheritdoc />
    public partial class AddedBookPriceTable : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Amount",
                table: "BookPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "BookId",
                table: "BookPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "CurrencyId",
                table: "BookPrices",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices",
                column: "BookId");

            migrationBuilder.CreateIndex(
                name: "IX_BookPrices_CurrencyId",
                table: "BookPrices",
                column: "CurrencyId");

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices",
                column: "BookId",
                principalTable: "Books",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices",
                column: "CurrencyId",
                principalTable: "Currencies",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Books_BookId",
                table: "BookPrices");

            migrationBuilder.DropForeignKey(
                name: "FK_BookPrices_Currencies_CurrencyId",
                table: "BookPrices");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_BookId",
                table: "BookPrices");

            migrationBuilder.DropIndex(
                name: "IX_BookPrices_CurrencyId",
                table: "BookPrices");

            migrationBuilder.DropColumn(
                name: "Amount",
                table: "BookPrices");

            migrationBuilder.DropColumn(
                name: "BookId",
                table: "BookPrices");

            migrationBuilder.DropColumn(
                name: "CurrencyId",
                table: "BookPrices");
        }
    }
}
