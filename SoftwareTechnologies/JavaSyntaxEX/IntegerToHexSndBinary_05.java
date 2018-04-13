import java.util.Scanner;

public class IntegerToHexSndBinary_05 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        int input = Integer.parseInt(scan.nextLine());

        String intToHex = Integer.toHexString(input).toUpperCase();
        String intToBinary = Integer.toBinaryString(input).toUpperCase();

        System.out.println(intToHex);
        System.out.println(intToBinary);

    }
}
