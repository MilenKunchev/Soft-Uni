import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Stream;

public class P04_Vowel_Or_Digit {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);

        String[] vowels = {"a", "e", "i", "o", "u", "y"};

        String[] digits = {"0", "1", "2", "3", "4", "5", "6", "7", "8", "9"};

        String symbol = scan.nextLine().toLowerCase();


        boolean isDigit = Stream.of(digits).anyMatch(x -> x.equals(symbol));
        boolean isVowel = Stream.of(vowels).anyMatch(x -> x.equals(symbol));

        if (isDigit) {
            System.out.println("digit");
        }
        else if (isVowel) {
            System.out.println("vowel");
        } else {
            System.out.println("other");
        }


    }
}
