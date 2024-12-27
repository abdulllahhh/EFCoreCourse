using AutoMapper;
using MoviesApi2.Models;
using MoviesApi2.DTOs;

namespace MoviesApi2.Helpers
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Movie, MovieDetailsDTO>();
            CreateMap<MovieDTO, Movie>()
                .ForMember(src => src.Poster, opt => opt.Ignore());
        }
    }
}
