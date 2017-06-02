using Xunit;
using System;
using System.Collections.Generic;
using Sentence.Objects;

namespace SentenceTest
{
  public class SentenceTest
  {
    [Fact]
    public void GetWord_ForSingleWordEntered_returnWord()
    {
      RepeatCounter testRC = new RepeatCounter("hello", "hello world");
      Assert.Equal("hello", testRC.GetWord());
    }
    [Fact]
    public void GetSentence_ForSentenceEntered_returnSentence()
    {
      RepeatCounter testRC = new RepeatCounter("hello", "hello world");
      Assert.Equal("hello", testRC.GetSentence());
    }
  }
}
