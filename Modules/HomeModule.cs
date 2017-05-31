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
        // inputString CheckString = new inputString();
        // string result = CheckString.IsItAPalindrome(Request.Form["palindromesTest"]);
        return View["index.cshtml"];
      };
    }
  }
}
