import java.util.Arrays;
import java.util.Scanner;

public class P08_Max_Sequence_Of_Increasing_Elements {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int[] array = Arrays
                .stream(scanner.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        int start = 0;
        int len = 1;
        int bestStart = 0;
        int bestLen = 0;

        for (int i = 1; i < array.length; i++) {

            int currentNum = array[i];
            int leftNum = array[i - 1];

            if (currentNum > leftNum ) {
                len++;

            } else {

                if (len > bestLen) {

                    bestLen = len;

                    bestStart = start;
                }

                start = i;
                len = 1;
            }
        }
        if (len > bestLen) {
            bestLen = len;

            bestStart = start;
        }
        if (start == 0) {

            bestStart = 0;

            bestLen = len;
        }

        int endOfPrint = bestStart + bestLen;


            for (int i = bestStart; i < endOfPrint; i++) {
                System.out.printf("%d ", array[i]);
            }

    }
}
