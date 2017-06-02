using Xunit;
using System;
using System.Collections.Generic;
using Sentence.Objects;

namespace SentenceTest
{
  public class SentenceTest
  {
    //Spec 1 Test
    [Fact]
    public void GetWord_ForSingleWordEntered_returnWord()
    {
      RepeatCounter testRC = new RepeatCounter("hello", "hello world");
      Assert.Equal("hello", testRC.GetWord());
    }
    //Spec 2 Test
    [Fact]
    public void GetSentence_ForSentenceEntered_returnSentence()
    {
      RepeatCounter testRC = new RepeatCounter("hello", "hello world");
      Assert.Equal("hello world", testRC.GetSentence());
    }
    //Spec 3 Test
    [Fact]
    public void SplitSentence_SplitSentenceIntoAnArray_returnArrayLength()
    {
      RepeatCounter testRC = new RepeatCounter("hello", "hello world");
      Assert.Equal(2, testRC.SplitSentence());
    }
  }
}
