using Microsoft.EntityFrameworkCore.Migrations;

namespace Oscypki_Blazor.Migrations
{
    public partial class seed_data : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Oscpkis",
                columns: new[] { "OscypkiId", "Description", "ImagePath", "ImageThumbnailPath", "Name", "Price" },
                values: new object[] { 1, "Smoked Polish Highlander Cheese made with Cows and Sheep Milk", "img/Oscypek.jpg", "img/Oscypek_thumbnail.jpg", "Oscypek", 2m });

            migrationBuilder.InsertData(
                table: "Oscpkis",
                columns: new[] { "OscypkiId", "Description", "ImagePath", "ImageThumbnailPath", "Name", "Price" },
                values: new object[] { 2, "A small version of the Smoked Polish Highlander Cheese made with Cows and Sheep Milk", "img/Oscypek.jpg", "img/Oscypek_small_thumbnail.jpg", "Small Oscypek", 1m });

            migrationBuilder.InsertData(
                table: "Oscpkis",
                columns: new[] { "OscypkiId", "Description", "ImagePath", "ImageThumbnailPath", "Name", "Price" },
                values: new object[] { 3, "Polish Highlander Cheese made with Cows and Sheep Milk in string form", "img/korbacz.jpg", "img/korbacz_thumbnail.jpg", "Korbacz", 4m });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Oscpkis",
                keyColumn: "OscypkiId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Oscpkis",
                keyColumn: "OscypkiId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Oscpkis",
                keyColumn: "OscypkiId",
                keyValue: 3);
        }
    }
}
