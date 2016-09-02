import java.io.*;

public class Hospital {
    public static void main(String[] args) throws IOException {
        int days;
        int doctors = 7;

        int totalTreated = 0;
        int totalUntreated = 0;
        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            days = Integer.parseInt(bufferedReader.readLine());

            int dayPatients;
            for (int i = 0; i < days; i++) {
                dayPatients = Integer.parseInt(bufferedReader.readLine());

                if (dayPatients > doctors) {
                    totalUntreated += (dayPatients - doctors);
                    totalTreated += doctors;



                } else {
                    totalTreated += dayPatients;
                }

                if (i % 3 == 1 && totalTreated < totalUntreated) {
                    doctors += 1;
                }
            }
        }

        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {
            bufferedWriter.write(
                    "Treated patients: " + totalTreated + ".\nUntreated patients: " + totalUntreated + ".\n"
            );
        }
    }
}
