using MVCDERSUI.Models.EntityBase;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCDERSUI.Models.Entity
{
    [Table("UserMembers", Schema ="dbo")]
    public class UserMember : BasicEntity
    {
        public UserMember()
        {
            this.NameSurname = "";
            this.Email = "";
            this.Password = "";
            this.UserNote = "";
        }
        public string NameSurname { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string UserNote { get; set; }
    }
}
