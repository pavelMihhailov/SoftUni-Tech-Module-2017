import java.util.Scanner;

public class SumNIntegers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();
        int result = 0;

        for (int i = 0; i < n; i++) {
            int number = scan.nextInt();
            result += number;
        }
        System.out.println("Sum = " + result);
    }
}
