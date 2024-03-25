using AresProjeto.Domain.Entitys;
using AresProjeto.Persistence.EntitysMapping;
using Microsoft.EntityFrameworkCore;


namespace AresProjeto.Persistence.Context
{
    public class UserTaskContext : DbContext
    {
        public UserTaskContext(DbContextOptions options) : base(options){}

        public DbSet<User> Users { get; set; }
        public DbSet<Taskt> Taskts { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new UserMapping());
            modelBuilder.ApplyConfiguration(new TasktMapping());
        }
    }
}
