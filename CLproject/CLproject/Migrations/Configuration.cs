namespace CLproject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CLproject;

 

    internal sealed class Configuration : DbMigrationsConfiguration<CLproject.GroceryContext>
    {
        private object contextGroceryContext;

        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
        }

        protected override void Seed(CLproject.GroceryContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //

            context.Products.AddOrUpdate(
                g => g.ProductName,
                new Product { ProductName = "Lettuce" },
                new Product { ProductName = "Dressing" },
                new Product { ProductName = "Tomato" }
                );

            context.Products.AddOrUpdate(
                g=> g.ProductId, 
                new Product { ProductId = 1 }, 
                new Product { ProductId = 2 }, 
                new Product { ProductId = 3 }
                );

            context.Products.AddOrUpdate(
                g => g.InCart,
                new Product { InCart = true },
                new Product { InCart = false },
                new Product { InCart = false }
                );
        }
    }
}
