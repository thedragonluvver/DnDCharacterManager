namespace WebAPI.Core.Models;

public class Item
{
    public string Name {get;set;} = string.Empty;
    public string Description {get;set;} = string.Empty;
    // weight is measured in pounds (lbs)
    public int Weight {get;set;}
    public int MoneyValueCount {get;set;} = 0;
    public MoneyEnum MoneyValue {get;set;} = 0;
}