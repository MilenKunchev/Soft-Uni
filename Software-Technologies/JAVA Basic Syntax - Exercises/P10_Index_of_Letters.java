
import java.util.ArrayList;
import java.util.List;
import java.util.Scanner;


public class P10_Index_of_Letters {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<Character> alphabet = new ArrayList<>();


        for (char i = 'a'; i <= 'z'; i++) {
            alphabet.add(i);
        }

        char[] word = scanner.nextLine().toLowerCase().toCharArray();

        for (char letter : word) {

            int index = alphabet.indexOf(letter);

            System.out.printf("%s -> %d%n", letter, index);
        }
    }
}
