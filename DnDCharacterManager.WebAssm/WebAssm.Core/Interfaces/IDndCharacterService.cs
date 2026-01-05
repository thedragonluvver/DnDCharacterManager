using WebAssm.Core.Models;

namespace WebAssm.Core.Interfaces;

public interface IDndCharacterService
{
    Task<List<DndCharacterSummary>> GetSummaries();
    Task<DndCharacter> GetCharacterById(int id);
    Task<DndCharacterInformation> Create(DndCharacterInformation characterInfo);
    Task<DndCharacterInformation> Update(DndCharacter character);
    Task<bool> DeleteById(int id);
}