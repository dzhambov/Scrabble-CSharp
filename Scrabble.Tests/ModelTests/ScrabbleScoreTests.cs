using System;
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
          Assert.AreEqual(2, Word.GameScore("a"));
        }
      
    }
  }
