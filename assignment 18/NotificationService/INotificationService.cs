using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace assignment_18.NotificationService
{
    internal interface INotificationService
    {
        void SendNotification(string recipient, string message);
    }
}
