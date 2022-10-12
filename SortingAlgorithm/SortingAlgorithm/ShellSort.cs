using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingAlgorithm
{
    class ShellSort
    {
        static int size = 100;
        int[] dizi = new int[size];
        int i, j, temp, artis;
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
            artis = size / 2;
            while(artis>0)
            {
                for(i=artis;i<size;i++)
                {
                    j = i;
                    while((j>=artis)&& (dizi[j-artis]>temp))
                    {
                        dizi[j] = dizi[j - artis];
                        j = j - artis;
                    }
                    dizi[j] = temp;
                }
                if (artis == 2)
                    artis = 1;
                else
                    artis = (int)(artis / 2.2);
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
