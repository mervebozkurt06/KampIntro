using System;
using System.Collections.Generic;
using System.Text;

namespace GenericsIntro
{
    class MyList<T>
    {
        T[] items; //array referans tip eleman eklenmesi için new lenmesi lazım
        public MyList() //ctor tab tab --> constructor
        {
            items = new T[0]; //arrayin newlendiği bloğa constructor denir
        }
        public void Add(T item)
        { 
            T[] tempArray = items; //new denildiğinde boş array referans ettiği için elemanları tempArray e yedekliyoruz önceki elemanlar uçmasın diye 
            items = new T[items.Length+1]; //dizinin eleman sayısını 1 arttırmak için çünkü 0 elemanlı başta
            for (int i = 0; i < tempArray.Length; i++)
            {
                items[i] = tempArray[i];
            }

            items[items.Length - 1] = item; //items ın son elemanı yeni gelen eleman olsun

        }
    }
}
