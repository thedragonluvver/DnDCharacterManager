namespace WebAPI.Core.Models;

public class Inventory
{
    public List<InventoryItem> Items {get;set;} = new List<InventoryItem>();
}