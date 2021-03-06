using System;
using Scrabble.Models;

namespace Scrabble
{
  public class Program
  {
    public static void Main()
    {
      Console.Clear();
      Console.ForegroundColor = ConsoleColor.DarkYellow;
      TypeLine("Hello Scrambbler");
      TypeLine("Enter a word if you would like to play");
      Console.ForegroundColor = ConsoleColor.Red;
      string wordInput = Console.ReadLine();
      int userScore = Word.GameScore(wordInput);
      TypeLine($"The word that you entered is {wordInput} and recieves {userScore} piont in Scrabble");
      Main();
    }
    public static void TypeLine(string input)
      {
      for (int i = 0; i < input.Length; i++)
      {
          Console.Write(input[i]);
          System.Threading.Thread.Sleep(35);
      }
      Console.Write(Environment.NewLine);
      Console.Write(Environment.NewLine);
      }
  }
}