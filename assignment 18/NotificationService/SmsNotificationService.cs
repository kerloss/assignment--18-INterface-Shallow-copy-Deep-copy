using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.NotificationService
{
    internal class SmsNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            //send SMS notification by outputting a message to the concole
            Console.WriteLine($"Sending an SMS notification to {recipient} : {message}");
        }
    }
}
