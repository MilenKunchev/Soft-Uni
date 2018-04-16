import java.util.*;

public class P19_Phonebook_Upgrade {
    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        TreeMap<String, String> phoneBook = new TreeMap<>();

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

            if (command.equals("ListAll")) {

                listAll(phoneBook);
            }


            input = scanner.nextLine().split(" ");
        }

    }

    private static void listAll(TreeMap<String, String> phoneBook) {

        Set set = phoneBook.entrySet();
        for (Object aSet : set) {
            Map.Entry mentry = (Map.Entry) aSet;
            System.out.printf("%s -> %s%n", mentry.getKey(), mentry.getValue());
        }
    }

    private static void searchOnPhoneBook(TreeMap<String, String> phoneBook, String name) {

        String phone = phoneBook.get(name);
        if (phoneBook.containsKey(name)) {

            System.out.printf("%s -> %s%n", name, phone);
        } else {

            System.out.printf("Contact %s does not exist.%n", name);
        }
    }

    private static void addToPhoneBook(TreeMap<String, String> phoneBook, String name, String phone) {

        phoneBook.put(name, phone);
    }
}
