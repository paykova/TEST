import java.util.Scanner;

public class VariableInHexFormat_01 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String hexNumber = scan.nextLine();

        int hexToDecimal = Integer.parseInt(hexNumber, 16);

        System.out.println(hexToDecimal);
    }
}
