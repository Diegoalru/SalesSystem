using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using SalesWeb.Models;

namespace SalesWeb.Controllers;

public class HomeController(ILogger<HomeController> logger) : Controller
{
    private readonly ILogger<HomeController> _logger = logger;

    public IActionResult Index()
    {
        _logger.LogInformation("Index page says hello");
        return View();
    }

    public IActionResult Privacy()
    {
        _logger.LogInformation("Privacy page says hello");
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}