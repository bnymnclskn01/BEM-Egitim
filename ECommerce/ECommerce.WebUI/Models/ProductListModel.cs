using ECommerce.EntityLayer.Model;
using System;
using System.Collections;
using System.Collections.Generic;

namespace ECommerce.WebUI.Models
{
    public class PageingInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage { get; set; }
        public int CurentPage { get; set; }
        public string CurrentCategory { get; set; }
        public int PagePages()
        {
            return (int)Math.Ceiling((decimal)TotalItems/ ItemsPerPage);
        }
    }

    public class ProductListModel
    {
        public PageingInfo PageingInfo { get; set; }
        public List<Product> Products { get; set; }    
    }
}
