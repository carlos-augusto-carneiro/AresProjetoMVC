using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AresProjeto.Aplication.UseCase.Users.AddUsers
{
    public sealed class AddUsersValidation : AbstractValidator<AddUsersRequest>
    {
        public AddUsersValidation()
        {
            RuleFor(x => x.Name).NotEmpty().MinimumLength(3).MaximumLength(64);
            RuleFor(x => x.Password).NotEmpty().MinimumLength(8).MaximumLength(20);
        }
    }
}
