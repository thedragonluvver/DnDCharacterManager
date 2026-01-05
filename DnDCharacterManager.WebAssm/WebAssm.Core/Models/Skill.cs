using WebAPI.Core.Enums;

namespace WebAPI.Core.Models;

public record Skill
{
    public string Name {get;set;} = string.Empty;
    public ProficiencyEnum Proficient {get;set;} = 0;
}