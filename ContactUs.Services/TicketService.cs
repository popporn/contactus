using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GFX.Core;
using ContactUs.Models;

namespace ContactUs.Services
{
    public class TicketService : ServiceBase<App, Ticket>
    {
        public override IRepository<Ticket> Repository { get; set; }

        public override Ticket Find(params object[] keys)
        {
            string id = (string)keys[0];
            return Query(t => t.Id == id).SingleOrDefault();
        }


    }
}
