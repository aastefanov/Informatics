package tk.aastefanov.geekycamp.javabasics;

import java.util.ArrayList;

public class FirstPrimes {
    private static ArrayList<Integer> primes = new ArrayList<>();

    private static void findPrimes(int max) {
        for (int i = 2; i <= max; i++) {
            boolean isPrime = true;
            for (Integer prime : primes) {

                if (prime > Math.sqrt(i)) break;
                if (i % prime == 0) {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime) primes.add(i);
        }
    }

    public static void main(String[] args) {
        findPrimes(10_000_000);
        System.out.println(primes.toString());
    }
}
