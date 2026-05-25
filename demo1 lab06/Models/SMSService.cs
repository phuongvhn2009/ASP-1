namespace demo1_lab06.Models
{
    public class SMSService : ImessageService
    {
        public void Send(string message)
        {
            Console.WriteLine("SMS sent: " + message);
        }
    }
}

