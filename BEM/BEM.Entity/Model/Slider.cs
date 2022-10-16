using BEM.Entity.EntityBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEM.Entity.Model
{
    public class Slider : BasicEntity, IEntity
    {
        public string Title { get; set; } // Başlık
        public string Description { get; set; } // Açıklama
        public string ImageUrl { get; set; } // Resim Yolu
        public int Rank { get; set; }
    }
}
