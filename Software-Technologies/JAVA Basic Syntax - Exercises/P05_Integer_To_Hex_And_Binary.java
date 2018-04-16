import java.util.Scanner;

public class P05_Integer_To_Hex_And_Binary {

    public static void main(String[] args) {
        Scanner scan =new Scanner(System.in);

        int num = scan.nextInt();

        String hexaDecimal = Integer.toHexString(num);
        String binary = Integer.toBinaryString(num);

        System.out.println(hexaDecimal.toUpperCase());
        System.out.println(binary);



    }
}
