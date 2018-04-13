import java.util.HashMap;
import java.util.Map;
import java.util.Scanner;

public class Phonebook_18 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String line=" ";
        Map<String, String> phonebook = new HashMap<>();

        while (!(line= scan.nextLine()).equals("END")) {

            String[] splittedComands = line.split(" ");
            String command = splittedComands[0];
            String name = splittedComands[1];

            switch (command) {
                case "A": //add
                    String phone = splittedComands[2];
                    if (phonebook.containsKey(name)) {
                        phonebook.put(name, phone);
                    } else {
                        phonebook.put(name, phone);
                    }
                    break;
                case "S": // search
                    if (phonebook.containsKey(name)) {
                        String foundPhone = phonebook.get(name);
                        System.out.printf("%s -> %s%n", name, foundPhone);
                    }
                    else {
                        System.out.printf("Contact %s does not exist.%n", name);
                    }
                    break;
            }
        }
    }
}

