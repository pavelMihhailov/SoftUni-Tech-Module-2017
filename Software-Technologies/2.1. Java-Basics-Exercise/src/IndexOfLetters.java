import java.util.Scanner;

public class IndexOfLetters {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] arr = scan.nextLine().split("");

        for (int i = 0; i < arr.length; i++) {
            int converted = (int)arr[i].charAt(0) - 97;
            System.out.println(arr[i] + " -> " + converted);
        }
    }
}
