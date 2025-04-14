using System;
using System.Linq;

class OddNumberOut
{
    // Function to find the number that doesn't belong to the pattern
    public static int FindOddNumberOut(int[] arr)
    {
        // Count the even and odd numbers
        int evenCount = arr.Count(x => x % 2 == 0);
        int oddCount = arr.Length - evenCount;

        // If the majority are even numbers, return the odd number
        if (evenCount > oddCount)
        {
            return arr.First(x => x % 2 != 0);  // Return the first odd number
        }
        else
        {
            return arr.First(x => x % 2 == 0);  // Return the first even number
        }
    }

    static void Main(string[] args)
    {
        Console.WriteLine("Enter the size of the series: ");
        int size = Convert.ToInt32(Console.ReadLine());
        
        int[] arr = new int[size];
        
        Console.WriteLine("Enter the elements of the series: ");
        for (int i = 0; i < size; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }

        // Find and display the number that doesn't belong to the pattern
        int oddNumberOut = FindOddNumberOut(arr);
        Console.WriteLine($"The number that doesn't belong to the series is: {oddNumberOut}");
    }
}
