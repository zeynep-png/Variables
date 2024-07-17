using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Variables
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen asagıdaki bilgileri giriniz:");

            Console.Write("T.C. Kimlik Numarasi :");
            string kimlikNo = Console.ReadLine();

            Console.Write("Adi :");
            string ad = Console.ReadLine();

            Console.Write("Soyadi :");
            string soyAd = Console.ReadLine();

            // telefon numarasını string olarak alıyorum çünkü üzerinde bir işlem yapılmayacak
            Console.Write("Telefon Numarasi :");
            string telNo = Console.ReadLine(); 

            Console.Write("Yas :");
            
            int yas = Convert.ToInt32(Console.ReadLine());

            //alinan urunlerin fiyatlarini üzerinde islem yapabilmek icin integer a ceviriyorum
            Console.Write("İlk Aldigi Urunun Fiyati :");
            int ılkUrun = Convert.ToInt32(Console.ReadLine());

            Console.Write("Ikinci Aldigi Urunun Fiyati :");
            int ikinciUrun = Convert.ToInt32(Console.ReadLine());

            int toplam = ılkUrun + ikinciUrun;
            int puan = (toplam / 100 * 10);



            Console.WriteLine($"{kimlikNo} Tc numarali {ad} {soyAd} isimli kisi icin kayit olusturulmustur.");
            Console.WriteLine(telNo + "telefon numrasina bildirim mesaji gonderilmistir");
            Console.WriteLine($"{toplam} toplam harcama karsiligi kazanilan 10% patika puan miktari -> {puan} TL'dir");

            Console.WriteLine("Cikis icin bir tusa basiniz");
            Console.ReadKey();
        }
    }
}
