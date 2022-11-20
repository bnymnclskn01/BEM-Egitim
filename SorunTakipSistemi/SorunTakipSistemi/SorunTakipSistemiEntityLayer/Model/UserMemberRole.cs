using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SorunTakipSistemiEntityLayer.Model
{
    [Table("UserMemberRoles", Schema = "dbo")]
    public class UserMemberRole
    {
        public UserMemberRole()
        {
            ID = Guid.NewGuid();
            Status = false;
            UserMembers = new HashSet<UserMember>();
        }
        [Key]
        public Guid ID { get; set; }
        public string RoleName { get; set; } //Rol Adı
        public int RoleCode { get; set; } // Rol Kodu 0-1-2-3 Olacak
        public string RoleNote { get; set; } // Role Notları
        public bool Status { get; set; } // Rol Aktif Pasif
        public DateTime CreateDate { get; set; } // Rol Eklenme Tarihi
        public DateTime UpdateDate { get; set; } // Rol İşlem Güncelleme Tarihi

        public virtual ICollection<UserMember> UserMembers { get; set; }
    }
}
