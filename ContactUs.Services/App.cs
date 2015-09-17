using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using GFX.Core;
using System.Data.Entity;
using ContactUs.DataAccess.Context;
using ContactUs.DataAccess;
using ContactUs.Models;

namespace ContactUs.Services
{
    public class App : RootClass
    {

        public bool TestingMode { get; private set; }

        public App(bool testing = false)
            : base(testing)
        {

            this.TestingMode = testing;
        }

        protected override DbContext NewDbContext()
        {
            return new ContactUsDb();
        }

        protected override void RegisterServices()
        {
            this.AddService<Ticket, TicketService, TicketRepository>();
        }

        protected override void RegisterServicesForUnitTests()
        {
            this.AddService<Ticket, TicketService, FakeRepository<Ticket>>();
        }

        public TicketService Tickets
        {
            get
            {
                return this.Services<Ticket, TicketService>();
            }
        }
    }
}