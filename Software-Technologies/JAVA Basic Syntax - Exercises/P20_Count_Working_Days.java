import java.time.DayOfWeek;
import java.time.LocalDate;
import java.time.format.DateTimeFormatter;
import java.util.Scanner;

public class P20_Count_Working_Days {

    public static void main(String[] args) {

        Scanner scanner = new Scanner(System.in);

        String startDateText = scanner.nextLine();
        String endDateText = scanner.nextLine();

        String format = "dd-MM-yyyy";

        int[] holidayDays = {
                1, 3, 1, 6, 24, 6, 22, 1, 24, 25, 26};
        int[] holidayMonths = {
                1, 3, 5, 5, 5, 9, 9, 11, 12, 12, 12};

        int totalDays = 0;

        LocalDate startDate = LocalDate
                .parse(startDateText, DateTimeFormatter.ofPattern(format));

        LocalDate endDate = LocalDate
                .parse(endDateText, DateTimeFormatter.ofPattern(format));

        for (LocalDate currentDate = startDate; currentDate.isBefore(endDate.plusDays(1)); currentDate = currentDate.plusDays(1)) {

            DayOfWeek dayOfWeek = currentDate.getDayOfWeek();
            int dayAsNumber = dayOfWeek.getValue();

            if (dayAsNumber == 6 || dayAsNumber == 7) {
                continue;
            }

            int month = currentDate.getMonthValue();
            int day = currentDate.getDayOfMonth();

            boolean isHolyday = false;
            for (int i = 0; i < holidayDays.length; i++) {

                if (holidayDays[i] == day && holidayMonths[i] == month) {
                    isHolyday = true;
                    break;
                }
            }

            if (isHolyday) {
                continue;
            }

            totalDays++;
    }

        System.out.println(totalDays);
    }
}
