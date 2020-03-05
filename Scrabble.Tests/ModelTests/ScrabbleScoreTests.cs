using Scrabble;
using Scrabble.Tests;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Scrabble.Tests
{
  [TestClass]
  public class WordTest
  {
    [TestMethod]
    
      public void GameScore_WordScore_1()
        {
          int score = Word.GameScore('a');
          Assert.AreEqual(1, score);
        }
      
    }
  }
