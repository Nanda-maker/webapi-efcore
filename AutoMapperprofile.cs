using AutoMapper;
using webapi_efcore.Controllers.Services.CharacterService.Dtos.Character;
using webapi_efcore.Models;

namespace webapi_efcore
{
    public class AutoMapperprofile : Profile
    {
        public AutoMapperprofile()
        {
            CreateMap<Character, GetCharacterDto>();
            CreateMap<AddCharacterDto, Character>();
        }

    }
}