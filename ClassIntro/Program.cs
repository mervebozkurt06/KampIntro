using System;

namespace ClassIntro
{
    class Program
    {
        static void Main(string[] args)
        {
            string adi = "Merve";
            int yas = 24;

            //tanımladığın clasın değişkenini oluşturma ve değerleri atama
            Kurs kurs1=new Kurs();  //Kurs string int gibi yeni bir tür kendi yazdığımız
            kurs1.KursAdi = "C#";
            kurs1.Egitmen = "Engin Demirog";
            kurs1.IzlenmeOrani = 68;

            Kurs kurs2 = new Kurs();  //Kurs string int gibi yeni bir tür kendi yazdığımız
            kurs2.KursAdi = "Java";
            kurs2.Egitmen = "Kerem Varis";
            kurs2.IzlenmeOrani = 64;

            Kurs kurs3 = new Kurs();  //Kurs string int gibi yeni bir tür kendi yazdığımız
            kurs3.KursAdi = "Python";
            kurs3.Egitmen = "Berkay Bilgin";
            kurs3.IzlenmeOrani = 80;

            //Console.WriteLine(kurs1.KursAdi + " : " + kurs1.Egitmen);

            Kurs[] kurslar = new Kurs[] {kurs1,kurs2,kurs3 }; //içinde kurs tipinde veriler tutabiliriz

            foreach (var kurs in kurslar) //kursları gezer kurs=alias
            {
                Console.WriteLine(kurs.KursAdi + " : " + kurs.Egitmen);
            }


            Console.WriteLine("Hello World!");
        }
    }

    class Kurs
    {
        //prop tab tab --> property=özellik
        public string KursAdi { get; set; }
        public string Egitmen { get; set; }
        public int IzlenmeOrani { get; set; }

    }
}
