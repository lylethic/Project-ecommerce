using ClothesWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ClothesWeb.Controllers
{
  public class HomeController : Controller
  {
    //private readonly ILogger<HomeController> _logger;

    //public HomeController(ILogger<HomeController> logger)
    //{
    //  _logger = logger;
    //}

    public IActionResult Index()
    {
      return View();
    }

    public IActionResult About()
    {
      return View();
    }

    public IActionResult Shop()
    {
      return View();
    }

    public IActionResult Blog()
    {
      return View();
    }

    public IActionResult Contact()
    {
      return View();
    }

    public IActionResult Login()
    {
      return View();
    }

    public IActionResult SignUp()
    {
      return View();
    }

    public IActionResult Cart()
    {
      return View();
    }
  }
}