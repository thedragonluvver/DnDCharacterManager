namespace WebAPI.Core.Models;

public record DndCharacterSummary
{
    public string CharacterName {get;set;} = string.Empty;
    public List<string> Class {get;set;} = new List<string>();
    public byte CharacterLevel {get;set;}
    public string Background {get;set;} = string.Empty;
    public List<string> Ideals {get;set;} = new List<string>();
    public List<string> Bonds {get;set;} = new List<string>();
    public List<string> Flaws {get;set;} = new List<string>();
    public List<string> PersonalityTraits {get;set;} = new List<string>();
    public bool Dead {get;set;} = false;
}