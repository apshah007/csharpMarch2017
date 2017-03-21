using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace CLproject
{
    public class GroceryContext : DbContext
    {
        public DbSet<Grocery> Grocery { get; set; }
    }

}