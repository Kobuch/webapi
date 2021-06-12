using Jppapi.Dtos;
using Jppapi.Models;
using AutoMapper;
using System;

namespace Jppapi.Profiles
{
    public class RozliczanieDniaProfile : Profile
    {

        public RozliczanieDniaProfile()
        {

      
        //source->target
        CreateMap <RozliczenieDnia, RozliczeniaDniaReadDto>();
        CreateMap<RozliczeniaDniaUpdateDto, RozliczenieDnia>();
        CreateMap<RozliczenieDnia, RozliczeniaDniaUpdateDto>();
        CreateMap<RozliczeniaDniaCreateDto, RozliczenieDnia>();

        }

       
    }
}