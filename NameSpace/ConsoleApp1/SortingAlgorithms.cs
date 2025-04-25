using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    //public delegate TResult SortDel<in T,out TResult>(T x,T y); //more clean

    internal class SortingAlgorithms<T>
    {
        public static void BubbleSort(T[] array, Func<T,T,bool> opration)
        {
            if (array is not null)
            {
                for (int i = 0; i < array.Length; i++)
                {
                    for (int j = 0; j < array.Length - i - 1; j++)
                    {
                        if (opration.Invoke(array[j], array[j + 1]))
                            SWAP(ref array[j], ref array[j + 1]);
                        //if (opration.Invoke(array[j], array[j + 1]))
                        //    SWAP(ref array[j], ref array[j + 1]);

                    }
                }
            }
        }

        private static void SWAP(ref T v1, ref T v2)
        {
            T temp;
            temp = v1;
            v1 = v2;
            v2 = temp;
        }

        public static bool SortAsc(int x,int y)
        {
            return x > y;
        }
        public static bool SortDsc(int x,int y)
        {
            return x < y;
        }

    }
}
