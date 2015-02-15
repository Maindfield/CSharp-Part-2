using System;

//•	Write a program that reads two integer arrays from the console and compares them element by element.

class CompareArrays
{
    static void Main()
    {
        Console.Write("Enter first array length:");
        int first = int.Parse(Console.ReadLine());
        Console.Write("Enter second array length:");
        int second = int.Parse(Console.ReadLine());



        int[] arr1 = new int[first];
        int[] arr2 = new int[second];
        bool check = false;

        if (first == second)
        {
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.Write("Enter first array number [{0}] = ", i);
                arr1[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr2.Length; i++)
            {
                Console.Write("Enter second array number [{0}] = ", i);
                arr2[i] = int.Parse(Console.ReadLine());
            }

            for (int i = 0; i < arr1.Length; i++)
            {
                if (arr1[i] == arr2[i])
                {
                    check = true;
                    Console.WriteLine("[{0}] = [{1}], is it equal? = [{2}] ",arr1[i], arr2[i], check);
                }
                else if (arr1[i] != arr2[i])
                {
                    check = false;
                    Console.WriteLine("[{0}] = [{1}], is it equal? = [{2}] ",arr1[i], arr2[i], check);
                }
            }
        }
        else
        {
            Console.WriteLine("You have entered not equal lenght for the arrays");
        }
    }
}

