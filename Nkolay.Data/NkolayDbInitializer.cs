
using System;
using System.Linq;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Logging;
using Nkolay.Web.Api.Core.Tdomain.OyunPini;

namespace Nkolay.Web.Api.Data
{
    public static class NkolayDbInitializer
    {
        public static IWebHost SetDb(this IWebHost host)
        {
            using (var scope = host.Services.CreateScope())
            {
                //var services = scope.ServiceProvider;
                Initialize(scope.ServiceProvider.GetRequiredService<NkolayContext>());
            }
            return host;
        }
        private static void Initialize(NkolayContext context)
        {
            // Run Migrations
            //context.Database.Migrate();
            //context.Database.EnsureCreated();

            //Look for any player.
            //if (context.Players.Any())
            //{
            //    return;   // DB has been seeded
            //}

            //var players = new Player[]
            //{
            //new Player {Name= "Ali", AccountBalance = 120M},
            //new Player {Name= "Veli", AccountBalance = 320M}
            //};
            //foreach (var p in players)
            //{
            //    context.Players.Add(p);
            //}

            context.SaveChanges();
        }
    }
}
