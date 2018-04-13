import java.util.LinkedHashMap;
import java.util.Scanner;
import java.util.TreeMap;

public class PhonebookUpgrade_19 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String line = " ";
        LinkedHashMap<String, String> phonebook = new LinkedHashMap<>();

        while (!(line = scan.nextLine()).equals("END")) {

            String[] splittedComands = line.split(" ");
            String command = splittedComands[0];

            if (command.equals("A")) {
                String phone = splittedComands[2];
                if (phonebook.containsKey(splittedComands[1])) {
                    phonebook.put(splittedComands[1], phone);
                } else {
                    phonebook.put(splittedComands[1], phone);
                }

            } else if (command.equals("S")) {
                if (phonebook.containsKey(splittedComands[1])) {
                    String foundPhone = phonebook.get(splittedComands[1]);
                    System.out.printf("%s -> %s%n", splittedComands[1], foundPhone);
                } else {
                    System.out.printf("Contact %s does not exist.%n", splittedComands[1]);
                }

            } else if (command.equals("ListAll")) {
                TreeMap<String, String> sortedMap = new TreeMap<>(phonebook);
                for (String key : sortedMap.keySet()) {
                    System.out.println(String.format("%s -> %s", key, phonebook.get(key)));
                }

            }

        }

    }
}
