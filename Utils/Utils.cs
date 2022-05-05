namespace UtilsMethods{

    public static class Utils{

        public static void Swap<T>(T[] array, int i, int j){
            T aux = array[i];
            array[i] = array[j];
            array[j] = aux;
        }
    }
}