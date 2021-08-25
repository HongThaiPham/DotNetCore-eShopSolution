using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace eShopSolution.Data.Migrations
{
    public partial class AddProductImageTableDBSet : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "332e1f45-0a7a-44ed-8cbe-ab7cbd588cfa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b227bef9-96fb-4404-9add-ecfed641dc4f", "AQAAAAEAACcQAAAAENWSCjyhyT6RoLxUcynjPG1KJ0KQk+scEKrzro1mlZwv1hkMGfwJtoVsetkg/+RVGw==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 24, 13, 19, 56, 88, DateTimeKind.Local).AddTicks(9870));
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "AppRoles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "6e41d9ba-0519-4fe4-aec4-db1b1856fbfa");

            migrationBuilder.UpdateData(
                table: "AppUsers",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1ab5315b-52cb-4898-b5a6-87f02a01f576", "AQAAAAEAACcQAAAAEFkFfX6MrX9gQ4+nX2YrJtBrPWOJRB5YwpbgXqCN501pHHUYmkr5djZ4jbqZJqSS0Q==" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "DateCreated",
                value: new DateTime(2021, 8, 24, 13, 15, 40, 324, DateTimeKind.Local).AddTicks(8880));
        }
    }
}
