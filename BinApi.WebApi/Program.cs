using BinApi.Providers.SmartRack;
using BinApi.Repositories.Bin;
using BinApi.Repositories.Item;
using BinApi.Services.BinMaintenanceSvc;
using BinApi.Services.ItemMaintenanceSvc;
using Microsoft.EntityFrameworkCore;

namespace BinApi.WebApi
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.

            builder.Services.AddControllers();
            builder.Services.AddDbContext<ItemDb>(opt => opt.UseInMemoryDatabase("ItemList"));
            builder.Services.AddDbContext<BinDb>(opt => opt.UseInMemoryDatabase("BinList"));
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

            // --- Configuration ---
            //builder.Services.Configure<SmartRackConfiguration>(
            //    builder.Configuration.GetSection("SmartRackConfiguration"));
            //builder.Services.Configure<BinRepositoryConfiguration>(
            //    builder.Configuration.GetSection("BinRepositoryConfiguration"));
            //builder.Services.Configure<ItemRepositoryConfiguration>(
            //    builder.Configuration.GetSection("ItemRepositoryConfiguration"));
            // Add other configurations for repos etc here.  Can extract to an extension method.

            // --- Dependency Injection ---
            //builder.Services.AddScoped<IBinMaintenanceSvc, BinMaintenanceSvc>();
            //builder.Services.AddScoped<IItemMaintenanceSvc, ItemMaintenanceSvc>();
            //builder.Services.AddScoped<IBinRepository, BinRepository>();
            //builder.Services.AddScoped<IItemRepository, ItemRepository>();
            // Other Dependency Injection here.  Can extract to an extension method.

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