import java.util.Scanner;

public class SumTwoNumbers_02 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        double n = Double.parseDouble(scan.nextLine());
        double m = Double.parseDouble(scan.nextLine());

        double sum = n + m;
        System.out.printf("%.2f", sum);

    }
}
