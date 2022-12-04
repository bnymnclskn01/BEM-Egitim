using System.Text.RegularExpressions;

namespace JoinDataTable.WebUI.Models.Helper
{
    public class StringHelper
    {
        /// <summary>
        /// Url replace için kullanılan fonksiyon
        /// </summary>
        /// <param name="text"></param>
        /// returns></returns>
        public static string StringReplacer(string text)
        {
            text = text.Replace("Q", "q");
            text = text.Replace("İ", "I");
            text = text.Replace("ı", "i");
            text = text.Replace("Ğ", "G");
            text = text.Replace("ğ", "g");
            text = text.Replace("Ö", "O");
            text = text.Replace("ö", "o");
            text = text.Replace("Ü", "U");
            text = text.Replace("ü", "u");
            text = text.Replace("Ş", "S");
            text = text.Replace("ş", "s");
            text = text.Replace("Ç", "C");
            text = text.Replace("ç", "c");
            text = text.Replace(" ", "-");
            text = text.Replace("!", "");
            text = text.Replace("?", "");
            text = text.Replace(".", "");
            text = text.Replace(":", "");
            text = text.Replace(";", "");
            text = text.Replace("'", "");
            text = text.Replace("\"", "");
            return text;
        }

        ///<summary>
        ///İçerik verilerini düzenlemek için kullanılan fonksiyon
        ///</summary>
        ///<param name="metin"></param>
        ///<returns></returns>
        public static string KarekterDuzenle(string metin)
        {
            string Duzenlenmis= metin;
            Duzenlenmis = Duzenlenmis.Replace("&#304;", "I");
            Duzenlenmis = Duzenlenmis.Replace("&#305", "i");
            Duzenlenmis = Duzenlenmis.Replace("&#214", "Ö");
            Duzenlenmis = Duzenlenmis.Replace("&#246", "ö");
            Duzenlenmis = Duzenlenmis.Replace("&#Ouml", "ö");
            Duzenlenmis = Duzenlenmis.Replace("&#ouml", "Ü");
            Duzenlenmis = Duzenlenmis.Replace("&#220", "Ü");
            Duzenlenmis = Duzenlenmis.Replace("&#252", "ü");
            Duzenlenmis = Duzenlenmis.Replace("&Uuml", "Ü");
            Duzenlenmis = Duzenlenmis.Replace("&uuml", "ü");
            Duzenlenmis = Duzenlenmis.Replace("&#199", "Ç");
            Duzenlenmis = Duzenlenmis.Replace("&#231", "ç");
            Duzenlenmis = Duzenlenmis.Replace("&Ccedil;", "Ç");
            Duzenlenmis = Duzenlenmis.Replace("&ccedil;", "ç");
            Duzenlenmis = Duzenlenmis.Replace("&#286;", "G");
            Duzenlenmis = Duzenlenmis.Replace("&#287;", "g");
            Duzenlenmis = Duzenlenmis.Replace("&#350;", "S");
            Duzenlenmis = Duzenlenmis.Replace("&#351;", "s");
            return Duzenlenmis;
        }
        public static string ImgNameReplace(string IncomingText)
        {
            IncomingText = IncomingText.Replace("ş", "s");
            IncomingText = IncomingText.Replace("Ş", "s");
            IncomingText = IncomingText.Replace("İ", "i");
            IncomingText = IncomingText.Replace("I", "i");
            IncomingText = IncomingText.Replace("ı", "i");
            IncomingText = IncomingText.Replace("ö", "o");
            IncomingText = IncomingText.Replace("Ö", "o");
            IncomingText = IncomingText.Replace("ü", "u");
            IncomingText = IncomingText.Replace("Ü", "u");
            IncomingText = IncomingText.Replace("Ç", "c");
            IncomingText = IncomingText.Replace("ç", "c");
            IncomingText = IncomingText.Replace("ğ", "g");
            IncomingText = IncomingText.Replace("Ğ", "g");
            IncomingText = IncomingText.Replace(" ", "-");
            IncomingText = IncomingText.Replace("---", "-");
            IncomingText = IncomingText.Replace("?", "");
            IncomingText = IncomingText.Replace("/", "");
            IncomingText = IncomingText.Replace("'", "");
            IncomingText = IncomingText.Replace("#", "");
            IncomingText = IncomingText.Replace("%", "");
            IncomingText = IncomingText.Replace("&", "");
            IncomingText = IncomingText.Replace("*", "");
            IncomingText = IncomingText.Replace("!", "");
            IncomingText = IncomingText.Replace("@", "");
            IncomingText = IncomingText.Replace("+", "");
            IncomingText = IncomingText.Replace("|", "");

            IncomingText = IncomingText.ToLower();
            IncomingText = IncomingText.Trim();

            string encodedUrl = (IncomingText ?? "").ToLower();
            encodedUrl = Regex.Replace(encodedUrl, @"\&+", "and");
            encodedUrl = encodedUrl.Replace("'", "");
            encodedUrl = Regex.Replace(encodedUrl, @"[^a-z0-9,.]", "-");
            encodedUrl = Regex.Replace(encodedUrl, @"-+", "-");
            encodedUrl = encodedUrl.Trim('-');

            return encodedUrl;
        }
    }
}
