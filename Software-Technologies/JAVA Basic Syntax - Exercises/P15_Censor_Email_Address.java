import java.util.Scanner;

public class P15_Censor_Email_Address {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String email = scanner.nextLine();
        String text = scanner.nextLine();

        String result = replaceName(email, text);

        System.out.println(result);
    }

    private static String replaceName(String email, String text) {

        String name = email.split("@")[0];
        String domain = email.split("@")[1];

        StringBuilder hiddenName = new StringBuilder();

        for (int i = 0; i < name.length(); i++) {

            hiddenName.append("*");
        }

        String newEmail = hiddenName + "@" + domain;


        return text.replaceAll(email, newEmail);
    }
}
