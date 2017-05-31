using Nancy;
using System.Collections.Generic;
using Palindromes.Objects;

namespace Palindromes
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => {
        return View["index.cshtml"];
      };
      Post["/"] = _ => {
        Palindrome input = new Palindrome();
        string userInput = Request.Form["palindromeTest"];
        userInput = input.RemoveSpaces(userInput);
        string result = input.RemoveSpaces(userInput);
        result = input.ReverseString(userInput);
        bool palindrome = input.IsPalindrome(userInput, result);
        return View["index.cshtml", palindrome];
      };
    }
  }
}
