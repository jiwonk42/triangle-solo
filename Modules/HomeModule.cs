using Nancy;
using Triangle.Objects;

namespace Triangle
{
  public class HomeModule : NancyModule
  {
    public HomeModule()
    {
      Get["/"] = _ => View["form.cshtml"];
      Get["/result"] = _ =>
      {
        TriangleVariables triangle = new TriangleVariables();
        triangle.SetSide1(Request.Query["side-1"]);
        triangle.SetSide2(Request.Query["side-2"]);
        triangle.SetSide3(Request.Query["side-3"]);
        return View["result.cshtml", triangle];
      };
    }
  }
}
