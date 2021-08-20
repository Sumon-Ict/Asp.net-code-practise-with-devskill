using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TicketBookingSystem.Training.BusinessObjects;

namespace TicketBookingSystem.Training.Services
{
    public class TicketService : ITicketService
    {
        public void CreateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }

        public void DeleteTicket(int id)
        {
            throw new NotImplementedException();
        }

        public Ticket GetTicket(int id)
        {
            throw new NotImplementedException();
        }

        public (IList<Ticket> records, int total, int totalDisplay) GetTickets(int pageIndex, int pageSize, string searchText, string sortText)
        {
            throw new NotImplementedException();
        }

        public void UpdateTicket(Ticket ticket)
        {
            throw new NotImplementedException();
        }
    }
}
