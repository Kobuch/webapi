using AutoMapper;
using Jppapi.Models;
using Jppapi.Dtos;


namespace Jppapi.Profiles
{
    public class StawkiProfile :Profile
    {
   
        public StawkiProfile()
        {
            //source->target
            CreateMap<Stawka, StawkaReadDto>();
            CreateMap<StawkaCreateDto, Stawka>();
            CreateMap<StawkaUpdateDto, Stawka>();
            CreateMap<Stawka, StawkaUpdateDto>();

        }


    }
}
