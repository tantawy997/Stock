using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stock.Context;
using BL.AutoMapperProfile;
using DAL.repos.ProductRepo;
using Stock.Models;
using BL.ProductsManager;

internal class Program
{
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        var co1 = builder.Configuration.GetConnectionString("co1");
        builder.Services.AddDbContext<AppdbContext>(a => a.UseSqlServer(co1));

        builder.Services.AddAutoMapper(typeof(AutoMapping).Assembly);


        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("CorsPolicy", builder =>
                builder
                .AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader());
        });

        builder.Services.AddScoped<IProductsRepo, ProductsRepo>();
        builder.Services.AddScoped<IProductsManager, ProductsManager>();

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors("CorsPolicy");

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}   