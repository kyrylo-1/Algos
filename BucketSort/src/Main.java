import java.util.ArrayList;
import java.util.List;

public class Main {

    public static void main(String[] args) {

        Integer[] arr = new Integer[]{5,3,4,7,2,8,6,9,1};
        sortBucket(arr,100);
//        insertionSort(arr);
    }

    public static void sortBucket(Integer[] array, int bucketSize) {
        if (array.length == 0) {
            return;
        }

        // Determine minimum and maximum values
        Integer minValue = array[0];
        Integer maxValue = array[0];
        for (int i = 1; i < array.length; i++) {
            if (array[i] < minValue) {
                minValue = array[i];
            } else if (array[i] > maxValue) {
                maxValue = array[i];
            }
        }

        // Initialise buckets
        int bucketCount = (maxValue - minValue) / bucketSize + 1;
        List<List<Integer>> buckets = new ArrayList<List<Integer>>(bucketCount);
        for (int i = 0; i < bucketCount; i++) {
            buckets.add(new ArrayList<Integer>());
        }

        // Distribute input array values into buckets
        for (int i = 0; i < array.length; i++) {
            buckets.get((array[i] - minValue) / bucketSize).add(array[i]);
        }

        // Sort buckets and place back into input array
        int currentIndex = 0;
        for (int i = 0; i < buckets.size(); i++) {
            Integer[] bucketArray = new Integer[buckets.get(i).size()];
            bucketArray = buckets.get(i).toArray(bucketArray);
            bucketArray = insertionSort(bucketArray);
            for (int j = 0; j < bucketArray.length; j++) {
                array[currentIndex++] = bucketArray[j];
            }
        }
    }

    private static Integer[] insertionSort(Integer[] array){
        int len = array.length;
        for (int i = 1; i < len; i++)
        {
            int iElement = array[i];
            int j = i;

            while (j > 0 && array[j - 1] > iElement)
            {
                array[j] = array[j - 1];
                j--;
            }

            array[j] = iElement;
        }

        return array;
    }
}
