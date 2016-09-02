import java.io.*;

public class Digits {
    public static void main(String[] args) throws IOException {
        int initialNumber;

        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            initialNumber = Integer.parseInt(bufferedReader.readLine());
        }

        int number = initialNumber;
        int rows = number / 100 + number / 10 % 10;
        int cols = number / 100 + number % 10;
        int tempNumber = number;
        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < cols; j++) {

                    if (number % 5 == 0) {
                        tempNumber -= initialNumber / 100;
                    }
                    else if (number % 3 == 0) {
                        tempNumber -= initialNumber / 10 % 10;
                    }

                    else {
                        tempNumber += initialNumber % 10;
                    }

                    number = tempNumber;
                    bufferedWriter.write(tempNumber + " ");
                }
                bufferedWriter.write("\n");
            }
        }
    }
}
