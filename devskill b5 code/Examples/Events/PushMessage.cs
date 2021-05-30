using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class PushMessage : IMessage
    {
        public void SendMessage(List<Contact> contacts)
        {
            foreach(var contact in contacts)
            {
                Console.WriteLine($"Pusing message to : {contact.Mobile}");
            }
        }
    }
}
