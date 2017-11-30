import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        int[] input = Arrays.stream(scanner.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        int currentStart = 0;
        int currentLength = 1;
        int bestStart = 0;
        int bestLength = 1;

        for (int i = 1; i < input.length; i++) {
            if (input[i] > input[i - 1]) {
                currentLength++;

                if (currentLength > bestLength) {
                    bestLength = currentLength;
                    bestStart = currentStart;
                }

            } else {
                currentLength = 1;
                currentStart = i;

            }
        }

        for (int i = bestStart; i < bestStart + bestLength; i++) {
            System.out.print(input[i] + " ");
        }
    }
}