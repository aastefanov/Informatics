import java.io.*;

public class PickAxe {

    private static String buildString(String input, int count) {
        if (count < 0) {
            throw new IllegalArgumentException("The count must be non-negative.");
        }
        return new String(new char[count]).replace("\0", input);
    }

    private static String buildString(char input, int count) {
        return buildString(String.valueOf(input), count);
    }

    public static void main(String[] args) throws IOException {
        int n;
        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            n = Integer.parseInt(bufferedReader.readLine());
        }

        try (BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {

            /* Top */
            String beginning = buildString('-', 3 * n);
            for (int i = 0; i < n; i++) {
                bufferedWriter.write(
                        beginning + "*" + buildString('-', i) + "*" + buildString('-', 2 * n - 2 - i) + "\n"
                );
            }

            /* middle */
            bufferedWriter.write(
                    buildString(
                            (
                                    buildString('*', 3 * n) + "*" +
                                            buildString('-', n - 1) + "*" +
                                            buildString('-', n - 1) + "\n"
                            ), n / 2)
            );

            /* bottom */
            StringBuilder beginningBuilder = new StringBuilder(buildString('-', 3 * n));
            StringBuilder middleBuilder = new StringBuilder(buildString('-', n - 1));
            StringBuilder endBuilder = new StringBuilder(buildString('-', n - 1));

            for (int i = 1; i < n / 2; i++) {
                bufferedWriter.write(
                        beginningBuilder +
                                "*" + middleBuilder + "*"
                                + endBuilder + "\n"
                );

                beginningBuilder.setLength(beginningBuilder.length() - 1);
                middleBuilder.append("--");
                endBuilder.setLength(endBuilder.length() - 1);
            }

            /* last row */

            bufferedWriter.write(
                    beginningBuilder + "*" + middleBuilder.toString().replaceAll("-", "*") + "*" + endBuilder
            );
        }
    }
}
