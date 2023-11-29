using AutoMapper;
using eLibraryApi.Dto;
using eLibraryApi.Models;

namespace eLibraryApi.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Book, BookDto>();
            CreateMap<BookDto, Book>();
        }
    }
}
