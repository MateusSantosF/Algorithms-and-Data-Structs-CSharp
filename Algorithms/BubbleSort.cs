
using System;
using Utils;

namespace Algorithms{

    public static class BubbleSort{     
       public static void sort<T> (T[] array) where T : IComparable{

           var length = array.Length;
           bool swap = false;

           for (int i = 0; i < length || swap; i++)
           {
               swap = false;
               for (int j = i + 1; j < length; j++)
               {
                   if(array[i].CompareTo(array[j]) > 0){
                       Utils.Utils.Swap(array, i, j);
                       swap = true;
                   }
               }
           }
           
       }
    }
}