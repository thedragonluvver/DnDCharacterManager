using System.Text.Json.Serialization;
using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public class Armour : Item
{
    [JsonPropertyName("BaseArmourClass")]
    public byte BaseArmourClass {get;set;}
    [JsonPropertyName("EquipSlot")]
    public EquipSlotEnum EquipSlot {get;set;}
    [JsonPropertyName("ArmourTag")]
    public ArmourTagEnum ArmourTag {get;set;}
}