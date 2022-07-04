using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class AddFiledIsDeleted : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "ProductTypes",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                oldClrType: typeof(DateTime),
                oldType: "datetime2",
                oldNullable: true);

            migrationBuilder.AddColumn<int>(
                name: "IsDeleted",
                table: "Products",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9545));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9547));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9548));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9549));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9550));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9551));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9552));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9553));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9554));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9555));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2611));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2622));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2623));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2624));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2625));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2627));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2628));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2628), "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.8 lít; Nấu nước sôi nhanh 7 - 8 phút với công suất 1800W", "Bình đun siêu tốc Delites 1.8 lít ST18DB01" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2629), "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.7 lít; Nấu nước sôi nhanh 4 - 6 phút với công suất 2200W", "Bình đun siêu tốc Electrolux 1.7 lít EEK3505" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2630), "Dung tích 1.7 lít, tay cầm to bản dễ dàng cầm nắm; Mâm nhiệt từ inox bền bỉ truyền nhiệt tốt, an toàn", "Bình đun siêu tốc Sunhouse 1.7 lít SHD1382B" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2631), "Dung tích 1.7 lít, thang đo mực nước tiện châm nước khi đun; Chất liệu nhựa PP an toàn sức khỏe, đế tiếp tiện xoay 360 độ lấy nước dễ dàng", "Bình đun siêu tốc Delites 1.7 lít ST17P01WG" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2631), "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.8 lít; Nấu nước sôi nhanh 5 - 7 phút với công suất 2200W", "Bình đun siêu tốc Delites 1.8 lít ST18G02" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2632), "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.5 lít; Nấu nước sôi nhanh 5 - 7 phút với công suất 1800W", "Bình đun siêu tốc Kangaroo 1.5 lít KG-18K1" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 7, 4, 23, 26, 54, 529, DateTimeKind.Local).AddTicks(2633), "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.0 lít; Nấu nước sôi nhanh 4 - 6 phút với công suất 2200W", "Bình đun siêu tốc Delites 1.5 lít ST10P01" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "86073ce4-36b6-4e98-ae1c-32ae9c7f068f");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "52386e05-c017-48c1-a3e8-e5a55b74c1d3");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate" },
                values: new object[] { "6cd34f38-6b1e-42cb-b828-fd1ebadc535a", "AQAAAAEAACcQAAAAEIRWVl0YZTJ8CUHDrj6J3uUmAHwUDGDTW3K6kUh3/+LT0RYqQ1fqMaxA11oTN5w51A==", new DateTime(2022, 7, 4, 23, 26, 54, 530, DateTimeKind.Local).AddTicks(4986) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate" },
                values: new object[] { "6cffdf11-f7d6-4d46-a3bf-4542038e21f2", "AQAAAAEAACcQAAAAEDb33X7bSbnX+JpvQy4U7bS+kfbh/OYFFT88vgIbv09BAf4HvJDgwU3h6ODZGSg4Eg==", new DateTime(2022, 7, 4, 23, 26, 54, 532, DateTimeKind.Local).AddTicks(9506) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate" },
                values: new object[] { "f0d9ea35-18bc-444f-9542-9a6b7507b35f", "AQAAAAEAACcQAAAAELLAdyZn4tS8m25bmnGTrz8tmwkCyBG9RPN6pf4+cNGKBSu8CEpz/PWzcyug3JPbeA==", new DateTime(2022, 7, 4, 23, 26, 54, 531, DateTimeKind.Local).AddTicks(7323) });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "ProductTypes");

            migrationBuilder.DropColumn(
                name: "IsDeleted",
                table: "Products");

            migrationBuilder.AlterColumn<DateTime>(
                name: "CreatedDate",
                table: "Products",
                type: "datetime2",
                nullable: true,
                oldClrType: typeof(DateTime),
                oldType: "datetime2");

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 1,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2320));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 2,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2322));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 3,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2323));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 4,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2325));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 5,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2326));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 6,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2328));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 7,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2329));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 8,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2331));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 9,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2332));

            migrationBuilder.UpdateData(
                table: "Comments",
                keyColumn: "Id",
                keyValue: 10,
                column: "Created",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2333));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 1,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2190));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 2,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2202));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 3,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2203));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 4,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2205));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 5,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2206));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 6,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2207));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 7,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2208));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 8,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2209));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 9,
                column: "CreatedDate",
                value: new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2210));

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 10,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2210), "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu", "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 11,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2211), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG829" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 12,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2212), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Kangaroo 1.2 lít KG822" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 13,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2213), "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Delites 1.8 lít NCG1010" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 14,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2214), "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG572" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 15,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2217), "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh", "Nồi cơm nắp gài Ava 1.8 lít NCG1806" });

            migrationBuilder.UpdateData(
                table: "Products",
                keyColumn: "Id",
                keyValue: 16,
                columns: new[] { "CreatedDate", "Description", "Name" },
                values: new object[] { new DateTime(2022, 6, 28, 9, 20, 42, 750, DateTimeKind.Local).AddTicks(2218), "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút", "Nồi cơm điện Midea 0.6 lít MR-CM06SD" });

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("54ba416f-6b89-4c53-873d-4fbd48506e6d"),
                column: "ConcurrencyStamp",
                value: "3e7ae986-b6ea-4e57-a4da-36c367a20c3b");

            migrationBuilder.UpdateData(
                table: "Roles",
                keyColumn: "Id",
                keyValue: new Guid("8d04dce2-969a-435d-bba4-df3f325983dc"),
                column: "ConcurrencyStamp",
                value: "31f38468-f3de-42b5-af2d-c612558dc9cd");

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("69bd714f-9576-45ba-b5b7-f00649be00de"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate" },
                values: new object[] { "75a77216-b988-4bf7-bc2e-683728c583fd", "AQAAAAEAACcQAAAAEAn3+PYak4S6/gO9TL3c/9Wt+BcEXg0+/NfHUbVJTiIYgD3OGV8uDt+OXQ16Z4xoJQ==", new DateTime(2022, 6, 28, 9, 20, 42, 751, DateTimeKind.Local).AddTicks(9106) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91054-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate" },
                values: new object[] { "cd61fb9e-7070-4ef6-9b8c-2dd3807d764c", "AQAAAAEAACcQAAAAEMczglLuZYhKCyGAHYsCdX/rTIo2pNLDIrY/CYxIsiXnDwG3lqq5bs2v7ueWdafIbw==", new DateTime(2022, 6, 28, 9, 20, 42, 755, DateTimeKind.Local).AddTicks(2289) });

            migrationBuilder.UpdateData(
                table: "Users",
                keyColumn: "Id",
                keyValue: new Guid("bff91064-dc92-421e-a233-d1080f630928"),
                columns: new[] { "ConcurrencyStamp", "PasswordHash", "RegisteredDate" },
                values: new object[] { "bfd391d5-a852-4f66-a948-486f4ca08ae8", "AQAAAAEAACcQAAAAENs98V6vd/wbRB9BmGTbTPLJUR9FTaJ5pZ6CS+r1Vna1q5ePQ0OoOoILq442WgDrJg==", new DateTime(2022, 6, 28, 9, 20, 42, 753, DateTimeKind.Local).AddTicks(5629) });
        }
    }
}
