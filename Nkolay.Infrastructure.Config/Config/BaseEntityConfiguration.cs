using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nkolay.Web.Infrastructure.Core.Config
{

    //EntityCongurationMapper<Game> where TBase : BaseEntity
    public class BaseEntityConfiguration<TBase> : IEntityTypeConfiguration<TBase> where TBase : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> entityTypeBuilder)
        {
            //Base Configuration
            entityTypeBuilder.HasKey(p => p.Id);
            //entityTypeBuilder.Property(b => b.AddedDate).HasDefaultValueSql("CURRENT_TIMESTAMP");

            //entityTypeBuilder.ToTable(GetType().Name, SchemaUtility.GetSchema(GetType()));
        }
    }
}
