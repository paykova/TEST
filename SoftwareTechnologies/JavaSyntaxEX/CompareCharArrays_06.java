import java.util.Arrays;
import java.util.Scanner;

public class CompareCharArrays_06 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[] firstInput = scan.nextLine().replaceAll(" ", "").toCharArray();
        char[] secondInput = scan.nextLine().replaceAll(" ", "").toCharArray();


        if (firstInput.length > secondInput.length) {
            System.out.println(secondInput);
            System.out.println(firstInput);
        } else if (firstInput.length < secondInput.length) {
            System.out.println(firstInput);
            System.out.println(secondInput);
        } else {
            for (int i = 0; i < firstInput.length; i++) {
                if (firstInput[i] > secondInput[i]) {
                    System.out.println(secondInput);
                    System.out.println(firstInput);
                    break;

                } else if (firstInput[i] < secondInput[i]) {
                    System.out.println(firstInput);
                    System.out.println(secondInput);
                    break;
                } else {
                    System.out.println(firstInput);
                    System.out.println(secondInput);
                    break;
                }
            }
        }
    }
}
