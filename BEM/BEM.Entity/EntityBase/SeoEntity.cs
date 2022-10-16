using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEM.Entity.EntityBase
{
    public class SeoEntity :BasicEntity
    {
        public string seoTitle { get; set; } 
        public string seoKeywords { get; set; }
        public string seoDescription { get; set; }
        public string seoAuthor { get; set; }
        public string seoCopyright { get; set; }
        public string seoDesign { get; set; }
        public string seoReply { get; set; }
        public string seoSubject { get; set; }
        public string seoTwitterTitle { get; set; }
        public string seoTwitterKeywords { get; set; }
        public string seoTwitterDescription { get; set; }
        public string seoTwitterUrl { get; set; }
        public string seoFacebookTitle { get; set; }
        public string seoFacebookKeywrods { get; set; }
        public string seoFacebookDescription { get; set; }
        public string seoFacebookUrl { get; set; }
    }
}
