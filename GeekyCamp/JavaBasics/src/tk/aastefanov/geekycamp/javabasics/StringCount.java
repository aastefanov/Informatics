package tk.aastefanov.geekycamp.javabasics;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;
import java.util.regex.Matcher;
import java.util.regex.Pattern;

public class StringCount {

    private static int substringCount(String string, String substring) {
        Pattern pattern = Pattern.compile(substring);
        Matcher matcher = pattern.matcher(string);
        int count = 0;
        while (matcher.find()){
            count +=1;
        }

        return count;
    }

    public static void main(String[] args) throws IOException {
        String substring;
        String text;

        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            substring = bufferedReader.readLine();
            text = bufferedReader.readLine();
        }

        System.out.println(substringCount(text, substring));
    }
}
