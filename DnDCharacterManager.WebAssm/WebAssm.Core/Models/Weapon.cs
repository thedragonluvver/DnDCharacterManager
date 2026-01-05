using WebAPI.Core.Enums;

namespace WebAPI.Core.Models;

public class Weapon : Item
{
    public DamageTypeEnum DamageType {get;set;}
    public List<WeaponTagEnum> WeaponTags {get;set;} = new List<WeaponTagEnum>();
    public EquipSlotEnum EquipSlot {get;set;}
    public EquipSlotEnum AlternateEquipSlot {get;set;}
    // public Dice DamageDice {get;set;}
    // public Dice AlternateDamageDice {get;set;}
}