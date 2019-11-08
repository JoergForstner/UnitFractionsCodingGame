using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections;
using System.Collections.Generic;

/**
 * Auto-generated code below aims at helping you parse
 * the standard input according to the problem statement.
 **/
class Solution
{

  static List<int> FindFactors(int num)
  {
    List<int>result = new List<int>();

    // Take out the 2s.
    while (num % 2 == 0)
    {
      result.Add(2);
      num /= 2;
    }

    // Take out other primes.
    var factor = 3;
    while (factor * factor <= num)
    {
      if (num % factor == 0)
      {
        // This is a factor.
        result.Add(factor);
        num /= factor;
      }
      else
      {
        // Go to the next odd number.
        factor += 2;
      }
    }

    // If num is not 1, then whatever is left is prime.
    if (num > 1) result.Add(num);

    return result;
  }

  static void Main(string[] args)
  {
    int n = int.Parse(Console.ReadLine());
    List<double> xValues = new List<double>();
    var divisors = FindFactors(n);

     foreach (var divisor in divisors)
    {
    // Write an action using Console.WriteLine()
    // To debug: Console.Error.WriteLine("Debug messages...");
      for (long y = n + 1; y <= 2 * n; y++)
      {
        if (((y*n )/ (y - n)) % divisor == 0 && ((y * n) * y/ (y - n)) % n == 0 && xValues.IndexOf((y * n) / (y - n)) == -1 && (y * n) / (y - n) == (long)((y * n) / (y - n)))
        {
          xValues.Add((y * n) / (y - n));
        }
      }
    }



    var resultx = xValues.OrderByDescending(i => i);
    foreach(double xval in resultx)
    {
      Console.WriteLine("1/" + Convert.ToString(n) + " = 1/" + Convert.ToString(xval) + " + 1/" + Convert.ToString(n * xval / (xval - n)));
    }  
  }
}
