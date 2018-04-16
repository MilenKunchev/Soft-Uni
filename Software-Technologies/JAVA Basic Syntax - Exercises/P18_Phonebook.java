import java.util.Arrays;
import java.util.LinkedHashMap;
import java.util.List;
import java.util.Scanner;
import java.util.stream.Collectors;


public class P18_Phonebook {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        LinkedHashMap<String, String> phoneBook = new LinkedHashMap<>();

        String[] input = scanner.nextLine().split(" ");

        while (!input[0].equals("END")) {

            String command = input[0];

            if (command.equals("A")) {

                String name = input[1];
                String phone = input[2];

                addToPhoneBook(phoneBook, name, phone);
            }

            if (command.equals("S")) {

                String name = input[1];

                searchOnPhoneBook(phoneBook, name);
            }


            input = scanner.nextLine().split(" ");
        }

    }

    private static void searchOnPhoneBook(LinkedHashMap<String, String> phoneBook, String name) {

        String phone = phoneBook.get(name);
        if (phoneBook.containsKey(name)) {

            System.out.printf("%s -> %s%n", name, phone);
        } else {

            System.out.printf("Contact %s does not exist.%n", name);
        }
    }

    private static void addToPhoneBook(LinkedHashMap<String, String> phoneBook, String name, String phone) {

        phoneBook.put(name, phone);
    }
}
