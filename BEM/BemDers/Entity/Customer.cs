using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemDers.Entity
{
    public class Customer
    {
        private string namesurname;
        public string NameSurname 
        { 
            get { return namesurname; } 
            set { namesurname = value; }
        }
        private ulong phone;
        public ulong Phone
        {
            get { return phone; }
            set { phone = value; }
        }
        private ulong identityNumber;
        public ulong IdentityNumber
        {
            get { return identityNumber; }
            set { identityNumber = value; }
        }
    }
}
