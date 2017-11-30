import java.util.Scanner;

public class ReverseString {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String str = scan.nextLine();
        String result = new StringBuilder(str).reverse().toString();
        System.out.println(result);
    }
}
