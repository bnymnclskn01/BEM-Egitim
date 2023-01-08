using Interface.Concrete;
using System;

namespace Interface
{
    internal class Program
    {
        static void Main(string[] args)
        {
            HesapManager hesap = new HesapManager();
            hesap.Carpma(5, 5);
            hesap.Bolme(5, 5);
            hesap.Topla(5, 5);
            hesap.Cikarma(5, 5);
        }
    }
}
