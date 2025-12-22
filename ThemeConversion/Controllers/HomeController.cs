using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using ThemeConversion.Models;

namespace ThemeConversion.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    
    public IActionResult About()
    {
        return View();
    }
    
    public IActionResult Facts()
    {
        return View();
    }

    public IActionResult Skills()
    {
        return View();
    }

    public IActionResult Resume()
    {
        return View();
    }
    
    public IActionResult Portfolio()
    {
        return View();
    }
    
    public IActionResult Services()
    {
        return View();
    }

    public IActionResult Testimonials()
    {
        return View();
    }

    public IActionResult Contacts()
    {
        return View();
    }
}
