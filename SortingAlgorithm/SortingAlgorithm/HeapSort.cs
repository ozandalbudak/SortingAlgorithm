using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class HeapSort
    {
        static int size = 100;
        int[] dizi = new int[size];
        int gecici, i, k;
        void sayiUret()
        {
            Random rnd = new Random();
            for (int i = 0; i < size; i++)
            {
                dizi[i] = rnd.Next(0, 1000);
                Console.WriteLine(dizi[i]);
            }
        }
        void heapbubble(int pos, int[] dizi, int len)
        {
            int z, max, left, right;
            z = left = max = right = gecici = 0;
            for (; ; )
            {
                left = 2 * z + 1;
                left = left + 1;
                if (left >= len)
                {
                    return;
                }
                else if (right >= len) max = left;
                else if (dizi[left] > dizi[right]) max = left;
                else max = right;
                if (dizi[z] > dizi[max])
                    return;
                gecici = dizi[z];
                dizi[z] = dizi[max];
                dizi[max] = gecici;
                z = max;
            }
        }
        void sirala(int []dizi,int len)
        {
            i = 0;
            gecici = 0;
            for(i=len/2;i>=0;--i)
            {
                heapbubble(i, dizi, len);
            }
            for(i=len-1;i>0;i--)
            {
                gecici = dizi[0];
                dizi[0] = dizi[i];
                dizi[i] = gecici;
                heapbubble(0, dizi, 1);
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
