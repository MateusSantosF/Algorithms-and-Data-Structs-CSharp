
using System;
using UtilsMethods;

namespace Algorithms{

    public static class BubbleSort{     
       public static void sort<T> (T[] array) where T : IComparable{

           int orderedPart = 0;
           bool swaped;

           do{
               swaped = false;
               for( int desordered = 0; desordered < (array.Length - orderedPart - 1); desordered++){
                   if( array[desordered].CompareTo(array[desordered+1]) > 0){
                       Utils.Swap(array, desordered, desordered+1);
                       swaped = true;
                   }
               }
               orderedPart++;
           }while(orderedPart <= array.Length && swaped);
           
       }
    }
}