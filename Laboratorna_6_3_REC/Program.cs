using System;

public class Program
{
    static void FillArrayRecursive(int[] arr, int size, int index)
    {
        if (index < size)
        {
            arr[index] = Convert.ToInt32(Console.ReadLine());
            FillArrayRecursive(arr, size, index + 1);
        }
    }

    static void PrintArrayRecursive(int[] arr, int size, int index)
    {
        if (index < size)
        {
            Console.Write($"{arr[index],4}");
            PrintArrayRecursive(arr, size, index + 1);
        }
        else
        {
            Console.WriteLine();
        }
    }
    
    public static int FindMinRecursive(int[] arr, int size, int index, int minElement)
    {
        if (index < size)
        {
            if (arr[index] % 2 != 0 && arr[index] < minElement)
            {
                minElement = arr[index];
            }
            return FindMinRecursive(arr, size, index + 1, minElement);
        }
        else
        {
            return minElement;
        }
    }
    
    static void FillArrayTRecursive<T>(T[] arr, int size, int index) where T : IConvertible
    {
        if (index < size)
        {
            arr[index] = (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            FillArrayTRecursive(arr, size, index + 1);
        }
    }
    
    static void PrintArrayTRecursive<T>(T[] arr, int size, int index)
    {
        if (index < size)
        {
            Console.Write($"{arr[index],4}");
            PrintArrayTRecursive(arr, size, index + 1);
        }
        else
        {
            Console.WriteLine();
        }
    }
    
    public static T FindMinTRecursive<T>(T[] arr, int size, int index, T minElement) where T : IComparable<T>
    {
        if (index < size)
        {
            if (arr[index] is int intElement && intElement % 2 != 0 && intElement.CompareTo(minElement) < 0)
            {
                minElement = arr[index];
            }
            return FindMinTRecursive(arr, size, index + 1, minElement);
        }
        else
        {
            return minElement;
        }
    }

    static void Main()
    {
        int size;

        Console.Write("Enter the size of the array: ");
        size = Convert.ToInt32(Console.ReadLine());

        if (size <= 0)
        {
            Console.Error.WriteLine("Invalid array size");
            Environment.Exit(1);
        }

        int[] arr = new int[size];

        FillArrayRecursive(arr, size, 0);
        PrintArrayRecursive(arr, size, 0);

        int minElement = FindMinRecursive(arr, size, 0, arr[0]);
        Console.WriteLine($"Min element in array: {minElement}");

        int[] arrT = new int[size];
        FillArrayTRecursive(arrT, size, 0);
        PrintArrayTRecursive(arrT, size, 0);

        int minElementT = FindMinTRecursive(arrT, size, 0, arrT[0]);
        Console.WriteLine($"Min element in array(T): {minElementT}");
    }
}   