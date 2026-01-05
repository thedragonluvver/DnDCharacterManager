namespace WebAssm.Core.Models;

public record DndCharacter
{
    public string CharacterName {get;set;} = string.Empty;
    public List<string> Class {get;set;} = new List<string>();
    public byte CharacterLevel {get;set;}
    public int EXP {get;set;} = 0;
    public string Race {get;set;} = string.Empty;
    public int Age {get;set;}
    public string SkinColour {get;set;} = string.Empty;
    public string EyeColour {get;set;} = string.Empty;
    public string HairColour {get;set;} = string.Empty;
    // height is measured in inches
    public int Height {get;set;}
    // weight is measured in pounds(lbs)
    public int Weight {get;set;}
    public string Background {get;set;} = string.Empty;
    public List<string> Ideals {get;set;} = new List<string>();
    public List<string> Bonds {get;set;} = new List<string>();
    public List<string> Flaws {get;set;} = new List<string>();
    public List<string> PersonalityTraits {get;set;} = new List<string>();
    public string WorshippedDeity {get;set;} = string.Empty;
    public int MaxHP {get;set;}
    public int CurrentHP {get;set;}
    public int TempHP {get;set;}
    public byte ArmourClass {get;set;}
    public sbyte Initiative {get;set;}
    public byte FailedDeathSaves {get;set;}
    public byte SuccededDeathSaves {get;set;}
    public bool Dead {get;set;} = false;
    public List<AbilityScore> AbilityScores {get;set;} = new List<AbilityScore>();
    public List<Feature> Features {get;set;} = new List<Feature>();
    public Inventory Inventory {get;set;} = new Inventory();
    public SpellBook SpellBook {get;set;} = new SpellBook();
}