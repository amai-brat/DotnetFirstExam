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
    public IActionResult Index(Game game)
    {
        return View(game);
    }

    [HttpPost]
    public async Task<IActionResult> Check(Character character)
    {
        Game game;
        if (!ModelState.IsValid)
        {
            game = new Game()
            {
                Character = character
            };
            return RedirectToAction("Index", game);
        }
        
        var monster = await _businessLogicClient.GetRandomMonsterAsync();
        var result = await _businessLogicClient.GetResultOfCombatAsync(
            new CharacterAndMonsterDto
            {
                Character = character,
                Monster = monster!
            });

        game = new Game
        {
            Character = character,
            Enemy = monster,
            Result = result
        };

        return View("Index", game);
    }
}