using AresProjeto.Aplication.Service.Sercurity;
using AresProjeto.Domain.Entitys;
using AresProjeto.Domain.Interfaces;
using AutoMapper;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AresProjeto.Aplication.UseCase.Users.AddUsers
{
    public sealed class AddUsersHandler : IRequestHandler<AddUsersRequest, AddUsersResponse>
    {
        private readonly IMapper _mapper;
        private readonly IUser _user;

        public AddUsersHandler(IMapper mapper, IUser user)
        {
            _mapper = mapper;
            _user = user;
        }

        public Task<AddUsersResponse> Handle(AddUsersRequest request, CancellationToken cancellationToken)
        {
            var mapearRequest = _mapper.Map<User>(request);
            mapearRequest.Password = mapearRequest.Password.GerarHash();
            _user.Adicioar(mapearRequest);
            var mapearResponse = _mapper.Map<AddUsersResponse>(mapearRequest);

            return Task.FromResult(mapearResponse);
        }
    }
}
