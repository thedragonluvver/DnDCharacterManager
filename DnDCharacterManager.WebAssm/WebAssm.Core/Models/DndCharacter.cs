using System.Text.Json.Serialization;

namespace WebAssm.Core.Models;

public record DndCharacter
{
    [JsonPropertyName("Id")]
    public int Id {get;set;}
    [JsonPropertyName("Character")]
    public DndCharacterInformation Character {get;set;} = new DndCharacterInformation();
    public DndCharacterSummary Summary {get;set;} = new DndCharacterSummary();
}