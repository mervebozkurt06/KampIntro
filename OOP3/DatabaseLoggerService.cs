using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class DatabaseLoggerService : ILoggerService //veritabanına loglama yapılacak
    {
        public void Log()
        {
            Console.WriteLine("Veritabanına loglandı");
        }
    }
}
