using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

// this is the correct working project with working database
namespace CLproject
{
    public class GroceryContext : DbContext
    {
        public GroceryContext()
        {
            // database.setinitializer(new databaseinitializer());
            
        }

       // public object ProductName { get; internal set; }
       //sets up a new database 
        public DbSet<Product> Products { get; set; }

    }
}