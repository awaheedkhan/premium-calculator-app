using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using PremiumCalculator.Api.Data.Repositories;
using PremiumCalculator.Api.Services;

namespace PremiumCalculator.Api
{
    public class Startup
    {
        public const string CorsPolicyName = "AllowDomainsPolicy";
        private const string CorsPolicyAppSettingKey = "Cors:AllowedDomains";

        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddCors(cx =>
            {
                cx.AddPolicy(CorsPolicyName,
                    builder =>
                    {
                        builder.WithOrigins(Configuration[CorsPolicyAppSettingKey].Split(";"))
                        .WithMethods("OPTIONS", "GET", "POST", "PUT", "DELETE")
                        .AllowAnyHeader();
                    });
            });

            services.AddControllers();
            services.AddScoped<IPremiumService, PremiumService>();
            services.AddScoped<IOccupationService, OccupationService>();
            services.AddScoped<IOccupationsRepository, OccupationsRepository>();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            app.UseRouting();
            app.UseCors(CorsPolicyName);

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }
    }
}
