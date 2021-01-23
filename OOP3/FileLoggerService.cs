using System;

namespace OOP3
{
    class FileLoggerService : ILoggerService //metin dosyasına loglama yapılacak
    {
        public void Log()
        {
            Console.WriteLine("Dosyaya loglandı");
        }
    }
}
