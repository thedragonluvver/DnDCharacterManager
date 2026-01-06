using System.Text.Json.Serialization;

namespace WebAssm.Core.Models;

public record AbilityScore
{
    [JsonPropertyName("Name")]
    public string Name {get;set;} = string.Empty;
    [JsonPropertyName("NameShort")]
    public char[] NameShort {get;set;} = new char[3];
    [JsonPropertyName("Score")]
    public byte Score {get;set;}
    [JsonPropertyName("Skills")]
    public List<Skill> Skills {get;set;} = new List<Skill>();
    [JsonPropertyName("SavingThrow")]
    public Skill SavingThrow {get;set;} = new Skill();
}