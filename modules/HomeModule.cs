// using Nancy;
// using NumberWordNS.Objects;
// using System.Collections.Generic;
//
// namespace NumberWordModuleNS
// {
//   public class HomeModule : NancyModule
//   {
//     public HomeModule()
//     {
//       Get["/"] = _ =>
//       {
//         return View["index.cshtml"];
//       };
//        Post["/"]= _ =>
//        {
//         NumberWord newNumWord = new NumberWord(Request.Form["phrase"]);
//         newPhrase.Chop();
//         return View["index.cshtml", newPhrase.Loop()];
//      };
//     }
//   }
// }
