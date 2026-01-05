namespace WebAssm.Core.Models;

public record InventoryItem
{
    public bool Equipped {get;set;}
    public int Quantity {get;set;}
    public Item Item {get;set;} = new Item();
}