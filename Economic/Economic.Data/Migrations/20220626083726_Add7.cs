using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class Add7 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9076));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9090));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9092));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9093));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9094));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9096));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9097));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9099));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9100));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 37, 26, 47, DateTimeKind.Local).AddTicks(9101));

            migrationBuilder.InsertData(
                table: "Orders",
                columns: new[] { "Id", "Address", "AppUserId", "DeliveryDate", "OrderDate", "Phone", "Status", "UserId" },
                values: new object[,]
                {
                    { 1, null, null, new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 21, 12, 45, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, null, null, new DateTime(2021, 5, 22, 10, 50, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 22, 13, 41, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 3, null, null, new DateTime(2021, 5, 23, 9, 34, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 22, 15, 23, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, null, null, new DateTime(2021, 5, 23, 16, 23, 0, 0, DateTimeKind.Unspecified), new DateTime(2021, 5, 23, 12, 11, 0, 0, DateTimeKind.Unspecified), null, 4, new Guid("bff91054-dc92-421e-a233-d1080f630928") },
                    { 5, null, null, null, new DateTime(2021, 5, 24, 12, 11, 0, 0, DateTimeKind.Unspecified), null, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, null, null, null, new DateTime(2021, 5, 24, 12, 30, 0, 0, DateTimeKind.Unspecified), null, 2, new Guid("bff91054-dc92-421e-a233-d1080f630928") }
                });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "3273061a-2ef5-4aed-93c2-6f3654208fd0");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "115fc7c7-9639-49b0-86fb-1b64b7b20366");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "1c7ad0bc-f51d-4b53-8cee-8f370c3dad53", "AQAAAAEAACcQAAAAEHYLpjOELfBSN0se4UBKMOjEsFPaYPAUeFLIfqQsQJTY7KgHiIc78/Q/BPYph066cA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c02fcf29-e9dc-4e5b-96f4-056ae00b9014", "AQAAAAEAACcQAAAAEGDOWEfpfECuA+zBatQcz+8sRJyPSmm2Jek624FhZ4zX+GxvEMrHR8zSoir62cPGWA==" });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash" },
                values: new object[] { "c85a52e5-3b80-44c9-a818-e842edd70798", "AQAAAAEAACcQAAAAEFc1kIfgrW2AGHotszjwyOhj3UBryu31rLsFt9GlyjdaSFnaItL2ZEQBZJ1CYHiF6w==" });

            migrationBuilder.InsertData(
                table: "OrderDetails",
                columns: new[] { "OrderId", "ProductId", "Amount" },
                values: new object[,]
                {
                    { 1, 1, 2 },
                    { 2, 2, 1 },
                    { 3, 1, 2 },
                    { 3, 3, 1 },
                    { 4, 1, 1 },
                    { 5, 2, 1 },
                    { 5, 3, 1 },
                    { 6, 4, 1 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 1, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 2, 2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 3, 3 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 4, 1 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 5, 2 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 5, 3 });

            migrationBuilder.DeleteData(
                table: "OrderDetails",
                keyColumns: new[] { "OrderId", "ProductId" },
                keyValues: new object[] { 6, 4 });

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Orders",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(352));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(364));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(365));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(366));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(367));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(369));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(370));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(372));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(373));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 6, 26, 15, 6, 52, 416, DateTimeKind.Local).AddTicks(374));

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
    }
}
