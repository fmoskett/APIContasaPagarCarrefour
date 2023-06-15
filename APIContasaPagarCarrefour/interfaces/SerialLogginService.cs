using APIContasaPagarCarrefour.repository;
using Serilog;
using Serilog.Events;
using Serilog.Sinks.File;
using Microsoft.Extensions.Configuration;


namespace APIContasaPagarCarrefour.interfaces
{
 

    public class SerilogLoggerService : ILoggerService
    {
        private readonly Serilog.ILogger _logger;

        public SerilogLoggerService()
        {
            //var configuration = new ConfigurationBuilder()
            //.SetBasePath(Directory.GetCurrentDirectory())
            //.AddJsonFile("appsettings.json", optional: true)
            //.Build();

            _logger = new LoggerConfiguration()
                //.WriteTo.File(configuration["LogFilePath"])
                .WriteTo.File("c:\\fontes\\LOG")
                .MinimumLevel.Debug()
                .MinimumLevel.Override("ApiContasPAgar", LogEventLevel.Information)
                .Enrich.FromLogContext()
                .CreateLogger();
        }

        public void LogInformation(string message)
        {
            _logger.Information(message);
        }

        public void LogError(string message, Exception exception)
        {
            _logger.Error(exception, message);
        }
    }

}
