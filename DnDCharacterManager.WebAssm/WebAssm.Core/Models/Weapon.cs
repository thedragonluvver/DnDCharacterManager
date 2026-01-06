using System.Text.Json.Serialization;
using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public class Weapon : Item
{
    [JsonPropertyName("DamageType")]
    public DamageTypeEnum DamageType {get;set;}
    [JsonPropertyName("WeaponTags")]
    public List<WeaponTagEnum> WeaponTags {get;set;} = new List<WeaponTagEnum>();
    [JsonPropertyName("EquipSlot")]
    public EquipSlotEnum EquipSlot {get;set;}
    [JsonPropertyName("AlternateEquipSlot")]
    public EquipSlotEnum AlternateEquipSlot {get;set;}
    public DiceData DamageDice {get;set;} = new DiceData();
    public DiceData AlternateDamageDice {get;set;} = new DiceData();
}