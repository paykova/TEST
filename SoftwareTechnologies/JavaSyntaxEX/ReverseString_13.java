import java.util.Scanner;

public class ReverseString_13 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String input = scan.nextLine();

        StringBuilder sb = new StringBuilder();

        sb.append(input);
        sb.reverse();

        System.out.println(sb);
    }
}
