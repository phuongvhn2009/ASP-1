namespace Lab06_Bai1.Models
{
    public interface IEmailService
    {
        void SendEmail(string recipient, string subject, string body);
    }
    public class EmailService : IEmailService
    {
        public void SendEmail(string recipient, string subject, string body)
        {
            Console.WriteLine("Sending Email...");
            Console.WriteLine($"To: {recipient}");
            Console.WriteLine($"Subject: {subject}");
            Console.WriteLine($"Body: {body}");
        }
    }

} 
