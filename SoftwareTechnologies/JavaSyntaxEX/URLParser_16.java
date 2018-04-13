import java.util.Scanner;

public class URLParser_16 {
    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String url = scan.nextLine();

        int protocolEndIndex = url.indexOf("://");
        String protocol = "";

        if (protocolEndIndex > 0) {
            protocol = url.substring(0, protocolEndIndex);
            url = url.substring(protocolEndIndex + 3);
        }

        int serverEndIndex = url.indexOf("/");
        String server = "";
        String resource = "";

        if (serverEndIndex < 0) {
            server = url;
        } else {
            server = url.substring(0, serverEndIndex);
            resource = url.substring(serverEndIndex + 1);
        }

        System.out.printf("[protocol] = \"%s\"%n", protocol);
        System.out.printf("[server] = \"%s\"%n", server);
        System.out.printf("[resource] = \"%s\"%n", resource);
    }
}
