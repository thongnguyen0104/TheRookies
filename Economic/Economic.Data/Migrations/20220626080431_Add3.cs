using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class Add3 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "5b09cc5a-04ea-4fe8-bd95-6e2d95ae0770");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "b8c6826f-c437-4c46-a31b-12588bec891c");

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "Vinh Long", "fa1a1f76-ad9e-4b6d-a981-109c64e70f22", "thong@gmail.com", true, false, null, "Nguyen Hoang Thong", "thong@gmail.com", "admin", "AQAAAAEAACcQAAAAEM0f6xQX8QyxAqXf9nIW+DpyJFfAZhj3Aa9L0NhVSRktEDwIr4dwn6MMAl3wCOQRpQ==", null, false, "", false, "admin" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, "TP HCM", "3c9b8b9a-4b88-48b0-aebc-08794a4a3a30", "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAEA8L+zTHDdwFJcEeXKpG4VvL9pJ8/c1GlQn6ML9Oi0Qzy0rL3w5pJiQqgHEvP+MlfQ==", null, false, "", false, "customer2" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, "Can Tho", "57dce83b-a0be-47b7-82df-62a066a0c33f", "customer1@gmail.com", true, false, null, "Nguyen Hoang Thong Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAEN1NRXMk82FtPH8Sfxn3ZGtbi5qGTFOe5pITDMjV3KQDSrV8LM4PLvhD+8E/cwuI4Q==", null, false, "", false, "customer1" }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"));

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "d00515e8-89bf-4bd8-a571-e9a8b6d26747");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "73bad414-4677-4e68-a9cf-d4f72a0b38a5");
        }
    }
}
