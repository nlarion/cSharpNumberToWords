using System.Collections.Generic;
using System;
using System.Linq;

namespace NumberWordNS.Objects
{
  public class NumberWord
    {
        private int _number;
        private char[] _numArray;
        // private List<int> = new List<int>() {"Million", "Hundred", "Thousand"};
        private List<string> _totalNum;


        public NumberWord (int number)
        {
          _number = number;
        }

        public char[] ChopNum()
        {
          string stringNum = _number.ToString();
          char[] numArray = stringNum.ToCharArray();
          _numArray = numArray;
          return numArray;
        }

        public List<string> LoopChar()
        {
          for(var i = 0; i < _numArray.Length; i++)
          {
            Console.WriteLine(_totalNum);
            if (_numArray[i] == '1')
            {
              _totalNum.Add("One");
            }
          }
          return _totalNum;
    }
  }
}
