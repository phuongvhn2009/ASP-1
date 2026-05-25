namespace demo1_lab06.Models
{
    public class EmailService : ImessageService
    {
        public void Send(string message)
        {
            Console.WriteLine("Email sent: " + message);
        }
    }
}
