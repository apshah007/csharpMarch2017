namespace CLproject.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CLproject;

 

    internal sealed class Configuration : DbMigrationsConfiguration<CLproject.GroceryContext>
    {
       // private object contextGroceryContext;

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
                p => p.ProductName,
                 new Product { ProductName = "Lettuce", InCart = true },
                 new Product { ProductName = "Dressing", InCart = false },
                 new Product { ProductName = "Tomato", InCart = false }
                    );
        }
    }
}
