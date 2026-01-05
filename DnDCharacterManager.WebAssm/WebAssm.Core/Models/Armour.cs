using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public class Armour : Item
{
    public byte BaseArmourClass {get;set;}
    public EquipSlotEnum EquipSlot {get;set;}
    public ArmourTagEnum ArmourTag {get;set;}
}