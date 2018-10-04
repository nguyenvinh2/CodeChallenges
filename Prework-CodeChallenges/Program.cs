using System;

namespace Prework_CodeChallenges
{
  class Program
  {
    static void Main(string[] args)
    {
      ArrayMax();

      LeapYear();

      int[,] myArray = new int[3, 5] { { 1, 2, 3, 4, 5 }, { 6, 7, 8, 9, 10 }, { 11, 12, 13, 14, 15 } };
      SumRows(myArray);

      int[] input = new int[] { 1, 2, 3 };
      PerfectSequence(input);
    }

    public static void ArrayMax()
    {
      Console.WriteLine("Enter 5 numerical digits between 0-9 (e.g. 12345). Excess digits will be rejected.");
      string input = Console.ReadLine();

      if (int.TryParse(input, out int result) == false)
      {
        Console.WriteLine("There are non-numeric values in your input and it broke the program :(");
        Console.ReadKey();
      }
      else if (input.Length < 5)
      {
        Console.WriteLine("You wrote less than 5 numbers and broke the program :(");
        Console.ReadKey();
      }

      char[] inputArray = input.ToCharArray();

      Console.WriteLine("Your array input is:");

      for (int i = 0; i < inputArray.Length; i++)
      {
        Console.Write(inputArray[i]);
      }

      Console.WriteLine("\nNow Enter a Number:");

      string inputNumber = Console.ReadLine();

      if (int.TryParse(inputNumber, out result) == false)
      {
        Console.WriteLine("There are non-numeric values in your input and it broke the program :(");
        Console.ReadKey();
      }

      int numberMultiply = int.Parse(inputNumber);
      int count = 0;

      for (int i = 0; i < inputArray.Length; i++)
      {
        if (Char.GetNumericValue(inputArray[i]) == numberMultiply)
        {
          count++;
        }
      }

      if (count == 0)
      {
        Console.WriteLine("There were no match numbers in the array. Press any key to exit.");
        Console.ReadKey();
      }
      else
      {
        Console.WriteLine($"Your result is: {Math.Pow(numberMultiply, count)}. Press any key to exit");
        Console.ReadKey();
      }
    }

    public static void LeapYear()
    {
      Console.WriteLine("Please Enter a Year:");
      string input = Console.ReadLine();
      if (int.TryParse(input, out int result) == false)
      {
        Console.WriteLine("There are non-numeric values in your input and it broke the program :(");

      }
      int year = int.Parse(input);
      if (year % 4 == 0)
      {
        if (year % 100 == 0 && year % 400 != 0)
        {
          Console.WriteLine("Sorry, this isn't a leap year.");
          Console.ReadKey();
        }
        else
        {
          Console.WriteLine("This is a leap year.");
          Console.ReadKey();
        }
      }
      else
      {
        Console.WriteLine("Sorry, this isn't a leap year.");
        Console.ReadKey();

      }
    }

    public static int[] SumRows(int[,] input)
    {
      Console.WriteLine("The input array is:");
      for (int i = 0; i < input.GetLength(0); i++)
      {
        System.Console.Write($"Array Row # {i}");
        Console.WriteLine();
        for (int j = 0; j < input.GetLength(1); j++)
        {
          Console.Write(input[i, j] + " ");
        }
        Console.WriteLine();

      }

      int[] sumArray = new int[input.GetLength(0)];

      for (int i = 0; i < input.GetLength(0); i++)
      {
        for (int j = 0; j < input.GetLength(1); j++)
        {
          sumArray[i] = sumArray[i] + input[i, j];
        }
        Console.WriteLine($"The sum of Row {i} is: {sumArray[i]}");
      }

      Console.Write("The array values are: ");
      foreach (int value in sumArray)
      {
        Console.Write($"{value} ");
      }
      Console.ReadKey();

      return sumArray;
    }

    public static void PerfectSequence(int[] input)
    {
      Console.WriteLine("The input array is:");
      foreach (int value in input)
      {
        Console.Write(value.ToString());
      }

      int count = 0;
      foreach (int value in input)
      {
        if (value < 0)
        {
          count++;
        }
      }
      if (count > 0)
      {
        Console.WriteLine("\nThis is not a perfect sequence.");
        Console.ReadKey();
      }
      else
      {
        int sum = 0;
        int product = 1;
        foreach (int value in input)
        {
          sum = sum + value;
          product = product * value;
        }
        if (sum == product)
        {
          Console.WriteLine("\nThis is a perfect sequence.");
          Console.ReadKey();
        }
        else
        {
          Console.WriteLine("\nThis is not a perfect sequence.");
          Console.ReadKey();
        }
      }
    }
  }
}

