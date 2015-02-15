using System;

            //Write a program that compares two char arrays lexicographically (letter by letter).

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter first array length:");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second array length:");
        int second = int.Parse(Console.ReadLine());



        char[] arr1 = new char[first];
        char[] arr2 = new char[second];
        bool check = false;

        if (first == second)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter first array char [{0}] = ", i);
                arr1[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("Enter second array char [{0}] = ", i);
                arr2[i] = char.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    check = true;
                    Console.WriteLine("[{0}] = [{1}], are they the same? = [{2}] ", arr1[i], arr2[i], check);
                }
                else if (arr1[i] != arr2[i])
                {
                    check = false;
                    Console.WriteLine("[{0}] = [{1}], are they the same? = [{2}] ", arr1[i], arr2[i], check);
                }
            }
        }
        else
        {
            Console.WriteLine("You have entered not equal lenght for the arrays");
        }
    }
}
