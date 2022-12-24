using ECommerce.EntityLayer.Model;
using System;
using System.Collections.Generic;

namespace ECommerce.WebUI.Models
{
    public class CategoryModel
    {
        public Guid ID { get; set; }
        public string Name { get; set; }
        public List<Product> Products { get; set; }
    }
}
