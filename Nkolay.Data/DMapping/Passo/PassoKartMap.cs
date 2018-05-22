using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nkolay.Web.Api.Core.Ddomain.Passo;
using Nkolay.Web.Infrastructure.Core.Config;

namespace Nkolay.Web.Api.Data.DMapping.Passo
{
    internal class PassoKartMap : DEntityTypeConfiguration<PASSO_KART>
    {
        public override void Configure(EntityTypeBuilder<PASSO_KART> entityTypeBuilder)
        {
            entityTypeBuilder.Property(c => c.Kod).HasMaxLength(100).IsRequired();
            entityTypeBuilder.ToNkolayTable(typeof(PASSO_KART));

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
