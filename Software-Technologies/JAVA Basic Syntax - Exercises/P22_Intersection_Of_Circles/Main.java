package P22_Intersection_Of_Circles;

import java.util.Scanner;

public class Main {

    public static boolean intersect(Circle first, Circle second) {

        double firstPart = Math.pow(
                first.getCenter().getX() - second.getCenter().getX(), 2);

        double secondPart = Math.pow(
                first.getCenter().getY() - second.getCenter().getY(), 2);

        double distance = Math.sqrt(firstPart + secondPart);

        return distance <= first.getRadius() + second.getRadius();
    }

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Circle first = new Circle(
                new Point(scanner.nextInt(), scanner.nextInt()), scanner.nextInt()
        );

        Circle second = new Circle(
                new Point(scanner.nextInt(), scanner.nextInt()), scanner.nextInt()
        );

        if (intersect(first, second)) {

            System.out.print("Yes");
        } else {
            System.out.println("No");
        }


    }
}