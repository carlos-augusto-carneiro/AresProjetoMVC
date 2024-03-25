

namespace AresProjeto.Aplication.UseCase.Users.AddUsers
{
    public sealed record AddUsersResponse
    {
        public string Name { get; set; } = default!;
        public string Password { get; set; } = default!;
    }
}
