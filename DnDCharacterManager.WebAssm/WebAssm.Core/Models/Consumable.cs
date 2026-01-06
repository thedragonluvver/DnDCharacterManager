using System.Text.Json.Serialization;
using WebAssm.Core.Enums;

namespace WebAssm.Core.Models;

public class Consumable : Item
{
    [JsonPropertyName("Uses")]
    public byte Uses {get;set;}
    [JsonPropertyName("Rechargable")]
    public bool Rechargable {get;set;} = false;
    [JsonPropertyName("EquipSlot")]
    public EquipSlotEnum EquipSlot {get;set;}
    // public Dice? UsageDice {get;set;}
}