using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEM.Entity.EntityBase
{
    public class BasicEntity
    {
        public BasicEntity()
        {
            this.ID = Guid.NewGuid();
            this.IsActive = false;
        }
        [Key,Required]
        public Guid ID { get; set; } // ID bağımsız 16 basamaklı sayi sisteminden değer üretiyor.
        public bool IsActive { get; set; } // Veri Aktif Durumunu Kontrol Ediyor.
        public DateTime NewCreateDate { get; set; } // İşlem yapıldığı tarihi alıyoruz.
        public DateTime NewLastDate { get; set; } // Son İşlem Tarihi.
    }
}
