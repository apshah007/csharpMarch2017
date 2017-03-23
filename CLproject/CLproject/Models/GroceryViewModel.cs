using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;


namespace CLproject.Models
{
    public class GroceryViewModel
    {
        public GroceryItem Item { get; set; }
        public List<GroceryItem> Groceries { get; set; }

        public GroceryViewModel()
        {
            this.Groceries = new List<GroceryItem>();
        }

    }

    public class GroceryItem
    {
        // [DisplayName("Item ID")]
        public int ItemId { get; set; }
        [DisplayName("Product Name")]
        [MaxLength(50, ErrorMessage = "Max length is 50 characters")]
        [MinLength(3, ErrorMessage= "Min length is 3 characters")]
        public string ProductName { get; set; }

        public bool InCart { get; set; }
    }

    
}

