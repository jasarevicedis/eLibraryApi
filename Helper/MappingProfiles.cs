using AutoMapper;
using eLibraryApi.Dto;
using eLibraryApi.Models;

namespace eLibraryApi.Helper
{
    public class MappingProfiles: Profile
    {
        public MappingProfiles()
        {
            CreateMap<Book, BookDtoRequest>();
            CreateMap<BookDtoRequest, Book>();

            CreateMap<Category, CategoryDtoRequest>();
            CreateMap<CategoryDtoRequest, Category>();

            CreateMap<Author, AuthorDtoRequest>();
            CreateMap<AuthorDtoRequest, Author>();



        }
    }
}
