import java.util.Scanner;

public class P02_Boolean_Variable {
    public static void main(String[] args) {

        Scanner input = new Scanner(System.in);

        String str = (input.nextLine());

        Boolean bool = Boolean.valueOf(str);

        if (bool) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }

    }
}
