namespace WebAssm.Core.Static;

public static class Dice
{
    public static int RollDice(byte maxRoll, int rollCount = 1, byte minRoll = 1)
    {
        Random random = new Random();
        int result = 0;
        for (int i = 0; i < rollCount; i++)
        {
            result += random.Next(minRoll,maxRoll);
        }
        return result;
    }
}