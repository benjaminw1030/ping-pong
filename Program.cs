using System;
using System.Collections.Generic;

namespace PingPong
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Input an integer:");
      string inputString = Console.ReadLine();
      int inputNumber = int.Parse(inputString);
      PingPong(inputNumber);
    }

    static void PingPong(int inputNumber)
    {
      for(int i = 1; i <= inputNumber; i++)
      {
        if(i % 3 == 0 && i % 5 == 0)
        {
          Console.WriteLine("ping pong");
        }
        else if (i % 3 == 0)
        {
          Console.WriteLine("ping");
        }
        else if (i % 5 == 0)
        {
          Console.WriteLine("pong");
        }
        else
        {
          Console.WriteLine(i);
        }
      }
    }
  }
}