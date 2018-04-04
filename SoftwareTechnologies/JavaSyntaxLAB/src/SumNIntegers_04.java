
import java.util.Scanner;

public class SumNIntegers_04 {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        Integer n  = Integer.parseInt(scan.nextLine());
        double sum = 0;

        for (int i = 0; i < n; i++) {
           Integer number = Integer.parseInt(scan.nextLine());
           sum = sum + number;
        }

        System.out.printf("%.1f", sum);
    }
}
