

using Algorithms;

namespace Program{

    public class Program{

        public static void Main(string[] args){

            int[] arrBubble = new int[9]{0,6,3,1,2,10,2,8,5};
            int[] arrInsertion = new int[9]{0,6,3,1,2,10,2,8,5};
            int[] arrSelection = new int[9]{0,6,3,1,2,10,2,8,5};

            Console.WriteLine("\nSelection Sort");
            SelectionSort.sort(arrSelection);
            print(arrSelection);

            Console.WriteLine("\nInsertion Sort");
            InsertionSort.sort(arrInsertion);
            print(arrInsertion);

            Console.WriteLine("\nBubble Sort");
            BubbleSort.sort(arrBubble);
            print(arrBubble);

        }

        public static void print<T>(T[] arr){
            Console.Write("\nArray: [");
            for( int i = 0; i < arr.Length; i++){
                Console.Write(arr[i]);
                if( i != arr.Length - 1)Console.Write(",");
                Console.Write(" ");
            }
            Console.Write("]\n");
        }

    }
}