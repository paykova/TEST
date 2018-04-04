import java.util.Scanner;

public class SymmetricNumbers_05 {
    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);

        Integer n = Integer.parseInt(scan.nextLine());

        for (int i = 0; i < n; i++) {
            Integer rev = Integer.reverse(i);
            if (rev.equals(i)){
                System.out.println(i);
            }
        }
    }
}
