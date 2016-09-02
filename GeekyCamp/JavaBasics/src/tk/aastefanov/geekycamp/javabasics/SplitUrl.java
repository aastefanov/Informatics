package tk.aastefanov.geekycamp.javabasics;

import java.io.BufferedReader;
import java.io.IOException;
import java.io.InputStreamReader;

public class SplitUrl {

    private static void splitUrl(String fullUrl) {
        String protocol, server, resource;

        protocol = fullUrl.substring(0, fullUrl.indexOf("://"));
        fullUrl = fullUrl.substring(protocol.length() + 3);
        server = fullUrl.substring(0, fullUrl.indexOf("/"));
        fullUrl = fullUrl.substring(server.length());
        resource = fullUrl;

        System.out.println(protocol + "\n" + server + "\n" + resource);
    }

    public static void main(String[] args) throws IOException {
        String url;
        try (BufferedReader bufferedReader = new BufferedReader(new InputStreamReader(System.in))) {
            url = bufferedReader.readLine();
        }

        splitUrl(url);
    }
}
