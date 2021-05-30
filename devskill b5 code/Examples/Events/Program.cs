using System;
using System.Collections.Generic;

namespace Events
{
    class Program
    {
        static void Main(string[] args)
        {
            var contacts = new List<Contact>
            {
                new Contact { Email = "abc@gmail.com", Mobile = "0830203223" },
                new Contact { Email =  "xyq@yahoo.com", Mobile = "0023022032" },
                new Contact { Email = "ijk@hotmail.com", Mobile = "8020820320" }
            };

            Notifier notifier = new Notifier();
            
            notifier.Notification += new Notifier.SendMessage(new EmailMessage().SendMessage);
            notifier.Notification += new Notifier.SendMessage(new SMSMessage().SendMessage);
            notifier.Notification += new Notifier.SendMessage(new PushMessage().SendMessage);
            notifier.Notification += new Notifier.SendMessage(MMSMessage);
            notifier.Notify(contacts);
        }

        public static void MMSMessage(List<Contact> info)
        {
            foreach(var item in info)
            {
                Console.WriteLine($"Sending MMS to: {item.Mobile}");
            }
        }
    }
}
