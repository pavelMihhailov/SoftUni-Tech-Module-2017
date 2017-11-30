import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int[] numbers = Arrays.stream(scan.nextLine().split(" ")).mapToInt(Integer::parseInt).toArray();
        boolean found = false;

        for (int i = 0; i < numbers.length; i++) {
            int leftSideSum = 0;
            int rightSideSum = 0;

            //rightSide
            for (int j = i + 1; j < numbers.length; j++) {
                rightSideSum += numbers[j];
            }
            //leftSide
            for (int j = i - 1; j >= 0 ; j--) {
                leftSideSum += numbers[j];
            }
            if (leftSideSum == rightSideSum)
            {
                System.out.println(i);
                found = true;
                break;
            }
        }
        if (found == false){
            System.out.println("no");
        }
    }
}
