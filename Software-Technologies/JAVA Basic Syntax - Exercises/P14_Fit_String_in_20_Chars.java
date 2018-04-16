import java.util.Scanner;

public class P14_Fit_String_in_20_Chars {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String str = scanner.nextLine();

        int length = str.length();

        if (length < 20) {

            System.out.println(padRight(str));
        }

        if (length >= 20) {
            System.out.println(str.substring(0, 20));
        }


    }

    private static String padRight(String str) {
        StringBuilder result = new StringBuilder();
        int countStars = 20 - str.length();
        result.append(str);
        for (int i = 0; i < countStars; i++) {
            result.append("*");
        }
        return result.toString();

    }


}
