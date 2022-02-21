using System;

// With input of 15, build an array of numbers from 0 or 1 to that number.
// Replace certain numbers with 'ping', other numbers with 'pong'.
// The pattern is....


public class Program
{
  public static void Main()
  {
    Console.WriteLine("Pick a number: ");
    int number = int.Parse(Console.ReadLine());
    Console.WriteLine(" ");
    for (int i = 1; i <= number; i++)
    {
      if ((i % 3) == 0 && (i % 5) == 0) {
        Console.WriteLine("ping-pong");
      } else if ((i % 3) == 0) {
        Console.WriteLine("ping");
      } else if ((i % 5) == 0) {
        Console.WriteLine("pong");
      } else {
        Console.WriteLine(i);
      }
    }
    
  }
}

