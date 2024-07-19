using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.NotificationService
{
    internal class EmailNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            //send email notification by outputting a message to the concole
            Console.WriteLine($"Sending an email notification to {recipient} : {message}");
        }
    }
}
