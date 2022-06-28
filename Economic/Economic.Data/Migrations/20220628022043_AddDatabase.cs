using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class AddDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "ProductTypes",
                columns: new[] { "Id", "Description", "Name" },
                values: new object[,]
                {
                    { 1, "Mang đến những bửa cơm đầy dinh dưỡng cho gia đình bạn", "Nồi cơm điện" },
                    { 2, "Giải pháp hiệu quả cho người bận rộn", "Ấm đun siêu tốc" },
                    { 3, "Lựa chọn tốt nhất hàng đàu mang lại vitamin trái cây", "Máy xay sinh tố" },
                    { 4, "Chắc lọc sự tinh túy từ thiện nhiên trong ly nước ép", "Máy ép trái cây" },
                    { 5, "Cắt giảm lượng dầu mỡ tối đa cho gia đình bạn", "Nồi chiên không dầu" },
                    { 6, "Sự lựa chọn tối ưu cho bửa xum họp gia đình", "Lẩu điện" },
                    { 7, "Những buổi tiệc nướng đầy ấm áp bên người thân được mang lại", "Bếp nướng" },
                    { 8, "Căn bếp đầy tiện nghi và sang trọng khi có mặt sản phẩm này", "Bếp hồng ngoại" }
                });

            migrationBuilder.InsertData(
                table: "Roles",
                columns: new[] { "Id", "ConcurrencyStamp", "Description", "Name", "NormalizedName" },
                values: new object[,]
                {
                    { new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"), "3e7ae986-b6ea-4e57-a4da-36c367a20c3b", "Customer role", "customer", "customer" },
                    { new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"), "31f38468-f3de-42b5-af2d-c612558dc9cd", "Administrator role", "admin", "admin" }
                });

            migrationBuilder.InsertData(
                table: "Users",
                columns: new[] { "Id", "AccessFailedCount", "Address", "ConcurrencyStamp", "Email", "EmailConfirmed", "LockoutEnabled", "LockoutEnd", "Name", "NormalizedEmail", "NormalizedUserName", "PasswordHash", "PhoneNumber", "PhoneNumberConfirmed", "RegisteredDate", "SecurityStamp", "TwoFactorEnabled", "UserName" },
                values: new object[,]
                {
                    { new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"), 0, "Vinh Long", "75a77216-b988-4bf7-bc2e-683728c583fd", "thong@gmail.com", true, false, null, "Nguyen Hoang Thong", "thong@gmail.com", "admin", "AQAAAAEAACcQAAAAEAn3+PYak4S6/gO9TL3c/9Wt+BcEXg0+/NfHUbVJTiIYgD3OGV8uDt+OXQ16Z4xoJQ==", null, false, new DateTime(2022, 6, 28, 9, 20, 42, 751, DateTimeKind.Local).AddTicks(9106), "", false, "admin" },
                    { new Guid("bff91054-dc92-421e-a233-d1080f630928"), 0, "TP HCM", "cd61fb9e-7070-4ef6-9b8c-2dd3807d764c", "customer2@gmail.com", true, false, null, "David", "customer2@gmail.com", "customer", "AQAAAAEAACcQAAAAEMczglLuZYhKCyGAHYsCdX/rTIo2pNLDIrY/CYxIsiXnDwG3lqq5bs2v7ueWdafIbw==", null, false, new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2289), "", false, "customer2" },
                    { new Guid("bff91064-dc92-421e-a233-d1080f630928"), 0, "Can Tho", "bfd391d5-a852-4f66-a948-486f4ca08ae8", "customer1@gmail.com", true, false, null, "Nguyen Hoang Thong Customer", "customer1@gmail.com", "customer", "AQAAAAEAACcQAAAAENs98V6vd/wbRB9BmGTbTPLJUR9FTaJ5pZ6CS+r1Vna1q5ePQ0OoOoILq442WgDrJg==", null, false, new DateTime(2022, 6, 28, 9, 20, 42, 753, DateTimeKind.Local).AddTicks(5629), "", false, "customer1" }
                });

            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Price", "ProductTypeId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2190), "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh chóng qua công nghệ nấu 1D, công suất 500W", "Nồi cơm nắp gài Kangaroo 1.5 lít KG825", 950000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2202), "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu", "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13", 1790000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2203), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG829", 1150000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2205), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Kangaroo 1.2 lít KG822", 900000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2206), "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Delites 1.8 lít NCG1010", 790000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2207), "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG572", 890000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2208), "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh", "Nồi cơm nắp gài Ava 1.8 lít NCG1806", 720000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2209), "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút", "Nồi cơm điện Midea 0.6 lít MR-CM06SD", 590000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2210), "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.5 lít; Nấu nước sôi nhanh 5- 7  phút với công suất 1500W", "Bình đun siêu tốc Delites 1.5 lít ST15S01", 170000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2210), "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu", "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13", 1790000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2211), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG829", 1150000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2212), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Kangaroo 1.2 lít KG822", 900000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2213), "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Delites 1.8 lít NCG1010", 790000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2214), "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG572", 890000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2217), "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh", "Nồi cơm nắp gài Ava 1.8 lít NCG1806", 720000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2218), "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút", "Nồi cơm điện Midea 0.6 lít MR-CM06SD", 590000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });

            migrationBuilder.InsertData(
                table: "Comments",
                columns: new[] { "Id", "Content", "Created", "ProductId", "Star", "UserId" },
                values: new object[,]
                {
                    { 1, "Nồi tạm ổn", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2320), 1, 5, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 2, "Sản phẩm tốt", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2322), 1, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 3, "Chất lượng ổn", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2323), 2, 3, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 4, "Tạm ổn", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2325), 2, 2, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 5, "Nồi tạm ổn", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2326), 3, 1, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 6, "Tốt lắm", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2328), 7, 5, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 7, "Tàm tạm", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2329), 7, 3, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 8, "Ổn áp", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2331), 8, 4, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") },
                    { 9, "Tốt", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2332), 9, 2, new Guid("bff91064-dc92-421e-a233-d1080f630928") },
                    { 10, "Sản phẩm ổn", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2333), 10, 3, new Guid("69bd714f-9576-45ba-b5b7-f00649be00de") }
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
                    { 24, 6, "6.3.jpg" }
                });

            migrationBuilder.InsertData(
                table: "ProductImages",
                columns: new[] { "Id", "ProductId", "ProductPath" },
                values: new object[,]
                {
                    { 25, 7, "7.jpg" },
                    { 26, 7, "7.1.jpg" },
                    { 27, 7, "7.2.jpg" },
                    { 28, 7, "7.3.jpg" },
                    { 29, 8, "8.jpg" },
                    { 30, 8, "8.1.jpg" },
                    { 31, 8, "8.2.jpg" },
                    { 32, 8, "8.3.jpg" },
                    { 33, 9, "9.jpg" },
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
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 8);

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
                table: "Products",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15);

            migrationBuilder.DeleteData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16);

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"));

            migrationBuilder.DeleteData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"));

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 1);

            migrationBuilder.DeleteData(
                table: "ProductTypes",
                keyColumn: "Id",
                keyValue: 2);
        }
    }
}
