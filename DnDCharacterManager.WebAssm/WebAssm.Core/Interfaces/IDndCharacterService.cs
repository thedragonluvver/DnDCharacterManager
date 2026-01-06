using WebAssm.Core.Models;

namespace WebAssm.Core.Interfaces;

public interface IDndCharacterService
{
    Task<List<DndCharacter>> GetAll();
    Task<DndCharacter> GetById(int id);
    Task<DndCharacter> Create(DndCharacter character);
    Task<DndCharacter> Update(DndCharacter character);
    Task<bool> DeleteById(int id);
}