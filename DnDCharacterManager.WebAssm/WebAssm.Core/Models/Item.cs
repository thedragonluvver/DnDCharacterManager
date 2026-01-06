using System.Text.Json.Serialization;
using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public class Item
{
    [JsonPropertyName("Name")]
    public string Name {get;set;} = string.Empty;
    [JsonPropertyName("Description")]
    public string Description {get;set;} = string.Empty;
    // weight is measured in pounds (lbs)
    [JsonPropertyName("Weight")]
    public int Weight {get;set;}
    [JsonPropertyName("MoneyValueCount")]
    public int MoneyValueCount {get;set;} = 0;
    [JsonPropertyName("MoneyValue")]
    public MoneyEnum MoneyValue {get;set;} = 0;
}