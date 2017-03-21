using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;

namespace MigrationsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new GroceryContext())
            {
                db.Blogs.Add(new Groceries { Name = "Added Grocery " });
                db.SaveChanges();

                foreach (var grocery in db.Groceries)
                {
                    Console.WriteLine(grocery.ProductName);
                }
            }

            
        }
    }
}
