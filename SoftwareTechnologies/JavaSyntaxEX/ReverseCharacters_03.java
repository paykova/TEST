import java.util.Scanner;

public class ReverseCharacters_03 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char a = scan.next().charAt(0);
        char b = scan.next().charAt(0);
        char c = scan.next().charAt(0);

        String str = Character.toString(a) + Character.toString(b) + Character.toString(c);
        StringBuilder input = new StringBuilder();

        input.append(str);
        input = input.reverse();

        System.out.println(input);
    }
}
