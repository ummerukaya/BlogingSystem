using BloginSystem.DataAccess;
using BloginSystem.Factories;
using BloginSystem.Repository;
using BloginSystem.Service;
using BloginSystem.Validators;
using FluentValidation;
using FluentValidation.AspNetCore;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace BloginSystem
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
            services.AddAutoMapper(typeof(Startup));
            services.AddControllersWithViews();
            services.AddDbContext<BlogingContext>();
            services.AddFluentValidation(x =>
            {
                x.DisableDataAnnotationsValidation = true;
                x.RegisterValidatorsFromAssemblyContaining<UserValidator>();
                x.RegisterValidatorsFromAssemblyContaining<BlogPostValidator>();
            });
            services.AddTransient<IValidator<User>, UserValidator>();
            services.AddTransient<IValidator<BlogPost>, BlogPostValidator>();
            services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
            services.AddScoped<IBlogPostService, BlogPostService>();
            services.AddScoped<IBlogPostFactory, BlogPostFactory>();
            services.AddScoped<IUserFactory, UserFactory>();
            services.AddScoped<IUserService, UserService>();

            services.AddAuthentication()
            .AddCookie();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }
            else
            {
                app.UseExceptionHandler("/Home/Error");
                // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
                app.UseHsts();
            }
            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();

            app.UseAuthorization();
            app.UseCookiePolicy();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllerRoute(
                    name: "default",
                    pattern: "{controller=User}/{action=Login}/{id?}");
            });
        }
    }
}
