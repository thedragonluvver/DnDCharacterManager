using System.Text.Json.Serialization;
using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public record SpellBook
{
    [JsonPropertyName("AbilityScoreCode")]
    public char[] AbilityScoreCode {get;set;} = new char[3];
    [JsonPropertyName("SpellcastingClass")]
    public SpellcastingClassEnum SpellcastingClass {get;set;}
    [JsonPropertyName("Cantrips")]
    public List<Spell> Cantrips {get;set;} = new List<Spell>();
    [JsonPropertyName("FirstLevelSpells")]
    public List<Spell> FirstLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("SecondLevelSpells")]
    public List<Spell> SecondLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("ThirdLevelSpells")]
    public List<Spell> ThirdLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("FourthLevelSpells")]
    public List<Spell> FourthLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("FifthLevelSpells")]
    public List<Spell> FifthLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("SixthLevelSpells")]
    public List<Spell> SixthLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("SeventhLevelSpells")]
    public List<Spell> SeventhLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("EighthLevelSpells")]
    public List<Spell> EighthLevelSpells {get;set;} = new List<Spell>();
    [JsonPropertyName("NinthLevelSpells")]
    public List<Spell> NinthLevelSpells {get;set;} = new List<Spell>();
}