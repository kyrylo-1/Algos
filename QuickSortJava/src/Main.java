public class Main {

    public static void main(String[] args) {
        // write your code here

        int[] array = new int[] { 3, 9, 1, 34, 9, 10, -3 };
        sort(array);
        for (int i = 0; i < array.length; i++) {
            System.out.print(array[i] + " ");
        }
    }

    public static int[] sort(int[] array) {
       return sort(array, 0, array.length - 1);
    }

    private static int[] sort(int[] array, int lo, int hi) {
        if (lo < hi) {
            //partial index
            int pi = partition(array, lo, hi);

            sort(array, lo, pi);
            sort(array, pi + 1, hi);
        }

        return array;
    }

    // Hoare partition
    private static int partition(int[] ar, int lo, int hi) {
        //int pivot = ar[lo];
        //int pivot = ar[new Random().Next(lo, hi + 1)];
        int pivot = ar[lo];
        int left = lo - 1; // Initialize left index
        int right = hi + 1; // Initialize right index

        while (true) {
            //increment the 'left' index until array with 'left' index less or equal the pivot
            do {
                left++;
            }
            while (ar[left] < pivot);

            //decrement the 'right' index until array with 'right' index more or equal the pivot
            do {
                right--;
            }
            while (ar[right] > pivot);

            if (left < right) {
                swap(ar,left,right);
            } else
                return right;
        }
    }

    private static int[] swap(int[] arr, int left, int right){
        int temp = arr[left];
        arr[left] =  arr[right];
        arr[right] = temp;
        return arr;
    }

}
