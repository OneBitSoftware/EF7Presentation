using System.Data.Entity;
using EF.Models;

namespace Ef6.Console
{
    public class Ef6Context : DbContext
    { 
        public IDbSet<Product> Products { get; set; }

        public IDbSet<Store> Stores { get; set; }
    }
}