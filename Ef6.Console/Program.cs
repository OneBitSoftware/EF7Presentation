using System.Diagnostics;
using System.Linq;
using EF.Helpers;

namespace Ef6.Console
{
    class Program
    {
        private const int Count = 5;

        static void Main()
        {
            CreateItems();
            //UpdateItems();
             
            System.Console.ReadLine();
        }

        private static void CreateItems()
        {
            var context = new Ef6Context();
            context.Database.Log = System.Console.Write;
            System.Console.WriteLine("Creating {0} items started! ", Count);
            var timer = Stopwatch.StartNew();

            timer.Start();
            for (var i = 0; i < Count; i++)
            {
                context.Stores.Add(RandomDataGenerator.GenerateStore());
            }

            // context.Database.Log = System.Console.Write;

            context.SaveChanges();

            timer.Stop();
            System.Console.WriteLine("Adding {0} took: {1}", Count, timer.Elapsed);
        }

        private static void UpdateItems()
        {
            var context = new Ef6Context();
            System.Console.WriteLine("Updating {0} items started! ", Count);
            var timer = Stopwatch.StartNew();

            timer.Start();

            var stores = context.Stores.OrderBy(x => x.Id).Take(Count);

            foreach (var store in stores)
            {
                store.Name = store.Name + " Updated";
            }

            context.SaveChanges();

            timer.Stop();
            System.Console.WriteLine("Updating {0} items took: {1}", Count, timer.Elapsed);
        }
    }
}
