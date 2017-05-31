using Xunit;
using System;
using Palindromes.Objects;

namespace Palindromes
{
  public class PalindromesTests
  {
    [Fact]
    public void String_to_arr_revered_test()
    {
      Palindrome instance = new Palindrome();
      string testString = instance.ReverseString("cat");
      Assert.Equal("tac", testString );
    }
    [Fact]
    public void IsPalindrome_true()
    {
      Palindrome instance = new Palindrome();
      string testString = instance.ReverseString("anna");
      bool isPalindrome = instance.IsPalindrome("anna", testString);
      Assert.Equal(true, isPalindrome);
    }
  }
}
