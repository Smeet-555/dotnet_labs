using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThemeConversion2.Models;

namespace ThemeConversion2.Controllers;

public class HomeController : Controller
{
    [Route("home/index/{page?}")]
    public IActionResult Index(string page = "index")
    {
        var allowedPages = new HashSet<string>
        {
            "index", "blog", "contact", "counter", "portfolio", "services" , "testimonials"
        };

        page = page.ToLower();

        if (!allowedPages.Contains(page))
            page = "index";

        return View(page);
    }
}
