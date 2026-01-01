using WebAPI.Core.Enums;

namespace WebAPI.Core.Models;

public class Consumable
{
    public byte Uses {get;set;}
    public bool Rechargable {get;set;} = false;
    public EquipSlotEnum EquipSlot {get;set;}
    // public Dice? UsageDice {get;set;}
}