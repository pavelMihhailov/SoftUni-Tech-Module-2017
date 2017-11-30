import java.util.Scanner;

public class CompareCharArrays {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] firstArr = scan.nextLine().split(" ");
        String[] secondArr = scan.nextLine().split(" ");

        boolean isEqual = false;

        for (int i = 0; i < Math.min(firstArr.length, secondArr.length); i++) {
            if (firstArr[i].charAt(0) > secondArr[i].charAt(0)) {
                System.out.println(String.join("", secondArr));
                System.out.println(String.join("", firstArr));
                isEqual = true;
                break;
            } else if (firstArr[i].charAt(0) < secondArr[i].charAt(0)) {
                System.out.println(String.join("", firstArr));
                System.out.println(String.join("", secondArr));
                isEqual = true;
                break;
            }
        }
        if (isEqual == false)
        {
            if (firstArr.length > secondArr.length){
                System.out.println(String.join("", secondArr));
                System.out.println(String.join("", firstArr));
            }
            else {
                System.out.println(String.join("", firstArr));
                System.out.println(String.join("", secondArr));
            }
        }
    }
}
