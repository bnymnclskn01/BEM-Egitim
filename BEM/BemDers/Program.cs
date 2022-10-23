using BemDers.Class;
using System;

namespace BemDers
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Örnek 1
            //string Ad, Soyad;
            //Ad = "Fatih";
            //Soyad = "Karslı";

            //Console.WriteLine("Kullanıcının Adı Soyadı : " + Ad + " " + Soyad);
            //Console.WriteLine("Kullanıcının Adı Soyadı : {0} {1}", Ad, Soyad);

            //Console.WriteLine("Adınızı Giriniz: ");
            //Ad = Console.ReadLine();
            //Console.WriteLine("Soyadınızı Giriniz : ");
            //Soyad = Console.ReadLine();

            //Console.WriteLine("Kullanıcının Adı Soyadı : " + Ad + " " + Soyad);
            //Console.WriteLine("Kullanıcının Adı Soyadı : {0} {1}",Ad, Soyad);
            #endregion
            #region Örnek 2
            //double sayi, sonuc;
            //Console.Write("KDV'si alınacak tutarı giriniz. : ");
            //sayi = Convert.ToDouble(Console.ReadLine());
            //sonuc = (sayi * 18) / 100;
            //sayi = (sayi * 18) / 100;
            //Console.WriteLine();
            //Console.Write("İşlem Sonucu : " + sonuc);
            //Console.WriteLine();
            //Console.Write("İşlem Sonucu : " + sayi);
            #endregion
            #region Örnek 3
            //int sayi1, sayi2;
            //Console.WriteLine("1. Sayiyi Giriniz");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //Console.WriteLine("2. Sayiyi Giriniz");
            //sayi2 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 > sayi2)
            //    Console.WriteLine("1. Sayı 2.Sayıdan Büyüktür.");
            //else if (sayi1 == sayi2)
            //    Console.WriteLine("İki sayı eşittir.");
            //else
            //    Console.WriteLine("2.Sayı 1.Sayıdan Büyüktür.");

            #endregion
            #region Örnek 4
            //int sayi;
            //Console.WriteLine("Sayı Giriniz : ");
            //sayi = Convert.ToInt32(Console.ReadLine());
            //if (sayi % 4 == 0 && sayi % 7 == 0)
            //    Console.WriteLine("Sayi 4'e ve 7'ye Tam Bölünüyor");
            #endregion
            #region Örnek 5
            // Girilen sayının 0 ile 100 arasında olp olmadığını bulan program
            //int sayi1 = 0;
            //Console.WriteLine("Bir sayı giriniz...");
            //sayi1 = Convert.ToInt32(Console.ReadLine());
            //if (sayi1 <= 100 && sayi1 >= 0)
            //    Console.WriteLine("Sayi 0 ile 100 arasındadır");
            //else
            //    Console.WriteLine("Sayi 0 ile 100 arasında değildir.");
            #endregion
            #region Örnek 6
            //Girilen cümledeki kelime sayılarını bulan ve kelimeleri ayırarak gösteren programı yazın.
            //string metin;
            //Console.Write("Metni Girin  : ");
            //metin = Console.ReadLine();
            //string[] kelimeler = metin.Split(' ');
            //Console.WriteLine("Kelime Sayısı :" + kelimeler.Length);
            //foreach (string kelime in kelimeler)
            //{
            //    Console.WriteLine(kelime);
            //}
            #endregion
            #region Örnek 7
            // 1 ile 50 arasındaki sayıları toplayark Ekrana Yazdıran Program
            #region Cevap
            //int sayi, toplam = 0;
            //for (int i = 1; i <= 50; i++)
            //{
            //    Console.Write(i + ". Sayı : ");
            //    sayi = Convert.ToInt32(Console.ReadLine());
            //    toplam += sayi;
            //}
            //Console.WriteLine("Toplam : " + toplam);

            #endregion
            #endregion
            #region Örnek 8
            //Bilet Kesim Operasyonu yazacağız kullanıcı bilet kesme işlemi kullanıcı tarafından sonlanmadıkça sürekli yeni bilet kesim ekranı gelecek.
            //for(; ; )
            //{
            //    Console.WriteLine("Bilet Kesmek İstiyor Musunuz ? E/H");
            //    char secim = Convert.ToChar(Console.ReadLine());
            //    if (secim == 'H' || secim == 'h')
            //    {
            //        break;
            //    }
            //}
            //bool BiletTakip = true;
            //while (BiletTakip)
            //{
            //    Console.Write("Kesimi durdurmak için y harfine basınız : ");
            //    char secim = Convert.ToChar(Console.ReadLine());
            //    if (secim == 'y' || secim == 'Y')
            //    {
            //        BiletTakip = false;
            //        break;
            //    }
            //}

            #endregion
            #region Örnek 9
            //bool Secim = false;
            //SubClass subClass = new SubClass();
            //char Islemler;

            //do
            //{
            //    Console.WriteLine("BalkanBank Hoş Geldiniz \n***************\nYapmak istediğiniz işlem nedir?\n***************\n1-Para Çekme\n2-Para Yatırma\n3-Para Transferi\n4-Kira Ödmee\n5-Vergi Ödeme\n6-Çıkış Yapmak İstiyorum\n***************\nBalkanBank İşlem Menüsü");
            //    Islemler = Convert.ToChar(Console.ReadLine());

            //    switch (Islemler)
            //    {
            //        case '1':
            //            subClass.ParaCekme();
            //            Secim = true;
            //            Console.Clear();
            //            break;
            //        case '2':
            //            subClass.ParaYatirma();
            //            Secim = true;
            //            Console.Clear();
            //            break;
            //        case '3':
            //            subClass.ParaTranseri();
            //            Secim = true;
            //            Console.Clear();
            //            break;
            //        case '4':
            //            subClass.KiraOdeme();
            //            Secim = true;
            //            Console.Clear();
            //            break;
            //        case '5':
            //            subClass.VergiOdeme();
            //            Secim = true;
            //            Console.Clear();
            //            break;
            //        case '6':
            //            Secim = false;
            //            Console.Clear();
            //            break;
            //    }
            //} while (Secim == true);
            #endregion
            #region Örnek 10
            Koltuk koltuk = new Koltuk();
            Masa masa = new Masa();
            masa.OzellikYaz();
            koltuk.OzellikYaz();
            #endregion
            Console.ReadKey();
        }  
    }
}
