using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        //Method injection

        public void BasvuruYap(IKrediManager krediManager,ILoggerService loggerService) //hangi tipi krediye göre başvuru yapılacak? hepsinin referansını tutan interface gönderilir
        {
            //başvuran bilgilerini değerlendirme
            //

            krediManager.Hesapla(); //gelen parametreye göre bu çalışır taşıt konut ihtyaç olarak gelebilir
            loggerService.Log(); //tek log gönderirken 


            //yanlış kullanım-------
            KonutKrediManager konutKrediManager = new KonutKrediManager();
            konutKrediManager.Hesapla();
            //böyle yapılırsa tüm başvurular konutkredisine bağlı oldu

        }

        public void KrediOnBilgilendirmeYap(List<IKrediManager> krediler) //bir kredi de seçip hesaplamak isteyebilir 100 tane de bu yüzden IKrediManager türünde list
        {
            foreach (var kredi in krediler) //bütün listedeki kredi türlerini dolaş ve hesabını yap
            {
                kredi.Hesapla();
            }

        }
    }
}
