import java.util.Arrays;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;

public class P12_Bomb_Numbers {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        List<Integer> nums = Arrays
                .stream(scanner.nextLine().split("\\s+"))
                .map(Integer::parseInt)
                .collect(Collectors.toList());
        int[] bombNumber = Arrays
                .stream(scanner.nextLine().split("\\s+"))
                .mapToInt(Integer::parseInt)
                .toArray();

        int bombValue = bombNumber[0];
        int bombPower = bombNumber[1];

        while (nums.contains(bombValue)) {

            int bombIndex = nums.indexOf(bombValue);
            int startIndex = bombIndex - bombPower;
            int endIndex = bombIndex + bombPower + 1;

            if (startIndex < 0) {
                startIndex = 0;
            }
            if (endIndex > nums.size() - 1) {
                endIndex = nums.size();
            }

            nums.subList(startIndex, endIndex).clear();
        }

        int sum = nums.stream().mapToInt(Integer::intValue).sum();

        System.out.println(sum);
    }
}
