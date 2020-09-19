using System;

namespace RSdesk.Models
{
    public class Ticket
    {
        public int Id { get; set; }
        public int Number { get; set; }
        public string Title { get; set; }
        public Client Client { get; set; }
        public string Contact { get; set; }
        public string Executor { get; set; }
        public DateTime RegisterDate { get; set; }
        public DateTime SolutionDate { get; set; }
        public string Status { get; set; }
        public string Description { get; set; }
    }
}