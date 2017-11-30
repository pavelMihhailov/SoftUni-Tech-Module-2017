import java.lang.reflect.Array;
import java.util.Arrays;
import java.util.Scanner;
import java.util.SortedMap;

public class Largest3Nums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] array = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        Arrays.sort(array);

        for (int i = array.length - 1; i > array.length - 1 - 3; i--) {
            if (i < 0) break;
            System.out.println(array[i]);
        }
    }
}
