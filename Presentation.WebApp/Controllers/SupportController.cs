using Application.Support;
using Application.Support.Inputs;
using Microsoft.AspNetCore.Mvc;
using Presentation.WebApp.Models.Support;

namespace Presentation.WebApp.Controllers;

public class SupportController() : Controller
{
    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    [ValidateAntiForgeryToken]
    public async Task<IActionResult> Index(ContactForm form, CancellationToken ct = default)
    {
        if (!ModelState.IsValid)
            return View(form);

        var input = new RegisterContactRequestInput(
            form.FirstName,
            form.LastName,
            form.Email,
            form.Phone,
            form.Message
        );

        //await contactFormService.RegisterContactRequestAsync(input, ct);
        TempData["Message"] = "Contact request sent.";
        return RedirectToAction(nameof(Index));
    }

}
