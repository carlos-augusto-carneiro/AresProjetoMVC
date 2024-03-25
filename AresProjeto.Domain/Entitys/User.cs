

namespace AresProjeto.Domain.Entitys;

public class User : EntityBase
{
    public string Name { get; set; } = default!;
    public string Password { get; set; } = default!;

    public IList<Taskt>? Taskts { get; set; }
}
