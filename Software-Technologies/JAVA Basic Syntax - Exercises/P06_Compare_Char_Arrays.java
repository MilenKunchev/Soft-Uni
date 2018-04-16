import java.util.Scanner;

public class P06_Compare_Char_Arrays {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String[] arr1 = scanner.nextLine().split(" ");
        String[] arr2 = scanner.nextLine().split(" ");

        int compareResult = compere(arr1, arr2);

        if (compareResult < 0) {
            System.out.println(String.join("", arr1));
            System.out.println(String.join("", arr2));

        } else if (compareResult > 0) {
            System.out.println(String.join("", arr2));
            System.out.println(String.join("", arr1));
        } else {
            if (arr2.length < arr1.length) {
                System.out.println(String.join("", arr2));
                System.out.println(String.join("", arr1));
            } else {
                System.out.println(String.join("", arr1));
                System.out.println(String.join("", arr2));
            }
        }
    }

    private static int compere(String[] arr1, String[] arr2) {

        int compareResult = 0;
        int minArrayLength = Math.min(arr1.length, arr2.length);

        for (int i = 0; i < minArrayLength; i++) {

            String ch1 = arr1[i];
            String ch2 = arr2[i];
            compareResult = ch1.compareTo(ch2);

            if (compareResult < 0) {

                return compareResult;
            }
            if (compareResult > 0) {
                return compareResult;
            }
        }
        return compareResult;
    }
}
