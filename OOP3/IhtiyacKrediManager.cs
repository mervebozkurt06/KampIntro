using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class IhtiyacKrediManager : IKrediManager //-->interface deki metodları içermek zorunda
    {
        public void BirseyYap()
        {
            throw new NotImplementedException();
        }

        public void Hesapla()
        {
            //
            //

            Console.WriteLine("Ihtiyac Kredisi ödeme planı hesaplandı");
        }
    }
}
