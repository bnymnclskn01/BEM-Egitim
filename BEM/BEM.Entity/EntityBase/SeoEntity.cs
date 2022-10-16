using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BEM.Entity.EntityBase
{
    public class SeoEntity :BasicEntity
    {
        public string seoTitle { get; set; } // Sayfa Başlık
        public string seoKeywords { get; set; } // Sayfa Anahtar Kelime
        public string seoDescription { get; set; } // Sayfa Açıklaması
        public string seoAuthor { get; set; } // Site Yazarı
        public string seoCopyright { get; set; } // Lisans Yazısı
        public string seoDesign { get; set; } // Site Tasarımsıcısı
        public string seoReply { get; set; } // firma web sitesi
        public string seoSubject { get; set; }  // Site Konusu
        public string seoTwitterTitle { get; set; } // seo Twitter Başlık
        public string seoTwitterKeywords { get; set; } // Seo Twitter Anahtar Kelimeler
        public string seoTwitterDescription { get; set; } // seo Twitter Açıklaması
        public string seoTwitterUrl { get; set; } // Twitter Adresiniz
        public string seoFacebookTitle { get; set; } // Facebook Adres Başlğı
        public string seoFacebookKeywrods { get; set; } // Facebook Anahtar Kelime
        public string seoFacebookDescription { get; set; } // Facebook Açıklama
        public string seoFacebookUrl { get; set; } // Facebook URL
    }
}
