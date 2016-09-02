import java.io.*;
import java.text.DecimalFormat;

public class HotelRoom {

    private enum Months {
        May,
        June,
        July,
        August,
        September,
        October
    }


    public static void main(String[] args) throws IOException {
        Months month;
        int daysStaying;

        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            month = Months.valueOf(bufferedReader.readLine());
            daysStaying = Integer.parseInt(bufferedReader.readLine());
        }

        double apartmentPrice = 0;
        double studioPrice = 0;

        if (month == Months.May || month == Months.October) {
            studioPrice = 50 * daysStaying;
            apartmentPrice = 65 * daysStaying;

            if (daysStaying > 14) {
                apartmentPrice *= 0.9;
                studioPrice *= 0.7;
            } else if (daysStaying > 7) {
                studioPrice *= 0.95;
            }
        }

        if (month == Months.June || month == Months.September) {
            studioPrice = 75.20 * daysStaying;
            apartmentPrice = 68.70 * daysStaying;

            if (daysStaying > 14) {
                apartmentPrice *= 0.9;
                studioPrice *= 0.8;
            }
        }

        if (month == Months.July || month == Months.August) {
            studioPrice = 76 * daysStaying;
            apartmentPrice = 77 * daysStaying;

            if (daysStaying > 14) {
                apartmentPrice *= 0.9;
            }
        }

        DecimalFormat decimalFormat = new DecimalFormat("0.00");
        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {
            bufferedWriter.write(
                    "Apartment: " + decimalFormat.format(apartmentPrice) + " lv.\n" +
                            "Studio: " + decimalFormat.format(studioPrice) + " lv.\n"
            );
        }
    }
}
