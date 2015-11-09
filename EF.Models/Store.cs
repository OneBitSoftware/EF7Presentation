using System.Collections.Generic;

namespace EF.Models
{
    public class Store
    {
        public int Id { get; set; }

        public string Name { get; set; }
         
        public decimal Income { get; set; }

        public ICollection<Product> Products { get; set; }
    }
}
