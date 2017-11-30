import java.util.Collections;
import java.util.Scanner;

public class CensorEmailAdresses {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String email = scan.nextLine();
        String text = scan.nextLine();

        String replace = CensoredEmail(email);
        String replaced = text.replaceAll(email, replace);

        System.out.println(replaced);
    }
    private static String CensoredEmail(String email){
        String[] splitted = email.split("@");
        String username = splitted[0];
        String domain = splitted[1];
        StringBuilder result = new StringBuilder();
        result.append(String.join("", Collections.nCopies(username.length(), "*")) + "@" + domain);
        return result.toString();
    }
}
