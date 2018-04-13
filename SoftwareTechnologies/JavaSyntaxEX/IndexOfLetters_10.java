import java.util.Scanner;

public class IndexOfLetters_10 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        char[] input = scan.nextLine().toCharArray();

        for (int i = 0; i < input.length; i++) {
            int alphabetNum = input[i] - 'a';
            System.out.printf("%c -> %d%n", input[i], alphabetNum);
        }
    }
}
