using Microsoft.EntityFrameworkCore;
using TP7.Application.ServiceInterfaces;
using TP7.Domain.RepositoryInterfaces;
using TP7.Infrastructure.Repositories;
using TP7.Application.Services;
using TP7.Infrastructure;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configure services
        builder.Services.AddDbContext<ApplicationDbContext>(options =>
            options.UseSqlServer(
                builder.Configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly("TP7.Presentation") // Specify the migrations assembly here
            )
        );
        builder.Services.AddScoped<IMovieRepository, MovieRepository>();
        builder.Services.AddScoped<IMovieService, MovieService>();
        builder.Services.AddScoped<IGenreRepository, GenreRepository>();
        builder.Services.AddScoped<IGenreService, GenreService>();
        builder.Services.AddScoped<IClientRepository, ClientRepository>();
        builder.Services.AddScoped<IClientService, ClientService>();
        builder.Services.AddScoped<IReviewRepository, ReviewRepository>();
        builder.Services.AddScoped<IReviewService, ReviewService>();
        builder.Services.AddScoped<IClientMovieRepository, ClientMovieRepository>();
        builder.Services.AddScoped<IClientMovieService, ClientMovieService>();

        builder.Services.AddControllersWithViews();

        var app = builder.Build();

        // Configure HTTP request pipeline
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        app.UseAuthorization();

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        // Run the application
        app.Run();
    }
}

