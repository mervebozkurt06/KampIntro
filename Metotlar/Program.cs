using System;

namespace Metotlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            string[] meyveler = new string[] { "Elma", "Karpuz" };

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya Elmasi";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır Karpuzu";

            Urun[] urunler = new Urun[] { urun1,urun2}; //Urun array i oluşturduk - urun1 urun2 gibi 
                                                        // veriler genelde bir veri kaynağından gelir
            //type safe -- tip güvenli
            foreach (Urun urun in urunler) //urunler deki her bir elemanı tek tek gez
            {                              //urun= döndüğü eleman için takma isim(blok 2 kere çalışır)
                                           //Urun = veri tipi (C# veri tipi güvenliği için çalışacağı veri tipini bilmek ister)
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("------------");

            }

            Console.WriteLine("--------Metotlar-----------");

            //cw tab tab --> console writeline
            //instance - örnek 
            //encapsulation(kapsülleme) -> Urun sınıfına StokAdedi eklendiğinde diğer sayfalar etkilenmedi

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1); //bu method 2 farklı sayfada kullanabilme imkanı verdi
            sepetManager.Ekle(urun2);

            sepetManager.Ekle2("Armut","Yeşil armut",12,10);
            sepetManager.Ekle2("Elma","Yeşil elma",12,9);
            sepetManager.Ekle2("Karpuz","Diyarbakır karpuzu",12,8);
            


        }
    }
}



// tekrar tekrar kullanılabilirliği sağlayan kod blokları=metotlar
// do not repeat yourself - DRY - Clean Code - Best Practice

// urunAdi, fiyati, aciklama gibi bi ürün nesnesi oluşturmak için = classlar 
// classlar string int gibi bir veri tipidir.
// class isimlendirmeleri büyük harfle başlar