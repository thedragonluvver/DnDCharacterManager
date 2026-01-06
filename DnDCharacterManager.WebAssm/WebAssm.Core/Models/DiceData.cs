namespace WebAssm.Core.Models;

public record DiceData
{
    public byte MaxRoll {get;set;} = 1;
    public byte MinRoll {get;set;} = 1;
    public int RollCount {get;set;} = 1;
}