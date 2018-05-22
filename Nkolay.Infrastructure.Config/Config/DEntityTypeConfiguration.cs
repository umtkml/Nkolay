using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Nkolay.Web.Infrastructure.Core.Config
{
    public class DEntityTypeConfiguration<TBase> : BaseEntityConfiguration<BaseEntity> where TBase : DEntity
    {
        public virtual void Configure(EntityTypeBuilder<TBase> entityTypeBuilder)
        {
            // D Base Configuration
            //entityTypeBuilder.ToNkolayTable(typeof(TBase));
            entityTypeBuilder.Property(b => b.DspeciificField).HasMaxLength(10);
        }
    }
}
