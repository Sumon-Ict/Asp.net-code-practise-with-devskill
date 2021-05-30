using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public class Notifier
    {
        public delegate void SendMessage(List<Contact> contacts);

        public event SendMessage Notification;

        public void Notify(List<Contact> contacts)
        {
            Notification(contacts);
        }
    }
}
