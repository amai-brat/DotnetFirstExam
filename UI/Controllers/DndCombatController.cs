using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto;
using UI.Services;

namespace UI.Controllers;

public class DndCombatController : Controller
{
    private readonly IBusinessLogicClient _businessLogicClient;

    public DndCombatController(IBusinessLogicClient businessLogicClient)
    {
        _businessLogicClient = businessLogicClient;
    }

    [HttpGet]
    public IActionResult Index()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Index(Character character)
    {
        if (!ModelState.IsValid)
        {
            return View(character);

        }

        return RedirectToAction("Game", character);
    }

    [HttpGet]
    public async Task<IActionResult> Game(Character character)
    {
        var monster = await _businessLogicClient.GetRandomMonsterAsync();
        var result = await _businessLogicClient.GetResultOfCombatAsync(
            new CharacterAndMonsterDto
            {
                Character = character,
                Monster = monster!
            });
        
        return Ok(result);
    }
}