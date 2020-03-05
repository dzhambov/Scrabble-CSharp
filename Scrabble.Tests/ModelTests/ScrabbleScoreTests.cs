using Scrabble.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
      public void GameScore_WordScore_1()
        {
          Assert.AreEqual(2, Word.GameScore("a" + "i"));
        }

    [TestMethod]
      public void GameScore_WordScore_2()
        {
          Assert.AreEqual(4, Word.GameScore("g" + "d"));
        }

    [TestMethod]
      public void GameScore_WordScore_5()
        {
          Assert.AreEqual(5, Word.GameScore("g" + "d" + "o"));
        }

    [TestMethod]
      public void GameScore_WordScore_7()
        {
          Assert.AreEqual(7, Word.GameScore("c" + "o" + "p"));
        }

    [TestMethod]
      public void GameScore_WordScore_9()
        {
          Assert.AreEqual(9, Word.GameScore("h" + "o" + "w"));
        }

    [TestMethod]
      public void GameScore_WordScore_10()
        {
          Assert.AreEqual(10, Word.GameScore("k" + "e" + "e" + "p"));
        }

    [TestMethod]
      public void GameScore_WordScore_12()
        {
          Assert.AreEqual(12, Word.GameScore("j" + "o" + "b"));
        }
    [TestMethod]
      public void GameScore_WordScore_22()
        {
          Assert.AreEqual(22, Word.GameScore("q" + "u" + "i" + "z"));
        }
    }
  }
