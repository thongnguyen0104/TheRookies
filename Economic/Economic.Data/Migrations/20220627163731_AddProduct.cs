using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class AddProduct : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.InsertData(
                table: "Products",
                columns: new[] { "Id", "CreatedDate", "Description", "Name", "Price", "ProductTypeId", "UpdatedDate" },
                values: new object[,]
                {
                    { 1, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3888), "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh chóng qua công nghệ nấu 1D, công suất 500W", "Nồi cơm nắp gài Kangaroo 1.5 lít KG825", 950000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 2, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3900), "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu", "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13", 1790000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 3, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3902), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG829", 1150000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 4, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3903), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Kangaroo 1.2 lít KG822", 900000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 5, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3904), "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Delites 1.8 lít NCG1010", 790000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 6, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3905), "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG572", 890000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 7, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3906), "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh", "Nồi cơm nắp gài Ava 1.8 lít NCG1806", 720000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 8, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3907), "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút", "Nồi cơm điện Midea 0.6 lít MR-CM06SD", 590000m, 1, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 9, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3908), "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.5 lít; Nấu nước sôi nhanh 5- 7  phút với công suất 1500W", "Bình đun siêu tốc Delites 1.5 lít ST15S01", 170000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 10, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3909), "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu", "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13", 1790000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 11, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3910), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG829", 1150000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 12, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3911), "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Kangaroo 1.2 lít KG822", 900000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 13, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3912), "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Delites 1.8 lít NCG1010", 790000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 14, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3913), "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG572", 890000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 15, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3914), "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh", "Nồi cơm nắp gài Ava 1.8 lít NCG1806", 720000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) },
                    { 16, new DateTime(2022, 6, 27, 23, 37, 31, 509, DateTimeKind.Local).AddTicks(3915), "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút", "Nồi cơm điện Midea 0.6 lít MR-CM06SD", 590000m, 2, new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified) }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
        }
    }
}
