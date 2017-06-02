using Nancy;
using System.Collections.Generic;
using System.Diagnostics;
using SentenceTest;

namespace Sentence.Objects
{
  public class RepeatCounter
  {
    private string _word;
    private string _sentence;
    private int _counter;

    public RepeatCounter(string word, string sentence)
    {
      _word = word;
      _sentence = sentence;
    }
    public string GetWord()
    {
      return _word;
    }
    public string GetSentence()
    {
      return _sentence;
    }
  }
}
