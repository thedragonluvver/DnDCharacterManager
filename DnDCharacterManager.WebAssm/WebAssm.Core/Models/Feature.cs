using System.Text.Json.Serialization;

namespace WebAssm.Core.Models;

public record Feature
{
    [JsonPropertyName("Name")]
    public string Name {get;set;} = string.Empty;
    [JsonPropertyName("Description")]
    public string Description {get;set;} = string.Empty;
    [JsonPropertyName("Activated")]
    public bool Activated {get;set;}
    [JsonPropertyName("MaxCharges")]
    public byte MaxCharges {get;set;}
    [JsonPropertyName("CurrentCharges")]
    public byte CurrentCharges {get;set;}
    [JsonPropertyName("ParentFeatureName")]
    public string ParentFeatureName {get;set;} = string.Empty;
}