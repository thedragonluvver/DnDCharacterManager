using System.Text.Json.Serialization;

namespace WebAssm.Core.Models;

public record Inventory
{
    [JsonPropertyName("Items")]
    public List<InventoryItem> Items {get;set;} = new List<InventoryItem>();
}