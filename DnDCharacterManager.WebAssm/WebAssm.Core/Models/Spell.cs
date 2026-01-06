using System.Text.Json.Serialization;
using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public record Spell
{
    [JsonPropertyName("Name")]
    public string Name {get;set;} = string.Empty;
    [JsonPropertyName("Description")]
    public string Description {get;set;} = string.Empty;
    // range is measured in feet
    [JsonPropertyName("Range")]
    public int Range {get;set;} 
    [JsonPropertyName("Ritual")]
    public bool Ritual {get;set;}
    [JsonPropertyName("Concentration")]
    public bool Concentration {get;set;}
    [JsonPropertyName("Verbal")]
    public bool Verbal {get;set;}
    [JsonPropertyName("Somatic")]
    public bool Somatic {get;set;}
    [JsonPropertyName("Materials")]
    public List<string> Materials {get;set;} = new List<string>();
    [JsonPropertyName("BaseLevel")]
    public byte BaseLevel {get;set;}
    [JsonPropertyName("Scaling")]
    public bool Scaling {get;set;}
    [JsonPropertyName("ScalingIncrement")]
    public byte ScalingIncrement {get;set;} = 0;
    [JsonPropertyName("Prepared")]
    public bool Prepared {get;set;}
    [JsonPropertyName("SpellcasingClasses")]
    public List<SpellcastingClassEnum> SpellcastingClasses {get;set;} = new List<SpellcastingClassEnum>();
    [JsonPropertyName("School")]
    public MagicSchoolEnum School {get;set;}
    [JsonPropertyName("CastingTime")]
    public CastingTimeEnum CastingTime {get;set;}
    [JsonPropertyName("Duration")]
    public DurationEnum Duration {get;set;}
    [JsonPropertyName("DamageType")]
    public DamageTypeEnum? DamageType {get;set;} = null;
    public List<DiceData> DamageDice {get;set;} = new List<DiceData>();
}