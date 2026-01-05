using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public record Skill
{
    public string Name {get;set;} = string.Empty;
    public ProficiencyEnum Proficient {get;set;} = 0;
}