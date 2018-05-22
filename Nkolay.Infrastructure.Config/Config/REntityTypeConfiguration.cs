using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nkolay.Web.Infrastructure.Core.Config
{
    public abstract class REntityTypeConfiguration<TBase> : BaseEntityConfiguration<BaseEntity> where TBase : REntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> entityTypeBuilder)
        {
            // R Base Configuration
            //entityTypeBuilder.ToNkolayTable(typeof(TBase));
            entityTypeBuilder.Property(b => b.RspeciificField).HasMaxLength(15);
        }
    }
}
