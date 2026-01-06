using WebAssm.Core.Models;

namespace WebAssm.Core.Static;

public static class Dice
{
    public static int RollDice(DiceData data)
    {
        Random random = new Random();
        int result = 0;
        for (int i = 0; i < data.RollCount; i++)
        {
            result += random.Next(data.MinRoll, data.MaxRoll);
        }
        return result;
    }
}