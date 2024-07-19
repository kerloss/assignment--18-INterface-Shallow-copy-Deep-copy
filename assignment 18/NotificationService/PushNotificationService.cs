using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.NotificationService
{
    internal class PushNotificationService : INotificationService
    {
        public void SendNotification(string recipient, string message)
        {
            //send Push notification by outputting a message to the concole
            Console.WriteLine($"Sending a Push notification to {recipient} : {message}");
        }
    }
}
