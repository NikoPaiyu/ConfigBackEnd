using Config.CPQ.configPage2.Models;
using Config.CPQ.configPage2.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Options;

namespace Config.CPQ.configPage2
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.Configure<ConfigPageDatabaseSettings>(
            Configuration.GetSection(nameof(ConfigPageDatabaseSettings)));

            services.AddSingleton<IConfigPageDatabaseSettings>(sp =>
                sp.GetRequiredService<IOptions<ConfigPageDatabaseSettings>>().Value);

            services.AddSingleton<SeriesService>();
            services.AddSingleton<CategoryService>();
            services.AddSingleton<ConfigTabsService>();
            services.AddSingleton<PartService>();

            services.AddControllers();  
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
