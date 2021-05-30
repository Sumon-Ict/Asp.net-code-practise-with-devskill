using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class SMSMessage : IMessage
    {
        public void SendMessage(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Sending SMS to : {contact.Mobile}");
            }
        }
    }
}
