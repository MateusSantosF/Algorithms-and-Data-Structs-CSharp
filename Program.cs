

using Algorithms;

namespace Program{

    public class Program{

        public static void Main(string[] args){

            int[] arr = new int[9]{0,6,3,1,2,10,2,8,5};

            BubbleSort.sort(arr);
            print(arr);

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