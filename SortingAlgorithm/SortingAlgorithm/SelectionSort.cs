using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class SelectionSort
    {
        static int size = 100;
        int[] dizi = new int[size];
        int gecici, i, j, min;
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
            for (i = 0; i < size; i++)
            {
                min = i;
                for (j = i + 1; j < size; j++)
                {
                    if (dizi[j] < dizi[min])
                    { min = j; }
                    gecici = dizi[i];
                    dizi[i] = dizi[min];
                    dizi[min] = gecici;
                }
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
