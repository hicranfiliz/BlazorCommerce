﻿using BlazorCommerce.Model;

namespace BlazorCommerce.Services.ProductService
{
    public class ProductService : IProductService
    {
        public List<Product> Products { get; set; } = new List<Product>();  

        public void LoadProducts()
        {
            Products = new List<Product>()
            {
                new Product
                {
                    Id = 1,
                    CategoryId = 1,
                    Title = "The Hitchhiker's Guide to the Galaxy",
                    Description = "The Hitchhiker's Guide to the Galaxy (sometimes referred to as HG2G, HHGTTG, H2G2, or tHGttG) is a comedy science fiction series created by Douglas Adams.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/b/bd/H2G2_UK_front_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 9.99m,
                    OriginalPrice = 19.99m
                },
                new Product
                {
                    Id = 2,
                    CategoryId = 1,
                    Title = "Ready Player One",
                    Description = "Ready Player One is a 2011 science fiction novel, and the debut novel of American author Ernest Cline. The story, set in a dystopia in 2045, follows protagonist Wade Watts on his search for an Easter egg in a worldwide virtual reality game, the discovery of which would lead him to inherit the game creator's fortune.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/a/a4/Ready_Player_One_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 21.99m,
                    OriginalPrice = 25.99m
                },
                new Product
                {
                    Id = 3,
                    CategoryId = 2,
                    Title = "Pentax Spotmatic",
                    Description = "The Pentax Spotmatic refers to a family of 35mm single-lens reflex cameras manufactured by the Asahi Optical Co. Ltd., later known as Pentax Corporation, between 1964 and 1976.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/e9/Honeywell-Pentax-Spotmatic.jpg",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 9.99m,
                    OriginalPrice = 9.99m
                },
                new Product
                {
                    Id = 4,
                    CategoryId = 2,
                    Title = "Xbox",
                    Description = "The Xbox is a home video game console and the first installment in the Xbox series of video game consoles manufactured by Microsoft.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/4/43/Xbox-console.jpg",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 29.99m,
                    OriginalPrice = 39.99m
                },
                new Product
                {
                    Id = 5,
                    CategoryId = 2,
                    Title = "Super Nintendo Entertainment System",
                    Description = "The Super Nintendo Entertainment System (SNES), also known as the Super NES or Super Nintendo, is a 16-bit home video game console developed by Nintendo that was released in 1990 in Japan and South Korea.",
                    Image = "https://upload.wikimedia.org/wikipedia/commons/e/ee/Nintendo-Super-Famicom-Set-FL.jpg",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 9.99m,
                    OriginalPrice = 9.99m
                },
                new Product
                {
                    Id = 6,
                    CategoryId = 3,
                    Title = "Half-Life 2",
                    Description = "Half-Life 2 is a 2004 first-person shooter game developed and published by Valve. Like the original Half-Life, it combines shooting, puzzles, and storytelling, and adds features such as vehicles and physics-based gameplay.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/2/25/Half-Life_2_cover.jpg",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 13.99m,
                    OriginalPrice = 16.99m
                },
                new Product
                {
                    Id = 7,
                    CategoryId = 3,
                    Title = "Diablo II",
                    Description = "Diablo II is an action role-playing hack-and-slash computer video game developed by Blizzard North and published by Blizzard Entertainment in 2000 for Microsoft Windows, Classic Mac OS, and macOS.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/d/d5/Diablo_II_Coverart.png",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 9.99m,
                    OriginalPrice = 9.99m
                },
                new Product
                {
                    Id = 8,
                    CategoryId = 3,
                    Title = "Day of the Tentacle",
                    Description = "Day of the Tentacle, also known as Maniac Mansion II: Day of the Tentacle, is a 1993 graphic adventure game developed and published by LucasArts. It is the sequel to the 1987 game Maniac Mansion.",
                    Image = "https://upload.wikimedia.org/wikipedia/en/7/79/Day_of_the_Tentacle_artwork.jpg",
                    DateCreated = new DateTime(2021, 1, 1),
                    Price = 9.99m,
                    OriginalPrice = 9.99m
                }
            };
        }
    }
}
