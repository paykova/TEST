import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CensorEmailAddress_15 {
    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String email = reader.readLine();
        String text = reader.readLine();

        String censoredEmail = GetCensoredEmail(email.substring(0,email.indexOf('@')).length()) + email.substring(email.indexOf('@'));

        System.out.println(text.replace(email, censoredEmail));

    }

    private static String GetCensoredEmail(int length) {
        StringBuilder result = new StringBuilder();

        for (int i = 0; i < length; i++) {
            result.append('*');
        }
        return result.toString();
    }
}
