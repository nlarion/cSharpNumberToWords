using System.Collections.Generic;
using System;
using System.Linq;

namespace NumberWordNS.Objects
{
  public class NumberWord
  {
    private int _number;
    private char[] _numArray;
    private Dictionary<string, int> _numberDictionary = new Dictionary<string, int>
    {
      {"Thousand", 1000},
      {"Hundred", 100},
      {"Ten", 10},
      {"", 1}
    };

    private Dictionary<string, int> _translationDictionary = new Dictionary<string, int>
    {
      {"One", 1},
      {"Two", 2},
      {"Three", 3},
      {"Four", 4},
      {"Five", 5},
      {"Six", 6},
      {"Seven", 7},
      {"Eight", 8},
      {"Nine", 9},
      {"Ten", 10},
      {"Eleven", 11},
      {"Twelve", 12},
      {"Thirteen", 13},
      {"Forteen", 14},
      {"Fifteen", 15},
      {"Sixteen", 16},
      {"Seventeen", 17},
      {"Eighteen", 18},
      {"Ninteen", 19}
    };

    private Dictionary<string, int> _specialDictionary = new Dictionary<string, int>
    {
      {"Twenty", 2},
      {"Thirty", 3},
      {"Forty", 4},
      {"Fifty", 5},
      {"Sixty", 6},
      {"Seventy", 7},
      {"Eighty", 8},
      {"Ninety", 9}
    };

    public NumberWord (int number)
    {
      _number = number;
    }

    public Dictionary<string,int> GetNumber()
    {
       Dictionary<string, int> newDictionary = new Dictionary<string, int>();
      foreach(KeyValuePair<string, int> entry in _numberDictionary)
      {
        if((entry.Key == "Ten" || entry.Key == "Ten Thousand" || entry.Key == "Ten Million")&& (_number/entry.Value)==1)
        {
          newDictionary.Add(entry.Key, 0);
        }
        else
        {
          int totalAmount = (_number/entry.Value) * entry.Value;
          newDictionary.Add(entry.Key, (_number/entry.Value));
          _number = _number - totalAmount;
        }
      }
      return newDictionary;
    }

    public string BuildWord()
    {
      string returnString = "";
      Dictionary<string,int> getNumber = this.GetNumber();

      foreach(KeyValuePair<string, int> entry in getNumber)
      {
        if(entry.Key == "Ten" || entry.Key == "Ten Thousand" || entry.Key == "Ten Million")
        {
          foreach(KeyValuePair<string, int> number in _specialDictionary)
          {
            if(number.Value == entry.Value)
            {
              returnString += number.Key + " ";
            }
          }
        }
        else
        {
          foreach(KeyValuePair<string, int> number in _translationDictionary)
          {
            if(number.Value == entry.Value)
            {
              returnString += number.Key + " " + entry.Key + " ";
            }
          }
        }
      }
      return returnString;
    }
  }
}
