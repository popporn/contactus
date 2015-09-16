using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContactUs.Models
{
    public class Ticket
    {
        public string Id { get; set; }
        public DateTime LastActivityDate { get; set; }
        public string LastActivityByUser { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public TicketStatus Status { get; private set; }

        public void Accept()
        {

        }
        public void Close()
        {

        }
        public void Reject()
        {

        }
    }
}
