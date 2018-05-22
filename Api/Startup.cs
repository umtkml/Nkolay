using Microsoft.ApplicationInsights;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Nkolay.Web.Api.Data;
using Nkolay.Web.Infrastructure.Repository;

namespace Nkolay.Web.Api
{
    public class Startup
    {
        //private readonly TelemetryClient _telemetryClient;
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
            //_telemetryClient = new TelemetryClient()
            //{
            //    InstrumentationKey = Configuration["ApplicationInsights:InstrumentationKey"],
            //};
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            new ServiceInitializer().RegisterServices(services);
            //services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            //services.AddDbContextPool<<NkolayContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddDbContextPool<NkolayContext>(options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));
            services.AddMvc();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env, IApplicationLifetime applicationLifetime)
        {
            applicationLifetime.ApplicationStopping.Register(OnShutdown);

            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            //app.UseMvc();
            //app.UseMvcWithDefaultRoute();
            app.UseMvc(routes =>
             {
                 routes.MapRoute("default", "Nkolay/{controller}/{action}/{id?}");
             });

        }
        private void OnShutdown()
        {
           // _telemetryClient.Flush();
                //Wait while the data is flushed
           // System.Threading.Thread.Sleep(1000);
        }
    }
}
