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
    public void Chop_Up_Word()
    {
      Scrabble test = new Scrabble("hey");
      Assert.Equal(new char[]{'h', 'e', 'y'}, test.Chop());
    }


  }
}
