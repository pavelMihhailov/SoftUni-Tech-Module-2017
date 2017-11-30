import java.util.*;

public class PhonebookUpgrade {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);
        String input = scanner.nextLine();
        Map<String, String> phonebook = new TreeMap<>();
        while (!input.equals("END")){
            String[] info = input.split(" ");
            String command = info[0];
            if(command.equals("A")){
                String name = info[1];
                String phone = info[2];
                phonebook.put(name, phone);
            }
            else if(command.equals("S")){
                String name = info[1];
                if(!phonebook.containsKey(name)) System.out.printf("Contact %s does not exist.%n", name);
                else System.out.printf("%s -> %s%n", name, phonebook.get(name));
            }
            else if(command.equals("ListAll")){
                for (String key : phonebook.keySet()){
                    System.out.printf("%s -> %s%n", key, phonebook.get(key));
                }
            }
            input = scanner.nextLine();
        }
    }
}