using System;


            //•Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
            //•Print the obtained array on the console.

class AllocateArray
{
    static void Main()
    {
        int[] numbers = new int[20];

          for (int index = 0; index < numbers.Length; index++)
            {
              Console.WriteLine("Numbers[{0}] = [{1}] ",index, (index * 5));
            }
    }
}
