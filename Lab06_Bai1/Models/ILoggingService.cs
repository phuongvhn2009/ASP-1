namespace Lab06_Bai1.Models
{
    public interface ILoggingService
    {
        void Log(string message);
    }
    public class LoggingService : ILoggingService
    {
        public void Log(string message)
        {
            Console.WriteLine($"[LOG - {DateTime.Now:HH:mm:ss}]: {message}");
        }
    }

}
