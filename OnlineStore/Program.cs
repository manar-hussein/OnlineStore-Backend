
using Application;
using Application.Repositories;
using Microsoft.EntityFrameworkCore;

namespace OnlineStore
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddScoped<IUniteOfWork,UniteOfWork>();
            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddDbContext<APIStoreDbContext>(option =>
            option.UseSqlServer(builder.Configuration.GetConnectionString("Dev"))
            );

            var app = builder.Build();
            var scope = app.Services.CreateScope();
            var services = scope.ServiceProvider;
            var StoreContext = services.GetRequiredService<APIStoreDbContext>();
            StoreContext.Database.Migrate();
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
}
