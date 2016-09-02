import java.io.*;
import java.text.DecimalFormat;

public class DailyProfit {
    public static void main(String[] args) throws IOException {
        int workDays;
        double dailyProfitUsd;
        double usdToBgn;

        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            workDays = Integer.parseInt(bufferedReader.readLine());
            dailyProfitUsd = Double.parseDouble(bufferedReader.readLine());
            usdToBgn = Double.parseDouble(bufferedReader.readLine());
        }

        double monthlyProfit = workDays * dailyProfitUsd;
        double yearlyProfit = (monthlyProfit * 14.5) * 3/4;
        double finalProfit = yearlyProfit * usdToBgn;

        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {
            bufferedWriter.write(
                    new DecimalFormat("0.00").format(finalProfit / 365)
                            + "\n"
            );
        }
    }
}
