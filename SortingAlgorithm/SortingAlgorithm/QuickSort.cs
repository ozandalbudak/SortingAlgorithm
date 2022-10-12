using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class QuickSort
    {
        static int size = 100;
        int[] dizi = new int[size];
        int gecici, i, j, k, pivot, sol = 0, sag = size - 1;
        void sayiUret()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                dizi[i] = rnd.Next(0, 1000);
                Console.WriteLine(dizi[i]);
            }
        }
        void sirala(int[] dizi, int sol, int sag)
        {
            k = sol; j = sag; pivot = dizi[k];
            do
            {
                while ((dizi[j] >= pivot) && (j > k))
                    j--;
                if (k != j)
                {
                    gecici = dizi[k];
                    dizi[k] = dizi[j];
                    dizi[j] = gecici;
                }
                while ((dizi[k] < pivot) && (j > k))
                    k++;
                if (k != j)
                {
                    gecici = dizi[j];
                    dizi[j] = dizi[k];
                    dizi[k] = gecici;
                    j--;
                }
            } while (k < j);
            if ((sol + 1) < k)
            { sirala(dizi, sol, k - 1); }
            if ((sag + 1) < k)
            {
                sirala(dizi, k + 1, sag);
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
