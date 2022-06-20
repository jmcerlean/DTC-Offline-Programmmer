using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace CSTemplate.Classes
{
    public class DTCDb : DbContext
    {
        public DbSet<DTCData> Data { get; set; }

        public DbSet<Failcodes> Failcodes { get; set; }

    }
}
