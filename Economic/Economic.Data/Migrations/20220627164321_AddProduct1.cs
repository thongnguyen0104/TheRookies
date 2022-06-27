using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class AddProduct1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "RegisteredDate",
                table: "Users");

            migrationBuilder.DropColumn(
                name: "CreatedDate",
                table: "Products");

            migrationBuilder.DropColumn(
                name: "UpdatedDate",
                table: "Products");

            migrationBuilder.InsertData(
                table: "AppUserRole",
                columns: new[] { "RoleId", "UserId" },
                values: new object[,]
                {
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91054-dc92-421e-a233-d1080f630928") },
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91064-dc92-421e-a233-d1080f630928") }
                });

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

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ProductId", "ProductPath" },
                values: new object[,]
                {
                    { 1, 1, "1.jpg" },
                    { 2, 1, "1.1.jpg" },
                    { 3, 1, "1.2.jpg" },
                    { 4, 1, "1.3.jpg" },
                    { 5, 2, "2.jpg" },
                    { 6, 2, "2.1.jpg" },
                    { 7, 2, "2.2.jpg" },
                    { 8, 2, "2.3.jpg" },
                    { 9, 3, "3.jpg" },
                    { 10, 3, "3.1.jpg" },
                    { 11, 3, "3.2.jpg" },
                    { 12, 3, "3.3.jpg" },
                    { 13, 4, "4.jpg" },
                    { 14, 4, "4.1.jpg" },
                    { 15, 4, "4.2.jpg" },
                    { 16, 4, "4.3.jpg" },
                    { 17, 5, "5.jpg" },
                    { 18, 5, "5.1.jpg" },
                    { 19, 5, "5.2.jpg" },
                    { 20, 5, "5.3.jpg" },
                    { 21, 6, "6.jpg" },
                    { 22, 6, "6.1.jpg" },
                    { 23, 6, "6.2.jpg" },
                    { 24, 6, "6.3.jpg" },
                    { 25, 7, "7.jpg" },
                    { 26, 7, "7.1.jpg" },
                    { 27, 7, "7.2.jpg" },
                    { 28, 7, "7.3.jpg" },
                    { 29, 8, "8.jpg" },
                    { 30, 8, "8.1.jpg" },
                    { 31, 8, "8.2.jpg" },
                    { 32, 8, "8.3.jpg" },
                    { 33, 9, "9.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ProductId", "ProductPath" },
                values: new object[,]
                {
                    { 34, 9, "9.1.jpg" },
                    { 35, 9, "9.2.jpg" },
                    { 36, 9, "9.3.jpg" },
                    { 37, 10, "10.jpg" },
                    { 38, 10, "10.1.jpg" },
                    { 39, 10, "10.2.jpg" },
                    { 40, 10, "10.3.jpg" },
                    { 41, 11, "11.jpg" },
                    { 42, 11, "11.1.jpg" },
                    { 43, 11, "11.2.jpg" },
                    { 44, 11, "11.3.jpg" },
                    { 45, 12, "12.jpg" },
                    { 46, 12, "12.1.jpg" },
                    { 47, 12, "12.2.jpg" },
                    { 48, 12, "12.3.jpg" },
                    { 49, 13, "13.jpg" },
                    { 50, 13, "13.1.jpg" },
                    { 51, 13, "13.2.jpg" },
                    { 52, 13, "13.3.jpg" },
                    { 53, 14, "14.jpg" },
                    { 54, 14, "14.1.jpg" },
                    { 55, 14, "14.2.jpg" },
                    { 56, 14, "14.3.jpg" },
                    { 57, 15, "15.jpg" },
                    { 58, 15, "15.1.jpg" },
                    { 59, 15, "15.2.jpg" },
                    { 60, 15, "15.3.jpg" },
                    { 61, 16, "16.jpg" },
                    { 62, 16, "16.1.jpg" },
                    { 63, 16, "16.2.jpg" },
                    { 64, 16, "16.3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "2cd78571-e5cc-4a7e-9a77-ba18621195c9", "Customer role", "customer", "customer" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "4584303a-f9e8-41fa-bc6b-2e481dda5f77", "Administrator role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "Vinh Long", "ef5f16a4-ae38-4604-9edc-9b5e04cbd46d", "thong@gmail.com", true, false, null, "Nguyen Hoang Thong", "thong@gmail.com", "admin", "AQAAAAEAACcQAAAAEHCVrCwZAlYUh3GgkOfHioIESN5jtcByXcY7iswv7YKjjtZWFxJMAMj7lNBORuB0Gg==", null, false, "", false, "admin" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, "TP HCM", "ce65c1c0-8e8f-47df-9783-610cea761fd2", "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAEIVChlYlYVZvu9wMBWYwH5d+4TUcNZjZ3b1elhXu48K3GpGXLR6P5LUnyOC5wbRhfg==", null, false, "", false, "customer2" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, "Can Tho", "d59eaf8d-2ead-4726-a755-03f26337110c", "customer1@gmail.com", true, false, null, "Nguyen Hoang Thong Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAEBA0ZJtvO6P2lzWUc4esj0/07taWrGw5AjKVcfm1ISTjGdBwg3FZxN5GIro4z/5Cmw==", null, false, "", false, "customer1" }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "Created", "ProductId", "Star", "UserId" },
                values: new object[,]
                {
                    { 1, "Nồi tạm ổn", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1522), 1, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, "Sản phẩm tốt", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1536), 1, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 3, "Chất lượng ổn", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1537), 2, 3, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, "Tạm ổn", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1539), 2, 2, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 5, "Nồi tạm ổn", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1540), 3, 1, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, "Tốt lắm", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1541), 7, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 7, "Tàm tạm", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1543), 7, 3, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 8, "Ổn áp", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1544), 8, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 9, "Tốt", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1546), 9, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 10, "Sản phẩm ổn", new DateTime(2022, 6, 27, 23, 43, 21, 208, DateTimeKind.Local).AddTicks(1547), 10, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
                });

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
                table: "AppUserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") });

            migrationBuilder.DeleteData(
                table: "AppUserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91054-dc92-421e-a233-d1080f630928") });

            migrationBuilder.DeleteData(
                table: "AppUserRole",
                keyColumns: new[] { "RoleId", "UserId" },
                keyValues: new object[] { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), new Guid("bff91064-dc92-421e-a233-d1080f630928") });

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
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 17);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 18);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 19);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 20);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 21);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 22);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 23);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 24);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 25);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 26);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 27);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 28);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 29);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 30);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 31);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 32);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 33);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 34);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 35);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 36);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 37);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 38);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 39);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 40);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 41);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 42);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 43);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 44);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 45);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 46);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 47);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 48);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 49);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 50);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 51);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 52);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 53);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 54);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 55);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 56);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 57);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 58);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 59);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 60);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 61);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 62);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 63);

            migrationBuilder.DeleteData(
                table: "ProductImages",
                keyColumn: "Id",
                keyValue: 64);

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"));

            migrationBuilder.DeleteData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"));

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

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"));

            migrationBuilder.AddColumn<DateTime>(
                name: "RegisteredDate",
                table: "Users",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.AddColumn<DateTime>(
                name: "UpdatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3888));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3900));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3902));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3903));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3904));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3905));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3906));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3907));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3908));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3909));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3910));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3911));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3912));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3913));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3914));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3915));
        }
    }
}
