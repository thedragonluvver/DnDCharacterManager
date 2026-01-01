namespace WebAPI.Core.Models;

public class Feature
{
    public string Name {get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    public bool Activated {get;set;}
    public byte MaxCharges {get;set;}
    public byte CurrentCharges {get;set;}
    public string ParentFeatureName {get;set;} = string.Empty;
    // public Dice? Dice {get;set;} = null;
}