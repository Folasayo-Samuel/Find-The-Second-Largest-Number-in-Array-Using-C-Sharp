using System;

namespace SecondLargestNumberArray;

public class Program
{
	static void Main(string[]args)
	{
		int n, i, j = 0, largest, secondLargest;
		int[] arr1 = new int[50];

		Console.Write("\n\nFind the second largest element in an array: \n");
		Console.Write("------------------------\n");

		Console.Write("Input the size of array");
		n = Convert.ToInt32(Console.ReadLine());

		// Stores values into the array
		Console.Write($"Input {n} elements in the array: \n");
		for (i = 0; i < n; i++)
		{
			Console.Write($"element - {i}: ");
			arr1[i] = Convert.ToInt32(Console.ReadLine());
		}

		// Find location of the largest element in the array.
		largest = 0;
		
		for(i = 0; i < n; i++)
		{
			if(largest < arr1[i])
			{
				largest = arr1[i];
				j = i;
			}
		}

		// Ignore the largest element and find the 2nd largest element in the array
		secondLargest = 0;
		for(i = 0; i < n; i++)
		{
			if(i == j)
			{
				i++; // Ignoring the largest element
				i--;
			}
			else
			{
				if(secondLargest < arr1[i])
				{
					secondLargest = arr1[i];
				}
			}
		}
		Console.Write($"The second largest element in the array is: {secondLargest} \n\n");

        Console.ReadKey();


    }
}