using Xunit;
using System;
using Palindromes.Objects;

namespace Palindromes
{
  public class PalindromesTests
  {
    [Fact]
    public void String_Trim_true()
    {
      Palindrome instance = new Palindrome();
      string testString = instance.RemoveSpaces("too hot to hoot");
      Assert.Equal("toohottohoot", testString);
    }
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
    [Fact]
    public void IsNotPalindrome_true()
    {
      Palindrome instance = new Palindrome();
      string testString = instance.ReverseString("argyle");
      bool isPalindrome = instance.IsPalindrome("argyle", testString);
      Assert.Equal(false, isPalindrome);
    }
  }
}
