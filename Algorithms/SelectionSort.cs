using UtilsMethods;

namespace Algorithms{



    public static class SelectionSort{

        public static void sort<T>(T[] array) where T:IComparable{


            for (int i = 0; i < array.Length; i++)
            {
                int currentMin = i;
                for (int j = i+1; j < array.Length; j++)
                {
                    if(array[currentMin].CompareTo(array[j]) > 0){
                        currentMin = j;                    }
                }
                Utils.Swap(array, i, currentMin);
            }
        }
    }
}