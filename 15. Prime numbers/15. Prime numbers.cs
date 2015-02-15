using System;

// Write a program that finds all prime numbers in the range [`1...10 000 000`]. Use the [Sieve of Eratosthenes] algorithm.

class PrimeNumbers
{
    static void Main()
    {
        int n = 10000000 + 1;
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = i;
        }
        int currentPrime = 2;
        while (true)
        {
            int i = 2;
            while (currentPrime * i < n)
            {
                arr[currentPrime * i] = 0;
                i++;
            }
            bool isFinished = true;
            i = currentPrime;

            while (i < n / 2)
            {
                i++;
                if (arr[i] != 0)
                {
                    currentPrime = i; 
                    isFinished = false; 
                    break;
                }
            }
            if (isFinished)
            {
                break;
            }
        }
        for (int i = 2; i <= 10000000; i++) 
        {
            if (arr[i] != 0)
            {
                Console.Write(arr[i] + ", ");
            }
        }
        Console.WriteLine();
    }
}