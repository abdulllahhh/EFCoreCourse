﻿using Amapper.Dtos;
using Amapper.Models;
using AutoMapper;

namespace Amapper
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Book, BookDto>()
                .ForMember(dest => dest.Id, src => src.MapFrom(src => src.BookId))
                .ForMember(dest => dest.IsFree, src => src.MapFrom(src => src.Price == 0))
                .ReverseMap();
        }
    }
}