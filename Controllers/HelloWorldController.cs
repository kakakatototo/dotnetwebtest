using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace webtest.Controllers
{
    public class HelloWorldController :Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public string Welcome(string name = "Anonymous",int numTimes = 1) 
        {
            return HtmlEncoder.Default.Encode($"Hello {name}, NumTimes is: {numTimes}");
        }
    }
}