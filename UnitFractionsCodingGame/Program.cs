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
  static IEnumerable<int> GetDivisors(int n)
  {
    return from a in Enumerable.Range(2, n / 2)
           where n % a == 0
           select a;
  }

  static void Main(string[] args)
  {
    int n = int.Parse(Console.ReadLine());
    List<double> xValues = new List<double>();
    var divisors = GetDivisors(n).DefaultIfEmpty(n);

    foreach (var divisor in divisors)
    {
      // Write an action using Console.WriteLine()
      // To debug: Console.Error.WriteLine("Debug messages...");
      double x = 2 * n;
      while (x <= (double)n * (n + 1))
      {
        if (n * x / (x - n) == (int)(n * x / (x - n)) && xValues.IndexOf(x) == -1)
        {
          xValues.Add(x);
        }
        x += divisor;
      }
    }
    var resultx = xValues.OrderByDescending(i => i);
    foreach(double xval in resultx)
    {
      Console.WriteLine("1/" + Convert.ToString(n) + " = 1/" + Convert.ToString(xval) + " + 1/" + Convert.ToString(n * xval / (xval - n)));
    }  
  }
}
