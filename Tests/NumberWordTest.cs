using Xunit;
using NumberWordNS.Objects;
using System.Collections.Generic;
using System;
using System.Linq;


namespace NumberWordTestNS
{
  public class NumberWordTest
  {
    [Fact]
    public void SubtractFromNumber()
    {
      NumberWord test = new NumberWord(2222);
      Dictionary<string,int> testResults = new Dictionary<string,int>();
      testResults.Add("Thousand", 2);
      testResults.Add("Hundred", 2);
      testResults.Add("Ten", 2);
      testResults.Add("", 2);
      Assert.Equal(testResults, test.GetNumber());
    }
    [Fact]
    public void SubtractFromNumber2()
    {
      NumberWord test = new NumberWord(2211);
      Dictionary<string,int> testResults = new Dictionary<string,int>();
      testResults.Add("Thousand", 2);
      testResults.Add("Hundred", 2);
      testResults.Add("Ten", 0);
      testResults.Add("", 11);
      Assert.Equal(testResults, test.GetNumber());
    }

    [Fact]
    public void LoopDictionaries()
    {
      NumberWord test = new NumberWord(2222);
      string testString = test.BuildWord();
      Assert.Equal("Two Thousand Two Hundred Twenty Two  ", testString);
    }

    [Fact]
    public void LoopDictionaries2()
    {
      NumberWord test = new NumberWord(4456);
      string testString = test.BuildWord();
      Assert.Equal("Four Thousand Four Hundred Fifty Six  ", testString);
    }
    [Fact]
    public void LoopDictionaries3()
    {
      NumberWord test = new NumberWord(2211);
      string testString = test.BuildWord();
      Assert.Equal("Two Thousand Two Hundred Eleven  ", testString);
    }
  }
}
