using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class EmailMessage : IMessage
    {
        public void SendMessage(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Sending email to:{contact.Email}");
            }
        }
    }
}
