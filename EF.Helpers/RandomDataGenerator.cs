using System;
using EF.Models;

namespace EF.Helpers
{
    public class RandomDataGenerator
    {

        private static readonly Random Rand;

        static RandomDataGenerator()
        {
            Rand = new Random();
        }

        public static Product GenerateProduct()
        {
            var product = new Product
            {
                Name = "Some Name " + Rand.Next(0, 1000),
                Price = 1000 * (decimal)Rand.NextDouble(),
                DueDate = Rand.Next(0, 3) % 2 == 0 ? DateTime.Now.AddDays(Rand.Next(0, 50)) : DateTime.Now.AddDays(-1 * Rand.Next(0, 50)),
            };

            return product;
        }

        public static Store GenerateStore()
        {
            var store = new Store()
            {
                Name = "Store Name " + Rand.Next(0, 1000),
            };

            return store;
        }
    }
}
