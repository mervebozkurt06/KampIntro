using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            //ŞUBEDEKİ ÇALIŞANIN EKRANI


            //IhtiyacKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager ihtiyacKrediManager = new IhtiyacKrediManager();
            IKrediManager tasitKrediManager = new TasitKrediManager();
            IKrediManager konutKrediManager = new KonutKrediManager();

            ILoggerService databaseLoggerService = new DatabaseLoggerService();
            ILoggerService fileLogerService = new FileLoggerService();

            BasvuruManager basvuruManager = new BasvuruManager();
            basvuruManager.BasvuruYap(konutKrediManager, databaseLoggerService);
            //basvuruManager.BasvuruYap(konutKrediManager, new DatabaseLoggerService()); -->DatabaseLoggerService böyle de instance yapılabilir

            List<IKrediManager> krediler = new List<IKrediManager>() { ihtiyacKrediManager,tasitKrediManager}; //ekrandan ihtiyacı seçtiğinde

            //basvuruManager.KrediOnBilgilendirmeYap(krediler);
        }
    }
}
//basvuruManager.BasvuruYap(ihtiyacKrediManager); //çalışan ihtiyacı seçti

