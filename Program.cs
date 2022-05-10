// See https://aka.ms/new-console-template for more information
using System;

public class Solution
{
    // Test case for converting milli meters to meters
    public static void showMeters(int numMillimeters)
    {
        Console.WriteLine(numMillimeters / (double)1000);
    }

    // method that takes two integers and displays their sum.
    public static void showSum(int num1, int num2)
    {
        Console.WriteLine(num1 + num2);
    }

    // method that takes five doubles and returns their average.
    public static double average(double n1, double n2, double n3, double n4, double n5)
    {
        double avg = (n1 + n2 + n3 + n4 + n5) / 5;
        return avg;
    }

    // method that returns the sum of two randomly generated integers.
    public static double randomSum()
    {
        Random random = new Random();
        int num1 = random.Next(10, 50);
        int num2 = random.Next(10, 50);
        return num1 + num2;
    }

    // method that takes three integers and returns true if their sum is divisible by 3, false otherwise.
    public static bool isDivisibleBy3(int n1, int n2, int n3)
    {
        int sum = n1 + n2 + n3;
        return sum % 3 == 0;
    }

    // method that takes two strings and displays the string that has fewer characters.
    public static void findSmallestString(string s1, string s2)
    {
        if (s1.Length < s2.Length)
        {
            Console.WriteLine(s1);
        }
        else
        {
            Console.WriteLine(s2);
        }
    }

    // method that takes an array of doubles and returns the largest value in the array.
    public static int findMaxElement(int[] arr)
    {
        // Initialize maximum element
        int max = arr[0];

        // Traverse array elements from second and
        // compare every element with current max
        for (int i = 1; i < arr.Length; i++)
        {
            if (arr[i] > max)
            {
                max = arr[i];
            }
        }
        return max;
    }

    // method that generates and returns an array of fifty integer values.
    public static int[] findArray()
    {
        // declare array
        int[] arr = new int[50];
        Random random = new Random();

        // Traverse array elements from second and
        // compare every element with current max
        for (int i = 0; i < arr.Length; i++)
        {
            arr[i] = random.Next(10, 50);
        }

        return arr;
    }

    // method that takes two bool variables and returns true if they have the same value, false otherwise.
    public static bool checkBools(bool b1, bool b2)
    {
        if (b1 == true && b2 == true)
        {
            return true;
        }
        else if (b1 == false && b2 == false)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    // method that takes an int and a double and returns their product.
    public static double findMult(int num1, double num2)
    {
        return num1 * num2;
    }

    // method that takes a two-dimensional array of integers and returns the average of the entries.
    public static double find2DAverage(int[,] arr)
    {
        int count = 0;
        int sum = 0;
        for (int i = 0; i < arr.GetLength(0); i++)
        {
            for (int j = 0; j < arr.GetLength(1); j++)
            {
                sum += arr[i, j];
                count++;
            }
        }

        return sum / count;
    }

    public static void Main()
    {
        // Test 1 
        showMeters(753);

        // Test 2
        showSum(10, 20);

        // Test 3
        Console.WriteLine(average(75.3, 96.5, 45.8, 69.0, 44.6));

        // Test 4
        Console.WriteLine(randomSum());

        // Test 5
        Console.WriteLine(isDivisibleBy3(10, 20, 30));

        // Test 6
        findSmallestString("Amit", "Steve");

        // Test 7
        int[] arr = { 10, 324, 45, 90, 9808 };
        Console.WriteLine(findMaxElement(arr));

        // Test 8
        int[] newArray = findArray();
        foreach (var item in newArray)
        {
            Console.Write(item + " ");
        }
        Console.WriteLine();

        // Test 9
        Console.WriteLine(checkBools(false, false));

        // Test 10
        Console.WriteLine(findMult(10, 20.5));

        // Test 11
        int[,] arr2D = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
        Console.WriteLine(find2DAverage(arr2D));
    }
}