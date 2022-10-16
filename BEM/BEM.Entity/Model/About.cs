using BEM.Entity.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEM.Entity.Model
{
    public class About : BasicEntity,IEntity
    {
        public About()
        {
            this.Title = "";
            this.Description = "";
            this.ImageUrl = "";
        }
        public string Title { get; set; } //  Hakkımızdanın Başlığı 110 karekter
        public string Description { get; set; } // Açıklama Alanı Serbest Atış Bölgesi
        public string ImageUrl { get; set; } // Resim Dosya Yolu
    }
}
