import java.util.Scanner;

public class P03_Reverse_Characters {

    public static void main(String[] args) {

        Scanner scan =  new Scanner(System.in);

       String letter1 = scan.nextLine();
       String letter2 = scan.nextLine();
       String letter3 = scan.nextLine();

       System.out.printf("%s%s%s",letter3,letter2,letter1);

    }
}
