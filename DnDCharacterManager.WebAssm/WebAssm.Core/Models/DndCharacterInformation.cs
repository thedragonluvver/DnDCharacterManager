using System.Text.Json.Serialization;

namespace WebAssm.Core.Models;

public record DndCharacterInformation
{
    [JsonPropertyName("CharacterName")]
    public string CharacterName {get;set;} = string.Empty;
    [JsonPropertyName("Classes")]
    public List<string> Classes {get;set;} = new List<string>();
    [JsonPropertyName("CharacterLevel")]
    public byte CharacterLevel {get;set;}
    [JsonPropertyName("EXP")]
    public int EXP {get;set;} = 0;
    [JsonPropertyName("Race")]
    public string Race {get;set;} = string.Empty;
    [JsonPropertyName("Age")]
    public int Age {get;set;}
    [JsonPropertyName("SkinColour")]
    public string SkinColour {get;set;} = string.Empty;
    [JsonPropertyName("EyeColour")]
    public string EyeColour {get;set;} = string.Empty;
    [JsonPropertyName("HairColour")]
    public string HairColour {get;set;} = string.Empty;
    // height is measured in inches
    [JsonPropertyName("Height")]
    public int Height {get;set;}
    // weight is measured in pounds(lbs)
    [JsonPropertyName("Weight")]
    public int Weight {get;set;}
    [JsonPropertyName("Background")]
    public string Background {get;set;} = string.Empty;
    [JsonPropertyName("Ideals")]
    public List<string> Ideals {get;set;} = new List<string>();
    [JsonPropertyName("Bonds")]
    public List<string> Bonds {get;set;} = new List<string>();
    [JsonPropertyName("Flaws")]
    public List<string> Flaws {get;set;} = new List<string>();
    [JsonPropertyName("PersonalityTraits")]
    public List<string> PersonalityTraits {get;set;} = new List<string>();
    [JsonPropertyName("WorshippedDeity")]
    public string WorshippedDeity {get;set;} = string.Empty;
    [JsonPropertyName("MaxHP")]
    public int MaxHP {get;set;}
    [JsonPropertyName("CurrentHP")]
    public int CurrentHP {get;set;}
    [JsonPropertyName("TempHP")]
    public int TempHP {get;set;}
    [JsonPropertyName("ArmourClass")]
    public byte ArmourClass {get;set;}
    [JsonPropertyName("Initiative")]
    public sbyte Initiative {get;set;}
    [JsonPropertyName("FailedDeathSaves")]
    public byte FailedDeathSaves {get;set;}
    [JsonPropertyName("SucceededDeathSaves")]
    public byte SuccededDeathSaves {get;set;}
    [JsonPropertyName("Dead")]
    public bool Dead {get;set;} = false;
    [JsonPropertyName("AbilityScores")]
    public List<AbilityScore> AbilityScores {get;set;} = new List<AbilityScore>();
    [JsonPropertyName("Features")]
    public List<Feature> Features {get;set;} = new List<Feature>();
    [JsonPropertyName("Inventory")]
    public Inventory Inventory {get;set;} = new Inventory();
    [JsonPropertyName("SpellBook")]
    public SpellBook SpellBook {get;set;} = new SpellBook();
}