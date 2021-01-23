using System;

namespace Oop2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Engin demiroğ
            GercekMusteri gercekMusteri = new GercekMusteri();
            gercekMusteri.Id = 1;
            gercekMusteri.MusteriNo = "12345";
            gercekMusteri.Adi = "Engin";
            gercekMusteri.Soyadi = "Demirog";
            gercekMusteri.TcNo = "121324";


            //Kodlama.io
            TuzelMusteri tuzelMusteri = new TuzelMusteri();
            tuzelMusteri.Id = 2;
            tuzelMusteri.MusteriNo = "798978";
            tuzelMusteri.SirketAdi = "Kodlama.io";
            tuzelMusteri.VergiNo = "12324254";


            Musteri musteri3 = new GercekMusteri(); //Musteri class ı hem Gercek hem de tuzel musteri classının referansını tutabiliyor.
            Musteri musteri4 = new TuzelMusteri();

            MusteriManager musteriManager = new MusteriManager(); //--> instance
            musteriManager.Ekle(gercekMusteri);
            musteriManager.Ekle(tuzelMusteri);

            





            //Gerçek Müşteri - Tüzel Müşteri
            //SO(L)ID

        }
    } 
    // 1 özellik tutan class
    // 2 operasyon tutan class
}
