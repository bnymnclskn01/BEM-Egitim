using BemDers.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BemDers.Class
{
    public class ActionMetod
    {
        public void MusteriEkle()
        {
            Customer customer = new Customer(); // Nesne tanımlama
            Console.WriteLine("****************************");
            Console.WriteLine("Müşteri Ekleme ekranına hoş geldiniz");
            Console.WriteLine("****************************");
            Console.WriteLine("Lütfen müşteri adınızı ve soyadınızı giriniz: ");
            customer.NameSurname = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Lütfen müşteri telefon numaranızı giriniz : ");
            customer.Phone = ulong.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            Console.WriteLine("lütfen tc kimlik numarasını yazınız. : ");
            customer.IdentityNumber = ulong.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            Console.WriteLine("Ekleme işlemi başarıyla tamamlanmıştır. İşlemleriniz için teşekkür ederiz.");
            Console.WriteLine("****************************");
        }
        public void AracEkle()
        {
            CarType carType = new CarType();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Ekleme Sayfasına Hoş Geldiniz.");
            Console.WriteLine("****************************");
            Console.WriteLine("Lütfen araç markasını giriniz. : ");
            carType.Brand = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Lütfen araç modelini giriniz. : ");
            carType.Model = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Lütfen araç kaç km'deyse giriniz : ");
            carType.Km = int.Parse(Console.ReadLine());
            Console.WriteLine("****************************");
            Console.WriteLine("Araç kaç model bir arabadır ? : ");
            carType.CreateDate = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç rengi nedir ? : ");
            carType.Color = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç tipi nedir ? : ");
            carType.CType = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç kaç kapılıdır ? : ");
            carType.NumberDoor = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Araç Yakıt Tipi Nedir ? : ");
            carType.FuelType = Console.ReadLine();
            Console.WriteLine("****************************");
            Console.WriteLine("Ekleme işlemi başarıyla tamamlanmıştır. İşlemleriniz için teşekkür ederiz.");
            Console.WriteLine("****************************");
        }
    }
}
