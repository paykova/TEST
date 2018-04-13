import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class CensorEmailAddress_2nd {
    public static void main(String[] args) throws IOException {

        BufferedReader reader = new BufferedReader(new InputStreamReader(System.in));

        String email = reader.readLine();
        String text = reader.readLine();


        String username = email.split("@")[0];
        String domain = email.split("@")[1];

        StringBuilder resultEmail = new StringBuilder();

        for (int i = 0; i < username.length(); i++) {
            resultEmail.append("*");
        }
        resultEmail.append("@").append(domain);
        String result = text.replaceAll(email, resultEmail.toString());
        System.out.println(result);
    }

}
