using System.Text.Json.Serialization;
using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public record Skill
{
    [JsonPropertyName("Name")]
    public string Name {get;set;} = string.Empty;
    [JsonPropertyName("Proficient")]
    public ProficiencyEnum Proficient {get;set;} = 0;
    
    public DiceData DiceData {get;set;} = new DiceData(){MaxRoll = 20};
}