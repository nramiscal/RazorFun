using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
namespace RazorFun {
    public class HomeController : Controller {

        [HttpGet("")]
        public IActionResult Index() => View();
    }
}

