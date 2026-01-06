using System.Text.Json.Serialization;

namespace WebAssm.Core.Models;

public record InventoryItem
{
    [JsonPropertyName("Equipped")]
    public bool Equipped {get;set;}
    [JsonPropertyName("Quantity")]
    public int Quantity {get;set;}
    [JsonPropertyName("Item")]
    public Item Item {get;set;} = new Item();
}