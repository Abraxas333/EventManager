using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventManager
{
    internal class EmailNotifier : IEventNotifier
    {
        public static void Notify(string recipient, string message) 
        {
            Console.WriteLine($"Email sent to {recipient}: {message}");
        }
    }
}
