using project5.Models;
using System;
using System.Linq;

namespace project5.Data
{
    public static class DbInitializer
    {
        public static void Initialize(project5Context context)
        {
            context.Database.EnsureCreated();


            if (context.Category.Any())
            {
                return;   // DB has been seeded
            }

            var categories = new Category[]
            {
            new Category{Name="Áo Bóng Đá",EnrollmentDate=DateTime.Parse("2021-11-15")},
            new Category{Name="Giáy Bóng Đá",EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Category{Name="Tất Chống Trơn",EnrollmentDate=DateTime.Parse("2021-11-13")},
            new Category{Name="Áo Khoác CLB",EnrollmentDate=DateTime.Parse("2021-11-12")},
            };

            foreach (Category s in categories)
            {
                context.Category.Add(s);
            }
            context.SaveChanges();

            var products = new Product[]
             {
            new Product{CategoryID=1,Name=" Cheasea",Price=1000,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=1,Name=" Việt Nam",Price=1000,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=1,Name=" Hà Nội FC",Price=300,Unit=3,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=2,Name="Giáy Bóng Đá Mizuno",Price=1900,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=2,Name="Giáy Bóng Đá Wika",Price=1900,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=3,Name="Tất Chống Trơn Adidas",Price=10,Unit=1,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=3,Name="Tất Chống Trơn Mizuno",Price=30,Unit=3,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=4,Name="Áo Khoác Cheasea",Price=200,Unit=22,EnrollmentDate=DateTime.Parse("2021-11-14")},
            new Product{CategoryID=4,Name="Áo Khoác Việt Nam",Price=1900,Unit=14,EnrollmentDate=DateTime.Parse("2021-11-14")},
             };

            foreach (Product s in products)
            {
                context.Product.Add(s);
            }
            context.SaveChanges();
        }
    }
}
