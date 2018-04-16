import java.util.Arrays;
import java.util.Scanner;

public class P09_Most_Frequent_Number {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays
                .stream(scanner.nextLine().split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int bestCount = 0;
        int bestNum = 0;

        for (int i = 0; i < nums.length; i++) {

            int currentNum = nums[i];
            int count = 0;

            for (int j = i; j < nums.length; j++) {

                if (nums[j] == currentNum) {

                    count++;
                }
            }

            if (count > bestCount) {

                bestCount = count;
                bestNum = currentNum;
            }
        }

        System.out.println(bestNum);
    }
}
