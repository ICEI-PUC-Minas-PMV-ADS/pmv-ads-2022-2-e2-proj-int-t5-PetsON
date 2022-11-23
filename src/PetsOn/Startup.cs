﻿using Domain.Interfaces;
using Domain.Service;
using Microsoft.EntityFrameworkCore;
using PetsOn.Domain.Repository;
using PetsOn.Repository.DAL;
using PetsOn.Repository.Entities;
using PetsOn.Services;
using PetsOn.Services.Interfaces;

namespace PetsOn

{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddControllersWithViews();

            services.Configure<CookiePolicyOptions>(options =>
            {
                options.CheckConsentNeeded = ContextBoundObject => true;
                options.MinimumSameSitePolicy = SameSiteMode.None;
            });
            services.AddMvc();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer("Server=NOTEGABRIEL\\SQLEXPRESS;Database=petson;Trusted_Connection=True;"));

            //services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddHttpContextAccessor();
            services.AddSession();

            //Serviço Aplicação: 
            services.AddScoped<IServiceAplicationPetshop, ServiceAplicationPetshop>();
            services.AddScoped<IServiceAplicationUsuario, ServiceAplicationUsuario>();
            services.AddScoped<IServiceAplicationCliente, ServiceAplicationCliente>();
            services.AddScoped<IServiceAplicationAnimal, ServiceAplicationAnimal>();

            //Domínio:
            services.AddScoped<IServicePetshop, ServicePetshop>();
            services.AddScoped<IServiceUsuario, ServiceUsuario>();
            services.AddScoped<IServiceCliente, ServiceCliente>();
            services.AddScoped<IServiceAnimal, ServiceAnimal>();

            //Repositório:
            services.AddScoped<IRepositoryPetshop, RepositoryPetshop>();
            services.AddScoped<IRepositoryUsuario, RepositoryUsuario>();
            services.AddScoped<IRepositoryCliente, RepositoryCliente>();
            services.AddScoped<IRepositoryAnimal, RepositoryAnimal>();

        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
        }
    }
}
