using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nkolay.Web.Api.Core.Tdomain.OyunPini;
using Nkolay.Web.Infrastructure.Utility.Context;

namespace Nkolay.Web.Api.Data.TMapping.OyunPini
{
    public class PlayerConfiguration : EntityBaseConfig<Player>
    {
        public override void Configure(EntityTypeBuilder<Player> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Description).HasMaxLength(250);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.AccountBalance).IsRequired().HasColumnType("decimal(10, 2)");
            builder.ToNkolayTable(typeof(Player));
        }
    }
}