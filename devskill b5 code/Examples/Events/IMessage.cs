using System;
using System.Collections.Generic;
using System.Text;

namespace Events
{
    public interface IMessage
    {
        void SendMessage(List<Contact> contacts);
    }
}
