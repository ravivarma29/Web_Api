using consumeapi_httpClient.Models;
using consumeAPI_httpclient.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace consumeapi_httpClient.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public IActionResult DisplayPost()
        {
            PostDetails postObject = new PostDetails();
            ViewBag.post = postObject.GetPostData();
            return View();
        }

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}