using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nkolay.Web.Api.Core.Ddomain.Bayi;
using Nkolay.Web.Infrastructure.Core.Config;

namespace Nkolay.Web.Api.Data.DMapping.Bayi
{
    internal class BayiLimitMap : DEntityTypeConfiguration<BAYI_LIMIT>
    {
        public override void Configure(EntityTypeBuilder<BAYI_LIMIT> entityTypeBuilder)
        {
            entityTypeBuilder.Property(c => c.Kod).HasMaxLength(255).IsRequired();
            entityTypeBuilder.ToNkolayTable(typeof(BAYI_LIMIT));

            // Önrk aşağıdaki şekilde vs etc.

            ////fields
            //entity.Property(t => t.ID).HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);
            //entity.Property(t => t.Quanatity).IsRequired().HasColumnType("tinyint");
            //entity.Property(t => t.Price).IsRequired();
            //entity.Property(t => t.CustomerId).IsRequired();
            //entity.Property(t => t.AddedDate).IsRequired();
            //entity.Property(t => t.ModifiedDate).IsRequired();
            //entity.Property(t => t.IP);


            ////relationship
            //entity.HasRequired(t => t.Customer).WithMany(c => c.Orders).HasForeignKey(t => t.CustomerId).WillCascadeOnDelete(false);
        }
    }
}