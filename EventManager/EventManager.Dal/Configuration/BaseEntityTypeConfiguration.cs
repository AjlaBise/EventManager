using EventManager.Dal.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace EventManager.Dal.Configuration
{
    public abstract class BaseEntityTypeConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder
                .HasKey(p => p.Id);
        }
    }
}