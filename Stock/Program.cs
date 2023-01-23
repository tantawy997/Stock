using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Stock.Context;
using BL.AutoMapperProfile;
using DAL.repos.ProductRepo;
using Stock.Models;
using BL.ProductsManager;
using DAL.repos.CatalogRepo;
using BL.CatalogManager;

#pragma warning disable CS0618

internal class Program
{

    private static void Main(string[] args)
    {
        //var AllowAll = "AllowAll";

        var builder = WebApplication.CreateBuilder(args);

        // Add services to the container.
        //builder.Services.AddApplicationServices(builder.Configuration);


        var co1 = builder.Configuration.GetConnectionString("co1");
        builder.Services.AddDbContext<AppdbContext>(a => a.UseSqlServer(co1));

        builder.Services.AddAutoMapper(typeof(AutoMapping).Assembly);


        builder.Services.AddControllers();
        // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddCors(options =>
        {
            options.AddPolicy("AllowAll",
                policyBuilder =>
                {
                    policyBuilder

                        .AllowAnyOrigin()
                        .AllowAnyMethod()
                        .AllowAnyHeader();
                });
        });
        builder.Services.AddHttpContextAccessor();

        builder.Services.AddScoped<IProductsRepo, ProductsRepo>();
        builder.Services.AddScoped<IProductsManager, ProductsManager>();
        builder.Services.AddScoped<ICatalogsRepo, CatalogsRepo>();
        builder.Services.AddScoped<ICatalogsManager, CatalogsManager>();  

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }
        app.UseCors("AllowAll");

        app.UseStaticFiles();

        app.UseHttpsRedirection();

        app.UseAuthorization();

        app.MapControllers();

        app.Run();
    }
}   