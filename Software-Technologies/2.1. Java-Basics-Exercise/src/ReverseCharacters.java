import java.util.Scanner;

public class ReverseCharacters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        StringBuilder result = new StringBuilder();
        for (int i = 0; i < 3; i++) {
            String letter = scan.nextLine();
            result.append(letter);
        }
        System.out.println(result.reverse());
    }
}
