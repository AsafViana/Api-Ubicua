using Api_Ubicua.Data;
using Microsoft.EntityFrameworkCore;

namespace Api_Ubicua
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        public void ConfigureServices(IServiceCollection service)
        {
            service.AddCors(options =>
            {
                options.AddPolicy("AllowLocalhost5173",
                    builder =>
                    {
                        builder.WithOrigins("http://localhost:5173")
                               .AllowAnyHeader()
                               .AllowAnyMethod();
                    });
            });

            string mySqlConnection = Configuration.GetConnectionString("DefaultConnection");
            service.AddDbContextPool<Contexto>(options => 
            options.UseMySql(mySqlConnection, 
            ServerVersion.AutoDetect(mySqlConnection)));

            service.AddControllers();
            service.AddEndpointsApiExplorer();
            service.AddSwaggerGen();
        }

        public void Configure(WebApplication app, IWebHostEnvironment environment)
        {
            if (app.Environment.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseCors("AllowLocalhost5173");

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
