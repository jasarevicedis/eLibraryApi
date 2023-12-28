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
            CreateMap<Book, BookDtoResponse>();
            CreateMap<BookDtoResponse, Book>();

            CreateMap<Category, CategoryDtoRequest>();
            CreateMap<CategoryDtoRequest, Category>();
            CreateMap<Category, CategoryDtoResponse>();
            CreateMap<CategoryDtoResponse, Category>();

            CreateMap<Author, AuthorDtoRequest>();
            CreateMap<AuthorDtoRequest, Author>();
            CreateMap<Author, AuthorDtoResponse>();
            CreateMap<AuthorDtoResponse, Author>();


        }
    }
}
