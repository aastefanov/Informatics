package tk.aastefanov.geekycamp.javabasics;

import java.io.*;
import java.util.ArrayList;

public class ArrayEqualsCount {


    private static String getMaxCount(int[] arr) {
        int prev = arr[0];
        int maxNumber = arr[0];
        int count = 1;
        int maxCount = 1;

        for (int i = 1; i < arr.length; i++) {
            if (arr[i] == prev) {
                count++;
            } else {
                if (count >= maxCount) {
                    maxCount = count;
                    maxNumber = arr[i - 1];
                }
                count = 1;
                prev = arr[i];
            }
        }

        return createArray(maxNumber, maxCount).toString();
    }

    private static ArrayList<Integer> createArray(int number, int count) {
        ArrayList<Integer> arrayList = new ArrayList<>();
        for(int i=0;i<count;i++) {
            arrayList.add(number);
        }

        return arrayList;
    }

    public static void main(String[] args) throws IOException {

        int arr[] = {1, 2, 3, 4, 4, 4, 5, 6, 7, 6, 5, 5, 4, 3};


        System.out.println(getMaxCount(arr));
    }
}
