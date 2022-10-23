using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemDers.Entity
{
    public class EncapsuationEntity
    {
        private string companyName;
        public string CompanyName { get { return companyName; } set {companyName = value; } }
        private string companyPhone;
        public string CompanyPohne { get { return companyPhone; } set { companyPhone = value; } }
    }
}
