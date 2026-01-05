namespace WebAPI.Core.Models;

public record AbilityScore
{
    public string Name {get;set;} = string.Empty;
    public char[] NameShort {get;set;} = new char[3];
    public byte Score {get;set;}
    public List<Skill> Skills {get;set;} = new List<Skill>();
    public Skill SavingThrow {get;set;} = new Skill();
}