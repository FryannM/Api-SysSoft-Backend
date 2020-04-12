using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using PrototipoWebApi_1.Interfaces;
using PrototipoWebApi_1.Profilles;
using PrototipoWebApi_1.Repositorios;
using PrototipoWebApi_1.Services;
using Microsoft.OpenApi.Models;

namespace PrototipoWebApi_1
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

            services.AddCors();
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_1);
            services.AddDbContext<RepositoryBase>(option => option.UseSqlServer(Configuration.GetConnectionString("DevConnection")));
            services.AddTransient<IDepartamentoServices, DepartamentoServices>();
            services.AddTransient<IColaboradoreServices, ColaboradorServices>();
            services.AddTransient<IUtilServices, PosicionServices>();

        

            
            var config = new AutoMapper.MapperConfiguration(cfg => {    
                cfg.AddProfile(new ColaboradorProfile());
             });

            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo{ Title = "SysSoft ", Version = "2.1" });
            });

            var mapper = config.CreateMapper();
            services.AddSingleton(mapper);

           
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseHsts();
            }

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("v1/swagger.json", "Sys Api");
            });


            app.UseCors(x =>
            {
                x.WithOrigins("https://localhost:5001")
                .AllowAnyOrigin()
                .AllowAnyMethod()
                .AllowAnyHeader()
                .AllowCredentials();
            });

           
            app.UseHttpsRedirection();
            app.UseMvc();
        }
    }
}
