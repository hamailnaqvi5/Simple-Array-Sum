using System;
public class ArraySum
{
    public static void Main()
    {
        int[] a = new int[1000];
        int i, n, sum = 0;
        Console.Write("\n\nSum of array:\n");
        Console.Write("Input total numbers to be stored in the array:");
        n = Convert.ToInt32(Console.ReadLine());
        Console.Write("Input {0}  array:\n", n);
        for (i = 0; i < n; i++)
        {
            Console.Write("Number - {0}:", i);
            a[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (i = 0; i < n; i++)
        {
            sum += a[i];
        }
        Console.Write("Sum of array is : {0}\n\n", sum);
    }
}