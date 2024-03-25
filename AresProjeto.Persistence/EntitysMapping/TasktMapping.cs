using AresProjeto.Domain.Entitys;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;


namespace AresProjeto.Persistence.EntitysMapping
{
    public class TasktMapping : IEntityTypeConfiguration<Taskt>
    {
        public void Configure(EntityTypeBuilder<Taskt> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Id).IsRequired().ValueGeneratedOnAdd().HasColumnName("Id").HasColumnOrder(1);
            builder.Property(x => x.Title).IsRequired().HasMaxLength(64).HasColumnName("Title").HasColumnOrder(2);
            builder.Property(x => x.Description).IsRequired().HasMaxLength(128).HasColumnName("Description").HasColumnOrder(3);
            builder.Property(x => x.StartDate).IsRequired().HasColumnName("StartDate").HasColumnOrder(4);
            builder.Property(x => x.EndDate).IsRequired().HasColumnName("EndDate").HasColumnOrder(5);
            builder.Property(x => x.StartTime).IsRequired().HasColumnName("StartTime").HasColumnOrder(6);

            builder.HasOne(x => x.User).WithMany(x => x.Taskts).HasForeignKey(x => x.IdUser);
        }
    }
}
