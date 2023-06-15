using APIContasaPagarCarrefour;
using APIContasaPagarCarrefour.dominio;
using log4net;
using log4net.Config;


internal class Program
{
    private static readonly ILog log4 = LogManager.GetLogger(typeof(Program));
    private static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        // Configurar o Log4Net
        XmlConfigurator.Configure(new FileInfo("log4net.config"));

        log4.Info("Iniciando o aplicativo");

        var host = Host.CreateDefaultBuilder(args)
            .ConfigureWebHostDefaults(webBuilder =>
            {
                webBuilder.UseStartup<Startup>();
            })
            .ConfigureAppConfiguration((hostingContext, config) =>
            {
                config.SetBasePath(Directory.GetCurrentDirectory());
                config.AddJsonFile("appsettings.json", optional: false, reloadOnChange: true);
            })
            .Build();

        host.Run();



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

        using (var context = new ContasContext())
        {
            context.Database.EnsureCreated();
        }


        app.Run();
    }
}

// Add services to the container.

