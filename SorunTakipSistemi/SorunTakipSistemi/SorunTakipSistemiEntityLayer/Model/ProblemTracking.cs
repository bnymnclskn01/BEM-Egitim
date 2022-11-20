using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorunTakipSistemiEntityLayer.Model
{
    [Table("ProblemTrackings",Schema ="dbo")]
    public class ProblemTracking
    {
        public ProblemTracking()
        {
            ID = Guid.NewGuid();
        }
        [Key]
        public Guid ID { get; set; } // İşlem Takip ID 
        public string ImageUrl { get; set; }
        public string Title { get; set; } // İşlem Başlığı
        public string Description { get; set; } // İşlem Açıklaması
        public string PriorityStatus { get; set; } // Öncelik Durumu
        public string TransactionStatus { get; set; } // İşlem Durumu
        public string RegistrationOpener { get; set; } // Kayıt Açan Kişi
        public string Transacter { get; set; } // Kayıtta İşlem Yapan Kişi
        public DateTime CreateDate { get; set; } // İşlem Eklenme Tarihi
        public DateTime UpdateDate { get; set; } // İşlem Güncelleme Tarihi
    }
}
