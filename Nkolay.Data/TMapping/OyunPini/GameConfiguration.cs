using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Nkolay.Web.Api.Core.Tdomain.OyunPini;
using Nkolay.Web.Infrastructure.Utility.Context;

namespace Nkolay.Web.Api.Data.TMapping.OyunPini
{
    public class GameConfiguration : EntityBaseConfig<Game>
    {
        public override void Configure(EntityTypeBuilder<Game> builder)
        {
            builder.HasKey(p => p.Id);
            builder.Property(p => p.Name).IsRequired().HasMaxLength(100);
            builder.Property(p => p.Description).HasMaxLength(250);
            builder.Property(p => p.NewField).HasMaxLength(100);
            //builder.Property(p => p.T_Specific_Field).HasMaxLength(150);
            builder.Property(p => p.Price).IsRequired().HasColumnType("decimal(5, 2)");
            builder.ToNkolayTable(typeof(Game));
        }
    }
}