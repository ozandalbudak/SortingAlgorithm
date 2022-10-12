using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class MergeSort
    {
        static int size = 100;
        int[] dizi = new int[size];
        int i;
        void sayiUret()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                dizi[i] = rnd.Next(0, 1000);
                Console.WriteLine(dizi[i]);
            }
        }
        void sirala(int[] dizi, int low, int high)
        {
            int i = 0;
            int length = high - low + 1;
            int pivot = 0;
            int merge1 = 0;
            int merge2 = 0;
            int[] working = new int[size];
            if (low == high)
                return;
            pivot = (low + high) / 2;
            sirala(dizi, low, pivot);
            sirala(dizi, pivot + 1, high);
            for (i = 0; i < length; i++)
            {
                working[i] = dizi[low + i];
            }
            merge1 = 0;
            merge2 = pivot - low + 1;

            for (i = 0; i < length; i++)
            {
                if (merge2 <= high - low)
                {
                    if (merge1 <= pivot - low)
                    {
                        if (working[merge1] > working[merge2])
                        {
                            dizi[i + low] = working[merge2++];
                        }
                        else
                        {
                            dizi[i + low] = working[merge1++];
                        }
                    }
                    else
                    {
                        dizi[i + low] = working[merge2++];
                    }
                }
                else
                {
                    dizi[i + low] = working[merge1++];
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
