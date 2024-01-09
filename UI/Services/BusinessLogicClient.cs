using Shared;
using Shared.Dto;

namespace UI.Services;

public class BusinessLogicClient : IBusinessLogicClient
{
    private readonly string _blUrl;
    private readonly HttpClient _httpClient = new();

    public BusinessLogicClient(string businessLogicUrlBeginning)
    {
        _blUrl = businessLogicUrlBeginning;
    }

    public async Task<Result?> GetResultOfCombatAsync(CharacterAndMonsterDto dto)
    {
        var response = await _httpClient.PostAsJsonAsync(_blUrl + "/api/BusinessLogic/GetResult", dto);
        return await response.Content.ReadFromJsonAsync<Result>();
    }

    public async Task<Monster?> GetRandomMonsterAsync()
    { 
        return await _httpClient.GetFromJsonAsync<Monster>(_blUrl + "/api/BusinessLogic/GetRandomMonster");
    }
}