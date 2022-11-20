using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorunTakipSistemiEntityLayer.Model
{
    [Table("UserMembers", Schema = "dbo")]
    public class UserMember
    {
        public UserMember()
        {
            ID= Guid.NewGuid();
            Status=false;
            ProblemTrackingComments=new HashSet<ProblemTrackingComment>();
        }
        [Key,Required] // Birincil Anahtar (Tablolarda Zorunlu Birincil Anahtar Olması Gerekiyor)
        public Guid ID { get; set; } // Kullanıcı ID
        [Required,StringLength(70,ErrorMessage ="En fazla 70 karekter girebilirsiniz.")]
        public string NameSurname { get; set; } // Kulanıcının Adı Soyadı
        [Required,StringLength(70,ErrorMessage ="Lütfen en fazla 70 karekter giriniz."), MinLength(10,ErrorMessage ="En az 10 karekter girmek zorundasınız")]
        public string Email { get; set; } // Kullanıcı E-posta
        [Required,StringLength(25,ErrorMessage ="Lütfen en az 25 karekter giriniz."),MinLength(4,ErrorMessage ="Lütfen en az 4 karekter giriniz")]
        public string Username { get; set; } // Kullanıcı Adı

        [Required,StringLength(20,ErrorMessage ="Lütfen en fazla 20 karekter giriniz"),MinLength(8,ErrorMessage ="Lütfen en az 8 karekter giriniz.")]
        public string Password { get; set; } // Kullanıcı Telefonu
        [Required,MinLength(11,ErrorMessage ="Lütfen en az 11 karekter giriniz."), MaxLength(11,ErrorMessage = "Lütfen en az 11 karekter giriniz.")]
        public ulong Phone { get; set; } // Kullanıcı Telefon
        public string Address { get; set; } // Kullanıcı Adresi
        public string UserMemberRoleID { get; set; } // Kullanıcı Tipi Dropdown List (Dinamik Verilerle Donatılacak (Öğrenci,Öğretmen,Personel))
        public UserMemberRole UserMemberRole { get; set; }
        public bool Status { get; set; } // Kullanıcı Aktif Pasif
        public DateTime CreateDate { get; set; } // Kullanıcı Eklenme Tarihi
        public DateTime UpdateDate { get; set; } // Kullanıcı İşlem Güncelleme Tarihi

        public virtual ICollection<ProblemTrackingComment> ProblemTrackingComments { get; set; }

    }
}
