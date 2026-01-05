using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public class Consumable : Item
{
    public byte Uses {get;set;}
    public bool Rechargable {get;set;} = false;
    public EquipSlotEnum EquipSlot {get;set;}
    // public Dice? UsageDice {get;set;}
}