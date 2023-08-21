﻿using PetCareCliAPI.Helpers;
using PetCareCliAPI.Interfaces;
using PetCareCliAPI.Repositorys;
using Serilog;

namespace PetCareCliAPI
{
    public class Startup : IStartup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {

            services.AddControllers();
            services.AddEndpointsApiExplorer();
            services.AddSwaggerGen();
            services.AddScoped<IAPIHelper, ApiHelper>();
            services.AddScoped<ITutor, TutorRepository>();
            services.AddScoped<IPet, PetRepository>();
            services.AddScoped<ISpecialty, SpecialtyRepository>();
            services.AddScoped<IUnit, UnitRepository>();

            //services.AddMicrosoftIdentityWebApiAuthentication(Configuration);
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();
            //app.UseAuthentication();
            app.UseAuthorization();
            app.MapControllers();
        }
    }

    public interface IStartup
    {
        IConfiguration Configuration { get; }
        void Configure(WebApplication app, IWebHostEnvironment environment);
        void ConfigureServices(IServiceCollection services);
    }

    public static class StatupExtensions
    {
        public static WebApplicationBuilder UseStartup<TStartup>(this WebApplicationBuilder WebAppBuilder) where TStartup : IStartup
        {
            var startup = Activator.CreateInstance(typeof(TStartup), WebAppBuilder.Configuration) as IStartup;
            if (startup == null) throw new ArgumentException("Classe Startup.cs inválida!");

            startup.ConfigureServices(WebAppBuilder.Services);

            WebAppBuilder.Logging.ClearProviders();

            var logger = new LoggerConfiguration()
             .MinimumLevel.Debug()
             .WriteTo.Console()
             .WriteTo.File("Logs/log.txt", rollingInterval: RollingInterval.Day)
             .CreateLogger();

            WebAppBuilder.Logging.ClearProviders();
            WebAppBuilder.Logging.AddSerilog(logger);

            var app = WebAppBuilder.Build();
            startup.Configure(app, app.Environment);

            app.Run();

            return WebAppBuilder;
        }
    }
}
