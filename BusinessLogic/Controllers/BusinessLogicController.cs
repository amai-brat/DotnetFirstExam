using BusinessLogic.Model;
using BusinessLogic.Services;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto;

namespace BusinessLogic.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BusinessLogicController : Controller
{
    private readonly IApplicationContext _dbContext;
    private readonly ICombat _combat;
    
    public BusinessLogicController(IApplicationContext dbContext, ICombat combat)
    {
        _dbContext = dbContext;
        _combat = combat;
    }

    [HttpPost]
    public IActionResult GetResult([FromBody] CharacterAndMonsterDto dto)
    {
        return Json(_combat.GetResult(dto.Character, dto.Monster));
    }

    [HttpGet]
    public async Task<IActionResult> GetRandomMonster()
    {
        return Json(await _dbContext.GetRandomMonsterAsync());
    }
}