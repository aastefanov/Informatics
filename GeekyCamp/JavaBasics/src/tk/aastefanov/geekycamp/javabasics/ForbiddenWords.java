package tk.aastefanov.geekycamp.javabasics;

import java.util.ArrayList;
import java.util.Scanner;
import java.util.StringTokenizer;
import java.util.regex.Pattern;

public class ForbiddenWords {

    private static ArrayList<String> forbiddenWords = new ArrayList<>();

    private static void tokenizeString(String tokens, String delimiter) {

        StringTokenizer tokenizer = new StringTokenizer(tokens, delimiter);
        while (tokenizer.hasMoreElements()) {
            forbiddenWords.add(tokenizer.nextToken());
        }
    }

    private static String wordsRegex() {
        StringBuilder sb = new StringBuilder();
        for (String w : forbiddenWords) {
            if (sb.length() > 0) sb.append("|");
            sb.append(
                    String.format("(?<=(?=%s).{0,%d}).",
                            Pattern.quote(w),
                            w.length() - 1
                    )
            );
        }
        return sb.toString();
    }

    private static String replaceWords(String text) {
        return text.replaceAll(wordsRegex(), "*");
    }

    static void wordsStdio() {
        String forbiddenWordsString;
        String text;
        try (Scanner scanner = new Scanner(System.in)) {
            forbiddenWordsString = scanner.nextLine();
            text = scanner.nextLine();
        }

        tokenizeString(forbiddenWordsString, ",");

        System.out.println(replaceWords(text));
    }

    public static void main(String[] args) {
        wordsStdio();
    }
}
