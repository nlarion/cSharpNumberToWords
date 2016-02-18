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
    public void ChopNumberIntoDigits()
    {
      NumberWord test = new NumberWord(33);
      Assert.Equal(new char[]{'3', '3'}, test.ChopNum());
    }

    [Fact]
    public void LoopThroughCharArray()
    {
      NumberWord test = new NumberWord(1);
      test.ChopNum();
      Assert.Equal(new List<string>{"One"}, test.LoopChar());
    }


  }
}
