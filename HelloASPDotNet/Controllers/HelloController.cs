using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers;

[Route("/hello")]
public class HelloController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [Route("/hello")]
    public IActionResult Welcome(string name)
    {
        ViewBag.person = name;
        return View();
    }
}