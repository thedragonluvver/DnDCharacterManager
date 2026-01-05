namespace WebAssm.Core.Models;

public record Inventory
{
    public List<InventoryItem> Items {get;set;} = new List<InventoryItem>();
}