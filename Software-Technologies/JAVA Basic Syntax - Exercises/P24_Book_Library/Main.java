package P24_Book_Library;

import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;
import java.util.TreeMap;

public class Main {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        int totalBooks = Integer.parseInt(scanner.nextLine());

        TreeMap<String, Double> data = new TreeMap<>();

        for (int i = 0; i < totalBooks; i++) {

            String[] parts = scanner.nextLine().split(" ");

            Book book = new Book(
                    parts[0],
                    parts[1],
                    parts[2],
                    LocalDate.parse(parts[3], DateTimeFormatter.ofPattern("dd.MM.yyyy")),
                    parts[4],
                    Double.parseDouble(parts[5])
            );

            if (!data.containsKey(book.getAuthor())) {
                data.put(book.getAuthor(), 0.0);
            }

            double currentPriceSum = data.get(book.getAuthor());
            currentPriceSum += book.getPrice();
            data.put(book.getAuthor(), currentPriceSum);
        }

        data
                .entrySet()
                .stream()
                .sorted((e1, e2) -> {
                    int priceComparison=e2.getValue().compareTo(e1.getValue());

                    if (priceComparison ==0 ){
                        return e1.getKey().compareTo(e2.getKey());
                    }

                    return priceComparison;

                })
                .forEach(e -> System.out.printf("%s -> %.2f%n", e.getKey(), e.getValue()));
    }
}
