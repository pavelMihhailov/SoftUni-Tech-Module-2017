import java.util.Arrays;
import java.util.Scanner;

public class MostFrequentNumber {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();

        int leftMost = 0;
        int maxCount = 1;

        for (int i = numbers.length - 1; i >= 0; i--) {
            int count = 0;
            for (int j = numbers.length - 1; j >= 0; j--) {
                if (numbers[i] == numbers[j]) count++;
            }
            if (count >= maxCount){
                maxCount = count;
                leftMost = numbers[i];
            }
        }
        System.out.println(leftMost);
    }
}
