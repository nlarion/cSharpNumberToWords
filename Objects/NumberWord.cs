using System.Collections.Generic;
using System;
using System.Linq;

namespace NumberWordNS.Objects
{
  public class NumberWord
    {
        private int _number;
        

        public NumberWord (string phrase)
        {
          _phrase = phrase.ToLower();
        }

        public char[] Chop()
        {
          char[] newArray = _phrase.ToCharArray();
          _newArray = newArray;
          return newArray;
        }


  }
}
