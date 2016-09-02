package tk.aastefanov.geekycamp.javabasics;

import java.io.File;
import java.io.FileInputStream;
import java.io.FileNotFoundException;
import java.io.IOException;
import java.util.Scanner;

public class FilesInformation {

    private static String createFilePath(String filepath) {
        String basedir = "/home/albert/files/"; // Change to an existing directory or provide absolute paths
        return filepath.startsWith("/") ? filepath : basedir + filepath;
    }

    public static void main(String[] args) {
        Scanner scanner;

        try {
            scanner = new Scanner(new FileInputStream(createFilePath("info.txt")));
        } catch (FileNotFoundException e) {
            System.err.println(e.getMessage());
            return;
        }

        while (scanner.hasNextLine()) {
            File file = new File(createFilePath(scanner.nextLine()));

            try {
                System.out.println(file.createNewFile() ?
                        "File " + file.getAbsolutePath() + " created." :
                        "File " + file.getAbsolutePath() + " exists.");
            } catch (IOException e) {
                System.err.println(e.getMessage());
            }
        }
    }
}
