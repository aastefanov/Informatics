import java.io.*;

public class Business {
    public static void main(String[] args) throws IOException {
        int requiredHours;
        int availableDays;
        int outWorkers;
        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            requiredHours = Integer.parseInt(bufferedReader.readLine());
            availableDays = Integer.parseInt(bufferedReader.readLine());
            outWorkers = Integer.parseInt(bufferedReader.readLine());
        }

        int workedHours = (int) (((0.9 * availableDays) * 8) + (outWorkers * availableDays * 2));

        int hoursDiff = requiredHours - workedHours;
        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {

            bufferedWriter.write(
                    (
                            (hoursDiff <= 0) ?
                                    "Yes!" + -hoursDiff + " hours left." :
                                    "Not enough time!" + hoursDiff + " hours needed."
                    )
                            + "\n");

        }
    }
}
