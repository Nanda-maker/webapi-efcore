using System.Collections.Generic;
using System.Threading.Tasks;
using webapi_efcore.Controllers.Dtos.Character;
using webapi_efcore.Controllers.Services.CharacterService.Dtos.Character;
using webapi_efcore.Models;

namespace webapi_efcore.Controllers.Services.CharacterService
{
    public interface ICharacterService
    {
        Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
        Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
        Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
        Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updateCharacter);
        Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);

    }
}