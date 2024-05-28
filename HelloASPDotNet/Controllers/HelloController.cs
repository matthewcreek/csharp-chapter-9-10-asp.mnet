using Microsoft.AspNetCore.Mvc;

namespace HelloASPDotNet.Controllers;

[Route("/helloworld")]
public class HelloController : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        string html = "<form method='post' action='/helloworld/welcome'>" +
            "<input type='text' name='name' />" +
            "<select name='language'>" + 
            "<option value='english'>English</option>" +
            "<option value='spanish'>Spanish</option>" +
            "<option value='french'>French</option>" +
            "<option value='bosniam'>Bosnian</option>" +
            "<option value='vietnamese'>Vietnamese</option>" +
            "</select>" +
            "<input type='submit' value='Greet Me!' />" +
            "</form>";

        return Content(html, "text/html");
    }

    // [HttpGet("welcome/{name?}")]
    // [HttpPost("welcome")]
    // public IActionResult Welcome(string name = "World")
    // {
    //     return Content($"Welcome to my app, {name}!", "text/html");
    // }

    [HttpGet("welcome/{name?}")]
    [HttpPost("welcome")]
    public IActionResult Display(string name = "World", string language = "english")
    {
        return Content(CreateMessage(name, language));
    }

    public static string CreateMessage(string name, string language) 
    {
        string helloTranslation = "";
        switch (language)
        {
            case "french":
                helloTranslation = "Bonjour ";
                break;
             case "spanish":
                 helloTranslation = "Hola ";
                 break;
             case "bosnian":
                 helloTranslation = "Zdravo ";
                 break;
             case "vietnamese":
                 helloTranslation = "Xin Chao ";
                 break;
             case "english":
                 helloTranslation = "Hello ";
                 break;
        }
        return helloTranslation + name;
    }
}