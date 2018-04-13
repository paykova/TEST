import java.util.Scanner;

public class BooleanVariable_02 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();
        boolean strToBoolean = Boolean.valueOf(input);

        if (strToBoolean) {
            System.out.println("Yes");
        } else {
            System.out.println("No");

        }

    }
}
