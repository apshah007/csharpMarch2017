using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;


namespace CLproject
{
    public class GroceryContext : DbContext
    {
        public GroceryContext()
        {
            // database.setinitializer(new databaseinitializer());
        }

        public DbSet<Product> Products { get; set; }

    }
}