using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

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
        public string ItemId { get; set; }
        [DisplayName("Product Name")]
        [MaxLength(50, ErrorMessage = "Max length is 50 characters")]
        public string ProductName { get; set; }

        public bool InCart { get; set; }
    }
}

