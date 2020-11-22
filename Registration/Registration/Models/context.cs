using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Registration.Models
{
    public class context:DbContext
    {
        public DbSet<Register> Registers { get; set; }
    }
}