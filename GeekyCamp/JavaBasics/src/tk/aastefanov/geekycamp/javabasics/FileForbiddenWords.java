package tk.aastefanov.geekycamp.javabasics;

import java.io.*;


public class FileForbiddenWords {

    private static String createFilePath(String filepath) {
        String basedir = "/home/albert/files/"; // Change to an existing directory or provide absolute paths
        return filepath.startsWith("/") ? filepath : basedir + filepath;
    }

    public static void main(String[] args) {

        File input;
        FileInputStream inputStream;
        try {
            input = new File(createFilePath("input.txt"));
            inputStream = new FileInputStream(input);
        } catch (FileNotFoundException e) {
            System.err.println(e.getMessage());
            return;
        }

        File output = new File(createFilePath("output.txt"));
        try {
            if (!output.createNewFile()) {
                System.err.println("Output file exists, overwriting.");
            }
        } catch (IOException e) {
            e.getMessage();
            return;
        }
        PrintStream outputStream = null;
        try {
            outputStream = new PrintStream(output);
        } catch (FileNotFoundException e) {
            e.getMessage();
        }


        System.setIn(inputStream);
        System.setOut(outputStream);

        ForbiddenWords.wordsStdio();
    }
}
