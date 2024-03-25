using AresProjeto.Domain.Entitys;
using AutoMapper;


namespace AresProjeto.Aplication.UseCase.Users.AddUsers
{
    public sealed class AddUsersMap : Profile
    {
        public AddUsersMap()
        {
            CreateMap<AddUsersRequest, User>();
            CreateMap<User, AddUsersResponse>();
        }
    }
}
