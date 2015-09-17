using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ContactUs.Models;

namespace ContactUs.DataAccess.Context
{
    public class ContactUsDb : DbContext
    {
        public DbSet<Ticket> Tickets { get; set; }
    }
}
