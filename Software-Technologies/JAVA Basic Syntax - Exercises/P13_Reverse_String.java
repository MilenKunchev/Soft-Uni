import java.util.Arrays;
import java.util.Scanner;

public class P13_Reverse_String {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String str = scanner.nextLine();

        char[] input = str.toCharArray();
        int length = input.length;

        char[] reversed = new char[length];

        for (int i = length - 1; i >= 0; i--) {
            char element = input[i];
            int index = length - i - 1;
            reversed[index] = input[i];
        }

        String reversedString = Arrays.toString(reversed);

        reversedString = reversedString.substring(1, reversedString.length()-1).replace(", ", "");
        System.out.println(reversedString);

    }
}
