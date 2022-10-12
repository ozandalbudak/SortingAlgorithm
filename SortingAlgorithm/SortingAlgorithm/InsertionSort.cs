using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class InsertionSort
    {
        static int size = 100;
        int[] dizi = new int[size];
        int gecici, i, j, k;
        void sayiUret()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                dizi[i] = rnd.Next(0, 1000);
                Console.WriteLine(dizi[i]);
            }
        }
        void sirala()
        {
            for (i = 1; i < size; i++)
            {
                gecici = dizi[i];
                j = i - 1;
                while (gecici < dizi[j] && j >= 0)
                {
                    dizi[j + 1] = dizi[j];
                    j = j - 1;
                }
                dizi[j + 1] = gecici;
            }
        }
        void ekranabas()
        {
            for (i = 0; i < size; i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
