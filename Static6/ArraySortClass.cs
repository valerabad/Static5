using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Static6
{
	static class ArraySortClass
	{
       static public bool DescendingDirectCompare(int A, int B, bool direct)
        {
            bool res;
            res = direct ? A > B : A < B;
            return res;
        }

       public static void BubbleSort(this int[] array, bool descending)
        {            
            for (int j = 0; j < array.Length - 1; j++)
            {
                for (int i = 0; i < array.Length - j - 1; i++)
                {
                    //if (array[i] < array[i + 1])
                    if (DescendingDirectCompare(array[i], array[i + 1], descending))
                    {
                        int tmp = array[i];
                        array[i] = array[i + 1];
                        array[i + 1] = tmp;
                    }                    
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);

            }            
        }
	}
}
