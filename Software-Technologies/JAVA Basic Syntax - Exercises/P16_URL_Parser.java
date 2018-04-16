import java.util.Scanner;

public class P16_URL_Parser {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String url = scanner.nextLine();

        String protocol = "";
        String server = "";
        String resource = "";


        if (url.contains("://")) {
            protocol = url.split("://")[0];

            url = url.split("://")[1];
        }

        if (url.contains("/")) {

            server = url.split("/")[0];
            resource = url.replace(server, "").replaceFirst("/", "");
        } else {
            server = url;
        }

        System.out.printf("[protocol] = \"%s\"%n", protocol);
        System.out.printf("[server] = \"%s\"%n", server);
        System.out.printf("[resource] = \"%s\"%n", resource);

    }
}
