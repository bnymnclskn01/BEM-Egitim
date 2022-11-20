using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorunTakipSistemiEntityLayer.Model
{
    [Table("ProblemTrackingComments", Schema = "dbo")]
    public class ProblemTrackingComment
    {
        public ProblemTrackingComment()
        {
            ID = Guid.NewGuid();
            ProblemTrackingComments = new HashSet<ProblemTrackingComment>();
        }
        [Key]
        public Guid ID { get; set; } // Yorum ID
        public Guid ProblemTrackingID { get; set; } // İşlem Takip ID Alacağız
        public ProblemTracking ProblemTracking { get; set; } // İşlem Takip Tablosu Referans Ediliyor
        public Guid UserMemberID { get; set; } // Kullanıcı ID Alacağız Kullanıcı Tablosundan Refere Ediyoruz.
        public UserMember UserMember { get; set; } // Refere edildiği yer kullanıcının.
        public string CommentTitle { get; set; } // Yorum Başlık
        public string CommentDescription { get; set; } // Yorum Açıklama
        public virtual ICollection<ProblemTrackingComment> ProblemTrackingComments { get; set; }
    }
}
