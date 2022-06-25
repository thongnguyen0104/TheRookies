using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Economic.Data.Entities;
using Microsoft.EntityFrameworkCore;

namespace Economic.Data.Extensions
{
    public static class ModelBuilderExtentions
    {
        public static void Seed(this ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Product>().HasData(
                new Product()
                {
                    Id = 1,
                    Name = "Nồi cơm nắp gài Kangaroo 1.5 lít KG825",
                    Price = 950000,
                    Description = "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh chóng qua công nghệ nấu 1D, công suất 500W",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 2,
                    Name = "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13",
                    Price = 1790000,
                    Description = "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 3,
                    Name = "Nồi cơm nắp gài Kangaroo 2.2 lít KG829",
                    Price = 1150000,
                    Description = "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 4,
                    Name = "Nồi cơm nắp gài Kangaroo 1.2 lít KG822",
                    Price = 900000,
                    Description = "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 5,
                    Name = "Nồi cơm nắp gài Delites 1.8 lít NCG1010",
                    Price = 790000,
                    Description = "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 6,
                    Name = "Nồi cơm nắp gài Kangaroo 2.2 lít KG572",
                    Price = 890000,
                    Description = "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 7,
                    Name = "Nồi cơm nắp gài Ava 1.8 lít NCG1806",
                    Price = 720000,
                    Description = "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 8,
                    Name = "Nồi cơm điện Midea 0.6 lít MR-CM06SD",
                    Price = 590000,
                    Description = "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút",
                    ProductTypeId = 1
                },
                new Product()
                {
                    Id = 9,
                    Name = "Bình đun siêu tốc Delites 1.5 lít ST15S01",
                    Price = 170000,
                    Description = "Đáp ứng nhu cầu pha cà phê, nấu mì… với dung tích 1.5 lít; Nấu nước sôi nhanh 5- 7  phút với công suất 1500W",
                    ProductTypeId = 2
                },
                new Product()
                {
                    Id = 10,
                    Name = "Nồi cơm điện tử Joyoung 1.8 lít F-50FY13",
                    Price = 1790000,
                    Description = "Nấu cơm thơm ngon, chín đều nhờ công nghệ nấu gia nhiệt tuần hoàn; Gia nhiệt đều, nấu cơm nhanh, giữ ấm lâu với công suất 860W cùng lòng nồi dạng niêu",
                    ProductTypeId = 2
                },
                new Product()
                {
                    Id = 11,
                    Name = "Nồi cơm nắp gài Kangaroo 2.2 lít KG829",
                    Price = 1150000,
                    Description = "Nồi cơm nắp gài nhỏ gọn, đẹp mắt phù hợp cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhớ công nghệ nấu 1D, công suất 900W",
                    ProductTypeId = 2
                },
                new Product()
                {
                    Id = 12,
                    Name = "Nồi cơm nắp gài Kangaroo 1.2 lít KG822",
                    Price = 900000,
                    Description = "Nồi cơm nắp gài nhỏ gọn, đẹp mắt sử dụng cho nhu cầu nấu cơm cơ bản; Nấu cơm chín đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D",
                    ProductTypeId = 2
                },
                new Product()
                {
                    Id = 13,
                    Name = "Nồi cơm nắp gài Delites 1.8 lít NCG1010",
                    Price = 790000,
                    Description = "Nồi cơm nắp gài thiết kế đẹp mắt đáp ứng nhu cầu nấu cơm cơ bản; Nấu cơm chín nhanh đều, tơi xốp, thơm ngon nhờ công nghệ nấu 3D",
                    ProductTypeId = 2
                },
                new Product()
                {
                    Id = 14,
                    Name = "Nồi cơm nắp gài Kangaroo 2.2 lít KG572",
                    Price = 890000,
                    Description = "Nồi cơm nắp gài thiết kế nổi bật phù hợp cho nhu cầu nấu cơm cơ bản; Cơm nấu nhín ngon, nhanh chóng qua công nghệ nấu 1D, công suất 700W",
                    ProductTypeId = 2
                },
                new Product()
                {
                    Id = 15,
                    Name = "Nồi cơm nắp gài Ava 1.8 lít NCG1806",
                    Price = 720000,
                    Description = "Thiết kế đơn giản, màu sắc trẻ trung; Công nghệ nấu 1D, công suất 700W truyền nhiệt từ đáy nồi, cơm chín nhanh",
                    ProductTypeId = 2
                },
                new Product()
                {
                    Id = 16,
                    Name = "Nồi cơm điện Midea 0.6 lít MR-CM06SD",
                    Price = 590000,
                    Description = "Thiết kế màu cam tơi tắn, nhỏ gọn; Công nghệ nấu 1D nấu chín từ 20 - 30 phút",
                    ProductTypeId = 2
                });

            modelBuilder.Entity<ProductType>().HasData(
                new ProductType { Id = 1, Name = "Nồi cơm điện", Description = "Mang đến những bửa cơm đầy dinh dưỡng cho gia đình bạn" },
                new ProductType { Id = 2, Name = "Ấm đun siêu tốc", Description = "Giải pháp hiệu quả cho người bận rộn" },
                new ProductType { Id = 3, Name = "Máy xay sinh tố", Description = "Lựa chọn tốt nhất hàng đàu mang lại vitamin trái cây" },
                new ProductType { Id = 4, Name = "Máy ép trái cây", Description = "Chắc lọc sự tinh túy từ thiện nhiên trong ly nước ép" },
                new ProductType { Id = 5, Name = "Nồi chiên không dầu", Description = "Cắt giảm lượng dầu mỡ tối đa cho gia đình bạn" },
                new ProductType { Id = 6, Name = "Lẩu điện", Description = "Sự lựa chọn tối ưu cho bửa xum họp gia đình" },
                new ProductType { Id = 7, Name = "Bếp nướng", Description = "Những buổi tiệc nướng đầy ấm áp bên người thân được mang lại" },
                new ProductType { Id = 8, Name = "Bếp hồng ngoại", Description = "Căn bếp đầy tiện nghi và sang trọng khi có mặt sản phẩm này" }
                );
        }
    }
}
