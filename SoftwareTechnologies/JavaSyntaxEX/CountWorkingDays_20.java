import java.text.DateFormat;
import java.text.ParseException;
import java.text.SimpleDateFormat;
import java.time.LocalDate;
import java.time.LocalTime;
import java.time.format.DateTimeFormatter;
import java.time.temporal.ChronoUnit;
import java.util.Date;
import java.util.Scanner;

public class CountWorkingDays_20 {
    public static void main(String[] args) throws ParseException {
        Scanner scan = new Scanner(System.in);

        String firstLine = scan.nextLine();
        String secondLine = scan.nextLine();

        DateTimeFormatter formatter = DateTimeFormatter.ofPattern("dd-MM-yyyy");
        LocalDate firstDate = LocalDate.parse(firstLine, formatter);
        LocalDate secondDate = LocalDate.parse(secondLine, formatter);


        long days = ChronoUnit.DAYS.between(firstDate, secondDate);

        int workingDays = 0;

        for (int i = 0; i <= days; i++) {
            boolean workDay = checkIfHoliday(firstDate);

            if (!workDay) {
                workingDays++;
            }
            firstDate = firstDate.plusDays(1);
        }
        System.out.println(workingDays);
    }

    private static boolean checkIfHoliday(LocalDate date) {
        if
                ((date.getDayOfMonth() == 1 && date.getMonth().getValue() == 1) ||
                (date.getDayOfMonth() == 3 && date.getMonth().getValue() == 3) ||
                (date.getDayOfMonth() == 1 && date.getMonth().getValue() == 5) ||
                (date.getDayOfMonth() == 6 && date.getMonth().getValue() == 5) ||
                (date.getDayOfMonth() == 24 && date.getMonth().getValue() == 5) ||
                (date.getDayOfMonth() == 6 && date.getMonth().getValue() == 9) ||
                (date.getDayOfMonth() == 22 && date.getMonth().getValue() == 9) ||
                (date.getDayOfMonth() == 1 && date.getMonth().getValue() == 11) ||
                (date.getDayOfMonth() == 24 && date.getMonth().getValue() == 12) ||
                (date.getDayOfMonth() == 25 && date.getMonth().getValue() == 12) ||
                (date.getDayOfMonth() == 26 && date.getMonth().getValue() == 12)
                ) {
            return true;
        } else if (date.getDayOfWeek().getValue() == 6 || date.getDayOfWeek().getValue() == 7) {
            return true;
        } else {
            return false;
        }
    }
}
