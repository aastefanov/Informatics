package tk.aastefanov.geekycamp.javabasics;

import java.util.Scanner;

public class SortArray {

    private static void bubbleSort(int[] arr) {
        bubbleSort(arr, true);
    }

    private static void bubbleSort(int[] arr, boolean isAscending) {
        for (int i = 0; i < arr.length; i++) {
            for (int j = 0; j < arr.length; j++) {
                if (isAscending ?
                        (arr[i] < arr[j]) :
                        (arr[i] > arr[j])
                        ) {

                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                }
            }
        }
    }

    private static void printArray(int[] arr) {
        for (int element : arr) {
            System.out.println(element);
        }
    }

    private static void sortAscending(int[] arr) {
        bubbleSort(arr);
    }

    private static void sortDescending(int[] arr) {
        bubbleSort(arr, false);
    }

    public static void main(String[] args) {
        int n;
        int[] arr;
        try (Scanner scanner = new Scanner(System.in)) {
            n = scanner.nextInt();
            arr = new int[n];

            for (int i = 0; i < arr.length; i++) {
                arr[i] = scanner.nextInt();
            }
        }

        sortAscending(arr);
        printArray(arr);
        System.out.println();
        sortDescending(arr);
        printArray(arr);

    }
}
