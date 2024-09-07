using BackendApi.models;
using Microsoft.EntityFrameworkCore;

namespace BackendApi.SeedData
{
    public static class ProductSeed
    {
        public static void Seed(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>().HasData(
                new Products
                {
                    Id = 1,
                    Name = "Smartphone",
                    Price = 699,
                    Description = "Latest model with cutting-edge technology.",
                    IsAvailable = true,
                    DateTime = DateTime.Now,
                    ImageUrl = "https://example.com/images/smartphone.jpg" // Replace with actual image
                },
                new Products
                {
                    Id = 2,
                    Name = "Laptop",
                    Price = 1299,
                    Description = "High performance laptop for professionals.",
                    IsAvailable = true,
                    DateTime = DateTime.Now,
                    ImageUrl = "https://example.com/images/laptop.jpg" // Replace with actual image
                },
                new Products
                {
                    Id = 3,
                    Name = "Headphones",
                    Price = 199,
                    Description = "Noise-cancelling over-ear headphones.",
                    IsAvailable = true,
                    DateTime = DateTime.Now,
                    ImageUrl = "https://example.com/images/headphones.jpg" // Replace with actual image
                },
                new Products
                {
                    Id = 4,
                    Name = "Smartwatch",
                    Price = 249,
                    Description = "Smartwatch with health tracking features.",
                    IsAvailable = false,
                    DateTime = DateTime.Now,
                    ImageUrl = "https://example.com/images/smartwatch.jpg" // Replace with actual image
                },
                new Products
                {
                    Id = 5,
                    Name = "Tablet",
                    Price = 499,
                    Description = "Portable tablet with high-resolution display.",
                    IsAvailable = true,
                    DateTime = DateTime.Now,
                    ImageUrl = "https://example.com/images/tablet.jpg" // Replace with actual image
                }
            );
        }
    }
}
