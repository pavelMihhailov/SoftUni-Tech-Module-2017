import java.util.Scanner;

public class SymmetricNumbers {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int n = scan.nextInt();

        for (int i = 1; i <= n; i++) {
            int reversedI = reversedString(i);
            if (i == reversedI){
                System.out.println(i);
            }
        }
    }

    private static int reversedString(int n) {
        String chislo = Integer.toString(n);
        String chisloReverse = new StringBuilder(chislo).reverse().toString();
        int result = Integer.parseInt(chisloReverse);
        return result;
    }
}
