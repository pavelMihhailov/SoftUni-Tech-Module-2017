import java.util.Scanner;

public class FitStringIn20Chars {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String str = scan.nextLine();
        StringBuilder resultStr = new StringBuilder();

        if (str.length() > 20) {
            System.out.println(str.substring(0, 20));
        }
        else {
            resultStr.append(str);
            for (int i = resultStr.length() + 1; i <= 20; i++) {
                resultStr.append('*');
            }
            System.out.println(resultStr);
        }

    }
}
