using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace project5.Models
{
    public class FilterCategory
    {
        public List<Product> Products { get; set; }
        public SelectList SelectCategory { get; set; }
        public string Category { get; set; }
    }
}
