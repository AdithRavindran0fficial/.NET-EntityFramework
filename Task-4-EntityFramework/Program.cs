
using Microsoft.EntityFrameworkCore;
using Task_4_EntityFramework.Data;
using Task_4_EntityFramework.Services;

namespace Task_4_EntityFramework
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Add services to the container.
            
            builder.Services.AddDbContext<EmployeeContext>(x =>
            {
                x.UseSqlServer(builder.Configuration.GetConnectionString("Dbconnection"));

            });
            builder.Services.AddScoped<IEmployeeService, EmployeeService>();

            builder.Services.AddControllers();
            // Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
            builder.Services.AddEndpointsApiExplorer();
            builder.Services.AddSwaggerGen();

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
