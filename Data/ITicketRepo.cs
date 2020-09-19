using System.Collections.Generic;
using RSdesk.Models;

namespace RSdesk.Data
{
    public interface ITicketRepo
    {
        bool SaveChanges();

        IEnumerable<Ticket> GetAllTickets();
        Ticket GetTicket(int id);
        void CreateTicket(Ticket ticket);
        void UpdateTicket(Ticket ticket);
        void DeleteTicket(Ticket ticket);
    }
}