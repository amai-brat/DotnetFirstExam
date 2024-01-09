using Shared;

namespace BusinessLogic.Services;

public interface ICombat
{
    public Result GetResult(Character character, Monster monster);
}