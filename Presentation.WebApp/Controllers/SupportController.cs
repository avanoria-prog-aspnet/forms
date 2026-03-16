using Microsoft.AspNetCore.Mvc;

namespace Presentation.WebApp.Controllers;

public class SupportController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
