using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class Add6 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "Created", "ProductId", "Star", "UserId" },
                values: new object[,]
                {
                    { 1, "Nồi tạm ổn", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(352), 1, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, "Sản phẩm tốt", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(364), 1, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 3, "Chất lượng ổn", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(365), 2, 3, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, "Tạm ổn", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(366), 2, 2, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 5, "Nồi tạm ổn", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(367), 3, 1, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, "Tốt lắm", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(369), 7, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 7, "Tàm tạm", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(370), 7, 3, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 8, "Ổn áp", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(372), 8, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 9, "Tốt", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(373), 9, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 10, "Sản phẩm ổn", new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(374), 10, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "53e2e6b9-c949-4e75-9926-eff36beacefb");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "d93a904d-bc5e-44f5-b104-11e2c2026466");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "11a66f89-82b5-438f-904f-e73c3bce5a3d", "AQAAAAEAACcQAAAAEFex2V3OUzOnUnLQrTXzlvfG+Yus6IElAs8CLeUYSAOEpmRbkUcr5/Xa8JiQvRSaPA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "0faf31fe-6218-4c73-abfd-a510f55fa2ce", "AQAAAAEAACcQAAAAEM7Xy5nidB2HvXfQNcjfSVDT3Vx2YnEjJ8OBUv/KpVx0tkEXNdUF8hE66cckQG/Aiw==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d68e17e-17c1-4861-8821-ed6574dc8448", "AQAAAAEAACcQAAAAEHJ9+VTIXxPrW11cveecZAAa1b5LL1RqJQlA4BpPmzBMAdpO3c56oUbVRt4am5yq4Q==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "7c49c17b-420a-479f-bf04-902ac044b819");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "1ddd3ade-06d4-401b-9747-85efc822372a");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7f844cf3-95c1-4532-97f1-2b22013579cd", "AQAAAAEAACcQAAAAEOVufr1J980Mfmp+55l7vD+6JTNZJpjgcNHAIhrQlTkJmCLtA+8wezIR7p2xFF/kJQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "e5098c0f-9ce9-41dc-8f32-72a164279013", "AQAAAAEAACcQAAAAEMiBJth28Cj0dYC9uoMqO+DaQ8Hl4VGZBJESZfvj62lX1iuuScJQeIt/QInEDquirQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "7eb0b337-7e70-44e9-816d-0f3b96623223", "AQAAAAEAACcQAAAAEFciUnadnMr9f2SWoqe5OvXoZMu6kQEspLLkS52SBSPbY4u/CJP30ZUeRhTdF0KN8A==" });
        }
    }
}
