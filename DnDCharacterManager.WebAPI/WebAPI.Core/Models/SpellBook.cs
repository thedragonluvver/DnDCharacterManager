using WebAPI.Core.Enums;

namespace WebAPI.Core.Models;

public class SpellBook
{
    public char[] AbilityScoreCode {get;set;} = new char[3];
    public SpellcastingClassEnum SpellcastingClass {get;set;}
    public List<Spell> Cantrips {get;set;} = new List<Spell>();
    public List<Spell> FirstLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> SecondLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> ThirdLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> FourthLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> FifthLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> SixthLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> SeventhLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> EighthLevelSpells {get;set;} = new List<Spell>();
    public List<Spell> NinthLevelSpells {get;set;} = new List<Spell>();
}