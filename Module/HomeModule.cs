using Nancy;
using System.Collections.Generic;
using WordCounter.Objects;

namespace WordChecker
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ =>View["index.cshtml"];

      Post["/results"] = _ =>{
        RepeatCounter newCount = new RepeatCounter(Request.Form["word"], Request.Form["sentence"]);
        return View["result.cshtml", newCount];
      };
    }
  }
}
