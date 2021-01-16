using System;

namespace Donguler
{
    class Program
    {
        static void Main(string[] args)
        {
            string kurs1 = "Yazılım Geliştirici Kampı Yetiştirme Kampı";
            string kurs2 = "Programlamaya başlangıç için temel kurs";
            string kurs3 = "Java";

            Console.WriteLine(kurs1);
            Console.WriteLine(kurs2);
            Console.WriteLine(kurs3);


            //array - dizi

            string[] kurslar = new string[] {
                "Yazılım Geliştirici Kampı Yetiştirme Kampı",
            "Programlamaya başlangıç için temel kurs",
            "Java"};

            for (int i = 0; i <kurslar.Length;i++)
            {
                Console.WriteLine(kurslar[i]);
            }

            foreach (string kurs in kurslar) //kursları dolaş tek tek - kurs=alias
            {
                Console.WriteLine(kurs);
               
            }


        }
    }
}
