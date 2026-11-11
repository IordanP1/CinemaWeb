using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
namespace CinemaApp.Web
{
    using CinemaApp.Data;
    using CinemaApp.Services.Core;
    using CinemaApp.Services.Core.Contracts;
    using Microsoft.AspNetCore.Identity;
    using Microsoft.EntityFrameworkCore;
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            var connectionString = builder.Configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
            builder.Services.AddDbContext<ApplicationDbContext>(options =>
                options.UseSqlServer(connectionString));
            builder.Services.AddDatabaseDeveloperPageExceptionFilter();

            builder.Services.AddDefaultIdentity<IdentityUser>(options =>
            {
                ConfigureIdentityOptions(builder.Configuration, options);
            })
                .AddEntityFrameworkStores<ApplicationDbContext>();
            builder.Services.AddControllersWithViews();
            builder.Services.AddScoped<IMovieService,MovieServices>();

            var app = builder.Build();

            // Configure the HTTP request pipeline.
            if (app.Environment.IsDevelopment())
            {
                app.UseMigrationsEndPoint();
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
            app.UseAuthentication();
            app.UseAuthorization();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");
            app.MapRazorPages();

            app.Run();
        }
        private static void ConfigureIdentityOptions(ConfigurationManager config, IdentityOptions options)
        {
            options.SignIn.RequireConfirmedAccount = config
                .GetValue<bool>("Identity:SignIn:RequireConfirmedAccount");
            options.Password.RequireDigit = config
                .GetValue<bool>("Identity:Password:RequireDigit");
            options.Password.RequiredLength = config
                .GetValue<int>("Identity:Password:RequiredLength");
            options.Password.RequireNonAlphanumeric = config
                .GetValue<bool>("Identity:Password:RequireNonAlphanumeric");
            options.Password.RequireUppercase = config
                .GetValue<bool>("Identity:Password:RequireUppercase");
            options.Password.RequireLowercase = config
                .GetValue<bool>("Identity:Password:RequireLowercase");
            options.User.RequireUniqueEmail = config
                .GetValue<bool>("Identity:User:RequiredUniqueEmail");

            options.User.RequireUniqueEmail = config
                .GetValue<bool>("Identity:User:RequireUniqueEmail");
        }
    }
}
