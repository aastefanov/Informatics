package tk.aastefanov.geekycamp.javabasics;

import java.io.*;

public class FactorialTrailingZeroes {

    private static int getTrailingZeroes(int n) {
        int count = 0;
        for (int i = 5; n / i >= 1; i *= 5) {
            count += n / i;
        }
        return count;
    }

    public static void main(String[] args) throws IOException {
        int n;

        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            n = Integer.parseInt(bufferedReader.readLine());
        }

        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {
            bufferedWriter.write(getTrailingZeroes(n) + "\n");
        }
    }
}