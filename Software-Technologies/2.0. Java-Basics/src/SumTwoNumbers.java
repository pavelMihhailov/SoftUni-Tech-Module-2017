import java.util.Scanner;

public class SumTwoNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        double num1 = scan.nextDouble();
        double num2 = scan.nextDouble();
        double result = num1 + num2;
        System.out.printf("%.2f", result);
    }
}