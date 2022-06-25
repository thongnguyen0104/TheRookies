using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Economic.Data.Migrations
{
    public partial class AddProductEconomicDatabase : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
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
                table: "Products",
                columns: new[] { "Id", "Description", "Name", "Price", "ProductTypeId" },
                values: new object[,]
                {
                    { 1, "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh chóng qua công nghệ nấu 1D, công suất 500W", "Nồi cơm nắp gài Kangaroo 1.5 lít KG825", 950000m, 1 },
                    { 2, "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu", "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13", 1790000m, 1 },
                    { 3, "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG829", 1150000m, 1 },
                    { 4, "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Kangaroo 1.2 lít KG822", 900000m, 1 },
                    { 5, "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Delites 1.8 lít NCG1010", 790000m, 1 },
                    { 6, "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG572", 890000m, 1 },
                    { 7, "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh", "Nồi cơm nắp gài Ava 1.8 lít NCG1806", 720000m, 1 },
                    { 8, "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút", "Nồi cơm điện Midea 0.6 lít MR-CM06SD", 590000m, 1 },
                    { 9, "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.5 lít; Nấu nước sôi nhanh 5- 7  phút với công suất 1500W", "Bình đun siêu tốc Delites 1.5 lít ST15S01", 170000m, 2 },
                    { 10, "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu", "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13", 1790000m, 2 },
                    { 11, "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG829", 1150000m, 2 },
                    { 12, "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Kangaroo 1.2 lít KG822", 900000m, 2 },
                    { 13, "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D", "Nồi cơm nắp gài Delites 1.8 lít NCG1010", 790000m, 2 },
                    { 14, "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W", "Nồi cơm nắp gài Kangaroo 2.2 lít KG572", 890000m, 2 },
                    { 15, "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh", "Nồi cơm nắp gài Ava 1.8 lít NCG1806", 720000m, 2 },
                    { 16, "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút", "Nồi cơm điện Midea 0.6 lít MR-CM06SD", 590000m, 2 }
                });
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
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
