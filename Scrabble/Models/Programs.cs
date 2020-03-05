using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public void Main()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      TypeLine("Hello Scrambbler");
      TypeLine("Enter a word if you would like to play");
      string wordInput = Console.ReadLine();
      TypeLine($"The word that you entered is {wordInput} and recieves {GameScore} piont in Scrabble");
    }
    public static void TypeLine(string input)
      {
      for (int i = 0; i < input.Length; i++)
      {
          Console.Write(input[i]);
          System.Threading.Thread.Sleep(25);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
      }
  }
}