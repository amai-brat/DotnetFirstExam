using Microsoft.AspNetCore.Mvc;

namespace UI.Controllers;

public class DndCombatController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}