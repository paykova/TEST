import java.util.Scanner;

public class VowelOrDigit_04 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char input = scan.next().charAt(0);

        if (input == 'a' || input == 'e' || input == 'i' || input == 'o' || input == 'u' || input == 'y') {
            System.out.println("vowel");
        } else if (Character.isDigit(input)) {
            System.out.println("digit");
        } else {
            System.out.println("other");
        }

    }
}
