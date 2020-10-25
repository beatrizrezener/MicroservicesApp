using System;
using System.Linq;
using System.Collections.Generic;
using MongoDB.Driver;
using Catalog.API.Entities;

namespace Catalog.API.Data
{
    public class CatalogContextSeed
    {
        public static void SeedData(IMongoCollection<Product> productCollection)
        {
            bool existProduct = productCollection.Find(p => true).Any();
            if(!existProduct)
            {
                productCollection.InsertManyAsync(GetPreconfiguredProducts());
            }
        }

        public static IEnumerable<Product> GetPreconfiguredProducts()
        {
            return new List<Product>()
            {
                new Product()
                {
                    Name = "Product A",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "imageA.png",
                    Price = 950.00M,
                    Category = "Smartphone"
                },
                new Product()
                {
                    Name = "Product B",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "imageB.png",
                    Price = 840.00M,
                    Category = "Smartphone"
                },
                                new Product()
                {
                    Name = "Product C",
                    Summary = "Summary",
                    Description = "Description",
                    ImageFile = "imageC.png",
                    Price = 350.00M,
                    Category = "Smartphone"
                },
            };
        }
    }
}
