using System;
using System.Diagnostics;
using System.Linq;
using EF.Helpers;

namespace Ef7.Console
{
    class Program
    {
        private const int Count = 5;

        static void Main()
        {
            //CreateItems();
            //UpdateItems();
            ListModifiedEntries();

            System.Console.ReadLine();
        }

        private static void ListModifiedEntries()
        {
            var context = new Ef7Context();
            context.LogQuery();

            var modified = from s in context.Stores
                where Microsoft.Data.Entity.EF.Property<DateTime>(s, "LastUpdated") != null
                select s;

            foreach (var store in modified)
            {
                System.Console.WriteLine(store.Name);
            }
        }


        private static void CreateItems()
        {
            var context = new Ef7Context();
            context.LogQuery();
            System.Console.WriteLine("Creating {0} items started! ", Count);
            var timer = Stopwatch.StartNew();

            timer.Start();
            for (var i = 0; i < Count; i++)
            {
                context.Stores.Add(RandomDataGenerator.GenerateStore());
            }

            context.SaveChanges();

            timer.Stop();
            System.Console.WriteLine("Adding {0} took: {1}", Count, timer.Elapsed);
        }

        private static void UpdateItems()
        {
            var context = new Ef7Context();
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
