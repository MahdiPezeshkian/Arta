using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Arta.Data.Models;

namespace Arta.Data.Context
{
    public class MyContext
    {
        public DbSet<Main> Main { get; set; }
        public DbSet<Detail> Detail { get; set; }

    }
}
