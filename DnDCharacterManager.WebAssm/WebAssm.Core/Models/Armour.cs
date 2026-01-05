using WebAPI.Core.Enums;

namespace WebAPI.Core.Models;

public class Armour : Item
{
    public byte BaseArmourClass {get;set;}
    public EquipSlotEnum EquipSlot {get;set;}
    public ArmourTagEnum ArmourTag {get;set;}
}