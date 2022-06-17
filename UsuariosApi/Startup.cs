using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using System;
using UsuariosApi.Data;
using UsuariosApi.Models;
using UsuariosApi.Services;

namespace UsuariosApi
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
            services.AddDbContext<UserDbContext>(options => options.UseMySql(Configuration.GetConnectionString("UsuarioConnection"), new MySqlServerVersion(new Version(8, 0, 28))));
            services.AddIdentity<CustomIdentityUser, IdentityRole<int>>(
                opt => opt.SignIn.RequireConfirmedEmail = true
                )
                .AddEntityFrameworkStores<UserDbContext>()
                .AddDefaultTokenProviders();
            services.AddScoped<CadastroService, CadastroService>();
            services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
            services.AddScoped<EmailService, EmailService>();
            services.AddScoped<TokenService, TokenService>();
            services.AddScoped<LoginService, LoginService>();
            services.AddScoped<LogoutService, LogoutService>();

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
