using UtilsMethods;

namespace Algorithms{


    public static class InsertionSort{

        public static void sort<T>(T[] array) where T:IComparable{

            int ordered = 0;

            for (int i = 1; i < array.Length; i++)
            {
                ordered = i;
                while( ordered > 0){
                    if(array[ordered - 1].CompareTo(array[ordered]) > 0)
                    Utils.Swap(array, ordered-1, ordered);
                    ordered--;
                }
            }
        }
    }
}