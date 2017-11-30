import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Phonebook {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        Map<String, String> phonebook = new HashMap<>();
        while (!input.equals("END")){
            String[] info = input.split(" ");
            String command = info[0];
            String name = info[1];
            if(command.equals("A")){
                String phone = info[2];
                phonebook.put(name, phone);
            }
            else if(command.equals("S")){
                if(!phonebook.containsKey(name)) System.out.printf("Contact %s does not exist.%n", name);
                else System.out.printf("%s -> %s%n", name, phonebook.get(name));
            }
            input = scanner.nextLine();
        }
    }
}