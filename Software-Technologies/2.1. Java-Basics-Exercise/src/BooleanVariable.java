import java.util.Scanner;

public class BooleanVariable {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String word = scan.nextLine();
        Boolean result = Boolean.valueOf(word);
        if (result) System.out.println("Yes");
        else System.out.println("No");
    }
}
