using System;
using System.Collections.Generic;

namespace Palindromes.Objects
{
  public class Palindrome
  {
    public string ReverseString(string userInput)
    {
      char[] array = new char[userInput.Length];
      char[] arrayReversed = new char[userInput.Length];
      array = userInput.ToCharArray();
      for (int i = 0, j = userInput.Length-1; i <= array.Length-1; i++)
      {
        arrayReversed[i] = array[j];
        j--;
      }
      string reversedString = new string(arrayReversed);
      return reversedString;
    }
    public bool IsPalindrome(string userInput, string reversedString)
    {
      if (userInput == reversedString) {
        return true;
      }
      else
      {
        return false;
      }
    }
  }
}
