import java.util.Scanner;

public class P17_Change_to_Uppercase {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String text = scanner.nextLine();

        while (text.contains("<upcase>")) {

            int startIndex = text.indexOf("<upcase>");
            int endIndex = text.indexOf("</upcase>");

            text = replaceText(text, startIndex, endIndex);
        }

        System.out.println(text);

    }

    private static String replaceText(String text, int startIndex, int endIndex) {


        String leftPart = text.substring(0, startIndex);

        startIndex = startIndex + 8;

        String textToUpper = text.substring(startIndex, endIndex).toUpperCase();

        int rightPartStartIndex = endIndex + 9;
        int rightPartEndIndex = text.length();

        String rightPart = text.substring(rightPartStartIndex, rightPartEndIndex);

        return leftPart + textToUpper + rightPart;
    }
}
