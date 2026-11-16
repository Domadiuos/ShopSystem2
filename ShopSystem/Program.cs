
using Microsoft.EntityFrameworkCore;
using ShopSystem.Data;
using ShopSystem.Helper;
using ShopSystem.Repo;

namespace ShopSystem
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            builder.Services.AddDbContext<App_DbContext>(
                options=>options.UseSqlServer(
              builder.Configuration.GetConnectionString("x")));
            //1.
            builder.Services.AddControllers();
            //2.
            builder.Services.AddEndpointsApiExplorer();
            //3.
            builder.Services.AddDbContext<App_DbContext>();
            //4.
            builder.Services.AddAutoMapper(typeof(ProfileMapping));
            //5.
            builder.Services.AddScoped(typeof(IGeneric<>), typeof(Generic<>));
            //6.
            builder.Services.AddSwaggerGen();
            //7.
            builder.Services.AddScoped<SellerRepo>();
            builder.Services.AddScoped<CustomerRepo>();
         

            // Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi


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
