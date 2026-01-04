using WebAPI.Core.Models;

namespace WebAPI.Core.Interfaces;

public interface IDndCharacterRepository
{
    Task<List<DndCharacterSummary>> GetSummaries();
    Task<DndCharacterSummary> GetSummary();
    Task<List<DndCharacter>> GetCharacters();
    Task<DndCharacter> GetCharacter(int id);
    Task<DndCharacter> CreateCharacter(DndCharacter character);
    Task<DndCharacter> UpdateCharacter(DndCharacter character);
    Task<bool> DeleteCharacter(int id);
}