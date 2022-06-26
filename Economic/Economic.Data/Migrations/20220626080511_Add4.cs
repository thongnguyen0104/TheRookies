using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class Add4 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "fb4d61db-cedc-40bf-a003-830ca932ec0d");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "5cdd7c4a-2fd3-4c60-bb96-2648ff34fb9e");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "6d59c677-7215-4022-bdf6-a4a47039d6d1", "AQAAAAEAACcQAAAAEFD/2hm7G/Kf2L3TpRFj1pa3rfI9up5XCLy+T5vQF51hHNUIQH/HoXV3ymm2NAPxUQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "b79ffb5d-6fe2-467c-987f-02452c1ef6c5", "AQAAAAEAACcQAAAAEBg5DYlvNBd+6oPlZ4/OhXX25bjV0NI8uDzYQcvuDkurMu5DIMX8uRApqRp9n01DWQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "98588c54-eceb-4334-921b-dab3b5b17cb3", "AQAAAAEAACcQAAAAEFoNOtpNCMzyirWM51N5KTI4PqlRWMAgCrPX0xD6tm2VZ28nSGWCuPptP88a/w1m8A==" });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
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

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "fa1a1f76-ad9e-4b6d-a981-109c64e70f22", "AQAAAAEAACcQAAAAEM0f6xQX8QyxAqXf9nIW+DpyJFfAZhj3Aa9L0NhVSRktEDwIr4dwn6MMAl3wCOQRpQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "3c9b8b9a-4b88-48b0-aebc-08794a4a3a30", "AQAAAAEAACcQAAAAEA8L+zTHDdwFJcEeXKpG4VvL9pJ8/c1GlQn6ML9Oi0Qzy0rL3w5pJiQqgHEvP+MlfQ==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "57dce83b-a0be-47b7-82df-62a066a0c33f", "AQAAAAEAACcQAAAAEN1NRXMk82FtPH8Sfxn3ZGtbi5qGTFOe5pITDMjV3KQDSrV8LM4PLvhD+8E/cwuI4Q==" });
        }
    }
}
