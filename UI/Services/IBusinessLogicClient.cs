using Shared;
using Shared.Dto;

namespace UI.Services;

public interface IBusinessLogicClient
{
    public Task<Result?> GetResultOfCombatAsync(CharacterAndMonsterDto dto);
    public Task<Monster?> GetRandomMonsterAsync();
}