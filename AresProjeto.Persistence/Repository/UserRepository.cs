using AresProjeto.Domain.Entitys;
using AresProjeto.Domain.Interfaces;
using AresProjeto.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AresProjeto.Persistence.Repository;

public class UserRepository : IUser
{
    private readonly UserTaskContext _context;

    public UserRepository(UserTaskContext context)
    {
        _context = context;
    }

    public void Adicioar(User user)
    {
        _context.Users.Add(user);
        _context.SaveChanges();
    }

    public void Atualizar(Guid Id, User user)
    {
        throw new NotImplementedException();
    }

    public void Deletar(Guid Id)
    {
        throw new NotImplementedException();
    }

    public Taskt GetTaskt(Guid IdTaskt)
    {
        throw new NotImplementedException();
    }

    public IList<Taskt> listTasks()
    {
        throw new NotImplementedException();
    }

    public void SumHours()
    {
        throw new NotImplementedException();
    }
}
