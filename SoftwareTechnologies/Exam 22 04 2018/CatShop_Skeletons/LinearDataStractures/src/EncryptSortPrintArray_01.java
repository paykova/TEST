import java.util.Scanner;

import static java.lang.System.in;

public class EncryptSortPrintArray_01 {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(in);

        int n = scanner.nextInt();

        String[] lines = new String[n];

        for (int i = 0; i < n; i++) {
            lines[i] = scanner.nextLine();
        }

    }
}
