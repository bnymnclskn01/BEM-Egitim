using BemDers.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemDers.Class
{
    public class Masa : Mobilya
    {
        public string Malzeme;
        public override void OzellikYaz()
        {
            Console.WriteLine("Lütfen Kanepenin Özelliklerini Giriniz");
            Console.WriteLine("Lütfen Renk Giriniz : ");
            Renk = Console.ReadLine();
            if (Renk == null || Renk == "")
            {
                Console.WriteLine("Lütfen Renk Alanını Boş Bırakmayınız.");
                Console.WriteLine("Lütfen Renk Griniiz : ");
                Renk = Console.ReadLine();
            }
            Console.WriteLine("Lütfen Malzemeyi Giriniz. : ");
            Malzeme = Console.ReadLine();
        }
    }
}
