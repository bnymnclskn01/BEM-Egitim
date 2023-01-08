using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interface.Abstract
{
    public interface IHesap
    {
        void Topla(int sayi1,int sayi2);
        void Cikarma(int sayi1,int sayi2);
        void Carpma(int sayi1,int sayi2);
        void Bolme(int sayi1,int sayi2);
    }
}
