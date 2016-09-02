package tk.aastefanov.geekycamp.javabasics;

import java.io.*;

public class HelloWorld {
    public static void main(String[] args) throws IOException {
        try(BufferedWriter bufferedWriter = new BufferedWriter(new OutputStreamWriter(System.out))) {
            bufferedWriter.write("Hello GeekyCamp\n");
        }


     }
}
