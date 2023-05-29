using TallerAPI.Data;
using Microsoft.EntityFrameworkCore;
using TallerAPI.Service;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.

        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<StoreDbContext>(
              options =>
              {
                  
                options.UseSqlServer(builder.Configuration.GetConnectionString("StoreConnection"));
              }
            );
        /*
          .AddTransient es un método de extensión utilizado para registrar servicios transitorios 
        en la configuración de la inyección de dependencias en ASP.NET Core.
         */
           //tiempo de vida que da a la interfaz
        builder.Services.AddTransient<ProductService, ProductService>();
        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}