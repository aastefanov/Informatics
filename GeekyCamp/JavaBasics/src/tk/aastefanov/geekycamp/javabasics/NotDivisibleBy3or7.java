package tk.aastefanov.geekycamp.javabasics;

import java.io.*;


public class NotDivisibleBy3or7 {
    public static void main(String[] args) throws IOException {
        int n;
        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            n = Integer.parseInt(bufferedReader.readLine());
        }

        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {
            for (int i = 1; i <= n; i++) {
                if (i % (3 * 7) != 0) {
                    bufferedWriter.write(i + "\n");
                }
            }
        }
    }
}
