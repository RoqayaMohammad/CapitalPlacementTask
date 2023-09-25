
using CapitalPlacementTask.Models;
using DataAccessLayer.Interfaces;
using DataAccessLayer.Repositories;
using Microsoft.Azure.Cosmos;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;

namespace CapitalPlacementTask
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

            var configuration = new ConfigurationBuilder()
   .SetBasePath(Directory.GetCurrentDirectory())
   .AddJsonFile("appsettings.json")
   .Build();

            builder.Services.AddSingleton((provider) =>
            {
                var endpointUri = configuration["CosmosDbSettings:EndpointUri"];
                var primaryKey = configuration["CosmosDbSettings:PrimaryKey"];
                var databaseName = configuration["CosmosDbSettings:DatabaseName"];

                var cosmosClientOptions = new CosmosClientOptions
                {
                    ApplicationName = databaseName,
                    ConnectionMode = ConnectionMode.Gateway,

                    //ServerCertificateCustomValidationCallback = (request, certificate, chain) =>
                    //{
                    //    // Always return true to ignore certificate validation errors
                    //    return true; //not for production
                    //}
                };

                var loggerFactory = LoggerFactory.Create(builder =>
                {
                    builder.AddConsole();
                });

                var cosmosClient = new CosmosClient(endpointUri, primaryKey, cosmosClientOptions);


                return cosmosClient;
            });

            builder.Services.AddScoped<IUnitOfWork, UnitOfWork>();
            builder.Services.AddScoped<IGenericRepository<ProgramDetails>, GenericRepository<ProgramDetails>();

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