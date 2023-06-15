namespace APIContasaPagarCarrefour.repository
{
    public interface ILoggerService
    {
        void LogInformation(string message);
        void LogError(string message, Exception exception);
        // Outros métodos de logging, se necessário
    }

}
