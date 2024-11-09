using AutoMapper;
using BookStoreApp.Blazor.Server.UI.Services.Base.API.Data;
using BookStoreApp.Blazor.Server.UI.Services.Base.API.Models.Author;
using BookStoreApp.Blazor.Server.UI.Services.Base.API.Models.Book;
using BookStoreApp.Blazor.Server.UI.Services.Base.API.Models.User;

namespace BookStoreApp.Blazor.Server.UI.Services.Base.API.Configurations
{
    public class MapperConfig : Profile
    {
        public MapperConfig()
        {
            CreateMap<AuthorCreateDto, Author>().ReverseMap();
            CreateMap<AuthorUpdateDto, Author>().ReverseMap();
            CreateMap<AuthorReadOnlyDto, Author>().ReverseMap();

            CreateMap<Book, BookReadOnlyDto>()
                .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();

            CreateMap<Book, BookDetailsDto>()
                .ForMember(q => q.AuthorName, d => d.MapFrom(map => $"{map.Author.FirstName} {map.Author.LastName}"))
                .ReverseMap();

            CreateMap<BookUpdateDto, Book>().ReverseMap();
            CreateMap<BookCreateDto, Book>().ReverseMap();

            CreateMap<ApiUser, UserDto>().ReverseMap();
        }
    }
}
