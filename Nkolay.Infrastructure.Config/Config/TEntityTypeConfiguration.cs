using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nkolay.Web.Infrastructure.Core.Config
{
    public abstract class TEntityTypeConfiguration<TBase> : BaseEntityConfiguration<BaseEntity> where TBase : TEntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> entityTypeBuilder)
        {
            // T Base Configuration
            entityTypeBuilder.Property(p => p.TspeciificField).HasMaxLength(10);
            //entityTypeBuilder.ToNkolayTable(typeof(TBase));
            //entityTypeBuilder.Property(b => b.T_Upd_Date).HasDefaultValueSql("CURRENT_TIMESTAMP");
        }
    }
}
