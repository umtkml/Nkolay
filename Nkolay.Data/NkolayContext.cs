using System;
using Microsoft.EntityFrameworkCore;
using Nkolay.Web.Api.Core.Tdomain.OyunPini;
using Nkolay.Web.Infrastructure.Utility.Context;

namespace Nkolay.Web.Api.Data
{

    public class NkolayContext : DbContext, IDisposable
    {
        public NkolayContext(DbContextOptions<NkolayContext> options) : base(options)
        {
        }

        //public DbSet<BAYI_LIMIT> BayiLimits { get; set; }
        //public DbSet<PASSO_KART> PassoKarts { get; set; }


        public DbSet<Game> Games { get; set; }
        public DbSet<Player> Players { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {

            //builder.ApplyConfiguration(new BayiLimitMap());
            //builder.ApplyConfiguration(new PassoKartMap());

            base.OnModelCreating(builder);
            builder.ApplyAllEntityConfiguration();

            #region Entity maps implement
            //// Interface that all of our Entity maps implement
            //var mappingInterface = typeof(IEntityTypeConfiguration<>);

            //// Types that do entity mapping
            //var mappingTypes = typeof(NkolayContext).GetTypeInfo().Assembly.GetTypes()
            //    .Where(x => x.GetInterfaces().Any(y => y.GetTypeInfo().IsGenericType && y.GetGenericTypeDefinition() == mappingInterface));

            //// Get the generic Entity method of the ModelBuilder type
            //var entityMethod = typeof(ModelBuilder).GetMethods()
            //    .Single(x => x.Name == "Entity" &&
            //                 x.IsGenericMethod &&
            //                 x.ReturnType.Name == "EntityTypeBuilder`1");

            //foreach (var mappingType in mappingTypes)
            //{
            //    // Get the type of entity to be mapped
            //    var genericTypeArg = mappingType.GetInterfaces().Single().GenericTypeArguments.Single();

            //    // Get the method builder.Entity<TEntity>
            //    var genericEntityMethod = entityMethod.MakeGenericMethod(genericTypeArg);

            //    // Invoke builder.Entity<TEntity> to get a builder for the entity to be mapped
            //    var entityBuilder = genericEntityMethod.Invoke(builder, null);

            //    // Create the mapping type and do the mapping
            //    var mapper = Activator.CreateInstance(mappingType);
            //    mapper.GetType().GetMethod("Map").Invoke(mapper, new[] { entityBuilder });
            //} 
            #endregion
        }
    }
}
