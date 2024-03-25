using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AresProjeto.Aplication.UseCase.Users.AddUsers
{
    public sealed record AddUsersRequest(string Name, string Password) : IRequest<AddUsersResponse>
    {
    }
}
