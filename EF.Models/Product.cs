using System;

namespace EF.Models
{
    public class Product
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public DateTime DueDate { get; set; }

        public decimal Price { get; set; }
    }
}