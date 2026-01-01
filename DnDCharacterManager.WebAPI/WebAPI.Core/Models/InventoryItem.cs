namespace WebAPI.Core.Models;

public class InventoryItem
{
    public bool Equipped {get;set;}
    public int Quantity {get;set;}
    public Item Item {get;set;} = new Item();
}