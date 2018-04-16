import java.util.Arrays;
import java.util.Scanner;

public class P11_Equal_Sums {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int[] nums = Arrays
                .stream(scanner.nextLine().split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int sum = Arrays.stream(nums).sum();
        int leftSum = 0;
        int rightSum = 0;
        boolean noEqualSums = true;

        for (int i = 0; i < nums.length; i++) {

            int currentNum = nums[i];

            rightSum = sum - (leftSum + currentNum);

            if (leftSum == rightSum) {
                System.out.println(i);
                noEqualSums = false;
                break;
            }

            leftSum = sum - rightSum;
        }
        if (noEqualSums) {

            System.out.println("no");
        }
    }
}
