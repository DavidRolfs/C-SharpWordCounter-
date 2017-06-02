using Nancy;
using System.Collections.Generic;
using System.Diagnostics;
using SentenceTest;
using System;

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
    public int SplitSentence()
    {
      string[] array = _sentence.Split();
      Console.WriteLine(array);
      return array.Length;
    }
    public int CountRepeats()
    {
      string sentence = _sentence.ToLower();
      _counter = 0;
      string[] sentenceArray = sentence.Split();

      for(int i = 0; i < sentenceArray.Length; i++)
      {
        if(_word == sentenceArray[i])
        {
          _counter ++;
        }
      }
      return _counter;
    }
  }
}
