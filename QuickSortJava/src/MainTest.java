import java.util.Arrays;

import static org.junit.jupiter.api.Assertions.*;

/**
 * Created by Kirill on 7/2/2018.
 */
class MainTest {
    @org.junit.jupiter.api.Test
    void sort() {
        int[] array = new int[] { 3, 9, 1, 34, 9, 10, -3 };
        Arrays.sort(array);
        assertArrayEquals(array, Main.sort(array));
    }

}