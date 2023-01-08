using Interface.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Concrete
{
    public class HesapManager : IHesap
    {
        public void Bolme(int sayi1, int sayi2)
        {
            double sonuc = Convert.ToDouble(sayi1 / sayi2);
            Console.WriteLine(sonuc);
        }

        public void Carpma(int sayi1, int sayi2)
        {
            double sonuc = Convert.ToDouble(sayi1 * sayi2);
            Console.WriteLine(sonuc);
        }

        public void Cikarma(int sayi1, int sayi2)
        {
            double sonuc = Convert.ToDouble(sayi1 - sayi2);
            Console.WriteLine(sonuc);
        }

        public void Topla(int sayi1, int sayi2)
        {
            double sonuc = Convert.ToDouble(sayi1 + sayi2);
            Console.WriteLine(sonuc);
        }
    }
}
