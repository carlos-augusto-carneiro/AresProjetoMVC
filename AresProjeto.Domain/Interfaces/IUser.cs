using AresProjeto.Domain.Entitys;


namespace AresProjeto.Domain.Interfaces
{
    public interface IUser
    {
        public void Adicioar(User user);
        public void Atualizar(Guid Id, User user);
        public void Deletar(Guid Id);
        public IList<Taskt> listTasks();
        public Taskt GetTaskt(Guid IdTaskt);

    }
}
