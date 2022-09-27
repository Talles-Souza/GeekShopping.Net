using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace GeekShopping.ProductAPI.Migrations
{
    public partial class SeedProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AlterColumn<string>(
                name: "image_url",
                table: "product",
                type: "varchar(300)",
                maxLength: 300,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldMaxLength: 300)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                table: "product",
                type: "varchar(50)",
                maxLength: 50,
                nullable: true,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.InsertData(
                table: "product",
                columns: new[] { "id", "category_name", "description", "image_url", "name", "price" },
                values: new object[,]
                {
                    { 5L, "camisa", "alguma coisa descrita aqui", "ainda nao tem", "Name", 69.9m },
                    { 6L, "camisa", "alguma coisa descrita aqui", "ainda nao tem", "Name", 69.9m },
                    { 7L, "camisa", "alguma coisa descrita aqui", "ainda nao tem", "Name", 69.9m },
                    { 8L, "camisa", "alguma coisa descrita aqui", "ainda nao tem", "Name", 69.9m },
                    { 9L, "camisa", "alguma coisa descrita aqui", "ainda nao tem", "Name", 69.9m },
                    { 10L, "camisa", "alguma coisa descrita aqui", "ainda nao tem", "Name", 69.9m },
                    { 11L, "camisa", "alguma coisa descrita aqui", "ainda nao tem", "Name", 69.9m }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 2L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 3L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 4L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 5L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 6L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 7L);

            migrationBuilder.DeleteData(
                table: "product",
                keyColumn: "id",
                keyValue: 8L);

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "image_url",
                keyValue: null,
                column: "image_url",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "image_url",
                table: "product",
                type: "varchar(300)",
                maxLength: 300,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(300)",
                oldMaxLength: 300,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");

            migrationBuilder.UpdateData(
                table: "product",
                keyColumn: "category_name",
                keyValue: null,
                column: "category_name",
                value: "");

            migrationBuilder.AlterColumn<string>(
                name: "category_name",
                table: "product",
                type: "varchar(50)",
                maxLength: 50,
                nullable: false,
                oldClrType: typeof(string),
                oldType: "varchar(50)",
                oldMaxLength: 50,
                oldNullable: true)
                .Annotation("MySql:CharSet", "utf8mb4")
                .OldAnnotation("MySql:CharSet", "utf8mb4");
        }
    }
}
