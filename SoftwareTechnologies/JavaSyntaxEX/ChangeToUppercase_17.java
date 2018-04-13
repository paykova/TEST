import java.util.Scanner;

public class ChangeToUppercase_17 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String text = scan.nextLine();

        while (true) {
            int openTag = text.indexOf("<upcase>");
            int closeTag = text.indexOf("</upcase>");

            if (openTag < 0 || closeTag < 0) {
                break;
            }
            String textForReplace = text.substring(openTag, closeTag + 9);

            text = text.replace(textForReplace, textForReplace.substring(8, textForReplace.length() - 9).toUpperCase());
        }
        System.out.println(text);
    }
}

