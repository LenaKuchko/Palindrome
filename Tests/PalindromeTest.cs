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
      string testString = instance.IsItAPalindrome("cat");
      Assert.Equal("tac", testString );
    }
  }
}
