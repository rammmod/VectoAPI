using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Options;
using VectoAPI.Services;
using VectoAPI.Settings;

namespace VectoAPI
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

            builder.Services.AddScoped<IProcessor, Processor>();
            builder.Services.Configure<ApplicationSettings>(builder.Configuration.GetSection(nameof(ApplicationSettings)));
            builder.Services.AddSingleton(sp => sp.GetRequiredService<IOptions<ApplicationSettings>>().Value);

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