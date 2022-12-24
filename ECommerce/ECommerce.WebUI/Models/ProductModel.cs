using ECommerce.EntityLayer.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace ECommerce.WebUI.Models
{
    public class ProductModel
    {
        public Guid Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(10000,MinimumLength =20,ErrorMessage ="Ürün açıklaması minimum 20 karakter ve maksimum 10000 karakter olmalıdır.")]
        public string Description { get; set; }
        [Required]
        public string ImageUrl { get; set; }

        [Required(ErrorMessage ="Fiyat Belirtiniz")]
        [Range(0,9999999999999)]
        public decimal? Price { get; set; }
        public List<Category> SelectedCategories { get; set; }
    }
}
