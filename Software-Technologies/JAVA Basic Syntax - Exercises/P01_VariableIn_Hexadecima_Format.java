import java.util.Scanner;

public class P01_VariableIn_Hexadecima_Format {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);
        String hexa = input.nextLine();

        int num = Integer.parseInt(hexa, 16);
        System.out.println(num);
    }
}
