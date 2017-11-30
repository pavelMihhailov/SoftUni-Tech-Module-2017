import java.util.Scanner;

public class ChangeToUpperCase {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String text = scan.nextLine();

        while (text.contains("<upcase>")) {
            int startIndex = text.indexOf("<upcase>");
            int endIndex = text.indexOf("</upcase>") + "</upcase>".length();

            String textToBeReplaced = text.substring(startIndex, endIndex);
            String upperText = text.substring(startIndex + 8, endIndex - 9).toUpperCase();
            text = text.replace(textToBeReplaced, upperText);
        }
        System.out.println(text);

    }
}
