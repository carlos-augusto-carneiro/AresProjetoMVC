using AresProjeto.Domain.Entitys;


namespace AresProjeto.Domain.Interfaces
{
    public interface ITaskt 
    {
        public void Adicioar(Taskt taskt);
        public void Atualizar(Guid Id, Taskt taskt);
        public void Deletar(Guid Id);
        public void StartTime();
        public void EndTime();
    }
}
