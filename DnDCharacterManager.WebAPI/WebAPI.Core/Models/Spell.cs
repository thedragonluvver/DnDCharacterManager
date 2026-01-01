using WebAPI.Core.Enums;

namespace WebAPI.Core.Models;

public class Spell
{
    public string Name {get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    // range is measured in feet
    public int Range {get;set;} 
    public bool Ritual {get;set;}
    public bool Concentration {get;set;}
    public bool Verbal {get;set;}
    public bool Somatic {get;set;}
    public List<string> Materials {get;set;} = new List<string>();
    public byte BaseLevel {get;set;}
    public bool Scaling {get;set;}
    public byte ScalingIncrement {get;set;} = 0;
    public bool Prepared {get;set;}
    public List<SpellcastingClassEnum> SpellcastingClasses {get;set;} = new List<SpellcastingClassEnum>();
    public MagicSchoolEnum School {get;set;}
    public CastingTimeEnum CastingTime {get;set;}
    public DurationEnum Duration {get;set;}
    public DamageTypeEnum? DamageType {get;set;} = null;
    // public Dice? DamageDice {get;set;} = null;
}