using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Economic.Data.Entities;
using Microsoft.AspNetCore.Identity;
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
            modelBuilder.Entity<ProductImage>().HasData(
                new ProductImage { Id = 1, ProductId = 1, ProductPath = "1.jpg"},
                new ProductImage { Id = 2, ProductId = 1, ProductPath = "1.1.jpg" },
                new ProductImage { Id = 3, ProductId = 1, ProductPath = "1.2.jpg" },
                new ProductImage { Id = 4, ProductId = 1, ProductPath = "1.3.jpg" },

                new ProductImage { Id = 5, ProductId = 2, ProductPath = "2.jpg" },
                new ProductImage { Id = 6, ProductId = 2, ProductPath = "2.1.jpg" },
                new ProductImage { Id = 7, ProductId = 2, ProductPath = "2.2.jpg" },
                new ProductImage { Id = 8, ProductId = 2, ProductPath = "2.3.jpg" },

                new ProductImage { Id = 9, ProductId = 3, ProductPath = "3.jpg" },
                new ProductImage { Id = 10, ProductId = 3, ProductPath = "3.1.jpg" },
                new ProductImage { Id = 11, ProductId = 3, ProductPath = "3.2.jpg" },
                new ProductImage { Id = 12, ProductId = 3, ProductPath = "3.3.jpg" },

                new ProductImage { Id = 13, ProductId = 4, ProductPath = "4.jpg" },
                new ProductImage { Id = 14, ProductId = 4, ProductPath = "4.1.jpg" },
                new ProductImage { Id = 15, ProductId = 4, ProductPath = "4.2.jpg" },
                new ProductImage { Id = 16, ProductId = 4, ProductPath = "4.3.jpg" },

                new ProductImage { Id = 17, ProductId = 5, ProductPath = "5.jpg" },
                new ProductImage { Id = 18, ProductId = 5, ProductPath = "5.1.jpg" },
                new ProductImage { Id = 19, ProductId = 5, ProductPath = "5.2.jpg" },
                new ProductImage { Id = 20, ProductId = 5, ProductPath = "5.3.jpg" },

                new ProductImage { Id = 21, ProductId = 6, ProductPath = "6.jpg" },
                new ProductImage { Id = 22, ProductId = 6, ProductPath = "6.1.jpg" },
                new ProductImage { Id = 23, ProductId = 6, ProductPath = "6.2.jpg" },
                new ProductImage { Id = 24, ProductId = 6, ProductPath = "6.3.jpg" },

                new ProductImage { Id = 25, ProductId = 7, ProductPath = "7.jpg" },
                new ProductImage { Id = 26, ProductId = 7, ProductPath = "7.1.jpg" },
                new ProductImage { Id = 27, ProductId = 7, ProductPath = "7.2.jpg" },
                new ProductImage { Id = 28, ProductId = 7, ProductPath = "7.3.jpg" },

                new ProductImage { Id = 29, ProductId = 8, ProductPath = "8.jpg" },
                new ProductImage { Id = 30, ProductId = 8, ProductPath = "8.1.jpg" },
                new ProductImage { Id = 31, ProductId = 8, ProductPath = "8.2.jpg" },
                new ProductImage { Id = 32, ProductId = 8, ProductPath = "8.3.jpg" },

                new ProductImage { Id = 33, ProductId = 9, ProductPath = "9.jpg" },
                new ProductImage { Id = 34, ProductId = 9, ProductPath = "9.1.jpg" },
                new ProductImage { Id = 35, ProductId = 9, ProductPath = "9.2.jpg" },
                new ProductImage { Id = 36, ProductId = 9, ProductPath = "9.3.jpg" },

                new ProductImage { Id = 37, ProductId = 10, ProductPath = "10.jpg" },
                new ProductImage { Id = 38, ProductId = 10, ProductPath = "10.1.jpg" },
                new ProductImage { Id = 39, ProductId = 10, ProductPath = "10.2.jpg" },
                new ProductImage { Id = 40, ProductId = 10, ProductPath = "10.3.jpg" },

                new ProductImage { Id = 41, ProductId = 11, ProductPath = "11.jpg" },
                new ProductImage { Id = 42, ProductId = 11, ProductPath = "11.1.jpg" },
                new ProductImage { Id = 43, ProductId = 11, ProductPath = "11.2.jpg" },
                new ProductImage { Id = 44, ProductId = 11, ProductPath = "11.3.jpg" },

                new ProductImage { Id = 45, ProductId = 12, ProductPath = "12.jpg" },
                new ProductImage { Id = 46, ProductId = 12, ProductPath = "12.1.jpg" },
                new ProductImage { Id = 47, ProductId = 12, ProductPath = "12.2.jpg" },
                new ProductImage { Id = 48, ProductId = 12, ProductPath = "12.3.jpg" },

                new ProductImage { Id = 49, ProductId = 13, ProductPath = "13.jpg" },
                new ProductImage { Id = 50, ProductId = 13, ProductPath = "13.1.jpg" },
                new ProductImage { Id = 51, ProductId = 13, ProductPath = "13.2.jpg" },
                new ProductImage { Id = 52, ProductId = 13, ProductPath = "13.3.jpg" },

                new ProductImage { Id = 53, ProductId = 14, ProductPath = "14.jpg" },
                new ProductImage { Id = 54, ProductId = 14, ProductPath = "14.1.jpg" },
                new ProductImage { Id = 55, ProductId = 14, ProductPath = "14.2.jpg" },
                new ProductImage { Id = 56, ProductId = 14, ProductPath = "14.3.jpg" },

                new ProductImage { Id = 57, ProductId = 15, ProductPath = "15.jpg" },
                new ProductImage { Id = 58, ProductId = 15, ProductPath = "15.1.jpg" },
                new ProductImage { Id = 59, ProductId = 15, ProductPath = "15.2.jpg" },
                new ProductImage { Id = 60, ProductId = 15, ProductPath = "15.3.jpg" },

                new ProductImage { Id = 61, ProductId = 16, ProductPath = "16.jpg" },
                new ProductImage { Id = 62, ProductId = 16, ProductPath = "16.1.jpg" },
                new ProductImage { Id = 63, ProductId = 16, ProductPath = "16.2.jpg" },
                new ProductImage { Id = 64, ProductId = 16, ProductPath = "16.3.jpg" }
                );


            // create any guid
            var adminRoleId = new Guid("8D04DCE2-969A-435D-BBA4-DF3F325983DC");
            var customerRoleId = new Guid("54BA416F-6B89-4C53-873D-4FBD48506E6D");
            var adminId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE");
            var customerId = new Guid("BFF91064-DC92-421E-A233-D1080F630928");
            var customerId2 = new Guid("BFF91054-DC92-421E-A233-D1080F630928");

            modelBuilder.Entity<AppRole>().HasData(
                new AppRole
                {
                    Id = adminRoleId,
                    Name = "admin",
                    NormalizedName = "admin",
                    Description = "Administrator role"
                },
                new AppRole
                {
                    Id = customerRoleId,
                    Name = "customer",
                    NormalizedName = "customer",
                    Description = "Customer role"
                });

            var hasher = new PasswordHasher<AppUser>();

            modelBuilder.Entity<AppUser>().HasData(
                new AppUser
                {
                    Id = adminId,
                    UserName = "admin",
                    NormalizedUserName = "admin",
                    Email = "thong@gmail.com",
                    NormalizedEmail = "thong@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Nguyen Hoang Thong",
                    Address = "Vinh Long"
                },
                new AppUser
                {
                    Id = customerId,
                    UserName = "customer1",
                    NormalizedUserName = "customer",
                    Email = "customer1@gmail.com",
                    NormalizedEmail = "customer1@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "Nguyen Hoang Thong Customer",
                    Address = "Can Tho"
                },
                new AppUser
                {
                    Id = customerId2,
                    UserName = "customer2",
                    NormalizedUserName = "customer",
                    Email = "customer2@gmail.com",
                    NormalizedEmail = "customer2@gmail.com",
                    EmailConfirmed = true,
                    PasswordHash = hasher.HashPassword(null, "Abcd1234!"),
                    SecurityStamp = string.Empty,
                    Name = "David",
                    Address = "TP HCM"
                });

            modelBuilder.Entity<IdentityUserRole<Guid>>().HasData(
                new IdentityUserRole<Guid>
                {
                    RoleId = adminRoleId,
                    UserId = adminId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId,
                },
                new IdentityUserRole<Guid>
                {
                    RoleId = customerRoleId,
                    UserId = customerId2,
                });

            modelBuilder.Entity<Comment>().HasData(
                new Comment { Id = 1, ProductId = 1, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Content = "Nồi tạm ổn", Star = 5, Created = DateTime.Now},
                new Comment { Id = 2, ProductId = 1, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Content = "Sản phẩm tốt", Star = 4, Created = DateTime.Now},
                new Comment { Id = 3, ProductId = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Content = "Chất lượng ổn", Star = 3, Created = DateTime.Now},
                new Comment { Id = 4, ProductId = 2, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Content = "Tạm ổn", Star = 2, Created = DateTime.Now},
                new Comment { Id = 5, ProductId = 3, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Content = "Nồi tạm ổn", Star = 1, Created = DateTime.Now},
                new Comment { Id = 6, ProductId = 7, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Content = "Tốt lắm", Star = 5, Created = DateTime.Now},
                new Comment { Id = 7, ProductId = 7, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Content = "Tàm tạm", Star = 3, Created = DateTime.Now},
                new Comment { Id = 8, ProductId = 8, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Content = "Ổn áp", Star = 4, Created = DateTime.Now},
                new Comment { Id = 9, ProductId = 9, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), Content = "Tốt", Star = 2, Created = DateTime.Now},
                new Comment { Id = 10, ProductId = 10, UserId = new Guid("69BD714F-9576-45BA-B5B7-F00649BE00DE"), Content = "Sản phẩm ổn", Star = 3, Created = DateTime.Now}
            );

            modelBuilder.Entity<Order>().HasData(
                new Order { Id = 1, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), OrderDate = new DateTime(2021, 5, 21, 12, 45, 0), DeliveryDate = new DateTime(2021, 5, 21, 12, 45, 0), Status = Enums.Status.Completed },
                new Order { Id = 2, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), OrderDate = new DateTime(2021, 5, 22, 13, 41, 0), DeliveryDate = new DateTime(2021, 5, 22, 10, 50, 0), Status = Enums.Status.Completed },
                new Order { Id = 3, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), OrderDate = new DateTime(2021, 5, 22, 15, 23, 0), DeliveryDate = new DateTime(2021, 5, 23, 9, 34, 0), Status = Enums.Status.Completed },
                new Order { Id = 4, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), OrderDate = new DateTime(2021, 5, 23, 12, 11, 0), DeliveryDate = new DateTime(2021, 5, 23, 16, 23, 0), Status = Enums.Status.Completed },
                new Order { Id = 5, UserId = new Guid("BFF91064-DC92-421E-A233-D1080F630928"), OrderDate = new DateTime(2021, 5, 24, 12, 11, 0), Status = Enums.Status.Shipping },
                new Order { Id = 6, UserId = new Guid("BFF91054-DC92-421E-A233-D1080F630928"), OrderDate = new DateTime(2021, 5, 24, 12, 30, 0), Status = Enums.Status.Shipping }
            );

            modelBuilder.Entity<OrderDetail>().HasData(
                new OrderDetail { OrderId = 1, ProductId = 1, Amount = 2 },
                new OrderDetail { OrderId = 2, ProductId = 2, Amount = 1 },
                new OrderDetail { OrderId = 3, ProductId = 3, Amount = 1 },
                new OrderDetail { OrderId = 3, ProductId = 1, Amount = 2 },
                new OrderDetail { OrderId = 4, ProductId = 1, Amount = 1 },
                new OrderDetail { OrderId = 5, ProductId = 3, Amount = 1 },
                new OrderDetail { OrderId = 5, ProductId = 2, Amount = 1 },
                new OrderDetail { OrderId = 6, ProductId = 4, Amount = 1 }
            );
        }
    }
}
