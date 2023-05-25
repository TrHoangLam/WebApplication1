using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
using System.Xml.Linq;

namespace WebApplication1.Controllers
{
    public class HelloWordController : Controller
    {
        public IActionResult Index(string name, int age = 1)
        {
            ViewData["Message"] = "Hello " + name;
            ViewData["Age"] = age;
            return View();
        }
     //   public string Index()
     //   {
     //       return "Hello My Name Is Lam ^^";
     //   }
      //  public string Welcome()
      //  {
      //      return "Hello My Name Is Lam";
      //  }
      public string Welcome(string name , int age=1 )
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, age: {age}");
        }
    }
}
