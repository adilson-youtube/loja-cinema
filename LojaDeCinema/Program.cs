using LojaDeCinema.Data;
using LojaDeCinema.Repositorios;
using LojaDeCinema.Repositorios.Interfaces;
using LojaDeCinema.Servicos;
using LojaDeCinema.Servicos.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace LojaDeCinema
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            builder.Services.AddEntityFrameworkNpgsql()
                .AddDbContext<LojaDeCinemaDBContex>(
                    options => options.UseNpgsql(builder.Configuration.GetConnectionString("DataBase"))
                );

            builder.Services.AddScoped<IBilheteRepositorio, BilheteRepositorio>();
            builder.Services.AddScoped<IComidaRepositorio, ComidaRepositorio>();

            builder.Services.AddScoped<IComidaServico, ComidaServico>();
            builder.Services.AddScoped<IBilheteServico, BilheteServico>();
            builder.Services.AddScoped<IFinancasServico, FinancasServico>();

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
}