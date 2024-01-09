using BusinessLogic.Model;
using Microsoft.AspNetCore.Mvc;
using Shared;
using Shared.Dto;

namespace BusinessLogic.Controllers;

[ApiController]
[Route("api/[controller]/[action]")]
public class BusinessLogicController : Controller
{
    private readonly IApplicationContext _dbContext;
    
    public BusinessLogicController(IApplicationContext dbContext)
    {
        _dbContext = dbContext;
    }

    [HttpPost]
    public IActionResult GetResult([FromBody] CharacterAndMonsterDto dto)
    {
        return Ok(new Result
        {
            WinnerName = "EM",
            Logs = new List<CombatLog>()
        });
    }

    [HttpGet]
    public async Task<IActionResult> GetRandomMonster()
    {
        return Json(await _dbContext.GetRandomMonsterAsync());
    }
}