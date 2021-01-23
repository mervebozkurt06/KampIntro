using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    interface IKrediManager //---->interface çünkü hesapla hepsinde farklı faiz oranına ve işlemlere sahip
    {                       // eğer birisi bu interface i kullanırsa hesapla() metodunu kullanmak zorunda olsun
                            // okunurluğu arttırmak için IKrediManager
        void Hesapla();
        void BirseyYap();
    }
}
//IKrediManager bir interface sahip olduğu metodları hangi class ona bağlıysa implemente etmek zorunda

//Interface leri birbirinin alternatifi olan kod içerikleri farklı olan durumlar için kullanırız

//loglama kim hangi operasyonu ne zaman çağırdı --birinin kredi başvurusuna sms mail gibi gönderme loglama 