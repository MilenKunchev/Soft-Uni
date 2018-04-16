import java.util.*;

public class P21_Advertisement_Message {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        Random random = new Random();

        int count = Integer.parseInt(scanner.nextLine());

        String[] phrases = {"Excellent product.", "Such a great product.", "I always use that product."
                , "Best product of its category.", "Exceptional product.", "I can't live without this product."};

        String[] events = {"Now I feel good.", "I have succeeded with this product.", "Makes miracles. I am happy of the results!"
                , "I cannot believe but now I feel awesome.", "Try it yourself, I am very satisfied.", "I feel great!"};

        String[] authors = {"Diana", "Petya", "Stella", "Elena", "Katya", "Iva", "Annie", "Eva"};

        String[] cities = {"Burgas", "Sofia", "Plovdiv", "Varna", "Ruse"};

        for (int i = 0; i < count; i++) {

            String message = generateMessage(phrases, events, authors, cities, random);

            System.out.println(message);
        }

    }

    private static String generateMessage(String[] phrases, String[] events, String[] authors, String[] cities, Random random) {

        int index1 = random.nextInt(phrases.length);
        int index2 = random.nextInt(events.length);
        int index3 = random.nextInt(authors.length);
        int index4 = random.nextInt(cities.length);

        String phrase = phrases[index1];
        String event = events[index2];
        String author = authors[index3];
        String city = cities[index4];

        String message = phrase + " " + event + " " + author + " – " + city;

        return message;
    }


}
