using Microsoft.EntityFrameworkCore.Migrations;

namespace Sneakers.Core.Data.Migrations
{
    public partial class Init : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Categories",
                columns: new[] { "CategoryId", "CategoryName", "Description" },
                values: new object[,]
                {
                    { 1, "Chill", "Les paires pour chiller" },
                    { 2, "Sport", "Les paires Sport" },
                    { 3, "Rares", "Les paires Rares" },
                    { 4, "Summer", "Les paires pour l'été" }
                });

            migrationBuilder.InsertData(
                table: "Sneakers",
                columns: new[] { "SneakerId", "CategoryId", "ImageUrl", "Instock", "LongDescription", "Price", "ShortDescription", "SneakerName" },
                values: new object[,]
                {
                    { 1, 3, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "legères, confortables et rares , idéale pour collectionneur ", 109m, "pour collectionneur", "Elijaah" },
                    { 2, 3, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "legères, confortables et rares , idéale pour collectionneur ", 109m, "pour collectionneur", "Cindy" },
                    { 3, 3, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "legères, confortables et rares , idéale pour collectionneur ", 109m, "pour collectionneur", "Sheti" },
                    { 4, 3, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "legères, confortables et rares , idéale pour collectionneur ", 109m, "pour collectionneur", "Jenevaah" },
                    { 5, 3, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "legères, confortables et rares , idéale pour collectionneur ", 109m, "pour collectionneur", "Ezraahn" },
                    { 6, 3, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "legères, confortables et rares , idéale pour collectionneur ", 109m, "pour collectionneur", "Aaron" },
                    { 7, 3, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "legères, confortables et rares , idéale pour collectionneur ", 109m, "pour collectionneur", "Williams" },
                    { 8, 4, "https://images.unsplash.com/photo-1582588678413-dbf45f4823e9?ixlib=rb-1.2.1&ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&auto=format&fit=crop&w=701&q=80 ", true, "Précieuse, confortables et rares , idéale pour votre Maman ", 109m, "pour Maman", "Rebecca" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Sneakers",
                keyColumn: "SneakerId",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Categories",
                keyColumn: "CategoryId",
                keyValue: 4);
        }
    }
}
