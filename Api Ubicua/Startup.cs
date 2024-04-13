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
                app.UseSwagger();
                app.UseSwaggerUI();
            }

            app.UseHttpsRedirection();

            app.UseAuthorization();

            app.MapControllers();
        }
    }
}
