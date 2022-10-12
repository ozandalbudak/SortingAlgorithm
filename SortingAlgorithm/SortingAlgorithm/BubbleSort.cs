using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class BubbleSort
    {
        static int size = 100;
        int[] dizi = new int[size];
        int gecici, i, k;
        void sayiUret()
        {
            Random rnd = new Random();
            for(int i=0;i<size;i++)
            {
                dizi[i] = rnd.Next(0, 1000);
                Console.WriteLine(dizi[i]);
            }
        }
        void sirala()
        {
            for(k=0;k<size-1;k++)
            {
                for(i=0;i<size-1;i++)
                {
                    if(dizi[i]<dizi[i+1])
                    {
                        gecici = dizi[i];
                        dizi[i] = dizi[i + 1];
                        dizi[i + 1] = gecici;
                    }
                }
            }
        }
        void ekranabas()
        {
            for(i=0;i<size;i++)
            {
                Console.WriteLine(dizi[i]);
            }
        }
    }
}
