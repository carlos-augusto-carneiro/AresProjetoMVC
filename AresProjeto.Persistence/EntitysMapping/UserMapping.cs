using AresProjeto.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace AresProjeto.Persistence.EntitysMapping
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("Id").HasColumnOrder(1);
            builder.Property(x => x.Name).IsRequired().HasMaxLength(64).HasColumnName("Name").HasColumnOrder(2);
            builder.Property(x => x.Password).IsRequired().HasMaxLength(20).HasColumnName("Password").HasColumnOrder(3);
        }
    }
}
