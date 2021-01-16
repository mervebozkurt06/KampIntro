using System;
using System.Collections.Generic;
using System.Text;

namespace Metotlar
{
    class SepetManager
    {
        //naming Convention ->Ekle
        //syntax
        public void Ekle(Urun urun) //-> ekle metodu
        {
            Console.WriteLine("Sepete Eklendi : " + urun.Adi);

        }

        public void Ekle2(string urunAdi, string aciklama, double fiyat,int stokAdedi) // 2. method
        {
            Console.WriteLine("Sepete Eklendi : " + urunAdi);
        }

    }
}
